using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            decimal num = decimal.Parse(txtGetal.Text);
            for (int i = 1; i < 11; i++)
            {
                txtTafel.AppendText($"{i} * {num} = {i * num}" + System.Environment.NewLine);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGetal.Text = "";
            txtTafel.Text = "";
        }
    }
}
