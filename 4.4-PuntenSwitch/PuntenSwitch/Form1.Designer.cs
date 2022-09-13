namespace PuntenSwitch
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
            this.txtPuntInvoer = new System.Windows.Forms.TextBox();
            this.btnTestPunt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtPuntInvoer
            //
            this.txtPuntInvoer.Location = new System.Drawing.Point(77, 35);
            this.txtPuntInvoer.Name = "txtPuntInvoer";
            this.txtPuntInvoer.Size = new System.Drawing.Size(100, 22);
            this.txtPuntInvoer.TabIndex = 0;
            //
            // btnTestPunt
            //
            this.btnTestPunt.Location = new System.Drawing.Point(77, 74);
            this.btnTestPunt.Name = "btnTestPunt";
            this.btnTestPunt.Size = new System.Drawing.Size(100, 23);
            this.btnTestPunt.TabIndex = 1;
            this.btnTestPunt.Text = "Test het punt";
            this.btnTestPunt.UseVisualStyleBackColor = true;
            this.btnTestPunt.Click += new System.EventHandler(this.btnTestPunt_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 124);
            this.Controls.Add(this.btnTestPunt);
            this.Controls.Add(this.txtPuntInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPuntInvoer;
        private System.Windows.Forms.Button btnTestPunt;
    }
}
