using DrawingForm.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm
{
    public static class GraphicsExtenstion
    {
        private static float Height;

        public static void SetParameters(this Graphics g, float height)
        {
            Height = height;

        }

        public static void SetTransform(this Graphics g)
        {

            //g.PageUnit = GraphicsUnit.Millimeter;
            //g.TranslateTransform(0, Height);
            //g.ScaleTransform(1.0f, -1.0f);

        }

        public static void DrawPoint(this Graphics g, Pen pen, Entities.Point point)
        {


            g.DrawEllipse(pen, point.Position.X, point.Position.Y, 1, 1);


        }

        public static void DrawLine(this Graphics g, Pen pen, LineElement line)
        {

            g.DrawLine(pen, line.StartPoint.X, line.StartPoint.Y, line.EndPoint.X, line.EndPoint.Y);

        }
        public static void DrawLineInCm(this Graphics g, Pen pen, LineElement line)
        {
            g.DrawLine(pen, line.StartPoint.X * 10f, line.StartPoint.Y * 10f, line.EndPoint.X * 10f, line.EndPoint.Y * 10f);
        }

        public static void DrawPointInCm(this Graphics g, Brush brush, Entities.Point point)
        {
            g.FillEllipse(brush, point.Position.X * 10f - 2, point.Position.Y * 10f - 2, 5, 5);
        }
    }
}
