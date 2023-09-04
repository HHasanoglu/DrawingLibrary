using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm.Entities
{
    public class LineElement
    {
        #region Ctor

        public LineElement()
        {
            StartPoint = Vector.Zero;
            EndPoint = Vector.Zero;
            Id = Guid.NewGuid();
            Thickness = 0.0;
        }

        public LineElement(Vector startPoint, Vector endPoint)
        {
            Id = Guid.NewGuid();
            StartPoint = startPoint;
            EndPoint = endPoint;
            Thickness = 0.0;

        }


        #endregion

        #region private Fields

        private Guid _id;

        private Vector _startPoint;

        private Vector _endPoint;

        private double _thickness;

        public double Thickness
        {
            get { return _thickness; }
            set { _thickness = value; }
        }



        #endregion

        #region Public Properties
        public Guid Id { get => _id; set => _id = value; }
        public Vector EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }


        public Vector StartPoint
        {
            get { return _startPoint; }
            set { _startPoint = value; }
        }

        #endregion
    }
}
