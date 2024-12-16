using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class DrawCommand : ICommand
    {
        Shape shape;
        Model model;
        public DrawCommand(Model m, Shape shape)
        {
            this.shape = shape;
            model = m;
        }

        public void Execute()
        {
            model.enter_new_shape(shape);
        }

        public void UnExecute()
        {
            model.remove_shape(shape.ID);
        }
    }
}
