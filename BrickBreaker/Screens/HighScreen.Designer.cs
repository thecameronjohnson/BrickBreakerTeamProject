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
			this.highScores = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			// button1
			// 
			this.button1.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Cyan;
			this.button1.Location = new System.Drawing.Point(611, 449);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 78);
			this.button1.TabIndex = 6;
			this.button1.Text = "RETURN";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HighScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.highScores);
			this.Name = "HighScreen";
			this.Size = new System.Drawing.Size(800, 550);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Label highScores;
		private System.Windows.Forms.Button button1;
	}
}
