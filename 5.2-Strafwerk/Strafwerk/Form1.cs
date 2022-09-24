using System;
using System.Windows.Forms;

namespace Strafwerk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaakStrafwerk_Click(object sender, EventArgs e)
        {
            // Clear the current text, we don't want to append to the existing text.
            txtResultaat.Clear();

            // Fetch the required values.
            var sentence = txtStrafzin.Text;
            var amount = nudAantalRegels.Value;

            for (var i = 0; i < amount; i++)
                // Append our sentence to the result box.
                txtResultaat.AppendText(sentence + Environment.NewLine);
        }
    }
}