using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class DeleteCommand : ICommand
    {
        List<Shape> removeShapes = new List<Shape>();
        Model model;
        public DeleteCommand(Model m, List<Shape> removeShapes)
        {
            foreach (Shape shape in removeShapes)
            {
                this.removeShapes.Add(shape);
            }
            model = m;
        }

        public void Execute()
        {
            foreach (Shape shape in removeShapes)
            {
                model.remove_shape(shape);
            }
        }

        public void UnExecute()
        {
            foreach (Shape shape in removeShapes)
            {
                model.enter_new_shape(shape);
            }
        }
    }
}
