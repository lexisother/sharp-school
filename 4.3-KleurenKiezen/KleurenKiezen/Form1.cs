using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KleurenKiezen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Loop over all radio buttons and return the one that is checked.
        /// </summary>
        /// <returns>
        ///     <see cref="RadioButton" />
        /// </returns>
        private RadioButton getSelected()
        {
            RadioButton res = null;
            foreach (var rb in Controls.OfType<RadioButton>())
                if (rb.Checked)
                    res = rb;
            return res;
        }

        /// <summary>
        ///     Get a <see cref="Color">Color</see> of the input string.
        /// </summary>
        /// <param name="input">String to get Color of</param>
        /// <returns>
        ///     <see cref="Color" />
        /// </returns>
        private Color getColor(string input)
        {
            var col = Color.White;
            switch (input)
            {
                case "Rood":
                    col = Color.Red;
                    break;
                case "Blauw":
                    col = Color.Blue;
                    break;
                case "Geel":
                    col = Color.Yellow;
                    break;
                case "Groen":
                    col = Color.Green;
                    break;
                case "Oranje":
                    col = Color.Orange;
                    break;
            }

            return col;
        }

        private void btnSetColorPanel_Click(object sender, EventArgs e)
        {
            var rb = getSelected();
            var col = getColor(rb.Text);
            pnlCheckedColor.BackColor = col;
        }

        private void btnSetColorBackground_Click(object sender, EventArgs e)
        {
            var rb = getSelected();
            var col = getColor(rb.Text);
            BackColor = col;
        }
    }
}