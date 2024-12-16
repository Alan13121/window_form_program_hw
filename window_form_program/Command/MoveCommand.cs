using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2.Command
{
    public class MoveCommand : ICommand
    {
        Shape shape;
        Model model;
        PointF startPoint = new PointF();
        PointF endPoint = new PointF();
        public MoveCommand(Model m, Shape shape, PointF startPoint, PointF endPoint)
        {
            this.shape = shape;
            model = m;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public void Execute()
        {
            shape.OrangeDot = new PointF(shape.OrangeDot.X + endPoint.X - shape.X, shape.OrangeDot.Y + endPoint.Y - shape.Y);
            shape.X = endPoint.X;
            shape.Y = endPoint.Y;
        }

        public void UnExecute()
        {
            shape.OrangeDot = new PointF(shape.OrangeDot.X + startPoint.X - shape.X, shape.OrangeDot.Y + startPoint.Y - shape.Y);
            shape.X = startPoint.X;
            shape.Y = startPoint.Y;
        }
    }
}
