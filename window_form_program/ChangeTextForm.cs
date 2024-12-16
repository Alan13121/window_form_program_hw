using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class ChangeTextForm : Form
    {
        public ChangeTextForm()
        {
            InitializeComponent();
            ConfirmButton.Enabled = false;
            textBox1.TextChanged += TextChange;
            AcceptButton = ConfirmButton;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void TextChange(object sender, EventArgs e)
        {
            ConfirmButton.Enabled=true;
        }

        public string GetText() 
        { 
            return textBox1.Text.ToString();
        }
    }
}
