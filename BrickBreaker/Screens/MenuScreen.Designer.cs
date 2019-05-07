﻿namespace BrickBreaker
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.showDebug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Cyan;
            this.playButton.Location = new System.Drawing.Point(306, 281);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(181, 78);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Cyan;
            this.exitButton.Location = new System.Drawing.Point(306, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 78);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Aqua;
            this.title.Location = new System.Drawing.Point(87, 89);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(653, 68);
            this.title.TabIndex = 2;
            this.title.Text = "Brick Breaker";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(90, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brick Breaker";
            // 
            // nameButton
            // 
            this.nameButton.BackColor = System.Drawing.Color.Transparent;
            this.nameButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.nameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameButton.FlatAppearance.BorderSize = 0;
            this.nameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameButton.ForeColor = System.Drawing.Color.Cyan;
            this.nameButton.Location = new System.Drawing.Point(534, 487);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(92, 46);
            this.nameButton.TabIndex = 4;
            this.nameButton.Text = "Name Screen";
            this.nameButton.UseVisualStyleBackColor = false;
            this.nameButton.Visible = false;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // highButton
            // 
            this.highButton.BackColor = System.Drawing.Color.Transparent;
            this.highButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.highButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highButton.FlatAppearance.BorderSize = 0;
            this.highButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highButton.ForeColor = System.Drawing.Color.Cyan;
            this.highButton.Location = new System.Drawing.Point(649, 487);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(92, 46);
            this.highButton.TabIndex = 5;
            this.highButton.Text = "HS Screen";
            this.highButton.UseVisualStyleBackColor = false;
            this.highButton.Visible = false;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // showDebug
            // 
            this.showDebug.AutoSize = true;
            this.showDebug.BackColor = System.Drawing.Color.Transparent;
            this.showDebug.ForeColor = System.Drawing.Color.Cyan;
            this.showDebug.Location = new System.Drawing.Point(607, 426);
            this.showDebug.Name = "showDebug";
            this.showDebug.Size = new System.Drawing.Size(136, 17);
            this.showDebug.TabIndex = 6;
            this.showDebug.Text = "Show Debug Shortcuts";
            this.showDebug.UseVisualStyleBackColor = false;
            //this.showDebug.CheckedChanged += new System.EventHandler(this.showDebug_CheckedChanged);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.showDebug);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button howButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.CheckBox showDebug;
    }

}
