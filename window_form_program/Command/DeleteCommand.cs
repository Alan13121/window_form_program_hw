using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class DeleteCommand : ICommand
    {
        Shape shape;
        Model model;
        public DeleteCommand(Model m, Shape shape)
        {
            this.shape = shape;
            model = m;
            
        }

        public void Execute()
        {
            model.remove_shape(shape);
        }

        public void UnExecute()
        {
            model.enter_new_shape(shape);
        }
    }
}
