using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm
{
    public class LineElement
    {
        #region Ctor

        public LineElement(Guid id, PointF startPoint, PointF endPoint)
        {
            _Id = id;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        #endregion

        #region private Fields

        private Guid _Id;

        private PointF _startPoint;

        private PointF _endPoint;


        #endregion

        #region Public Properties
        public Guid Id { get => _Id; set => _Id = value; }
        public PointF StartPoint { get => _startPoint; set => _startPoint = value; }
        public PointF EndPoint { get => _endPoint; set => _endPoint = value; }

        #endregion
    }
}
