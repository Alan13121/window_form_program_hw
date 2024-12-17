using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class TextChangedCommand : ICommand
    {
        Shape shape;
        Model model;
        string beforeText;
        string afterText;
        public TextChangedCommand(Model m, Shape shape,string text)
        {
            this.shape = shape;
            model = m;
            this.beforeText = shape.Text;
            this.afterText = text;
        }

        public void Execute()
        {
            shape.Text = afterText;
        }

        public void UnExecute()
        {
            shape.Text = beforeText;
        }
    }
}
