using DrawingForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingForm
{
    public partial class Form1 : Form
    {
        #region Ctor

        public Form1()
        {
            InitializeComponent();

            _drawingHelper = new DrawignHelper();

            SubscribeToEvents();
        }

        #endregion

        #region Private Fields

        private DrawignHelper _drawingHelper;

        private Graphics _panelGraphic;
        const int _gridSize = 100; // Adjust this value for the grid spacing
        private Vector _currentPosition;
        private Vector _firstPosition;
        private int _drawIndex = -1;
        private bool _activeDrawing = false;
        private int _clickNum = 1;
        private bool _enableExtendedLine = true;

        #endregion

        #region Events

        private void BtnDisableExtendedLine_Click(object sender, EventArgs e)
        {
            if (_enableExtendedLine)
            {
                _enableExtendedLine = false;
                btnDisableExtendedLine.Text = "Enable Extended Line Mode";
            }
            else
            {
                _enableExtendedLine = true;
                btnDisableExtendedLine.Text = "Disable Extended Line Mode";
            }
        }
        // Button Draw With Mouse

        private void BtnDrawLineWithMouse_Click(object sender, EventArgs e)
        {
            if (_activeDrawing)
            {
                _drawIndex = -1;
                drawingPanel.Cursor = Cursors.Arrow;
                _activeDrawing = false;
            }
            else
            {
                _drawIndex = 1;
                _activeDrawing = true;
                drawingPanel.Cursor = Cursors.Cross;
            }
        }

        private void BtnDrawWithMouse_Click(object sender, EventArgs e)
        {
            if (_activeDrawing)
            {
                _drawIndex = -1;
                drawingPanel.Cursor = Cursors.Arrow;
                _activeDrawing = false;
            }
            else
            {
                _drawIndex = 0;
                _activeDrawing = true;
                drawingPanel.Cursor = Cursors.Cross;
            }
        }

        //Button Draw Diagram
        private void BtnDrawDiagram_Click(object sender, EventArgs e)
        {
            float.TryParse(txtX1.Text, out float x1);
            float.TryParse(txtY1.Text, out float y1);
            float.TryParse(txtX2.Text, out float x2);
            float.TryParse(txtY2.Text, out float y2);

            float.TryParse(txtMagnitude.Text, out float magnitude1);
            float.TryParse(txtMagnitude2.Text, out float magnitude2);
            DrawMagnitude(x1, y1, magnitude1, x2, y2, magnitude2);
            DrawLine(x1, y1, x2, y2);

            //using (_panelGraphic = drawingPanel.CreateGraphics())
            //{
            //    Pen Pen = new Pen(Color.LightSkyBlue, 2.5f);
            //    Vector startPoint = new Vector(ConvertCoordinate(x1), ConvertCoordinate(y1, true));
            //    Vector endPoint = new Vector(ConvertCoordinate(x2), ConvertCoordinate(y2, true));

            //    LineElement line = new LineElement(startPoint, endPoint);
            //    _panelGraphic.DrawLine(Pen, line);

            //    Pen.Dispose();

            //}

        }

        //  Mouse Down on panel to draw a point
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_activeDrawing)
                {
                    switch (_drawIndex)
                    {
                        case 0: // Point
                            {
                                AddCurrentPositionToListOfPoints();
                                break;
                            }

                        case 1: // Line
                            {
                                switch (_clickNum)
                                {
                                    case 1:
                                        {
                                            _firstPosition = _currentPosition;

                                            AddCurrentPositionToListOfPoints();

                                            _clickNum++;
                                            break;
                                        }

                                    case 2:
                                        {
                                            LineElement line = new LineElement(_firstPosition, _currentPosition);
                                            AddCurrentPositionToListOfPoints();
                                            //MessageBox.Show(string.Format("{0}, {1}", line.StartPoint.X + " " + line.StartPoint.Y, line.EndPoint.X + " " + line.EndPoint.Y));
                                            AddLineToListOfLines(line);
                                            _firstPosition = _currentPosition;

                                            break;
                                        }
                                }
                                break;
                            }
                    }
                    drawingPanel.Refresh();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (_drawIndex == 1)
                {
                    _drawIndex = -1;
                    drawingPanel.Cursor = Cursors.Arrow;
                    _activeDrawing = false;
                }
            }
        }

        private void AddLineToListOfLines(LineElement line)
        {
            _drawingHelper.LineElements.Add(line.Id, line);
        }

        private void AddCurrentPositionToListOfPoints()
        {
            _drawingHelper.ListOfPointsCoordinate.Add(new Entities.Point(_currentPosition));
        }

        // Mouse Move on Panel
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var originalXCoordinate = e.Location.X;
            var originalYCoordinate = e.Location.Y;

            PointF p = new PointF(originalXCoordinate - _gridSize,drawingPanel.Height - originalYCoordinate - _gridSize);

            _currentPosition = new Vector(ConvertCoordinate(e.Location.X - _gridSize), ConvertCoordinate(e.Location.Y, true));
            lblX.Text = string.Format("X: {0}, Y: {1}", p.X,p.Y);
            if (_enableExtendedLine)
            {
                drawingPanel.Refresh();
            }

        }

        // Button to clear to the panel
        private void BtnDeleteLines_Click(object sender, EventArgs e)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                //_panelGraphic.Clear(Color.White);

                _drawingHelper.ListOfPoints.Clear();
                _drawingHelper.ListOfPointsForMagnitude.Clear();
               

            }
            _drawingHelper.ListOfPointsCoordinate.Clear();
            _drawingHelper.LineElements.Clear();
            
            _clickNum = 1;
            _currentPosition = null;
            _firstPosition = null;
            drawingPanel.Refresh();
            drawingPanel.Invalidate();
        }

        // 



        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {

            DrawGrid();
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                Pen Pen = new Pen(Color.LightGray, 3);
                _panelGraphic.DrawLine(Pen, ConvertCoordinate(0), ConvertCoordinate(0, true), ConvertCoordinate(drawingPanel.Width), ConvertCoordinate(0, true));
                _panelGraphic.DrawLine(Pen, ConvertCoordinate(0), ConvertCoordinate(0, true), ConvertCoordinate(0), ConvertCoordinate(drawingPanel.Height, true));

                _panelGraphic.SetParameters(ConvertCoordinate(0, true));

                //Draw All points
                Pen = new Pen(Color.LightGreen, 2); // Color of the point
                if (_drawingHelper.ListOfPointsCoordinate.Count > 0)
                {
                    foreach (var point in _drawingHelper.ListOfPointsCoordinate)
                    {
                        _panelGraphic.DrawPoint(new Pen(Color.LightGreen, 2), point);

                    }
                }

                //Draw All lines

                Pen = new Pen(Color.LightSkyBlue, 2.5f);

                if (_drawingHelper.LineElements.Count > 0)
                {
                    foreach (var line in _drawingHelper.LineElements)
                    {
                        _panelGraphic.DrawLine(Pen, line.Value);
                    }
                }

                //Draw Line Extended

                switch (_drawIndex)
                {
                    case 1:
                        {
                            if (_clickNum == 2)
                            {
                                Pen = new Pen(Color.LightGreen, 2f);

                                Vector startPoint = new Vector(_firstPosition.X, _firstPosition.Y);
                                Vector endPoint = new Vector(_currentPosition.X, _currentPosition.Y);

                                LineElement line = new LineElement(startPoint, endPoint);
                                _panelGraphic.DrawLine(Pen, line);

                            }
                            break;
                        }
                }

                Pen.Dispose();
            }

        }

        //private void DrawingPanel_Resize(object sender, EventArgs e)
        //{
        //    // Get the Graphics object from the PictureBox
        //    using (_panelGraphic = drawingPanel.CreateGraphics())
        //    {
        //        _panelGraphic.Clear(Color.White);

        //        //DrawGrid();
        //    }
        //}

        private void BtnDrawLine_Click(object sender, EventArgs e)
        {
            float.TryParse(txtX1.Text, out float x1);
            float.TryParse(txtY1.Text, out float y1);
            float.TryParse(txtX2.Text, out float x2);
            float.TryParse(txtY2.Text, out float y2);


            DrawLine(x1, y1, x2, y2);

            float.TryParse(txtMagnitude.Text, out float magnitude1);
            float.TryParse(txtMagnitude2.Text, out float magnitude2);

            //DrawMagnitude(x1, y1, magnitude1);

            //if (_listOfPointsForMagnitude.Count >= 2)
            //{
            //    ConnectMagnitudes(_listOfPointsForMagnitude[0].X, _listOfPointsForMagnitude[0].Y, _listOfPointsForMagnitude[1].X, _listOfPointsForMagnitude[1].Y);

            //    _listOfPointsForMagnitude.RemoveAt(0);
            //}

            //DrawMagnitude(x2, y2, magnitude2);
        }

        private void ConnectMagnitudes(float x1, float y1, float x2, float y2)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                Pen gridPen = new Pen(Color.Red, 3);

                //var finalX1 = x1 + _gridSize;
                //var finalY1 = drawingPanel.Height - y1 - _gridSize;
                //var finalX2 = x2 + _gridSize;
                //var finalY2 = drawingPanel.Height - y2 - _gridSize;

                _panelGraphic.DrawLine(gridPen, x1, y1, x2, y2);

                gridPen.Dispose();
            }
        }

        #endregion

        #region Private Methods

        private void SubscribeToEvents()
        {
            btnDrawLine.Click += BtnDrawLine_Click;
            //drawingPanel.Resize += DrawingPanel_Resize;
            drawingPanel.Paint += DrawingPanel_Paint;
            btnDeleteLine.Click += BtnDeleteLines_Click;
            btnDrawDiagram.Click += BtnDrawDiagram_Click;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            btnDrawWithMouse.Click += BtnDrawWithMouse_Click;
            btnDrawLineWithMouse.Click += BtnDrawLineWithMouse_Click;
            btnDisableExtendedLine.Click += BtnDisableExtendedLine_Click;

            //This is for Git Check
        }



        private float ConvertCoordinate(float value, bool isY = false)
        {

            return isY ? drawingPanel.Height - value - _gridSize : value + _gridSize;

            //return isY ? drawingPanel.Height - value  : value ; 



        }

        private void DrawMagnitude(float x1, float y1, float magnitude1, float x2, float y2, float magnitude2)
        {

            x1 = ConvertCoordinate(x1);
            x2 = ConvertCoordinate(x2);
            y1 = ConvertCoordinate(y1, true);
            y2 = ConvertCoordinate(y2, true);

            var points = new List<PointF>();


            var maxMagnitude = Math.Max(magnitude1, magnitude2);
            var minMagnitude = Math.Min(magnitude1, magnitude2);

            float length = (float)Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));

            var maxLength = length * 0.2f;
            var x3 = x2 - magnitude2;
            var y3 = y2;

            var x4 = x1 - magnitude1;
            var y4 = y1;

            //if (x1 > x4)
            //{
            //    x1 = x1 - 1.5f;
            //    x2 = x2 - 1.5f;
            //}
            //else
            //{
            //    x1 = x1 + 1.5f;
            //    x2 = x2 + 1.5f;
            //}

            points.Add(new PointF(x1, y1));
            points.Add(new PointF(x2, y2));
            points.Add(new PointF(x3, y3));
            points.Add(new PointF(x4, y4));

            DrawPolygon(points.ToArray());


            //using (_panelGraphic = drawingPanel.CreateGraphics())
            //{

            //    // Define the points for the polygon

            //    PointF[] polygonPoints = new PointF[]
            //{
            //    new PointF(ConvertCoordinate( 0),ConvertCoordinate(0  ,true)),
            //    new PointF(ConvertCoordinate(0), ConvertCoordinate(100,true)),
            //    new PointF(ConvertCoordinate(50),ConvertCoordinate(100,true)),
            //    new PointF(ConvertCoordinate(-50), ConvertCoordinate(0  ,true))
            //};

            //    // Create a Pen for the polygon outline
            //    Pen outlinePen = new Pen(Color.Blue, 2);
            //    Brush fillBrush = new SolidBrush(Color.Blue);

            //    //Draw the polygon
            //    _panelGraphic.FillPolygon(fillBrush, polygonPoints);

            //    // Dispose of the Pen object to release resources
            //    outlinePen.Dispose();
            //}

            //using (_panelGraphic = drawingPanel.CreateGraphics())
            //{
            //    Pen gridPen = new Pen(Color.Black, 3);
            //    var finalX1 = x1;
            //    var finalY1 = drawingPanel.Height - y1;
            //    var finalX2 = x1;
            //    var finalY2 = drawingPanel.Height - y1 - maxLength;

            //    //var finalMagnitude = (magnitude * 25) / 100;


            //    _panelGraphic.DrawLine(gridPen, finalX1, finalY1, finalX2, finalY2);
            //    _listOfPointsForMagnitude.Add(new PointF(finalX2, finalY2));
            //    gridPen.Dispose();
            //}

        }

        private void DrawPolygon(PointF[] polygonPoints)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                // Create a Pen for the polygon outline
                Pen outlinePen = new Pen(Color.Blue, 2);
                Brush fillBrush = new SolidBrush(Color.LightBlue);

                //Draw the polygon
                _panelGraphic.FillPolygon(fillBrush, polygonPoints);

                // Dispose of the Pen object to release resources
                outlinePen.Dispose();
            }
        }

        private void DrawLine(float x1, float y1, float x2, float y2)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                Pen Pen = new Pen(Color.Blue, 3);

                var finalX1 = x1 + _gridSize;
                var finalY1 = drawingPanel.Height - y1 - _gridSize;
                var finalX2 = x2 + _gridSize;
                var finalY2 = drawingPanel.Height - y2 - _gridSize;

                _panelGraphic.DrawLine(Pen, finalX1, finalY1, finalX2, finalY2);

                //if (_drawingHelper.ListOfPoints.Count == 0)
                //{
                //    _panelGraphic.DrawLine(Pen, finalX1, finalY1, finalX2, finalY2);
                //}
                //else
                //{
                //    //var count = _drawingHelper.ListOfPoints.Count;
                //    //PointF Point = _drawingHelper.ListOfPoints[_drawingHelper.ListOfPoints.Last().];
                //    finalX1 = _drawingHelper.ListOfPoints.Last().X + _gridSize;
                //    finalY1 = drawingPanel.Height - _drawingHelper.ListOfPoints.Last().Y - _gridSize;
                //    finalX2 = x1 + _gridSize;
                //    finalY2 = drawingPanel.Height - y1 - _gridSize;

                //    _panelGraphic.DrawLine(Pen, finalX1, finalY1, finalX2, finalY2);
                //    //_listOfCoordinatesForFillBrush.Add()
                //}


                //DrawCircle(finalX1, finalY1);
                //DrawCircle(finalX2, finalY2);

                _drawingHelper.ListOfPoints.Add(new PointF(x1, y1));


                ClearInputs();

                Pen.Dispose();
            }
        }

        private void ClearInputs()
        {
            //txtX1.Clear();
            //txtX2.Clear();
            //txtMagnitude.Clear();
            //txtY1.Text = "";
            //txtY2.Text = "";
        }

        private void DrawCircle(float x, float y)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {

                int diameter = 4; // Diameter of the smaller rounded circle
                int cornerRadius = 2; // Radius of the rounded corners

                // Create a Brush for filling the smaller rounded circle (e.g., solid green)
                Brush fillBrush = new SolidBrush(Color.Black);

                // Create a rounded rectangle for the smaller rounded circle
                RectangleF roundedRectangle = new RectangleF(x - 3, y - 3, diameter, diameter);
                GraphicsPath roundedPath = GetRoundedRectangle(roundedRectangle, cornerRadius);

                // Fill the smaller rounded circle
                _panelGraphic.FillPath(fillBrush, roundedPath);

                // Dispose of the Brush and GraphicsPath objects to release resources
                fillBrush.Dispose();
                roundedPath.Dispose();


            }

        }

        // Helper method to create a rounded rectangle
        private GraphicsPath GetRoundedRectangle(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // Top-left corner
            path.AddArc(rect.Right - 2 * radius, rect.Y, radius * 2, radius * 2, 270, 90); // Top-right corner
            path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90, 90); // Bottom-left corner
            path.CloseFigure(); // Close the path

            return path;
        }


        private void DrawGrid()
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {

                Pen gridPen = new Pen(Color.White, 1); // Pen for grid lines
                drawingPanel.BackColor = Color.FromArgb(229, 236, 246);
                // Draw the horizontal lines
                for (int y = drawingPanel.Height; y > 0; y -= _gridSize)
                {
                    _panelGraphic.DrawLine(gridPen, 0, y, drawingPanel.Width, y);
                }

                //Draw the vertical lines
                for (int x = 0; x < drawingPanel.Width; x += _gridSize)
                {
                    _panelGraphic.DrawLine(gridPen, x, 0, x, drawingPanel.Height);
                }

                // Dispose of the Pen object to release resources
                gridPen.Dispose();
            }
        }
        #endregion
    }
}
