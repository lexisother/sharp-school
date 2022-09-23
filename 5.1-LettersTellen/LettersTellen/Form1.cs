using System;
using System.Linq;
using System.Windows.Forms;

namespace LettersTellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTelAantal_Click(object sender, EventArgs e)
        {
            var text = txtWoord.Text.ToCharArray();
            var spaties = text.Count(char.IsWhiteSpace);
            var klinkers = 0;
            var medeklinkers = 0;

            foreach (var c in text)
                switch (c)
                {
                    case 'a':
                        klinkers++;
                        break;
                    case 'e':
                        klinkers++;
                        break;
                    case 'i':
                        klinkers++;
                        break;
                    case 'o':
                        klinkers++;
                        break;
                    case 'u':
                        klinkers++;
                        break;
                    default:
                        medeklinkers++;
                        break;
                }

            lblAantalKlinkers.Text = klinkers.ToString();
            lblAantalMedeklinkers.Text = medeklinkers.ToString();
            lblAantalSpaties.Text = spaties.ToString();
        }
    }
}