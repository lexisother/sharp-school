namespace LettersTellen
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
            this.txtWoord = new System.Windows.Forms.TextBox();
            this.btnTelAantal = new System.Windows.Forms.Button();
            this.lblAantalSpaties = new System.Windows.Forms.Label();
            this.lblAantalKlinkers = new System.Windows.Forms.Label();
            this.lblAantalMedeklinkers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtWoord
            //
            this.txtWoord.Location = new System.Drawing.Point(108, 36);
            this.txtWoord.Name = "txtWoord";
            this.txtWoord.Size = new System.Drawing.Size(438, 22);
            this.txtWoord.TabIndex = 0;
            //
            // btnTelAantal
            //
            this.btnTelAantal.Location = new System.Drawing.Point(400, 78);
            this.btnTelAantal.Name = "btnTelAantal";
            this.btnTelAantal.Size = new System.Drawing.Size(146, 27);
            this.btnTelAantal.TabIndex = 1;
            this.btnTelAantal.Text = "Tel";
            this.btnTelAantal.UseVisualStyleBackColor = true;
            this.btnTelAantal.Click += new System.EventHandler(this.btnTelAantal_Click);
            //
            // lblAantalSpaties
            //
            this.lblAantalSpaties.AutoSize = true;
            this.lblAantalSpaties.Location = new System.Drawing.Point(148, 134);
            this.lblAantalSpaties.Name = "lblAantalSpaties";
            this.lblAantalSpaties.Size = new System.Drawing.Size(105, 16);
            this.lblAantalSpaties.TabIndex = 2;
            this.lblAantalSpaties.Text = "lblAantalSpaties";
            //
            // lblAantalKlinkers
            //
            this.lblAantalKlinkers.AutoSize = true;
            this.lblAantalKlinkers.Location = new System.Drawing.Point(148, 160);
            this.lblAantalKlinkers.Name = "lblAantalKlinkers";
            this.lblAantalKlinkers.Size = new System.Drawing.Size(106, 16);
            this.lblAantalKlinkers.TabIndex = 3;
            this.lblAantalKlinkers.Text = "lblAantalKlinkers";
            //
            // lblAantalMedeklinkers
            //
            this.lblAantalMedeklinkers.AutoSize = true;
            this.lblAantalMedeklinkers.Location = new System.Drawing.Point(148, 186);
            this.lblAantalMedeklinkers.Name = "lblAantalMedeklinkers";
            this.lblAantalMedeklinkers.Size = new System.Drawing.Size(140, 16);
            this.lblAantalMedeklinkers.TabIndex = 4;
            this.lblAantalMedeklinkers.Text = "lblAantalMedeklinkers";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Woord of zin";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aantal spaties";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aantal klinkers";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aantal medeklinkers";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAantalMedeklinkers);
            this.Controls.Add(this.lblAantalKlinkers);
            this.Controls.Add(this.lblAantalSpaties);
            this.Controls.Add(this.btnTelAantal);
            this.Controls.Add(this.txtWoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWoord;
        private System.Windows.Forms.Button btnTelAantal;
        private System.Windows.Forms.Label lblAantalSpaties;
        private System.Windows.Forms.Label lblAantalKlinkers;
        private System.Windows.Forms.Label lblAantalMedeklinkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}