using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm
{
    public class Vector
    {

        #region Ctor
        public Vector(float x, float y, float z = 0f)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Private Fields

        private float _x;
        private float _y;
        private float _z;

        #endregion

        #region Public Properties

        //public PointF ToPointF
        //{
        //    get
        //    {
        //        return new PointF(X, Y);
        //    }
        //}

        public static Vector Zero
        {
            get { return new Vector(0.0f, 0.0f, 0.0f); }
        }

        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public float Z { get => _z; set => _z = value; }


        #endregion

    }
}
