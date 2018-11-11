namespace MedalRanking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelUSAbronze = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numBronzeUSA = new System.Windows.Forms.NumericUpDown();
            this.panelUSAsilver = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numSilverUSA = new System.Windows.Forms.NumericUpDown();
            this.panelUSAgold = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGoldUSA = new System.Windows.Forms.NumericUpDown();
            this.panelRUSbronze = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numBronzeRUS = new System.Windows.Forms.NumericUpDown();
            this.panelRUSsilver = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numSilverRUS = new System.Windows.Forms.NumericUpDown();
            this.panelRUSgold = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numGoldRUS = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelUSAbronze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBronzeUSA)).BeginInit();
            this.panelUSAsilver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSilverUSA)).BeginInit();
            this.panelUSAgold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoldUSA)).BeginInit();
            this.panelRUSbronze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBronzeRUS)).BeginInit();
            this.panelRUSsilver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSilverRUS)).BeginInit();
            this.panelRUSgold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoldRUS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-3, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::MedalRanking.Properties.Resources.OlympicLogo;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.panelUSAbronze);
            this.splitContainer1.Panel1.Controls.Add(this.panelUSAsilver);
            this.splitContainer1.Panel1.Controls.Add(this.panelUSAgold);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::MedalRanking.Properties.Resources.russia;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.panelRUSbronze);
            this.splitContainer1.Panel2.Controls.Add(this.panelRUSsilver);
            this.splitContainer1.Panel2.Controls.Add(this.panelRUSgold);
            this.splitContainer1.Size = new System.Drawing.Size(605, 450);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelUSAbronze
            // 
            this.panelUSAbronze.BackColor = System.Drawing.Color.Transparent;
            this.panelUSAbronze.Controls.Add(this.label6);
            this.panelUSAbronze.Controls.Add(this.numBronzeUSA);
            this.panelUSAbronze.Location = new System.Drawing.Point(3, 163);
            this.panelUSAbronze.Name = "panelUSAbronze";
            this.panelUSAbronze.Size = new System.Drawing.Size(602, 69);
            this.panelUSAbronze.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(20, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bronze Medals";
            // 
            // numBronzeUSA
            // 
            this.numBronzeUSA.Location = new System.Drawing.Point(23, 17);
            this.numBronzeUSA.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBronzeUSA.Name = "numBronzeUSA";
            this.numBronzeUSA.Size = new System.Drawing.Size(68, 20);
            this.numBronzeUSA.TabIndex = 0;
            this.numBronzeUSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBronzeUSA.ValueChanged += new System.EventHandler(this.numBronzeUSA_ValueChanged);
            // 
            // panelUSAsilver
            // 
            this.panelUSAsilver.BackColor = System.Drawing.Color.Transparent;
            this.panelUSAsilver.Controls.Add(this.label4);
            this.panelUSAsilver.Controls.Add(this.numSilverUSA);
            this.panelUSAsilver.Location = new System.Drawing.Point(0, 80);
            this.panelUSAsilver.Name = "panelUSAsilver";
            this.panelUSAsilver.Size = new System.Drawing.Size(602, 69);
            this.panelUSAsilver.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Silver Medals";
            // 
            // numSilverUSA
            // 
            this.numSilverUSA.Location = new System.Drawing.Point(23, 17);
            this.numSilverUSA.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSilverUSA.Name = "numSilverUSA";
            this.numSilverUSA.Size = new System.Drawing.Size(68, 20);
            this.numSilverUSA.TabIndex = 0;
            this.numSilverUSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSilverUSA.ValueChanged += new System.EventHandler(this.numSilverUSA_ValueChanged);
            // 
            // panelUSAgold
            // 
            this.panelUSAgold.BackColor = System.Drawing.Color.Transparent;
            this.panelUSAgold.Controls.Add(this.label9);
            this.panelUSAgold.Controls.Add(this.label2);
            this.panelUSAgold.Controls.Add(this.numGoldUSA);
            this.panelUSAgold.Location = new System.Drawing.Point(3, 3);
            this.panelUSAgold.Name = "panelUSAgold";
            this.panelUSAgold.Size = new System.Drawing.Size(602, 73);
            this.panelUSAgold.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(34, 1);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "USA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold Medals";
            // 
            // numGoldUSA
            // 
            this.numGoldUSA.Location = new System.Drawing.Point(23, 23);
            this.numGoldUSA.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGoldUSA.Name = "numGoldUSA";
            this.numGoldUSA.Size = new System.Drawing.Size(68, 20);
            this.numGoldUSA.TabIndex = 0;
            this.numGoldUSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGoldUSA.ValueChanged += new System.EventHandler(this.numGoldUSA_ValueChanged);
            // 
            // panelRUSbronze
            // 
            this.panelRUSbronze.BackColor = System.Drawing.Color.Transparent;
            this.panelRUSbronze.Controls.Add(this.label8);
            this.panelRUSbronze.Controls.Add(this.numBronzeRUS);
            this.panelRUSbronze.Location = new System.Drawing.Point(3, 145);
            this.panelRUSbronze.Name = "panelRUSbronze";
            this.panelRUSbronze.Size = new System.Drawing.Size(602, 65);
            this.panelRUSbronze.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(20, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bronze Medals";
            // 
            // numBronzeRUS
            // 
            this.numBronzeRUS.Location = new System.Drawing.Point(23, 17);
            this.numBronzeRUS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBronzeRUS.Name = "numBronzeRUS";
            this.numBronzeRUS.Size = new System.Drawing.Size(68, 20);
            this.numBronzeRUS.TabIndex = 0;
            this.numBronzeRUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBronzeRUS.ValueChanged += new System.EventHandler(this.numBronzeRUS_ValueChanged);
            // 
            // panelRUSsilver
            // 
            this.panelRUSsilver.BackColor = System.Drawing.Color.Transparent;
            this.panelRUSsilver.Controls.Add(this.label5);
            this.panelRUSsilver.Controls.Add(this.numSilverRUS);
            this.panelRUSsilver.Location = new System.Drawing.Point(0, 73);
            this.panelRUSsilver.Name = "panelRUSsilver";
            this.panelRUSsilver.Size = new System.Drawing.Size(602, 69);
            this.panelRUSsilver.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(23, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Silver Medals";
            // 
            // numSilverRUS
            // 
            this.numSilverRUS.Location = new System.Drawing.Point(23, 17);
            this.numSilverRUS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSilverRUS.Name = "numSilverRUS";
            this.numSilverRUS.Size = new System.Drawing.Size(68, 20);
            this.numSilverRUS.TabIndex = 0;
            this.numSilverRUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSilverRUS.ValueChanged += new System.EventHandler(this.numSilverRUS_ValueChanged);
            // 
            // panelRUSgold
            // 
            this.panelRUSgold.BackColor = System.Drawing.Color.Transparent;
            this.panelRUSgold.Controls.Add(this.label10);
            this.panelRUSgold.Controls.Add(this.label3);
            this.panelRUSgold.Controls.Add(this.numGoldRUS);
            this.panelRUSgold.Location = new System.Drawing.Point(3, 2);
            this.panelRUSgold.Name = "panelRUSgold";
            this.panelRUSgold.Size = new System.Drawing.Size(602, 69);
            this.panelRUSgold.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Firebrick;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(25, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Russia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(25, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gold Medals";
            // 
            // numGoldRUS
            // 
            this.numGoldRUS.Location = new System.Drawing.Point(23, 22);
            this.numGoldRUS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGoldRUS.Name = "numGoldRUS";
            this.numGoldRUS.Size = new System.Drawing.Size(68, 20);
            this.numGoldRUS.TabIndex = 0;
            this.numGoldRUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGoldRUS.ValueChanged += new System.EventHandler(this.numGoldRUS_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MedalRanking.Properties.Resources.eight_col_olympic_continents_16x10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(602, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 89);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(86, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Medal Ranking";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelUSAbronze.ResumeLayout(false);
            this.panelUSAbronze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBronzeUSA)).EndInit();
            this.panelUSAsilver.ResumeLayout(false);
            this.panelUSAsilver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSilverUSA)).EndInit();
            this.panelUSAgold.ResumeLayout(false);
            this.panelUSAgold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoldUSA)).EndInit();
            this.panelRUSbronze.ResumeLayout(false);
            this.panelRUSbronze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBronzeRUS)).EndInit();
            this.panelRUSsilver.ResumeLayout(false);
            this.panelRUSsilver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSilverRUS)).EndInit();
            this.panelRUSgold.ResumeLayout(false);
            this.panelRUSgold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoldRUS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelUSAbronze;
        private System.Windows.Forms.NumericUpDown numBronzeUSA;
        private System.Windows.Forms.Panel panelUSAsilver;
        private System.Windows.Forms.NumericUpDown numSilverUSA;
        private System.Windows.Forms.Panel panelUSAgold;
        private System.Windows.Forms.NumericUpDown numGoldUSA;
        private System.Windows.Forms.Panel panelRUSbronze;
        private System.Windows.Forms.NumericUpDown numBronzeRUS;
        private System.Windows.Forms.Panel panelRUSsilver;
        private System.Windows.Forms.NumericUpDown numSilverRUS;
        private System.Windows.Forms.Panel panelRUSgold;
        private System.Windows.Forms.NumericUpDown numGoldRUS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

