using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnShowStraatPopUp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"De volgende text is ingevoerd in txtStraatNaam: {txtStraatNaam.Text}");
        }

        private void btnShowBeide_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"De volgende text is ingevoerd in txtNaam: {txtNaam.Text}");
            //MessageBox.Show($"De volgende text is ingevoerd in txtStraatNaam: {txtStraatNaam.Text}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void benPaintButtons_Click(object sender, EventArgs e)
        {
            // We love type generics.
            foreach(var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Red;
            }
        }

        private void btnPaintBackground_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNaam.Text = "";
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = SystemColors.ControlLight;
            }
            this.BackColor = SystemColors.Control;
        }
    }
}