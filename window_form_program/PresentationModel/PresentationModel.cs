using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hw2.PresentationModel
{
    public class PresentationModel : INotifyPropertyChanged
    {
        Model model;
        //Control canvas;
        public event PropertyChangedEventHandler PropertyChanged;
        bool isAddButtonEnabled = false;
        bool isShapeComboBoxCorrect = false;
        bool isTextTextBoxCorrect = false;
        bool isXTextBoxCorrect = false;
        bool isYTextBoxCorrect = false;
        bool isHeightTextBoxCorrect = false;
        bool isWidthTextBoxCorrect = false;
        Color shapeComboxTextColor = Color.Red;
        Color textTextColor = Color.Red;
        Color xTextColor = Color.Red;
        Color yTextColor = Color.Red;
        Color heightTextColor = Color.Red;
        Color widthTextColor = Color.Red;
        float output;
        public PresentationModel(Model model)//, Control canvas
        {
            this.model = model;
            //this.canvas = canvas;

        }
        public void ShapeComboBoxIndexChanged(int index)
        {
            if (index != -1)
            {
                shapeComboxTextColor = Color.Black;
                isShapeComboBoxCorrect = true;
            }

            else
            {
                shapeComboxTextColor = Color.Red;
                isShapeComboBoxCorrect = false;
            }

            notify("shapeComboxTextColor");

        }
        public void TextTextBoxTextChanged(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                textTextColor = Color.Black;
                isTextTextBoxCorrect = true;
            }
            else
            {
                textTextColor = Color.Red;
                isTextTextBoxCorrect = false;
            }
            notify("textTextColor");
        }
        public void XTextBoxTextChanged(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && float.TryParse(text, out output))
            {
                xTextColor = Color.Black;
                isXTextBoxCorrect = true;
            }
            else
            {
                xTextColor = Color.Red;
                isXTextBoxCorrect = false;
            }
            notify("xTextColor");
        }
        public void YTextBoxTextChanged(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && float.TryParse(text, out output))
            {
                yTextColor = Color.Black;
                isYTextBoxCorrect = true;
            }
            else
            {
                yTextColor = Color.Red;
                isYTextBoxCorrect = false;
            }
            notify("yTextColor");
        }
        public void HeightTextBoxTextChanged(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && float.TryParse(text, out output))
            {
                heightTextColor = Color.Black;
                isHeightTextBoxCorrect = true;
            }
            else
            {
                heightTextColor = Color.Red;
                isHeightTextBoxCorrect = false;
            }
            notify("heightTextColor");
        }
        public void WidthTextBoxTextChanged(string text)
        {
            if (!string.IsNullOrWhiteSpace(text) && float.TryParse(text, out output))
            {
                widthTextColor = Color.Black;
                isWidthTextBoxCorrect = true;
            }
            else
            {
                widthTextColor = Color.Red;
                isWidthTextBoxCorrect = false;
            }
            notify("widthTextColor");
        }
        public void CheckAllCorrect()
        {
            isAddButtonEnabled = isShapeComboBoxCorrect && isTextTextBoxCorrect && isXTextBoxCorrect && isYTextBoxCorrect && isHeightTextBoxCorrect && isWidthTextBoxCorrect;

            notify("isAddButtonEnabled");
        }
        private void notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool IsAddButtonEnabled
        {
            get
            {
                return isAddButtonEnabled;
            }
        }
        public Color ShapeComboxTextColor
        {
            get
            {
                return shapeComboxTextColor;
            }
        }
        public Color TextTextColor
        {
            get
            {
                return textTextColor;
            }
        }
        public Color XTextColor
        {
            get
            {
                return xTextColor;
            }
        }
        public Color YTextColor
        {
            get
            {
                return yTextColor;
            }
        }
        public Color HeightTextColor
        {
            get
            {
                return heightTextColor;
            }
        }
        public Color WidthTextColor
        {
            get
            {
                return widthTextColor;
            }
        }
    }
}
