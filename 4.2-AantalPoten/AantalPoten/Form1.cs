using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantalPoten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowLegs_Click(object sender, EventArgs e)
        {
            string selection = cboAnimals.Text;
            switch (selection)
            {
                case "Vogel":
                    {
                        MessageBox.Show("Dit dier heeft 2 poten.");
                        break;
                    }
                case "Kat":
                    {
                        MessageBox.Show("Dit dier heeft 4 poten.");
                        break;
                    }
                case "Hond":
                    {
                        MessageBox.Show("Dit dier heeft 4 poten.");
                        break;
                    }
                // oser,,,,,h,h,,fgh,,fgh,fgh :\pleading_face:
                case "Slang":
                    {
                        MessageBox.Show("Dit dier heeft geen poten.");
                        break;
                    }
                case "Duizendpoot":
                    {
                        MessageBox.Show("Dit dier heeft 1000 poten.");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Kies een dier.");
                        break;
                    }
            }
        }
    }
}