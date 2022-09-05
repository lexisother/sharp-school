namespace NaamPopUpKleuren
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
            this.btnShowPopUp = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.benPaintButtons = new System.Windows.Forms.Button();
            this.btnPaintBackground = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnShowPopUp
            //
            this.btnShowPopUp.Location = new System.Drawing.Point(12, 161);
            this.btnShowPopUp.Name = "btnShowPopUp";
            this.btnShowPopUp.Size = new System.Drawing.Size(146, 23);
            this.btnShowPopUp.TabIndex = 0;
            this.btnShowPopUp.Text = "Show popup";
            this.btnShowPopUp.UseVisualStyleBackColor = true;
            this.btnShowPopUp.Click += new System.EventHandler(this.btnShowPopUp_Click);
            //
            // txtNaam
            //
            this.txtNaam.Location = new System.Drawing.Point(12, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(286, 22);
            this.txtNaam.TabIndex = 1;
            //
            // benPaintButtons
            //
            this.benPaintButtons.Location = new System.Drawing.Point(12, 74);
            this.benPaintButtons.Name = "benPaintButtons";
            this.benPaintButtons.Size = new System.Drawing.Size(146, 23);
            this.benPaintButtons.TabIndex = 2;
            this.benPaintButtons.Text = "Kleur buttons";
            this.benPaintButtons.UseVisualStyleBackColor = true;
            this.benPaintButtons.Click += new System.EventHandler(this.benPaintButtons_Click);
            //
            // btnPaintBackground
            //
            this.btnPaintBackground.Location = new System.Drawing.Point(12, 103);
            this.btnPaintBackground.Name = "btnPaintBackground";
            this.btnPaintBackground.Size = new System.Drawing.Size(146, 23);
            this.btnPaintBackground.TabIndex = 3;
            this.btnPaintBackground.Text = "Kleur achtergrond";
            this.btnPaintBackground.UseVisualStyleBackColor = true;
            this.btnPaintBackground.Click += new System.EventHandler(this.btnPaintBackground_Click);
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(12, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 196);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPaintBackground);
            this.Controls.Add(this.benPaintButtons);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnShowPopUp);
            this.Name = "Form1";
            this.Text = "Show popup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPopUp;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button benPaintButtons;
        private System.Windows.Forms.Button btnPaintBackground;
        private System.Windows.Forms.Button btnClear;
    }
}