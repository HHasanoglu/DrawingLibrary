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
            g.PageUnit = GraphicsUnit.Pixel;
            g.TranslateTransform(0, Height);
            g.ScaleTransform(1.0f, -1.0f);
            
        }

        public static void DrawPoint(this Graphics g, Pen pen, Entities.Point point)
        {
            g.SetTransform();
            g.DrawEllipse(pen, point.Position.X, point.Position.Y, 4, 4);
            g.ResetTransform();
           
        }

        public static void DrawLine(this Graphics g,Pen pen,LineElement line)
        {
            g.SetTransform();
            g.DrawLine(pen, line.StartPoint.X, line.StartPoint.Y, line.EndPoint.X, line.EndPoint.Y);
            g.ResetTransform();
        }
    }
}
