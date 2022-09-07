using System;
using System.Windows.Forms;

namespace NaamPopUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowNaamPopUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"De volgende text is ingevoerd in txtNaam: {txtNaam.Text}");
        }

        private void btnShowStraatPopUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"De volgende text is ingevoerd in txtStraatNaam: {txtStraatNaam.Text}");
        }

        private void btnShowBeide_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"De volgende text is ingevoerd in txtNaam: {txtNaam.Text}");
            MessageBox.Show($"De volgende text is ingevoerd in txtStraatNaam: {txtStraatNaam.Text}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}