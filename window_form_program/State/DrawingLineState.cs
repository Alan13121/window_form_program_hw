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
        PointF startPoint;
        Shape GrayDot;
        public void DeleteShape(Model m, int ID)
        {

        }

        public void Initialize(Model m)
        {
            hintShape = new Line();
            isPointinShape = false;
            GrayDot = null;
            isPressed = false;
            startPoint = PointF.Empty;
        }

        public void MouseDown(Model m, PointF point)
        {
            List<Shape> shapes = m.GetShapes();
            foreach (Shape shape in shapes)
            {
                PointF currentPoint = shape.IsPointOnGaryDot(point);
                if (currentPoint != PointF.Empty)
                {
                    isPressed = true;
                    startPoint = currentPoint;
                    ul_point = lr_point = point;
                    hintShape.ID = 0;
                    hintShape.X = point.X;
                    hintShape.Y = point.Y;
                    hintShape.Width = 0;
                    hintShape.Height = 0;
                    hintShape.Text = "";
                    hintShape.ShapeName = "Line";
                    hintShape.HeadShapeID = shape.ID;
                    return;
                }

            }


        }

        public void MouseMove(Model m, PointF point)
        {
            if (isPressed)
            {

                hintShape.Width = point.X - ul_point.X;
                hintShape.Height = point.Y - ul_point.Y;
            }
            List<Shape> shapes = m.GetShapes();
            foreach (Shape shape in shapes)
            {

                if (shape.IsPointInShape(point))
                {
                    this.GrayDot = shape;
                    break;
                }
                else
                    this.GrayDot = null;
            }

        }

        public void MouseUp(Model m, PointF point)
        {
            if (isPressed)
            {
                List<Shape> shapes = m.GetShapes();
                foreach (Shape shape in shapes)
                {
                    PointF currentPoint = shape.IsPointOnGaryDot(point);
                    if (currentPoint != PointF.Empty && currentPoint != startPoint)
                    {
                        isPressed = false;
                        hintShape.TailShapeID = shape.ID;
                        m.commandManager.Execute(new DrawCommand(m, hintShape));
                        m.ChangeToGeneralState();
                        return;
                    }

                }
                isPressed = false;
            }


        }

        public void OnPaint(Model m, IDrawable g)
        {
            foreach (Shape shape in m.GetShapes())
                shape.DrawShape(g);
            if (GrayDot != null)
                this.GrayDot.DrawFourGrayDot(g);
            if (isPressed)
            {
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
