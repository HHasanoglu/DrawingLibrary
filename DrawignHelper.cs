using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingForm
{
    public class DrawignHelper
    {
        #region Ctor
        public DrawignHelper()
        {
            _lineElements = new Dictionary<Guid, LineElement>();
            _listOfPoints = new List<PointF>();
            _listOfPointsForMagnitude = new List<PointF>();
        }

        #endregion


        #region Private Fields

        private Dictionary<Guid, LineElement> _lineElements;
        private List<PointF> _listOfPoints;
        private List<PointF> _listOfPointsForMagnitude;

        #endregion

        #region Public Properties
        public Dictionary<Guid, LineElement> LineElements { get => _lineElements; set => _lineElements = value; }
        public List<PointF> ListOfPoints { get => _listOfPoints; set => _listOfPoints = value; }
        public List<PointF> ListOfPointsForMagnitude { get => _listOfPointsForMagnitude; set => _listOfPointsForMagnitude = value; }

        #endregion
    }
}
