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
        int numToCheck = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numGoldUSA_ValueChanged(object sender, EventArgs e)
        {
            int numGold = int.Parse(numGoldUSA.Value.ToString());
            PictureBox[] pbGoldUSA = new PictureBox[50];
            int x = 80; // for x coordinate

            for (int i = 0; i < numGold; i++)
            {
                pbGoldUSA[i] = new PictureBox();
                pbGoldUSA[i].Size = new Size(20, 20);
                pbGoldUSA[i].BackgroundImage = Properties.Resources.gold;
                pbGoldUSA[i].BackgroundImageLayout = ImageLayout.Stretch;

                if (numGold > 25)
                {
                    pbGoldUSA[i].Location = new Point(x - 480, 40);
                    panelUSAgold.Controls.Add(pbGoldUSA[i]);
                    x += 20;
                    textBox1.Text = $"{numGold}:{numToCheck}:{i}:{pbGoldUSA.Length}";
                }
                else
                {
                    pbGoldUSA[i].Location = new Point(x + 20, 20);
                    panelUSAgold.Controls.Add(pbGoldUSA[i]);
                    x += 20;
                    textBox1.Text = $"{numGold}:{numToCheck}:{i}:{pbGoldUSA.Length}";
                }
            }
                /*PictureBox pbGoldUSA = new PictureBox();
                pbGoldUSA.Size = new Size(20, 20);
                pbGoldUSA.BackgroundImage = Properties.Resources.gold;
                pbGoldUSA.BackgroundImageLayout = ImageLayout.Stretch;
                int x = 80; // for x coordinate

                for (int i = 0; i < numGold; i++)
                {
                    if (numGold > 25)
                    {
                        pbGoldUSA.Location = new Point(x - 480, 40);
                        panelUSAgold.Controls.Add(pbGoldUSA);
                        x += 20;
                        textBox1.Text = $"{numGold}:{numToCheck}:{i}";

                    }
                    else
                    {
                        pbGoldUSA.Location = new Point(x + 20, 20);
                        panelUSAgold.Controls.Add(pbGoldUSA);
                        x += 20;
                        textBox1.Text = $"{numGold}:{numToCheck}:{i}";
                    }
                }*/
            }

        private void numGoldRUS_ValueChanged(object sender, EventArgs e)
        {
            int numGold = int.Parse(numGoldRUS.Value.ToString());
            PictureBox pbGoldRUS = new PictureBox();
            pbGoldRUS.Size = new Size(20, 20);
            pbGoldRUS.BackgroundImage = Properties.Resources.gold;
            pbGoldRUS.BackgroundImageLayout = ImageLayout.Stretch;
            int x = 80; // for x coordinate

            for (int i = 0; i < numGold; i++)
            {
                if (numGold > 25)
                {
                    pbGoldRUS.Location = new Point(x - 480, 40);
                    panelRUSgold.Controls.Add(pbGoldRUS);
                    x += 20;
                }
                else
                {
                    pbGoldRUS.Location = new Point(x + 20, 20);
                    panelRUSgold.Controls.Add(pbGoldRUS);
                    x += 20;
                }
            }
        }
    }
}
