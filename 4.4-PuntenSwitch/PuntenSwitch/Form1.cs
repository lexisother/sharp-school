using System;
using System.Windows.Forms;

namespace PuntenSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // https://cdn.discordapp.com/emojis/849741528565678100.png
        private bool isInt(string value)
        {
            try
            {
                int.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnTestPunt_Click(object sender, EventArgs e)
        {
            var txt = txtPuntInvoer.Text;

            // Null/typechecks
            if (txt == null) return;
            if (!isInt(txt)) return;

            // I *would* do decimal parsing here, but it
            // isn't described in the exercise. ¯\_(ツ)_/¯
            var num = int.Parse(txt);
            if (num < 0 || num >= 11) MessageBox.Show("Voer een getal in tussen de 0 en de 10");

            // Checks {{{
            switch (num)
            {
                case int n when n >= 0 && n <= 5:
                    MessageBox.Show("Het punt is onvoldoende");
                    break;
                case 6:
                case 7:
                    MessageBox.Show("Het punt is ruim voldoende");
                    break;
                case 8:
                case 9:
                    MessageBox.Show("Het punt is zeer goed");
                    break;
                case 10:
                    MessageBox.Show("Perfect");
                    break;
            }
            // }}}
        }
    }
}