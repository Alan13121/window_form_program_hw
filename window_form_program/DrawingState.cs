using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hw2
{

    public class DrawingState : IState
    {
        Graphics _graphics;
        PointF ul_point, lr_point;
        bool isPressed;
        Shape hintShape;
        int type = -1;
        enum KindsOfShape
        {
            Start = 0,
            Terminator,
            Process,
            Decision
        }
        public void Initialize(Model m)
        {
            isPressed = false;
            hintShape = null;
        }
        public void OnPaint(Model m, IDrawable g)
        {
            foreach (Shape aShape in m.GetShapes())
            {
                aShape.DrawShape(g);
            }
            if (isPressed)
            {
                hintShape.Normalize();
                hintShape.DrawShape(g);
            }
        }
        public void MouseDown(Model m, PointF point)
        {
            isPressed = true;
            ul_point = lr_point = point;
            hintShape.X = point.X;
            hintShape.Y = point.Y;
            hintShape.Width = 0;
            hintShape.Height = 0;
            hintShape.Text = "";
        }
        public void MouseMove(Model m, PointF point)
        {
            if (isPressed && type != -1)
            {
                hintShape.Width = Math.Abs(point.X - ul_point.X);
                hintShape.Height = Math.Abs(point.Y - ul_point.Y);
                hintShape.X = Math.Min(point.X, ul_point.X);
                hintShape.Y = Math.Min(point.Y, ul_point.Y);
            }
        }
        public void MouseUp(Model m, PointF point)
        {
            if (isPressed && type != -1)
            {
                isPressed = false;
                hintShape.Normalize();
                hintShape.Text = RandomStringBuilder.GenerateRandomString();

                SizeF textSize = hintShape.GetTextSize();
                float textX = ((hintShape.X + hintShape.X + hintShape.Width) / 2) - (textSize.Width / 2);
                float textY = ((hintShape.Y + hintShape.Y + hintShape.Height) / 2) - (textSize.Height / 2);
                hintShape.OrangeDot = new PointF(textX, textY);

                if (hintShape.Width > 0 && hintShape.Height > 0)
                    m.enter_new_shape(hintShape);
                m.ChangeToGeneralState();
                type = -1;
            }
        }
        public void KeyDown(Model m, int keyValue)
        {
        }
        public void KeyUp(Model m, int keyValue)
        {
        }
        public void SetShapeType(Model m, string shapeType, int ID)
        {
            KindsOfShape enumType = (KindsOfShape)Enum.Parse(typeof(KindsOfShape), shapeType);
            type = (int)enumType;
            ShapeFactory factory = new ShapeFactory();
            hintShape = factory.CreateShape(shapeType, ID, "0", 0, 0, 0, 0);

        }
        public void DeleteShape(Model m, int ID)
        {
            m.remove_shape(ID);
        }
    }
}
