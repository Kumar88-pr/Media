using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Explore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top;
            bunifuPages1.SetPage(0);
        }

     

      
        private void btnPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top+10;
            bunifuPages1.SetPage(0);
        }

    }
}
