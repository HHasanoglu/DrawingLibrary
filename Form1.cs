using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            subscribeToEvents();
        }

        #endregion

        #region Private Fields

        private Graphics _panelGraphic;
        const int _gridSize = 100; // Adjust this value for the grid spacing

        #endregion

        private void subscribeToEvents()
        {
            btnDrawLine.Click += BtnDrawLine_Click;
            drawingPanel.Resize += DrawingPanel_Resize;
            drawingPanel.Paint += DrawingPanel_Paint;
            btnDeleteLines.Click += BtnDeleteLines_Click;
        }

        private void BtnDeleteLines_Click(object sender, EventArgs e)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                _panelGraphic.Clear(Color.White);

                DrawGrid();
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid();
        }

        private void DrawingPanel_Resize(object sender, EventArgs e)
        {
            // Get the Graphics object from the PictureBox
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                _panelGraphic.Clear(Color.White);

                //DrawGrid();
            }
        }

        private void BtnDrawLine_Click(object sender, EventArgs e)
        {
            float.TryParse(txtX1.Text, out float x1);
            float.TryParse(txtY1.Text, out float y1);
            float.TryParse(txtX2.Text, out float x2);
            float.TryParse(txtY2.Text, out float y2);
            DrawLine(x1,y1,x2,y2);
        }

        private void DrawLine(float x1, float y1, float x2, float y2)
        {
            using (_panelGraphic = drawingPanel.CreateGraphics())
            {
                Pen gridPen = new Pen(Color.Blue,4);
                var finalx1 = x1 + _gridSize;
                var finaly1 = drawingPanel.Height - y1 - _gridSize;
                var finalx2 = x2 + _gridSize;
                var finaly2 = drawingPanel.Height - y2 - _gridSize;

                _panelGraphic.DrawLine(gridPen,finalx1 ,finaly1 ,finalx2 ,finaly2 );
            }
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
                    _panelGraphic.DrawLine(gridPen, x , 0, x, drawingPanel.Height);
                }

                // Dispose of the Pen object to release resources
                gridPen.Dispose();
            }
        }
    }
}
