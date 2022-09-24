namespace Strafwerk
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
            this.txtStrafzin = new System.Windows.Forms.TextBox();
            this.nudAantalRegels = new System.Windows.Forms.NumericUpDown();
            this.btnMaakStrafwerk = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalRegels)).BeginInit();
            this.SuspendLayout();
            //
            // txtStrafzin
            //
            this.txtStrafzin.Location = new System.Drawing.Point(78, 19);
            this.txtStrafzin.Name = "txtStrafzin";
            this.txtStrafzin.Size = new System.Drawing.Size(404, 22);
            this.txtStrafzin.TabIndex = 0;
            //
            // nudAantalRegels
            //
            this.nudAantalRegels.Location = new System.Drawing.Point(78, 48);
            this.nudAantalRegels.Name = "nudAantalRegels";
            this.nudAantalRegels.Size = new System.Drawing.Size(120, 22);
            this.nudAantalRegels.TabIndex = 1;
            //
            // btnMaakStrafwerk
            //
            this.btnMaakStrafwerk.Location = new System.Drawing.Point(78, 76);
            this.btnMaakStrafwerk.Name = "btnMaakStrafwerk";
            this.btnMaakStrafwerk.Size = new System.Drawing.Size(120, 23);
            this.btnMaakStrafwerk.TabIndex = 2;
            this.btnMaakStrafwerk.Text = "Maak strafwerk";
            this.btnMaakStrafwerk.UseVisualStyleBackColor = true;
            this.btnMaakStrafwerk.Click += new System.EventHandler(this.btnMaakStrafwerk_Click);
            //
            // txtResultaat
            //
            this.txtResultaat.Location = new System.Drawing.Point(78, 105);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(404, 294);
            this.txtResultaat.TabIndex = 3;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zin";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnMaakStrafwerk);
            this.Controls.Add(this.nudAantalRegels);
            this.Controls.Add(this.txtStrafzin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalRegels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStrafzin;
        private System.Windows.Forms.NumericUpDown nudAantalRegels;
        private System.Windows.Forms.Button btnMaakStrafwerk;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}