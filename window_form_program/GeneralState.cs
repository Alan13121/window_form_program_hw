using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class GeneralState : IState
    {
        List<Shape> selectedShapes = new List<Shape>();
        const int CTRL_KEY = 17;
        bool isCtrlKeyDown;
        bool isMouseDown;
        bool isMovingText = false;
        PointF mouseDownPosition = new PointF();
        public void Initialize(Model m)
        {
            selectedShapes.Clear();
            isCtrlKeyDown = false;
        }
        public void MouseDown(Model m, PointF point)
        {
            mouseDownPosition = point;
            isMouseDown = true;
            foreach (Shape shape in Enumerable.Reverse(m.GetShapes()))
            {
                if (selectedShapes.Count > 0 && shape.IsPointOnOrangeDot(point))
                {
                    isMovingText = true;
                    return;
                }
                else if (shape.IsPointInShape(point))
                {

                    selectedShapes.Clear();
                    selectedShapes.Add(shape);

                    return;
                }


            }
            selectedShapes.Clear();

        }
        public void AddSelectedShape(Shape shape)
        {
            if (!selectedShapes.Contains(shape))
                selectedShapes.Add(shape);
        }

        public void MouseMove(Model m, PointF point)
        {
            if (mouseDownPosition.X > 0 && mouseDownPosition.Y > 0 && isMovingText)
            {
                foreach (Shape shape in selectedShapes)
                {
                    shape.OrangeDot = new PointF(shape.OrangeDot.X + (point.X - mouseDownPosition.X), shape.OrangeDot.Y + (point.Y - mouseDownPosition.Y));
                }
                mouseDownPosition = point;
            }
            else if (isMouseDown)
            {
                foreach (Shape shape in selectedShapes)
                {
                    shape.X += point.X - mouseDownPosition.X;
                    shape.Y += point.Y - mouseDownPosition.Y;
                    shape.OrangeDot = new PointF(shape.OrangeDot.X + (point.X - mouseDownPosition.X), shape.OrangeDot.Y + (point.Y - mouseDownPosition.Y));
                }
                mouseDownPosition = point;
            }
        }

        public void MouseUp(Model m, PointF point)
        {
            if (isMouseDown)
            {
                mouseDownPosition.X = -1;
                mouseDownPosition.Y = -1;
                isMouseDown = false;
                isMovingText = false;
            }
        }

        public void OnPaint(Model m, IDrawable g)
        {
            foreach (Shape shape in m.GetShapes())
                shape.DrawShape(g);
            foreach (Shape shape in selectedShapes)
                shape.DrawBoundingBox(g);

        }

        public void KeyDown(Model m, int keyValue)
        {
            if (keyValue == CTRL_KEY)
                isCtrlKeyDown = true;
        }

        public void KeyUp(Model m, int keyValue)
        {
            if (keyValue == CTRL_KEY)
                isCtrlKeyDown = false;
        }
        public void SetShapeType(Model m, string shapeType, int ID)
        {
        }
        public void DeleteShape(Model m, int ID)
        {
            Shape shapeToRemove = m.GetShapes().FirstOrDefault(x => x.ID == ID);
            m.remove_shape(ID);
            selectedShapes.Remove(shapeToRemove);
        }
    }
}
