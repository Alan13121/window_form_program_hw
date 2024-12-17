using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class TextMoveCommand : ICommand
    {
        Shape shape;
        Model model;
        PointF startPoint = new PointF();
        PointF endPoint = new PointF();
        public TextMoveCommand(Model m, Shape shape, PointF startPoint, PointF endPoint)
        {
            this.shape = shape;
            model = m;
            this.startPoint = new PointF { X = startPoint.X, Y = startPoint.Y };
            Console.WriteLine(startPoint.X.ToString());
            Console.WriteLine(startPoint.Y.ToString());
            this.endPoint = new PointF { X = endPoint.X, Y = endPoint.Y };
        }

        public void Execute()
        {
            shape.OrangeDot = endPoint;
        }

        public void UnExecute()
        {
            shape.OrangeDot = startPoint;
        }
    }
}
