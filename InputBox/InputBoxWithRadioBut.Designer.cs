﻿namespace lab06
{
    partial class InputBoxWithRadioBut
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
            this.OK_button = new System.Windows.Forms.Button();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(86, 104);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 3;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(12, 12);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(265, 21);
            this.radioButtonX.TabIndex = 4;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "изометрическая проекция по оси X";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(12, 66);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(265, 21);
            this.radioButtonZ.TabIndex = 5;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "изометрическая проекция по оси Z";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Location = new System.Drawing.Point(12, 39);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(265, 21);
            this.radioButtonY.TabIndex = 6;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "изометрическая проекция по оси Y";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // InputBoxWithRadioBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 139);
            this.Controls.Add(this.radioButtonY);
            this.Controls.Add(this.radioButtonZ);
            this.Controls.Add(this.radioButtonX);
            this.Controls.Add(this.OK_button);
            this.Name = "InputBoxWithRadioBut";
            this.Text = "InputBoxWithRadioBut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.RadioButton radioButtonZ;
        private System.Windows.Forms.RadioButton radioButtonY;
    }
}