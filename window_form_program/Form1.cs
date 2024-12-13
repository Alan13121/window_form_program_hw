using hw2.PresentationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hw2
{
    public partial class MyDrawing_Form : Form
    {
        List<Shape> shapes = new List<Shape>();
        Model model = new Model();
        Panel Canva = new DoubleBufferedPanel();
        PresentationModel.PresentationModel _presentationModel;
        public MyDrawing_Form()
        {
            InitializeComponent();
            Canva.Location = new Point(180, 49);
            //Canva.BackColor = Color.Red;
            Canva.Width = 568;
            Canva.Height = 513;
            Canva.MouseDown += Canva_MouseDown;
            Canva.MouseUp += Canva_MouseUp;
            Canva.MouseMove += Canva_MouseMove;
            Canva.Paint += Canva_Paint;
            _presentationModel = new PresentationModel.PresentationModel(model);
            model._modelChanged += HandleModelChanged;
            Controls.Add(Canva);
            this.DoubleBuffered = true;
            add_shape_buttom.DataBindings.Add("Enabled", _presentationModel, "isAddButtonEnabled");
            shape_type_comboBox.DataBindings.Add("ForeColor", _presentationModel, "shapeComboxTextColor");
            Text_label.DataBindings.Add("ForeColor", _presentationModel, "textTextColor");
            X_label.DataBindings.Add("ForeColor", _presentationModel, "xTextColor");
            Y_label.DataBindings.Add("ForeColor", _presentationModel, "yTextColor");
            Height_label.DataBindings.Add("ForeColor", _presentationModel, "heightTextColor");
            Width_label.DataBindings.Add("ForeColor", _presentationModel, "widthTextColor");
            GeneralStateBottom.Checked = true;
        }


        private void add_shape_buttom_Click(object sender, EventArgs e)
        {
            string[] new_shape = { shape_type_comboBox.Text, shape_text_textBox.Text, shape_x_textBox.Text, shape_y_textBox.Text, shape_height_textBox.Text, shape_width_textBox.Text };
            List<Shape> shapelist = model.enter_new_shape(new_shape);

            shape_info_dataGridView.Rows.Clear();
            for (int i = 0; i < shapelist.Count; i++)
            {
                shape_info_dataGridView.Rows.Add("刪除", shapelist[i].ID, shapelist[i].ShapeName, shapelist[i].Text, shapelist[i].X, shapelist[i].Y, shapelist[i].Height, shapelist[i].Width);
            }
            Canva.Invalidate();
        }

        private void shape_info_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)  // 確認點擊的行有效
            {
                int shapeID = int.Parse(shape_info_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                model.remove_shape(shapeID);
                shape_info_dataGridView.Rows.Remove(shape_info_dataGridView.Rows[e.RowIndex]);
                Canva.Invalidate();
            }

        }
        public void HandleModelChanged()
        {
            Canva.Invalidate();
        }


        private void Canva_Paint(object sender, PaintEventArgs e)
        {
            var shapeList = model.GetShapes();
            model.Draw(new WindowsFormsGraphicsAdaptor(e.Graphics));
            shape_info_dataGridView.Rows.Clear();
            for (int i = 0; i < shapeList.Count; i++)
            {
                shape_info_dataGridView.Rows.Add("刪除", shapeList[i].ID, shapeList[i].ShapeName, shapeList[i].Text, shapeList[i].X, shapeList[i].Y, shapeList[i].Height, shapeList[i].Width);
            }


        }
        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            model.PointerPressed(e.X, e.Y);
        }
        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {
            model.PointerReleased(e.X, e.Y);

            Canva.Cursor = Cursors.Default;
            StartToolButton.Checked = false;
            TerminatorToolButton.Checked = false;
            DecisionToolButton.Checked = false;
            ProcessToolButton.Checked = false;
            GeneralStateBottom.Checked = true;
        }

        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            model.PointerMoved(e.X, e.Y);
        }


        private void SetToolButtonSelected(System.Windows.Forms.ToolStripButton button, string shapeType)
        {
            Canva.Cursor = Cursors.Cross;
            model.ChangeToDrawingState(shapeType);
        }
        private void StartToolButton_Click(object sender, EventArgs e)
        {
            SetToolButtonSelected(StartToolButton, "Start");
        }

        private void TerminatorToolButton_Click(object sender, EventArgs e)
        {
            SetToolButtonSelected(TerminatorToolButton, "Terminator");
        }

        private void ProcessToolButton_Click(object sender, EventArgs e)
        {
            SetToolButtonSelected(ProcessToolButton, "Process");
        }

        private void DecisionToolButton_Click(object sender, EventArgs e)
        {
            SetToolButtonSelected(DecisionToolButton, "Decision");
        }
        private void GeneralStateBottom_Click(object sender, EventArgs e)
        {
            model.ChangeToGeneralState();
            Canva.Cursor = Cursors.Default;
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripButton clickedButton = e.ClickedItem as ToolStripButton;

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton button)
                {
                    button.Checked = false;
                }
            }
            clickedButton.Checked = true;
        }

        private void shape_type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presentationModel.ShapeComboBoxIndexChanged(shape_type_comboBox.SelectedIndex);
            _presentationModel.CheckAllCorrect();
        }

        private void shape_text_textBox_TextChanged(object sender, EventArgs e)
        {
            _presentationModel.TextTextBoxTextChanged(shape_text_textBox.Text);
            _presentationModel.CheckAllCorrect();
        }

        private void shape_x_textBox_TextChanged(object sender, EventArgs e)
        {
            _presentationModel.XTextBoxTextChanged(shape_x_textBox.Text);
            _presentationModel.CheckAllCorrect();
        }

        private void shape_y_textBox_TextChanged(object sender, EventArgs e)
        {
            _presentationModel.YTextBoxTextChanged(shape_y_textBox.Text);
            _presentationModel.CheckAllCorrect();
        }

        private void shape_height_textBox_TextChanged(object sender, EventArgs e)
        {
            _presentationModel.HeightTextBoxTextChanged(shape_height_textBox.Text);
            _presentationModel.CheckAllCorrect();
        }

        private void shape_width_textBox_TextChanged(object sender, EventArgs e)
        {
            _presentationModel.WidthTextBoxTextChanged(shape_width_textBox.Text);
            _presentationModel.CheckAllCorrect();
        }


    }
}
