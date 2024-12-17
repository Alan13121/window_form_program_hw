using hw2.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public class GeneralState : IState
    {
        List<Shape> selectedShapes = new List<Shape>();
        const int CTRL_KEY = 17;
        bool isCtrlKeyDown;
        bool isMovingLine;
        bool isMouseDown;
        bool isMovingText;
        PointF mouseDownPosition = new PointF();
        PointF startPoint = new PointF();
        PointF endPoint = new PointF();
        Line startLine = new Line();
        Line endLine = new Line();
        Line movedLine;
        public void Initialize(Model m)
        {
            selectedShapes.Clear();
            isCtrlKeyDown = false;
            isMovingText = false;
            isMovingLine = false;
        }
        public List<Shape> GetSelectShapes()
        {
            return selectedShapes;
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
                    endPoint = new PointF(shape.OrangeDot.X, shape.OrangeDot.Y);
                    startPoint = new PointF(shape.OrangeDot.X, shape.OrangeDot.Y);
                    return;
                }
                else if (shape.IsPointInShape(point))
                {

                    selectedShapes.Clear();
                    selectedShapes.Add(shape);
                    endPoint = new PointF(shape.X, shape.Y);
                    startPoint = new PointF(shape.X, shape.Y);
                    return;
                }


            }
            selectedShapes.Clear();

        }
        
        

        public void MouseMove(Model m, PointF point)
        {
            if (mouseDownPosition.X > 0 && mouseDownPosition.Y > 0 && isMovingText)
            {
                foreach (Shape shape in selectedShapes)
                {
                    shape.OrangeDot = new PointF(shape.OrangeDot.X + (point.X - mouseDownPosition.X), shape.OrangeDot.Y + (point.Y - mouseDownPosition.Y));
                    endPoint = new PointF(shape.OrangeDot.X, shape.OrangeDot.Y);
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
                    endPoint = new PointF(shape.X, shape.Y);

                    foreach (Shape line in m.GetShapes())
                    {
                        if (line.IsLine())
                        {
                            Line LineID = (Line)line;
                            if(LineID.HeadShapeID == shape.ID || LineID.TailShapeID == shape.ID)
                            {
                                if (!isMovingLine)
                                {
                                    startLine.X = LineID.X;
                                    startLine.Y = LineID.Y;
                                    startLine.Width = LineID.Width;
                                    startLine.Height = LineID.Height;
                                    movedLine = LineID;
                                    isMovingLine = true;
                                }

                                if (LineID.HeadShapeID == shape.ID)
                                {
                                    line.X += point.X - mouseDownPosition.X;
                                    line.Y += point.Y - mouseDownPosition.Y;
                                    line.Width -= point.X - mouseDownPosition.X;
                                    line.Height -= point.Y - mouseDownPosition.Y;

                                }
                                else 
                                {
                                    line.Width += point.X - mouseDownPosition.X;
                                    line.Height += point.Y - mouseDownPosition.Y;
                                }
                                endLine = LineID;
                                break;
                            }
                            
                            
                        }
                    }
                    
                }
                mouseDownPosition = point;
            }
        }

        public void MouseUp(Model m, PointF point)
        {
            if (isMovingText)
            {
                if (startPoint != endPoint)
                    m.commandManager.Execute(new TextMoveCommand(m, selectedShapes[0], startPoint, endPoint));
                mouseDownPosition.X = -1;
                mouseDownPosition.Y = -1;
                isMouseDown = false;
                isMovingText = false;
            }
            else if (isMovingLine)
            {
                if (startPoint != endPoint)
                {
                    m.commandManager.Execute(new LineMoveCommand(m, selectedShapes[0], startPoint, endPoint,movedLine,startLine,endLine));
                }
                mouseDownPosition.X = -1;
                mouseDownPosition.Y = -1;
                isMouseDown = false;
                isMovingText = false;
                isMovingLine = false;
            }
            else if (isMouseDown && selectedShapes.Count > 0)
            {
                if (startPoint != endPoint)
                {
                    m.commandManager.Execute(new MoveCommand(m, selectedShapes[0], startPoint, endPoint));
                }
                mouseDownPosition.X = -1;
                mouseDownPosition.Y = -1;
                isMouseDown = false;
                isMovingText = false;
                isMovingLine = false;
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
            if(selectedShapes.Count!=0)
                selectedShapes.Clear();
            
        }
        public void AddSelectedShape(Shape shape)
        {
            if (!selectedShapes.Contains(shape))
                selectedShapes.Add(shape);
        }
    }
}
