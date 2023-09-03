
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
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(12, 59);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(841, 467);
            this.drawingPanel.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(434, 7);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(79, 20);
            this.txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(434, 33);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(79, 20);
            this.txtY1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "x2";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(640, 30);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(79, 20);
            this.txtY2.TabIndex = 10;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(640, 4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(79, 20);
            this.txtX2.TabIndex = 9;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.AccessibleName = "";
            this.btnDrawLine.Location = new System.Drawing.Point(52, 12);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(113, 41);
            this.btnDrawLine.TabIndex = 3;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Location = new System.Drawing.Point(171, 12);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(113, 41);
            this.btnDeleteLine.TabIndex = 14;
            this.btnDeleteLine.Text = "Delete Line";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            // 
            // txtMagnitude
            // 
            this.txtMagnitude.Location = new System.Drawing.Point(519, 23);
            this.txtMagnitude.Name = "txtMagnitude";
            this.txtMagnitude.Size = new System.Drawing.Size(91, 20);
            this.txtMagnitude.TabIndex = 2;
            // 
            // txtMagnitude2
            // 
            this.txtMagnitude2.Location = new System.Drawing.Point(725, 20);
            this.txtMagnitude2.Name = "txtMagnitude2";
            this.txtMagnitude2.Size = new System.Drawing.Size(119, 20);
            this.txtMagnitude2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Magnitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Magnitude";
            // 
            // btnDrawDiagram
            // 
            this.btnDrawDiagram.Location = new System.Drawing.Point(290, 12);
            this.btnDrawDiagram.Name = "btnDrawDiagram";
            this.btnDrawDiagram.Size = new System.Drawing.Size(114, 41);
            this.btnDrawDiagram.TabIndex = 19;
            this.btnDrawDiagram.Text = "Draw Diagram";
            this.btnDrawDiagram.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
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
    }
}

