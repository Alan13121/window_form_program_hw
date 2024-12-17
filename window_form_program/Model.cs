using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using hw2;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace hw2
{
    public class Model
    {
        public CommandManager commandManager = new CommandManager();
        ShapeFactory factory = new ShapeFactory();
        Shapes shapes = new Shapes();
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        

        DrawingState drawingState;
        GeneralState generalState;
        DrawingLineState drawingLineState;
        IState currentState;

        public Model()
        {
            generalState = new GeneralState();
            drawingState = new DrawingState();
            drawingLineState = new DrawingLineState();
            ChangeToGeneralState();
        }
        public bool IsChangeText(PointF point)
        {
            foreach (Shape shape in generalState.GetSelectShapes())
            {
                if (shape.IsPointOnOrangeDot(point))
                    return true;
            }
            return false;
        }
        public void ChangeText(PointF point, string text)
        {
            foreach (Shape shape in generalState.GetSelectShapes())
            {
                if (shape.IsPointOnOrangeDot(point))
                {
                    commandManager.Execute(new TextChangedCommand(this, shape, text));
                    //shape.Text = text;
                }
            }

        }
        public void ChangeToGeneralState()
        {
            generalState.Initialize(this);
            currentState = generalState;
        }
        public void ChangeToDrawingState(string Type)
        {
            drawingState.Initialize(this);
            currentState = drawingState;
            currentState.SetShapeType(this, Type, 0);
        }
        public void ChangeToDrawingLineState()
        {
            drawingLineState.Initialize(this);
            currentState = drawingLineState;

        }

        public void Draw(IDrawable graphic)
        {
            currentState.OnPaint(this, graphic);
        }
        public void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
        public void PointerPressed(float x, float y)
        {
            currentState.MouseDown(this, new PointF { X = x, Y = y });
        }

        public void PointerMoved(float x, float y)
        {
            currentState.MouseMove(this, new PointF { X = x, Y = y });
            NotifyModelChanged();
        }
        public void PointerReleased(float x, float y)
        {
            currentState.MouseUp(this, new PointF { X = x, Y = y });
            NotifyModelChanged();
        }

        public List<Shape> GetShapes()
        {
            return shapes.get_list();
        }
        public void enter_new_shape(string[] shape)
        {
            Shape new_shape = factory.CreateShape(shape[0], 0, shape[1], int.Parse(shape[2]), int.Parse(shape[3]), int.Parse(shape[4]), int.Parse(shape[5]));
            commandManager.Execute(new DrawCommand(this, new_shape));
        }
        public void enter_new_shape(Shape new_shape)
        {
            shapes.Add_shape(new_shape);
        }
        public void enter_new_shape(Shape new_shape, int ID)
        {
            shapes.Add_shape(new_shape,ID);
        }
        public void remove_shape(int ID)
        {
            currentState.DeleteShape(this, ID);
            foreach (Shape removeShape in shapes.get_list())
            {
                if (removeShape.ID == ID)
                {
                    commandManager.Execute(new DeleteCommand(this, removeShape));
                    break;
                }

            }
            List<Shape> removeLines = new List<Shape>();
            foreach (Shape shape in shapes.get_list())
            {
                if (shape.IsLine())
                {
                    Line removeLine = (Line)shape;
                    if (removeLine.HeadShapeID == ID || removeLine.TailShapeID == ID)
                    {
                        removeLines.Add(removeLine);
                    }
                }
            }
            foreach (Shape line in removeLines)
                commandManager.Execute(new DeleteCommand(this, line));

        }
        public void remove_shape(Shape removeShape)
        {
            currentState.DeleteShape(this, 0);
            shapes.remove_shape(removeShape);
        }
        public void Undo()
        {
            commandManager.Undo();
        }

        public void Redo()
        {
            commandManager.Redo();
        }
        public bool IsRedoEnabled
        {
            get
            {
                return commandManager.IsRedoEnabled;
            }
        }

        public bool IsUndoEnabled
        {
            get
            {
                return commandManager.IsUndoEnabled;
            }
        }

    }










}

