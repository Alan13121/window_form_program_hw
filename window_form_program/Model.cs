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

namespace hw2
{
    public class Model
    {

        Shapes shapes = new Shapes();
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        int ID = 1;

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
            foreach(Shape shape in generalState.GetSelectShapes())
            {
                if(shape.IsPointOnOrangeDot(point))
                    return true;
            }
            return false;
        }
        public void ChangeText(PointF point,string text)
        {
            foreach (Shape shape in generalState.GetSelectShapes())
            {
                if (shape.IsPointOnOrangeDot(point))
                    shape.Text = text;
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
            currentState.SetShapeType(this, Type, ID++);
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
        public List<Shape> enter_new_shape(string[] new_shape)
        {
            shapes.Add_shape(new_shape[0], new_shape[1], int.Parse(new_shape[2]), int.Parse(new_shape[3]), int.Parse(new_shape[4]), int.Parse(new_shape[5]));
            return shapes.get_list();
        }
        public List<Shape> enter_new_shape(Shape new_shape)
        {

            shapes.Add_shape(new_shape);
            return shapes.get_list();
        }
        public void remove_shape(int ID)
        {
            shapes.remove_shape(ID);
        }
        
    }










}

