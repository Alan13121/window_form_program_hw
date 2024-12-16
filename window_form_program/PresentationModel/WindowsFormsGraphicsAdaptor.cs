using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hw2.PresentationModel
{

    internal class WindowsFormsGraphicsAdaptor : IDrawable
    {
        Graphics _graphics;
        readonly Font font = new Font("Arial", 16, FontStyle.Bold);
        readonly Brush brush = Brushes.Black;
        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            _graphics = graphics;
        }
        public void DrawEllipse(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {

            _graphics.DrawEllipse(Pens.Black, X, Y, Width, Height);

            _graphics.DrawString(Text, font, brush, new PointF(OrangeDot.X, OrangeDot.Y));
        }
        public void DrawRectangle(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {

            _graphics.DrawRectangle(Pens.Black, X, Y, Width, Height);

            _graphics.DrawString(Text, font, brush, new PointF(OrangeDot.X, OrangeDot.Y));
        }
        public void DrawOval(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {

            PointF leftTopPoint = new PointF(X, Y);
            PointF rightTopPoint = new PointF(X + Width, Y);
            PointF leftBottomPoint = new PointF(X, Y + Height);
            PointF rightBottomPoint = new PointF(X + Width, Y + Height);
            if (Width > 0 && Height > 0)
            {
                _graphics.DrawLine(Pens.Black, leftTopPoint.X + Width / 5, leftTopPoint.Y, rightTopPoint.X - Width / 5, rightTopPoint.Y);
                _graphics.DrawLine(Pens.Black, leftBottomPoint.X + Width / 5, leftBottomPoint.Y, rightBottomPoint.X - Width / 5, rightBottomPoint.Y);

                RectangleF leftArcRect = new RectangleF(leftTopPoint.X, leftTopPoint.Y, 2 * Width / 5, Height);
                RectangleF rightArcRect = new RectangleF((rightTopPoint.X - 2 * Width / 5), rightTopPoint.Y, 2 * Width / 5, Height);

                _graphics.DrawArc(Pens.Black, leftArcRect, 90, 180);
                _graphics.DrawArc(Pens.Black, rightArcRect, -90, 180);
            }

            _graphics.DrawString(Text, font, brush, new PointF(OrangeDot.X, OrangeDot.Y));
        }
        public void DrawPolygon(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {

            PointF[] diamondes = new PointF[]
            {
                new PointF((X + X + Width)/2, Math.Max(Y, Y + Height)),
                new PointF(Math.Max(X, X + Width), (Y + Y +Height)/2),
                new PointF((X + X + Width)/2, Math.Min(Y, Y + Height)),
                new PointF(Math.Min(X, X + Width), (Y + Y +Height)/2)
            };
            _graphics.DrawPolygon(Pens.Black, diamondes);

            _graphics.DrawString(Text, font, brush, new PointF(OrangeDot.X, OrangeDot.Y));
        }
        public void DrawBoundingBox(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {
            _graphics.DrawRectangle(new Pen(Color.Red, 5), X, Y, Width, Height);//圖形外框
            SizeF TextSize = _graphics.MeasureString(Text, font);
            _graphics.DrawRectangle(new Pen(Color.Red, 2), OrangeDot.X, OrangeDot.Y, TextSize.Width, TextSize.Height);//文字外框
            _graphics.FillEllipse(Brushes.Orange, OrangeDot.X - 5 + TextSize.Width / 2, OrangeDot.Y - 5, 10, 10);//小橘點
        }
        public void DrawText(float X, float Y, float Width, float Height, string Text, PointF OrangeDot)
        {

            _graphics.DrawString(Text, font, brush, new PointF(OrangeDot.X, OrangeDot.Y));
        }
        public void DrawLine(float X, float Y, float Width, float Height)
        {
            _graphics.DrawLine(new Pen(Color.Gray, 5), X, Y,  Width,  Height);
        }
        public void DrawGrayDot(float X, float Y, float Width, float Height)
        {
            _graphics.FillEllipse(Brushes.Gray, X + Width / 2 - 5, Y - 5, 10, 10);
            _graphics.FillEllipse(Brushes.Gray, X + Width / 2 - 5, Y + Height - 5, 10, 10);
            _graphics.FillEllipse(Brushes.Gray, X + Width - 5, Y + Height / 2 - 5, 10, 10);
            _graphics.FillEllipse(Brushes.Gray, X - 5, Y + Height / 2 - 5, 10, 10);

        }
    }

}
