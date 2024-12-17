using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class LineMoveCommand : ICommand
    {
        Shape shape;
        Model model;
        Line line;
        PointF startPoint;
        PointF endPoint ;
        Line startLine = new Line();
        Line endLine =new Line();
        public LineMoveCommand(Model m, Shape shape, PointF startPoint, PointF endPoint, Line movedLine,Line startLine,Line endLine)
        {
            this.shape = shape;
            this.line = movedLine;
            model = m;
            this.startPoint = startPoint;
            this.endPoint = endPoint;

            this.startLine.X = startLine.X;
            this.startLine.Y = startLine.Y;
            this.startLine.Width = startLine.Width;
            this.startLine.Height = startLine.Height;

            this.endLine.X = endLine.X;
            this.endLine.Y = endLine.Y;
            this.endLine.Width = endLine.Width;
            this.endLine.Height = endLine.Height;
        }

        public void Execute()
        {
            shape.OrangeDot = new PointF(shape.OrangeDot.X + endPoint.X - shape.X, shape.OrangeDot.Y + endPoint.Y - shape.Y);
            shape.X = endPoint.X;
            shape.Y = endPoint.Y;
            line.X = endLine.X;
            line.Y = endLine.Y;
            line.Width = endLine.Width;
            line.Height = endLine.Height;
        }

        public void UnExecute()
        {
            line.X = startLine.X;
            line.Y = startLine.Y;
            line.Width = startLine.Width;
            line.Height = startLine.Height;
            shape.OrangeDot = new PointF(shape.OrangeDot.X + startPoint.X - shape.X, shape.OrangeDot.Y + startPoint.Y - shape.Y);
            shape.X = startPoint.X;
            shape.Y = startPoint.Y;
            

        }
    }
}
