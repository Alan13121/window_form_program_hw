using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public interface IDrawable
    {
        void DrawEllipse(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
        void DrawRectangle(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
        void DrawOval(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
        void DrawPolygon(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
        void DrawBoundingBox(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
        void DrawText(float X, float Y, float Width, float Height, string Text, PointF OrangeDot);
    }
}

