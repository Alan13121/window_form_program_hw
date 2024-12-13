using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public interface IState
    {
        void Initialize(Model m);
        void OnPaint(Model m, IDrawable g);
        void MouseDown(Model m, PointF point);
        void MouseMove(Model m, PointF point);
        void MouseUp(Model m, PointF point);
        void KeyDown(Model m, int keyValue);
        void KeyUp(Model m, int keyValue);
        void SetShapeType(Model m, string shapeType, int ID);
        void DeleteShape(Model m, int ID);
    }
}
