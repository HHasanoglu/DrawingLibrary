
namespace DrawingForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.txtMagnitude = new System.Windows.Forms.TextBox();
            this.txtMagnitude2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrawDiagram = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.btnDrawWithMouse = new System.Windows.Forms.Button();
            this.btnDrawLineWithMouse = new System.Windows.Forms.Button();
            this.btnDisableExtendedLine = new System.Windows.Forms.Button();
            this.btnInsertGrid = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnResetZoom = new System.Windows.Forms.Button();
            this.lblZoomSize = new System.Windows.Forms.Label();
            this.columnsXTextBox = new System.Windows.Forms.TextBox();
            this.rowsYTextBox = new System.Windows.Forms.TextBox();
            this.gridSpacingYTextBox = new System.Windows.Forms.TextBox();
            this.gridSpacingXTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmitGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(26, 106);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(818, 470);
            this.drawingPanel.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(411, 9);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(52, 20);
            this.txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(411, 35);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(52, 20);
            this.txtY1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "x2";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(566, 32);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(50, 20);
            this.txtY2.TabIndex = 4;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(566, 6);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(50, 20);
            this.txtX2.TabIndex = 3;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.AccessibleName = "";
            this.btnDrawLine.Location = new System.Drawing.Point(12, 2);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(79, 41);
            this.btnDrawLine.TabIndex = 6;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Location = new System.Drawing.Point(12, 46);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(79, 41);
            this.btnDeleteLine.TabIndex = 8;
            this.btnDeleteLine.Text = "Delete Line";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            // 
            // txtMagnitude
            // 
            this.txtMagnitude.Location = new System.Drawing.Point(467, 20);
            this.txtMagnitude.Name = "txtMagnitude";
            this.txtMagnitude.Size = new System.Drawing.Size(69, 20);
            this.txtMagnitude.TabIndex = 2;
            // 
            // txtMagnitude2
            // 
            this.txtMagnitude2.Location = new System.Drawing.Point(634, 20);
            this.txtMagnitude2.Name = "txtMagnitude2";
            this.txtMagnitude2.Size = new System.Drawing.Size(76, 20);
            this.txtMagnitude2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Magnitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Magnitude";
            // 
            // btnDrawDiagram
            // 
            this.btnDrawDiagram.Location = new System.Drawing.Point(97, 2);
            this.btnDrawDiagram.Name = "btnDrawDiagram";
            this.btnDrawDiagram.Size = new System.Drawing.Size(80, 41);
            this.btnDrawDiagram.TabIndex = 7;
            this.btnDrawDiagram.Text = "Draw Diagram";
            this.btnDrawDiagram.UseVisualStyleBackColor = true;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(464, 74);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(66, 13);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "Coordinates:";
            // 
            // btnDrawWithMouse
            // 
            this.btnDrawWithMouse.Location = new System.Drawing.Point(183, 2);
            this.btnDrawWithMouse.Name = "btnDrawWithMouse";
            this.btnDrawWithMouse.Size = new System.Drawing.Size(88, 41);
            this.btnDrawWithMouse.TabIndex = 20;
            this.btnDrawWithMouse.Text = "Draw Point with Mouse";
            this.btnDrawWithMouse.UseVisualStyleBackColor = true;
            // 
            // btnDrawLineWithMouse
            // 
            this.btnDrawLineWithMouse.Location = new System.Drawing.Point(277, 2);
            this.btnDrawLineWithMouse.Name = "btnDrawLineWithMouse";
            this.btnDrawLineWithMouse.Size = new System.Drawing.Size(88, 41);
            this.btnDrawLineWithMouse.TabIndex = 21;
            this.btnDrawLineWithMouse.Text = "Draw Line with Mouse";
            this.btnDrawLineWithMouse.UseVisualStyleBackColor = true;
            // 
            // btnDisableExtendedLine
            // 
            this.btnDisableExtendedLine.Location = new System.Drawing.Point(97, 46);
            this.btnDisableExtendedLine.Name = "btnDisableExtendedLine";
            this.btnDisableExtendedLine.Size = new System.Drawing.Size(80, 41);
            this.btnDisableExtendedLine.TabIndex = 22;
            this.btnDisableExtendedLine.Text = "Disable Extended Line";
            this.btnDisableExtendedLine.UseVisualStyleBackColor = true;
            // 
            // btnInsertGrid
            // 
            this.btnInsertGrid.Location = new System.Drawing.Point(183, 46);
            this.btnInsertGrid.Name = "btnInsertGrid";
            this.btnInsertGrid.Size = new System.Drawing.Size(88, 41);
            this.btnInsertGrid.TabIndex = 23;
            this.btnInsertGrid.Text = "Insert Grid";
            this.btnInsertGrid.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(780, 6);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(64, 23);
            this.btnZoomOut.TabIndex = 24;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(716, 6);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(58, 23);
            this.btnZoomIn.TabIndex = 25;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnResetZoom
            // 
            this.btnResetZoom.Location = new System.Drawing.Point(780, 35);
            this.btnResetZoom.Name = "btnResetZoom";
            this.btnResetZoom.Size = new System.Drawing.Size(64, 20);
            this.btnResetZoom.TabIndex = 26;
            this.btnResetZoom.Text = "Reset Zoom";
            this.btnResetZoom.UseVisualStyleBackColor = true;
            // 
            // lblZoomSize
            // 
            this.lblZoomSize.AutoSize = true;
            this.lblZoomSize.Location = new System.Drawing.Point(713, 74);
            this.lblZoomSize.Name = "lblZoomSize";
            this.lblZoomSize.Size = new System.Drawing.Size(37, 13);
            this.lblZoomSize.TabIndex = 0;
            this.lblZoomSize.Text = "Zoom:";
            // 
            // columnsXTextBox
            // 
            this.columnsXTextBox.Location = new System.Drawing.Point(336, 54);
            this.columnsXTextBox.Name = "columnsXTextBox";
            this.columnsXTextBox.Size = new System.Drawing.Size(10, 20);
            this.columnsXTextBox.TabIndex = 27;
            this.columnsXTextBox.Visible = false;
            // 
            // rowsYTextBox
            // 
            this.rowsYTextBox.Location = new System.Drawing.Point(336, 80);
            this.rowsYTextBox.Name = "rowsYTextBox";
            this.rowsYTextBox.Size = new System.Drawing.Size(10, 20);
            this.rowsYTextBox.TabIndex = 28;
            this.rowsYTextBox.Visible = false;
            // 
            // gridSpacingYTextBox
            // 
            this.gridSpacingYTextBox.Location = new System.Drawing.Point(423, 57);
            this.gridSpacingYTextBox.Name = "gridSpacingYTextBox";
            this.gridSpacingYTextBox.Size = new System.Drawing.Size(10, 20);
            this.gridSpacingYTextBox.TabIndex = 30;
            this.gridSpacingYTextBox.Visible = false;
            // 
            // gridSpacingXTextBox
            // 
            this.gridSpacingXTextBox.Location = new System.Drawing.Point(439, 57);
            this.gridSpacingXTextBox.Name = "gridSpacingXTextBox";
            this.gridSpacingXTextBox.Size = new System.Drawing.Size(10, 20);
            this.gridSpacingXTextBox.TabIndex = 29;
            this.gridSpacingXTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Colums";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Rows";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "spacing X";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Spacing Y";
            this.label10.Visible = false;
            // 
            // btnSubmitGrid
            // 
            this.btnSubmitGrid.Location = new System.Drawing.Point(277, 73);
            this.btnSubmitGrid.Name = "btnSubmitGrid";
            this.btnSubmitGrid.Size = new System.Drawing.Size(10, 14);
            this.btnSubmitGrid.TabIndex = 35;
            this.btnSubmitGrid.Text = "Submit Grid";
            this.btnSubmitGrid.UseVisualStyleBackColor = true;
            this.btnSubmitGrid.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDrawLine;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 588);
            this.Controls.Add(this.btnSubmitGrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridSpacingYTextBox);
            this.Controls.Add(this.gridSpacingXTextBox);
            this.Controls.Add(this.rowsYTextBox);
            this.Controls.Add(this.columnsXTextBox);
            this.Controls.Add(this.lblZoomSize);
            this.Controls.Add(this.btnResetZoom);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnInsertGrid);
            this.Controls.Add(this.btnDisableExtendedLine);
            this.Controls.Add(this.btnDrawLineWithMouse);
            this.Controls.Add(this.btnDrawWithMouse);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnDrawDiagram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMagnitude2);
            this.Controls.Add(this.txtMagnitude);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.drawingPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.TextBox txtMagnitude;
        private System.Windows.Forms.TextBox txtMagnitude2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrawDiagram;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnDrawWithMouse;
        private System.Windows.Forms.Button btnDrawLineWithMouse;
        private System.Windows.Forms.Button btnDisableExtendedLine;
        private System.Windows.Forms.Button btnInsertGrid;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnResetZoom;
        private System.Windows.Forms.Label lblZoomSize;
        private System.Windows.Forms.TextBox columnsXTextBox;
        private System.Windows.Forms.TextBox rowsYTextBox;
        private System.Windows.Forms.TextBox gridSpacingYTextBox;
        private System.Windows.Forms.TextBox gridSpacingXTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmitGrid;
    }
}

