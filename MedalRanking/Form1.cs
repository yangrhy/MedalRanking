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
        decimal prevValue = 0;
        List<PictureBox> picMedals = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void numGoldUSA_ValueChanged(object sender, EventArgs e)
        {

            int numGold = int.Parse(numGoldUSA.Value.ToString());
            int x = 80; // for x coordinate
            PictureBox pbGoldUSA = new PictureBox();

            if (numGoldUSA.Value > prevValue)
            {
                for (int i = 0; i < numGold; i++)
                {         
                    if (numGold <= 25)
                    {
                        picMedals.Add(pbGoldUSA); // add the pictureBox to the list
                        picMedals[i].Size = new Size(20, 20);
                        picMedals[i].BackgroundImage = Properties.Resources.gold;
                        picMedals[i].BackgroundImageLayout = ImageLayout.Stretch;
                        picMedals[i].Location = new Point(x + 20, 20);
                        panelUSAgold.Controls.Add(picMedals[i]);
                        x += 20;
                        textBox1.Text = $"{numGold}:{numGoldUSA.Value}:{prevValue}:{x}";
                    }
                    else
                    {
                        picMedals.Add(pbGoldUSA); // add the pictureBox to the list
                        picMedals[i].Size = new Size(20, 20);
                        picMedals[i].BackgroundImage = Properties.Resources.gold;
                        picMedals[i].BackgroundImageLayout = ImageLayout.Stretch;
                        picMedals[i].Location = new Point(x - 480, 40);
                        panelUSAgold.Controls.Add(picMedals[i]);
                        x += 20;
                        textBox1.Text = $"{numGold}:{numGoldUSA.Value}:{prevValue}:{x}";
                    }
                }
            }
            else if (numGoldUSA.Value < prevValue)
            {
                for (int i = numGold; i > numGold; i--)
                {
                    picMedals.RemoveAt(numGold);
                    panelUSAgold.Controls.Remove(picMedals[numGold]);
                    x -= 20;
                    textBox1.Text = $"{numGold}:{numGoldUSA.Value}:{prevValue}:{x}";
                }

            }

            prevValue = numGoldUSA.Value;
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

        private void numSilverUSA_ValueChanged(object sender, EventArgs e)
        {

            if (numSilverUSA.Value < prevValue)
            {
                MessageBox.Show("Down");
            }
            else if (numSilverUSA.Value > prevValue)
            {
                MessageBox.Show("Up");
            }

            prevValue = numSilverUSA.Value;
        }

        private void numBronzeUSA_ValueChanged(object sender, EventArgs e)
        {
            var num = ((NumericUpDown)sender).Value;
            int numGold = int.Parse(numBronzeUSA.Value.ToString());

            PictureBox pbBronzeUSA = new PictureBox();
            pbBronzeUSA.Size = new Size(20, 20);
            pbBronzeUSA.BackgroundImage = Properties.Resources.bronze;
            pbBronzeUSA.BackgroundImageLayout = ImageLayout.Stretch;
            int x = 80; // for x coordinate

            for (int i = 0; i < numGold; i++)
            {
                if (numGold > 25)
                {
                    pbBronzeUSA.Location = new Point(x - 480, 40);
                    panelUSAbronze.Controls.Add(pbBronzeUSA);
                    x += 20;
                    textBox1.Text = $"{numGold}:{i}";

                }
                else
                {
                    pbBronzeUSA.Location = new Point(x + 20, 20);
                    panelUSAbronze.Controls.Add(pbBronzeUSA);
                    x += 20;
                    textBox1.Text = $"{numGold}:{i}";
                }
            }
        }
    }


}
