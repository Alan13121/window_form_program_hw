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
        public void DeleteShape(Model m, int ID)
        {
            m.remove_shape(ID);
        }

        public void Initialize(Model m)
        {
            throw new NotImplementedException();
        }

        public void KeyDown(Model m, int keyValue)
        {
            throw new NotImplementedException();
        }

        public void KeyUp(Model m, int keyValue)
        {
            throw new NotImplementedException();
        }

        public void MouseDown(Model m, PointF point)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(Model m, PointF point)
        {
            
        }

        public void MouseUp(Model m, PointF point)
        {
            throw new NotImplementedException();
        }

        public void OnPaint(Model m, IDrawable g)
        {
            List<Shape> shapes = m.GetShapes();
            foreach (Shape shape in shapes)
            {

                if (shape.IsPointInShape(point))
                {
                    shape.DrawFourGrayDot();
                }
            }
        }

        public void SetShapeType(Model m, string shapeType, int ID)
        {
            throw new NotImplementedException();
        }
    }
}
