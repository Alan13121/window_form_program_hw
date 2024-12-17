using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace hw2
{

    public class Shapes
    {

        List<Shape> Shapes_list = new List<Shape>();
        ShapeFactory fatory = new ShapeFactory();
        int ID_Count = 1;
        public void Add_shape(string shapeType, string text, int X, int Y, int Height, int Width)
        {
            Shapes_list.Add(fatory.CreateShape(shapeType, ID_Count, text, X, Y, Height, Width));
            ID_Count++;
        }
        public void Add_shape(Shape new_shape)
        {
            new_shape.ID = ID_Count;
            Shapes_list.Add(new_shape);
            ID_Count++;
        }
        public void remove_shape(Shape removeShape)
        {
            int ID = removeShape.ID;
            Shapes_list.RemoveAll(s => s.ID == ID);
        }
        public List<Shape> get_list()
        {

            return Shapes_list;
        }

    }
    public abstract class Shape
    {

        public string ShapeName { get; set; }
        public int ID { get; set; }
        public string Text { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public PointF OrangeDot { get; set; }

        public abstract void DrawShape(IDrawable shape);
        public void DrawBoundingBox(Graphics g)
        {
            g.DrawRectangle(Pens.Gray, X, Y, Width, Height);
        }
        public void DrawBoundingBox(IDrawable boundingBox)
        {
            boundingBox.DrawBoundingBox(X, Y, Width, Height, Text, OrangeDot);

        }

        public void Normalize()
        {
            X = Math.Min(X, X + Width);
            Y = Math.Min(Y, Y + Height);
            Width = Math.Abs(Width);
            Height = Math.Abs(Height);
        }
        public void ChangeText(string NewText)
        {
            this.Text = NewText;
        }
        public abstract bool IsPointInShape(PointF point);
        public bool IsPointOnOrangeDot(PointF point)
        {
            if (IsLine()) return false;
            GraphicsPath path = new GraphicsPath(FillMode.Winding);

            SizeF textSize = this.GetTextSize();
            path.AddEllipse(OrangeDot.X - 5 + textSize.Width / 2, OrangeDot.Y - 5, 10, 10);
            return path.IsVisible(point);
        }
        public SizeF GetTextSize()
        {
            if (IsLine()) return SizeF.Empty;
            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Font font = new Font("Arial", 16, FontStyle.Bold);
                SizeF textSize = g.MeasureString(Text, font);
                return textSize;
            }

        }
        public bool IsLine()
        {
            return ShapeName == "Line" ? true : false;
        }
        public void DrawFourGrayDot(IDrawable shape)
        {
            if (IsLine()) return;
            shape.DrawGrayDot(X, Y, Width, Height);
        }
        public PointF IsPointOnGaryDot(PointF point)
        {
            if (IsLine()) return PointF.Empty;
            GraphicsPath path = new GraphicsPath(FillMode.Winding);
            SizeF textSize = this.GetTextSize();

            path.AddEllipse(X + Width / 2 - 5, Y - 5, 10, 10);
            if (path.IsVisible(point))
                return new PointF { X = X + Width / 2, Y = Y };

            path.AddEllipse(X + Width / 2 - 5, Y + Height - 5, 10, 10);
            if (path.IsVisible(point))
                return new PointF {X = X + Width / 2,Y = Y + Height};

            path.AddEllipse(X + Width - 5, Y + Height / 2 - 5, 10, 10);
            if (path.IsVisible(point))
                return new PointF { X = X + Width, Y = Y + Height / 2 };

            path.AddEllipse(X - 5, Y + Height / 2 - 5, 10, 10);
            if (path.IsVisible(point))
                return new PointF { X = X , Y = Y + Height / 2 };

            return PointF.Empty;
        }


    }

    public class Start : Shape
    {
        public Start()
        {
            ShapeName = "Start";
        }
        public override void DrawShape(IDrawable shape)
        {
            shape.DrawEllipse(X, Y, Width, Height, Text, OrangeDot);
        }
        public override bool IsPointInShape(PointF point)
        {

            GraphicsPath path = new GraphicsPath(FillMode.Winding);

            path.AddEllipse(X, Y, Width, Height);

            return path.IsVisible(point);
        }

    }
    public class Terminator : Shape
    {
        public Terminator()
        {
            ShapeName = "Terminator";
        }
        public override void DrawShape(IDrawable shape)
        {
            shape.DrawOval(X, Y, Width, Height, Text, OrangeDot);
        }
        public override bool IsPointInShape(PointF point)
        {

            GraphicsPath path = new GraphicsPath(FillMode.Winding);

            path.AddRectangle(new RectangleF(X + Width / 5, Y, 3 * Width / 5, Height));
            RectangleF leftArcRect = new RectangleF(
                X,
                Y,
                2 * Width / 5,
                Height
            );
            RectangleF rightArcRect = new RectangleF(
                X + 3 * Width / 5,
                Y,
                2 * Width / 5,
                Height
            );
            path.AddArc(leftArcRect, 90, 180);
            path.AddArc(rightArcRect, -90, 180);

            return path.IsVisible(point);
        }
    }

    public class Process : Shape
    {
        public Process()
        {
            ShapeName = "Process";
        }
        public override void DrawShape(IDrawable shape)
        {
            shape.DrawRectangle(X, Y, Width, Height, Text, OrangeDot);
        }
        public override bool IsPointInShape(PointF point)
        {

            GraphicsPath path = new GraphicsPath(FillMode.Winding);

            path.AddRectangle(new RectangleF(X, Y, Width, Height));

            return path.IsVisible(point);
        }
    }
    public class Decision : Shape
    {
        public Decision()
        {
            ShapeName = "Decision";
        }
        public override void DrawShape(IDrawable shape)
        {
            shape.DrawPolygon(X, Y, Width, Height, Text, OrangeDot);
        }
        public override bool IsPointInShape(PointF point)
        {

            GraphicsPath path = new GraphicsPath(FillMode.Winding);

            path.AddPolygon(new PointF[] {new PointF((X + X + Width) / 2, Math.Max(Y, Y + Height)),
                                                  new PointF(Math.Max(X, X + Width), (Y + Y + Height) / 2),
                                                  new PointF((X + X + Width) / 2, Math.Min(Y, Y + Height)),
                                                  new PointF(Math.Min(X, X + Width), (Y + Y + Height) / 2)});
            return path.IsVisible(point);
        }
    }
    public class Line : Shape
    {
        public int HeadShapeID { get; set; }
        public int TailShapeID { get; set; }

        public Line()
        {
            ShapeName = "Line";
        }
        public override void DrawShape(IDrawable shape)
        {
            shape.DrawLine(X, Y, Width, Height);
        }
        public override bool IsPointInShape(PointF point)
        {
            return false;
        }
    }
}
