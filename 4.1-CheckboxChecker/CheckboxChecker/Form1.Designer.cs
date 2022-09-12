namespace CheckboxChecker
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
            this.chkShowMessagebox = new System.Windows.Forms.CheckBox();
            this.chkToonInLabel = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnToonTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // chkShowMessagebox
            //
            this.chkShowMessagebox.AutoSize = true;
            this.chkShowMessagebox.Location = new System.Drawing.Point(83, 96);
            this.chkShowMessagebox.Name = "chkShowMessagebox";
            this.chkShowMessagebox.Size = new System.Drawing.Size(156, 20);
            this.chkShowMessagebox.TabIndex = 0;
            this.chkShowMessagebox.Text = "Toon in messagebox";
            this.chkShowMessagebox.UseVisualStyleBackColor = true;
            //
            // chkToonInLabel
            //
            this.chkToonInLabel.AutoSize = true;
            this.chkToonInLabel.Location = new System.Drawing.Point(83, 122);
            this.chkToonInLabel.Name = "chkToonInLabel";
            this.chkToonInLabel.Size = new System.Drawing.Size(107, 20);
            this.chkToonInLabel.TabIndex = 1;
            this.chkToonInLabel.Text = "Toon in label";
            this.chkToonInLabel.UseVisualStyleBackColor = true;
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(83, 160);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            //
            // txtText
            //
            this.txtText.Location = new System.Drawing.Point(83, 46);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 22);
            this.txtText.TabIndex = 3;
            //
            // btnToonTekst
            //
            this.btnToonTekst.Location = new System.Drawing.Point(83, 197);
            this.btnToonTekst.Name = "btnToonTekst";
            this.btnToonTekst.Size = new System.Drawing.Size(75, 23);
            this.btnToonTekst.TabIndex = 4;
            this.btnToonTekst.Text = "Toon tekst";
            this.btnToonTekst.UseVisualStyleBackColor = true;
            this.btnToonTekst.Click += new System.EventHandler(this.btnToonTekst_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 263);
            this.Controls.Add(this.btnToonTekst);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.chkToonInLabel);
            this.Controls.Add(this.chkShowMessagebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowMessagebox;
        private System.Windows.Forms.CheckBox chkToonInLabel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnToonTekst;
    }
}