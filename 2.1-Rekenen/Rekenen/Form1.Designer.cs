namespace Rekenen
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBerekenSom = new System.Windows.Forms.Button();
            this.btnBerekenVerschil = new System.Windows.Forms.Button();
            this.btnBerekenProduct = new System.Windows.Forms.Button();
            this.btnBerekenQuotient = new System.Windows.Forms.Button();
            this.lblSom1 = new System.Windows.Forms.Label();
            this.lblVerschil1 = new System.Windows.Forms.Label();
            this.lblProduct1 = new System.Windows.Forms.Label();
            this.lblQuotient1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(64, 6);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 22);
            this.txtGetal1.TabIndex = 0;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(64, 34);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 22);
            this.txtGetal2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Getal2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "(int)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "(int)";
            // 
            // btnBerekenSom
            // 
            this.btnBerekenSom.Location = new System.Drawing.Point(12, 70);
            this.btnBerekenSom.Name = "btnBerekenSom";
            this.btnBerekenSom.Size = new System.Drawing.Size(152, 23);
            this.btnBerekenSom.TabIndex = 6;
            this.btnBerekenSom.Text = "Bereken som";
            this.btnBerekenSom.UseVisualStyleBackColor = true;
            this.btnBerekenSom.Click += new System.EventHandler(this.btnBerekenSom_Click);
            // 
            // btnBerekenVerschil
            // 
            this.btnBerekenVerschil.Location = new System.Drawing.Point(12, 99);
            this.btnBerekenVerschil.Name = "btnBerekenVerschil";
            this.btnBerekenVerschil.Size = new System.Drawing.Size(152, 23);
            this.btnBerekenVerschil.TabIndex = 7;
            this.btnBerekenVerschil.Text = "Bereken verschil";
            this.btnBerekenVerschil.UseVisualStyleBackColor = true;
            this.btnBerekenVerschil.Click += new System.EventHandler(this.btnBerekenVerschil_Click);
            // 
            // btnBerekenProduct
            // 
            this.btnBerekenProduct.Location = new System.Drawing.Point(12, 128);
            this.btnBerekenProduct.Name = "btnBerekenProduct";
            this.btnBerekenProduct.Size = new System.Drawing.Size(152, 23);
            this.btnBerekenProduct.TabIndex = 8;
            this.btnBerekenProduct.Text = "Bereken product";
            this.btnBerekenProduct.UseVisualStyleBackColor = true;
            this.btnBerekenProduct.Click += new System.EventHandler(this.btnBerekenProduct_Click);
            // 
            // btnBerekenQuotient
            // 
            this.btnBerekenQuotient.Location = new System.Drawing.Point(12, 157);
            this.btnBerekenQuotient.Name = "btnBerekenQuotient";
            this.btnBerekenQuotient.Size = new System.Drawing.Size(152, 23);
            this.btnBerekenQuotient.TabIndex = 9;
            this.btnBerekenQuotient.Text = "Bereken quotient";
            this.btnBerekenQuotient.UseVisualStyleBackColor = true;
            this.btnBerekenQuotient.Click += new System.EventHandler(this.btnBerekenQuotient_Click);
            // 
            // lblSom1
            // 
            this.lblSom1.AutoSize = true;
            this.lblSom1.Location = new System.Drawing.Point(170, 73);
            this.lblSom1.Name = "lblSom1";
            this.lblSom1.Size = new System.Drawing.Size(56, 16);
            this.lblSom1.TabIndex = 10;
            this.lblSom1.Text = "lblSom1";
            // 
            // lblVerschil1
            // 
            this.lblVerschil1.AutoSize = true;
            this.lblVerschil1.Location = new System.Drawing.Point(170, 102);
            this.lblVerschil1.Name = "lblVerschil1";
            this.lblVerschil1.Size = new System.Drawing.Size(76, 16);
            this.lblVerschil1.TabIndex = 11;
            this.lblVerschil1.Text = "lblVerschil1";
            // 
            // lblProduct1
            // 
            this.lblProduct1.AutoSize = true;
            this.lblProduct1.Location = new System.Drawing.Point(170, 131);
            this.lblProduct1.Name = "lblProduct1";
            this.lblProduct1.Size = new System.Drawing.Size(74, 16);
            this.lblProduct1.TabIndex = 12;
            this.lblProduct1.Text = "lblProduct1";
            // 
            // lblQuotient1
            // 
            this.lblQuotient1.AutoSize = true;
            this.lblQuotient1.Location = new System.Drawing.Point(170, 160);
            this.lblQuotient1.Name = "lblQuotient1";
            this.lblQuotient1.Size = new System.Drawing.Size(77, 16);
            this.lblQuotient1.TabIndex = 13;
            this.lblQuotient1.Text = "lblQuotient1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 216);
            this.Controls.Add(this.lblQuotient1);
            this.Controls.Add(this.lblProduct1);
            this.Controls.Add(this.lblVerschil1);
            this.Controls.Add(this.lblSom1);
            this.Controls.Add(this.btnBerekenQuotient);
            this.Controls.Add(this.btnBerekenProduct);
            this.Controls.Add(this.btnBerekenVerschil);
            this.Controls.Add(this.btnBerekenSom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBerekenSom;
        private System.Windows.Forms.Button btnBerekenVerschil;
        private System.Windows.Forms.Button btnBerekenProduct;
        private System.Windows.Forms.Button btnBerekenQuotient;
        private System.Windows.Forms.Label lblSom1;
        private System.Windows.Forms.Label lblVerschil1;
        private System.Windows.Forms.Label lblProduct1;
        private System.Windows.Forms.Label lblQuotient1;
    }
}

