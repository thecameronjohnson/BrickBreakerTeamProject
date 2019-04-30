namespace BrickBreaker
{
    partial class HighScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.highScores = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("OCR A Std", 24F);
			this.label1.ForeColor = System.Drawing.Color.Cyan;
			this.label1.Location = new System.Drawing.Point(54, 470);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Main Menu";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// highScores
			// 
			this.highScores.AutoSize = true;
			this.highScores.BackColor = System.Drawing.Color.Transparent;
			this.highScores.Font = new System.Drawing.Font("OCR A Std", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highScores.ForeColor = System.Drawing.Color.Cyan;
			this.highScores.Location = new System.Drawing.Point(56, 47);
			this.highScores.Name = "highScores";
			this.highScores.Size = new System.Drawing.Size(51, 380);
			this.highScores.TabIndex = 5;
			this.highScores.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.\r\n\r\n6.\r\n\r\n7.\r\n\r\n8.\r\n\r\n9.\r\n\r\n10.";
			// 
			// HighScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
			this.Controls.Add(this.highScores);
			this.Controls.Add(this.label1);
			this.Name = "HighScreen";
			this.Size = new System.Drawing.Size(800, 550);
			this.Load += new System.EventHandler(this.HighScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label highScores;
	}
}
