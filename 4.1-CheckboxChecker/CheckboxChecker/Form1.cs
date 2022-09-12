using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToonTekst_Click(object sender, EventArgs e)
        {
            string txt = txtText.Text;
            bool msgBox = chkShowMessagebox.Checked;
            bool label = chkToonInLabel.Checked;

            if (label) lblMessage.Text = txt;
            if (msgBox) MessageBox.Show(txt);
            if (!msgBox && !label) MessageBox.Show("Kies een van de twee mogelijkheden!");
        }
    }
}