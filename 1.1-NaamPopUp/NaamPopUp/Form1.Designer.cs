namespace NaamPopUp
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
            this.btnShowNaamPopUp = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtStraatNaam = new System.Windows.Forms.TextBox();
            this.btnShowStraatPopUp = new System.Windows.Forms.Button();
            this.btnShowBeide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowNaamPopUp
            // 
            this.btnShowNaamPopUp.Location = new System.Drawing.Point(231, 161);
            this.btnShowNaamPopUp.Name = "btnShowNaamPopUp";
            this.btnShowNaamPopUp.Size = new System.Drawing.Size(146, 23);
            this.btnShowNaamPopUp.TabIndex = 0;
            this.btnShowNaamPopUp.Text = "Show name popup";
            this.btnShowNaamPopUp.UseVisualStyleBackColor = true;
            this.btnShowNaamPopUp.Click += new System.EventHandler(this.btnShowNaamPopUp_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(12, 12);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(282, 22);
            this.txtNaam.TabIndex = 1;
            // 
            // txtStraatNaam
            // 
            this.txtStraatNaam.Location = new System.Drawing.Point(300, 12);
            this.txtStraatNaam.Name = "txtStraatNaam";
            this.txtStraatNaam.Size = new System.Drawing.Size(261, 22);
            this.txtStraatNaam.TabIndex = 2;
            // 
            // btnShowStraatPopUp
            // 
            this.btnShowStraatPopUp.Location = new System.Drawing.Point(231, 190);
            this.btnShowStraatPopUp.Name = "btnShowStraatPopUp";
            this.btnShowStraatPopUp.Size = new System.Drawing.Size(146, 23);
            this.btnShowStraatPopUp.TabIndex = 3;
            this.btnShowStraatPopUp.Text = "Show street popup";
            this.btnShowStraatPopUp.UseVisualStyleBackColor = true;
            this.btnShowStraatPopUp.Click += new System.EventHandler(this.btnShowStraatPopUp_Click);
            // 
            // btnShowBeide
            // 
            this.btnShowBeide.Location = new System.Drawing.Point(231, 219);
            this.btnShowBeide.Name = "btnShowBeide";
            this.btnShowBeide.Size = new System.Drawing.Size(146, 23);
            this.btnShowBeide.TabIndex = 4;
            this.btnShowBeide.Text = "Show both";
            this.btnShowBeide.UseVisualStyleBackColor = true;
            this.btnShowBeide.Click += new System.EventHandler(this.btnShowBeide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.btnShowBeide);
            this.Controls.Add(this.btnShowStraatPopUp);
            this.Controls.Add(this.txtStraatNaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnShowNaamPopUp);
            this.Name = "Form1";
            this.Text = "Show popup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowNaamPopUp;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtStraatNaam;
        private System.Windows.Forms.Button btnShowStraatPopUp;
        private System.Windows.Forms.Button btnShowBeide;
    }
}

