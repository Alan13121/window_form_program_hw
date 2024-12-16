using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class DrawingLineState : IState
    {
        bool isPointinShape;
        bool isPressed;
        Line hintShape;
        PointF ul_point, lr_point;
        Shape GrayDot;
        public void DeleteShape(Model m, int ID)
        {
            m.remove_shape(ID);
        }

        public void Initialize(Model m)
        {
            hintShape = new Line();
            isPointinShape = false;
            GrayDot = null;
            isPressed = false;
        }



        public void MouseDown(Model m, PointF point)
        {
            isPressed = true;
            ul_point = lr_point = point;
            hintShape.X = point.X;
            hintShape.Y = point.Y;
            hintShape.Width = 0;
            hintShape.Height = 0;
            hintShape.Text = "";
            hintShape.ShapeName = "Line";
        }

        public void MouseMove(Model m, PointF point)
        {
            if (isPressed)
            {
                hintShape.Width = Math.Abs(point.X - ul_point.X);
                hintShape.Height = Math.Abs(point.Y - ul_point.Y);
                hintShape.X = Math.Min(point.X, ul_point.X);
                hintShape.Y = Math.Min(point.Y, ul_point.Y);
            }
            List<Shape> shapes = m.GetShapes();
            foreach (Shape shape in shapes)
            {

                if (shape.IsPointInShape(point))
                {
                    this.GrayDot = shape;
                }
                else
                    this.GrayDot = null;
            }

        }

        public void MouseUp(Model m, PointF point)
        {
            isPressed = false;
            hintShape.Normalize();
            m.ChangeToGeneralState();
        }

        public void OnPaint(Model m, IDrawable g)
        {
            foreach (Shape shape in m.GetShapes())
                shape.DrawShape(g);
            if (GrayDot != null)
                this.GrayDot.DrawFourGrayDot(g);
            if (isPressed)
            {
                hintShape.Normalize();
                hintShape.DrawShape(g);
            }
        }

        public void SetShapeType(Model m, string shapeType, int ID)
        {

        }
        public void KeyDown(Model m, int keyValue)
        {

        }

        public void KeyUp(Model m, int keyValue)
        {

        }
    }
}
