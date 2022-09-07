using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NaamPopUpKleuren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPopUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"De volgende text is ingevoerd in txtNaam: {txtNaam.Text}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void benPaintButtons_Click(object sender, EventArgs e)
        {
            // We love type generics.
            foreach (var button in Controls.OfType<Button>()) button.BackColor = Color.Red;
        }

        private void btnPaintBackground_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNaam.Text = "";
            foreach (var button in Controls.OfType<Button>()) button.BackColor = SystemColors.ControlLight;
            BackColor = SystemColors.Control;
        }
    }
}