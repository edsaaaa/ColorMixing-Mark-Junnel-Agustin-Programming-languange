using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorColorAgustin
{
    public partial class ColorGame : Form
    {
        public ColorGame()
        {
            InitializeComponent();
        }
        private void tbfirstcolor_TextChanged(object sender, EventArgs e)
        {
            MergedColor();
        }
        private void tbsecondcolor_TextChanged(object sender, EventArgs e)
        {
            MergedColor();
        }
        private void MergedColor() {
            if (!string.IsNullOrWhiteSpace(tbfirstcolor.Text) && !string.IsNullOrWhiteSpace(tbsecondcolor.Text))
            {
                try
                {
                    Color firstcolor = Color.FromName(tbfirstcolor.Text);
                    Color secondcolor = Color.FromName(tbsecondcolor.Text);
                    Color mergecolor = Color.FromArgb
                        ((firstcolor.R + secondcolor.R) / 2, (firstcolor.G + secondcolor.G) / 2, (firstcolor.B + secondcolor.B) / 2);
                    labelshowMergedColor.BackColor = mergecolor;
                    labelshowMergedColor.Text = $"{mergecolor.Name}";
                }
                catch
                {
                    labelshowMergedColor.Text = "EME! wrong input.";
                }

            }
            else
            {
                labelshowMergedColor.Text = "";
            }

            
        }

        private void btnshowMixedColor_Click(object sender, EventArgs e)
        {
            //sinubukan kolang wag nalang po pansinin hehe
        }

        private void labelshowMergedColor_Click(object sender, EventArgs e)
        {
            //sinubukan kolang wag nalang po pansinin hehe (2)
        }

        private void tbshowmixedcolor_TextChanged(object sender, EventArgs e)
        {
            //sinubukan kolang wag nalang po pansinin hehe (3)
        }
        private void DisplayCombinationColors()
        {
        }

        private void btnshowlist_Click(object sender, EventArgs e)
        {
            DisplayCombinationColors();
        }
    }
}
