namespace DrawingForm
{
    partial class InsertGridForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAxisSpacingDir1 = new System.Windows.Forms.TextBox();
            this.lblDir1AxisSpacing = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAxisSpacingDir2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDir1AxisSpacing);
            this.groupBox1.Controls.Add(this.txtAxisSpacingDir1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dir-1 Axes";
            // 
            // txtAxisSpacingDir1
            // 
            this.txtAxisSpacingDir1.Location = new System.Drawing.Point(83, 26);
            this.txtAxisSpacingDir1.Name = "txtAxisSpacingDir1";
            this.txtAxisSpacingDir1.Size = new System.Drawing.Size(222, 20);
            this.txtAxisSpacingDir1.TabIndex = 0;
            this.txtAxisSpacingDir1.Text = "1000*3";
            // 
            // lblDir1AxisSpacing
            // 
            this.lblDir1AxisSpacing.AutoSize = true;
            this.lblDir1AxisSpacing.Location = new System.Drawing.Point(6, 26);
            this.lblDir1AxisSpacing.Name = "lblDir1AxisSpacing";
            this.lblDir1AxisSpacing.Size = new System.Drawing.Size(71, 13);
            this.lblDir1AxisSpacing.TabIndex = 1;
            this.lblDir1AxisSpacing.Text = "Axis Spacing:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAxisSpacingDir2);
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dir-2 Axes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axis Spacing:";
            // 
            // txtAxisSpacingDir2
            // 
            this.txtAxisSpacingDir2.Location = new System.Drawing.Point(83, 26);
            this.txtAxisSpacingDir2.Name = "txtAxisSpacingDir2";
            this.txtAxisSpacingDir2.Size = new System.Drawing.Size(222, 20);
            this.txtAxisSpacingDir2.TabIndex = 0;
            this.txtAxisSpacingDir2.Text = "1000*3";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitForm
            // 
            this.btnSubmitForm.Location = new System.Drawing.Point(258, 226);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(111, 35);
            this.btnSubmitForm.TabIndex = 3;
            this.btnSubmitForm.Text = "OK";
            this.btnSubmitForm.UseVisualStyleBackColor = true;
            // 
            // InsertGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 273);
            this.Controls.Add(this.btnSubmitForm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertGrid";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAxisSpacingDir1;
        private System.Windows.Forms.Label lblDir1AxisSpacing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAxisSpacingDir2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitForm;
    }
}