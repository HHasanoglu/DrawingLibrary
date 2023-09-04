using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm.Entities
{
    public class Point
    {
        #region Ctor

        public Point()
        {
            this.Position = Vector.Zero;
            this.Thickness = 0f;
        }
        public Point(Vector position)
        {
            this.Position = position;
            this.Thickness = 0f;
        }

        #endregion

        #region Private Fields

        private Vector _position;
        private double _thickness;


        #endregion

        #region Public Properties
        public Vector Position { get => _position; set => _position = value; }
        public double Thickness { get => _thickness; set => _thickness = value; }

        #endregion
    }
}
