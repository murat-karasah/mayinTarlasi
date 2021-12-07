using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mayin = 3;
        int skor = 50;

        public void button1_Click(object sender, EventArgs e)
        {
             mayin = 3;
             skor = 50;
            flowLayoutPanel1.Controls.Clear();
            Random rnd = new Random();
            int rnd1 = rnd.Next(1, 20);
            int rnd2 = rnd.Next(21, 40);
            int rnd3 = rnd.Next(41, 50);

            label2.Text = skor.ToString();
            label4.Text = mayin.ToString();


            for (int i = 0; i < 50; i++)
            {

                Button btn = new Button();
                btn.Width = btn.Height = 68;
                btn.Padding = new Padding(0);
                btn.Tag = i;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_click;
                if (rnd1==i || rnd2==i || rnd3==i)
                {
                    btn.Tag = "mayın";
                }
                

            }


        }
        void btn_click(object sender, EventArgs e)
        {
            Button basilan = sender as Button;
            label4.Text = mayin.ToString();

            if (basilan.Tag=="mayın")
            {

                MessageBox.Show("Mayını Buldunuz! Skor : " + skor, "Tebrikler!");
                basilan.BackColor = Color.Red;
            }
            else
            {
                skor--;
                label2.Text = skor.ToString();

                basilan.BackColor = Color.Green;
            }
        }
    }
}
