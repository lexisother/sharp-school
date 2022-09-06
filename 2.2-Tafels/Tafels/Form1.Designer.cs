namespace Tafels
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
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.txtTafel = new System.Windows.Forms.TextBox();
            this.btnToonTafel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(84, 6);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(99, 22);
            this.txtGetal.TabIndex = 0;
            // 
            // txtTafel
            // 
            this.txtTafel.Location = new System.Drawing.Point(12, 34);
            this.txtTafel.Multiline = true;
            this.txtTafel.Name = "txtTafel";
            this.txtTafel.Size = new System.Drawing.Size(252, 259);
            this.txtTafel.TabIndex = 1;
            // 
            // btnToonTafel
            // 
            this.btnToonTafel.Location = new System.Drawing.Point(189, 6);
            this.btnToonTafel.Name = "btnToonTafel";
            this.btnToonTafel.Size = new System.Drawing.Size(75, 23);
            this.btnToonTafel.TabIndex = 3;
            this.btnToonTafel.Text = "Maak";
            this.btnToonTafel.UseVisualStyleBackColor = true;
            this.btnToonTafel.Click += new System.EventHandler(this.btnToonTafel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(189, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Wis";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tafel van:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnToonTafel);
            this.Controls.Add(this.txtTafel);
            this.Controls.Add(this.txtGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.TextBox txtTafel;
        private System.Windows.Forms.Button btnToonTafel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
    }
}

