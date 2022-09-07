using System;
using System.Windows.Forms;

namespace Rekenen
{
    // Utility class for autocompletion.
    public class Values
    {
        public int g1;
        public int g2;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Utility function for fetching the values in both text fields.
        /// </summary>
        private Values getValues()
        {
            var g1 = int.Parse(txtGetal1.Text);
            var g2 = int.Parse(txtGetal2.Text);
            return new Values { g1 = g1, g2 = g2 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnBerekenSom_Click(object sender, EventArgs e)
        {
            var vals = getValues();

            var res = vals.g1 + vals.g2;

            lblSom1.Text = res.ToString();
        }

        private void btnBerekenVerschil_Click(object sender, EventArgs e)
        {
            var vals = getValues();

            var res = vals.g1 - vals.g2;

            lblVerschil1.Text = res.ToString();
        }

        private void btnBerekenProduct_Click(object sender, EventArgs e)
        {
            var vals = getValues();

            var res = vals.g1 * vals.g2;

            lblProduct1.Text = res.ToString();
        }

        private void btnBerekenQuotient_Click(object sender, EventArgs e)
        {
            var vals = getValues();

            // Here we have to force non-integer divisionby explicitly casting
            // one of the arguments to a floating-point type.
            // This is because integer division removes the decimals.
            var res = (double)vals.g1 / vals.g2;

            lblQuotient1.Text = res.ToString();
        }
    }
}