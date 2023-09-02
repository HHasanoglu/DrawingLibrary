
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
            this.drawingPanel.Size = new System.Drawing.Size(849, 467);
            this.drawingPanel.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(362, 7);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(79, 20);
            this.txtX1.TabIndex = 3;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(362, 33);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(79, 20);
            this.txtY1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "x2";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(496, 33);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(79, 20);
            this.txtY2.TabIndex = 10;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(496, 7);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(79, 20);
            this.txtX2.TabIndex = 9;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(52, 12);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(113, 41);
            this.btnDrawLine.TabIndex = 13;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 538);
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
            this.MaximumSize = new System.Drawing.Size(889, 577);
            this.MinimumSize = new System.Drawing.Size(889, 577);
            this.Name = "Form1";
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
    }
}

