using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedalRanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int numGold = int.Parse(numGoldUSA.Value.ToString());
            PictureBox pbGoldUSA = new PictureBox();
            pbGoldUSA.Size = new Size(20, 20);
            pbGoldUSA.BackgroundImage = Properties.Resources.gold;
            pbGoldUSA.BackgroundImageLayout = ImageLayout.Stretch;
            int x = 80; // for x coordinate
            for (int i = 0; i < numGold; i++)
            {
                pbGoldUSA.Location = new Point(x + 20, 20);
                panelUSAgold.Controls.Add(pbGoldUSA);
                x += 20;
            }
        }

        private void numGoldUSA_ValueChanged(object sender, EventArgs e)
        {
            int numGold = int.Parse(numGoldUSA.Value.ToString());
            PictureBox pbGoldUSA = new PictureBox();
            pbGoldUSA.Size = new Size(20, 20);
            pbGoldUSA.BackgroundImage = Properties.Resources.gold;
            pbGoldUSA.BackgroundImageLayout = ImageLayout.Stretch;
            int x = 80; // for x coordinate
            for (int i = 0; i < numGold; i++)
            {
                pbGoldUSA.Location = new Point(x + 20, 20);
                panelUSAgold.Controls.Add(pbGoldUSA);
                x += 20;
            }
        }
    }
}
