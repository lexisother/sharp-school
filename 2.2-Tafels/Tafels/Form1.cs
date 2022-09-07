using System;
using System.Windows.Forms;

namespace Tafels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isDecimal(string value)
        {
            try
            {
                decimal.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnToonTafel_Click(object sender, EventArgs e)
        {
            if (txtGetal.Text == null)
                return;
            if (!isDecimal(txtGetal.Text))
                return;

            txtTafel.Text = "";

            var num = decimal.Parse(txtGetal.Text);
            for (var i = 1; i < 11; i++) txtTafel.AppendText($"{i} * {num} = {i * num}" + Environment.NewLine);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGetal.Text = "";
            txtTafel.Text = "";
        }
    }
}