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
        PointF startPoint;
        PointF endPoint;
        List<Line> startLine ;
        List<Line> endLine ;
        List<Line> movedLine;
        Line _line;
        public LineMoveCommand(Model m, Shape shape, PointF startPoint, PointF endPoint, List<Line> movedLine, List<Line> startLine)
        {
            this.startLine = new List<Line>();
            this.endLine = new List<Line>();
            this.movedLine = new List<Line>();

            this.shape = shape;
            this.model = m;
            this.startPoint = startPoint;
            this.endPoint = endPoint;

            foreach (Line line in movedLine)
            {
                this.movedLine.Add(line);
            }

            foreach (Line line in movedLine) 
            {
                _line = new Line();
                _line.X = line.X;
                _line.Y = line.Y;
                _line.Width = line.Width;
                _line.Height = line.Height;
                this.endLine.Add(_line);
            }
            foreach (Line line in startLine)
            {
                _line = new Line();
                _line.X = line.X;
                _line.Y = line.Y;
                _line.Width = line.Width;
                _line.Height = line.Height;
                this.startLine.Add(_line);
            }
        }

        public void Execute()
        {
            shape.OrangeDot = new PointF(shape.OrangeDot.X + endPoint.X - shape.X, shape.OrangeDot.Y + endPoint.Y - shape.Y);
            shape.X = endPoint.X;
            shape.Y = endPoint.Y;

            for (int i = 0; i < movedLine.Count; i++)
            {
                movedLine[i].X = endLine[i].X;
                movedLine[i].Y = endLine[i].Y;
                movedLine[i].Width = endLine[i].Width;
                movedLine[i].Height = endLine[i].Height;
            }
            
        }

        public void UnExecute()
        {
            for (int i = 0; i < movedLine.Count; i++)
            {
                movedLine[i].X = startLine[i].X;
                movedLine[i].Y = startLine[i].Y;
                movedLine[i].Width = startLine[i].Width;
                movedLine[i].Height = startLine[i].Height;
            }
            
            shape.OrangeDot = new PointF(shape.OrangeDot.X + startPoint.X - shape.X, shape.OrangeDot.Y + startPoint.Y - shape.Y);
            shape.X = startPoint.X;
            shape.Y = startPoint.Y;
        }
    }
}
