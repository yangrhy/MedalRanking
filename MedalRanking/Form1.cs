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
        // value used to determine if numericUpDown buttons are pressed up or down
        decimal prevValueGoldUSA = 0;
        decimal prevValueSilverUSA = 0;
        decimal prevValueBronzeUSA = 0;
        decimal prevValueGoldRUS = 0;
        decimal prevValueSilverRUS = 0;
        decimal prevValueBronzeRUS = 0;

        // Lists of PictureBox for each medal/country that pictures will be stored in
        private List<PictureBox> picGoldMedalsUSA = new List<PictureBox>();
        private List<PictureBox> picSilverMedalsUSA = new List<PictureBox>();
        private List<PictureBox> picBronzeMedalsUSA = new List<PictureBox>();
        private List<PictureBox> picGoldMedalsRUS = new List<PictureBox>();
        private List<PictureBox> picSilverMedalsRUS = new List<PictureBox>();
        private List<PictureBox> picBronzeMedalsRUS = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void numGoldUSA_ValueChanged(object sender, EventArgs e)
        {
            // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
            // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
            var numMedals = numGoldUSA.Value;
            int x = 80; // for x coordinate
            int y = 20; // y coordinate
            PictureBox pb1 = new PictureBox();
            pb1.Size = new Size(20, 20);
            pb1.BackgroundImage = Properties.Resources.gold;
            pb1.BackgroundImageLayout = ImageLayout.Stretch;


            if (numGoldUSA.Value > prevValueGoldUSA) // if numericUpDown is pressed up
            {
                picGoldMedalsUSA.Add(pb1);

                for (int i = 0; i < numMedals; i++)
                {
                    if (i < 25) // used to determine when to start printing on the next row
                    {
                        picGoldMedalsUSA[i].Location = new Point(x + 20, y);
                        panelUSAgold.Controls.Add(picGoldMedalsUSA[i]);
                        x += 20;
                    }
                    else
                    {
                        picGoldMedalsUSA[i].Location = new Point(x - 480, y + 20);
                        panelUSAgold.Controls.Add(picGoldMedalsUSA[i]);
                        x += 20;
                    }
                }
            }
            else if (numGoldUSA.Value < prevValueGoldUSA) // if numericUpDown is pressed down
            {
                panelUSAgold.Controls.Remove(picGoldMedalsUSA[picGoldMedalsUSA.Count - 1]);
                picGoldMedalsUSA.RemoveAt(picGoldMedalsUSA.Count - 1);
            }

            prevValueGoldUSA = numGoldUSA.Value;
        }
     
        private void numSilverUSA_ValueChanged(object sender, EventArgs e)
        {
            // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
            // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
            var numMedals = numSilverUSA.Value;
            int x = 80; // for x coordinate
            int y = 20; // y coordinate
            PictureBox pb1 = new PictureBox();
            pb1.Size = new Size(20, 20);
            pb1.BackgroundImage = Properties.Resources.silver;
            pb1.BackgroundImageLayout = ImageLayout.Stretch;


            if (numSilverUSA.Value > prevValueSilverUSA) // if numericUpDown is pressed up
            {
                picSilverMedalsUSA.Add(pb1);

                for (int i = 0; i < numMedals; i++)
                {
                    if (i < 25) // used to determine when to start printing on the next row
                    {
                        picSilverMedalsUSA[i].Location = new Point(x + 20, y);
                        panelUSAsilver.Controls.Add(picSilverMedalsUSA[i]);
                        x += 20;
                    }
                    else
                    {
                        picSilverMedalsUSA[i].Location = new Point(x - 480, y + 20);
                        panelUSAsilver.Controls.Add(picSilverMedalsUSA[i]);
                        x += 20;
                    }
                }
            }
            else if (numSilverUSA.Value < prevValueSilverUSA) // if numericUpDown is pressed down
            {
                panelUSAsilver.Controls.Remove(picSilverMedalsUSA[picSilverMedalsUSA.Count - 1]);
                picSilverMedalsUSA.RemoveAt(picSilverMedalsUSA.Count - 1);
            }

            prevValueSilverUSA = numSilverUSA.Value;
        }

        private void numBronzeUSA_ValueChanged(object sender, EventArgs e)
            {
                // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
                // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
                var numMedals = numBronzeUSA.Value;
                int x = 80; // for x coordinate
                int y = 20; // y coordinate
                PictureBox pb1 = new PictureBox();
                pb1.Size = new Size(20, 20);
                pb1.BackgroundImage = Properties.Resources.bronze;
                pb1.BackgroundImageLayout = ImageLayout.Stretch;


                if (numBronzeUSA.Value > prevValueBronzeUSA) // if numericUpDown is pressed up
                {
                    picBronzeMedalsUSA.Add(pb1);

                    for (int i = 0; i < numMedals; i++)
                    {
                        if (i < 25) // used to determine when to start printing on the next row
                        {
                            picBronzeMedalsUSA[i].Location = new Point(x + 20, y);
                            panelUSAbronze.Controls.Add(picBronzeMedalsUSA[i]);
                            x += 20;
                        }
                        else
                        {
                            picBronzeMedalsUSA[i].Location = new Point(x - 480, y + 20);
                            panelUSAbronze.Controls.Add(picBronzeMedalsUSA[i]);
                            x += 20;
                        }
                    }
                }
                else if (numBronzeUSA.Value < prevValueBronzeUSA) // if numericUpDown is pressed down
                {
                    panelUSAbronze.Controls.Remove(picBronzeMedalsUSA[picBronzeMedalsUSA.Count - 1]);
                    picBronzeMedalsUSA.RemoveAt(picBronzeMedalsUSA.Count - 1);
                }

                 prevValueBronzeUSA = numBronzeUSA.Value;
        }

        private void numGoldRUS_ValueChanged(object sender, EventArgs e)
        {
            // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
            // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
            var numMedals = numGoldRUS.Value;
            int x = 80; // for x coordinate
            int y = 20; // y coordinate
            PictureBox pb1 = new PictureBox();
            pb1.Size = new Size(20, 20);
            pb1.BackgroundImage = Properties.Resources.gold;
            pb1.BackgroundImageLayout = ImageLayout.Stretch;


            if (numGoldRUS.Value > prevValueGoldRUS) // if numericUpDown is pressed up
            {
                picGoldMedalsRUS.Add(pb1);

                for (int i = 0; i < numMedals; i++)
                {
                    if (i < 25) // used to determine when to start printing on the next row
                    {
                        picGoldMedalsRUS[i].Location = new Point(x + 20, y);
                        panelRUSgold.Controls.Add(picGoldMedalsRUS[i]);
                        x += 20;
                    }
                    else
                    {
                        picGoldMedalsRUS[i].Location = new Point(x - 480, y + 20);
                        panelRUSgold.Controls.Add(picGoldMedalsRUS[i]);
                        x += 20;
                    }
                }
            }
            else if (numGoldRUS.Value < prevValueGoldRUS) // if numericUpDown is pressed down
            {
                panelRUSgold.Controls.Remove(picGoldMedalsRUS[picGoldMedalsRUS.Count - 1]);
                picGoldMedalsRUS.RemoveAt(picGoldMedalsRUS.Count - 1);
            }

            prevValueGoldRUS = numGoldRUS.Value;
        }

        private void numSilverRUS_ValueChanged(object sender, EventArgs e)
        {
            // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
            // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
            var numMedals = numSilverRUS.Value;
            int x = 80; // for x coordinate
            int y = 20; // y coordinate
            PictureBox pb1 = new PictureBox();
            pb1.Size = new Size(20, 20);
            pb1.BackgroundImage = Properties.Resources.silver;
            pb1.BackgroundImageLayout = ImageLayout.Stretch;


            if (numSilverRUS.Value > prevValueSilverRUS) // if numericUpDown is pressed up
            {
                picSilverMedalsRUS.Add(pb1);

                for (int i = 0; i < numMedals; i++)
                {
                    if (i < 25) // used to determine when to start printing on the next row
                    {
                        picSilverMedalsRUS[i].Location = new Point(x + 20, y);
                        panelRUSsilver.Controls.Add(picSilverMedalsRUS[i]);
                        x += 20;
                    }
                    else
                    {
                        picSilverMedalsRUS[i].Location = new Point(x - 480, y + 20);
                        panelRUSsilver.Controls.Add(picSilverMedalsRUS[i]);
                        x += 20;
                    }
                }
            }
            else if (numSilverRUS.Value < prevValueSilverRUS) // if numericUpDown is pressed down
            {
                panelRUSsilver.Controls.Remove(picSilverMedalsRUS[picSilverMedalsRUS.Count - 1]);
                picSilverMedalsRUS.RemoveAt(picSilverMedalsRUS.Count - 1);
            }

            prevValueSilverRUS = numSilverRUS.Value;
        }

        private void numBronzeRUS_ValueChanged(object sender, EventArgs e)
        {
            // adds pictures of medals (up to 50 (maximum allowed)) as changes (up, down) on numericUpDown button is pressed
            // by inserting the images into a list<{PictureBox>, allowing deletion of most previous set image if pressed do
            var numMedals = numBronzeRUS.Value;
            int x = 80; // for x coordinate
            int y = 20; // y coordinate
            PictureBox pb1 = new PictureBox();
            pb1.Size = new Size(20, 20);
            pb1.BackgroundImage = Properties.Resources.bronze;
            pb1.BackgroundImageLayout = ImageLayout.Stretch;


            if (numBronzeRUS.Value > prevValueBronzeRUS) // if numericUpDown is pressed up
            {
                picBronzeMedalsRUS.Add(pb1);

                for (int i = 0; i < numMedals; i++)
                {
                    if (i < 25) // used to determine when to start printing on the next row
                    {
                        picBronzeMedalsRUS[i].Location = new Point(x + 20, y);
                        panelRUSbronze.Controls.Add(picBronzeMedalsRUS[i]);
                        x += 20;
                    }
                    else
                    {
                        picBronzeMedalsRUS[i].Location = new Point(x - 480, y + 20);
                        panelRUSbronze.Controls.Add(picBronzeMedalsRUS[i]);
                        x += 20;
                    }
                }
            }
            else if (numBronzeRUS.Value < prevValueBronzeRUS) // if numericUpDown is pressed down
            {
                panelRUSbronze.Controls.Remove(picBronzeMedalsRUS[picBronzeMedalsRUS.Count - 1]);
                picBronzeMedalsRUS.RemoveAt(picBronzeMedalsRUS.Count - 1);
            }

            prevValueBronzeRUS = numBronzeRUS.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numMedalsUSA = numGoldUSA.Value + numSilverUSA.Value + numBronzeUSA.Value;
            var numMedalsRUS = numGoldRUS.Value + numSilverRUS.Value + numBronzeRUS.Value;

            if (numMedalsUSA > numMedalsRUS)
            {
                textBox1.Text += "USA wins by count!";
            }
            if (numGoldUSA.Value > numGoldRUS.Value)
            {
                textBox1.Text += "USA wins by color!";
            }
            else if ((numGoldUSA.Value == numGoldRUS.Value) && (numSilverUSA.Value > numSilverRUS.Value))
            {
                textBox1.Text += "USA wins by color!";
            }
            else if ((numGoldUSA.Value == numGoldRUS.Value) && (numSilverUSA.Value == numSilverRUS.Value) && (numBronzeUSA.Value > numBronzeRUS.Value))
            {
                textBox1.Text += "USA wins by color!";
            }           
            else
            {
                textBox1.Text = "None!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
