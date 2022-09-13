namespace KleurenKiezen
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
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.pnlCheckedColor = new System.Windows.Forms.Panel();
            this.btnSetColorPanel = new System.Windows.Forms.Button();
            this.btnSetColorBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // rbRed
            //
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(12, 12);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(62, 20);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Rood";
            this.rbRed.UseVisualStyleBackColor = true;
            //
            // rbBlue
            //
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(12, 38);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(64, 20);
            this.rbBlue.TabIndex = 1;
            this.rbBlue.Text = "Blauw";
            this.rbBlue.UseVisualStyleBackColor = true;
            //
            // rbYellow
            //
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(12, 64);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(57, 20);
            this.rbYellow.TabIndex = 2;
            this.rbYellow.Text = "Geel";
            this.rbYellow.UseVisualStyleBackColor = true;
            //
            // rbGreen
            //
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(12, 90);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(65, 20);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.Text = "Groen";
            this.rbGreen.UseVisualStyleBackColor = true;
            //
            // rbOrange
            //
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(12, 116);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(68, 20);
            this.rbOrange.TabIndex = 4;
            this.rbOrange.Text = "Oranje";
            this.rbOrange.UseVisualStyleBackColor = true;
            //
            // pnlCheckedColor
            //
            this.pnlCheckedColor.Location = new System.Drawing.Point(154, 12);
            this.pnlCheckedColor.Name = "pnlCheckedColor";
            this.pnlCheckedColor.Size = new System.Drawing.Size(172, 135);
            this.pnlCheckedColor.TabIndex = 5;
            //
            // btnSetColorPanel
            //
            this.btnSetColorPanel.Location = new System.Drawing.Point(12, 185);
            this.btnSetColorPanel.Name = "btnSetColorPanel";
            this.btnSetColorPanel.Size = new System.Drawing.Size(143, 23);
            this.btnSetColorPanel.TabIndex = 0;
            this.btnSetColorPanel.Text = "Kleur panel";
            this.btnSetColorPanel.UseVisualStyleBackColor = true;
            this.btnSetColorPanel.Click += new System.EventHandler(this.btnSetColorPanel_Click);
            //
            // btnSetColorBackground
            //
            this.btnSetColorBackground.Location = new System.Drawing.Point(12, 214);
            this.btnSetColorBackground.Name = "btnSetColorBackground";
            this.btnSetColorBackground.Size = new System.Drawing.Size(143, 23);
            this.btnSetColorBackground.TabIndex = 1;
            this.btnSetColorBackground.Text = "Kleur achtergrond";
            this.btnSetColorBackground.UseVisualStyleBackColor = true;
            this.btnSetColorBackground.Click += new System.EventHandler(this.btnSetColorBackground_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 249);
            this.Controls.Add(this.btnSetColorPanel);
            this.Controls.Add(this.btnSetColorBackground);
            this.Controls.Add(this.pnlCheckedColor);
            this.Controls.Add(this.rbOrange);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbYellow);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.Panel pnlCheckedColor;
        private System.Windows.Forms.Button btnSetColorPanel;
        private System.Windows.Forms.Button btnSetColorBackground;
    }
}