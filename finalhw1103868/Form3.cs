using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using WMPLib;

namespace finalproject
{
    public partial class Form4 : Form
    {
        WMPLib.WindowsMediaPlayer ex2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ex3 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ex4 = new WMPLib.WindowsMediaPlayer();
        private int clockTime = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clockTime = 0;
            int[] x = new int[3];
            int[] labar = new int[3];
            Random rand = new Random();
            timer1.Start();
            ex2.URL = "pmg.mp3";
            ex2.controls.play();
            /*for (int i = 0; i < 3; i++)
            {
                x[i] = rand.Next(1, 8);
                if (i == 0)
                {
                    if (x[i] == 1)
                    {
                        pictureBox1.Image = Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox1.Image = Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox1.Image = Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox1.Image = Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox1.Image = Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox1.Image = Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox1.Image = Properties.Resources.squirrel;
                    }
                }
                if (i == 1)
                {
                    if (x[i] == 1)
                    {
                        pictureBox2.Image = Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox2.Image = Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox2.Image = Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox2.Image = Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox2.Image = Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox2.Image = Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox2.Image = Properties.Resources.squirrel;
                    }
                }
                if (i == 2)
                {
                    if (x[i] == 1)
                    {
                        pictureBox3.Image = Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox3.Image = Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox3.Image = Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox3.Image = Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox3.Image = Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox3.Image = Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox3.Image = Properties.Resources.squirrel;
                    }
                }

            }*/
            /*labar[0] = 0;
            labar[1] = 0;
            if (x[0] == x[1])
            {
                labar[1] = 2;
                labar[0] = x[0];
            }

            if (x[0] == x[2])
            {
                labar[1] = 2;
                labar[0] = x[0];
            }

            if (x[2] == x[1])
            {
                labar[1] = 2;
                labar[0] = x[1];
            }

            if (x[0] == x[1] && x[0] == x[2] )
            {
                labar[1] = 3;
                labar[0] = x[0];
            }

            if (labar[1] == 2)
            {
                if ( labar[0] ==1 ) textBox1.Text = " 恭喜您抽中兩隻漂亮黑狗，可獲得100元獎金!! ";
                if (labar[0] ==2) textBox1.Text = " 恭喜您抽中兩隻可愛羊駝，可獲得200元獎金!! ";
                if (labar[0] == 3) textBox1.Text = " 恭喜您抽中兩隻紅牛，可獲得300元獎金!! ";
                if (labar[0] == 4) textBox1.Text = " 恭喜您抽中兩隻鱷魚先生，可獲得400元獎金!! ";
                if (labar[0] == 5) textBox1.Text = " 恭喜您抽中兩隻懶懶猴，可獲得500元獎金!! ";
                if (labar[0] == 6) textBox1.Text = " 恭喜您抽中兩隻兔兔魔法師，可獲得600元獎金!! ";
                if (labar[0] == 7) textBox1.Text = " 恭喜您抽中兩隻呆呆松鼠，可獲得700元獎金!! ";
             
            }
            else if (labar[1] == 3)
            {
                if (labar[0] == 1) textBox1.Text = " 恭喜您抽中三隻漂亮黑狗，可獲得1000元獎金!! ";
                if (labar[0] == 2) textBox1.Text = " 恭喜您抽中三隻可愛羊駝，可獲得2000元獎金!! ";
                if (labar[0] == 3) textBox1.Text = " 恭喜您抽中三隻紅牛，可獲得3000元獎金!! ";
                if (labar[0] == 4) textBox1.Text = " 恭喜您抽中三隻鱷魚先生，可獲得4000元獎金!! ";
                if (labar[0] == 5) textBox1.Text = " 恭喜您抽中三隻懶懶猴，可獲得5000元獎金!! ";
                if (labar[0] == 6) textBox1.Text = " 恭喜您抽中三隻兔兔魔法師，可獲得6000元獎金!! ";
                if (labar[0] == 7) textBox1.Text = " 恭喜您抽中三隻呆呆松鼠，可獲得7000元獎金!! ";

            }
            else
            {
                textBox1.Text = " 無抽中相同動物，下次再來:( ";
            }

           
            

            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            f1 = null;
            this.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            clockTime += 1;
            int[] x = new int[3];
            int[] labar = new int[3];
            Random rand = new Random();
            clockTime += 1;
            
            for (int i = 0; i < 3; i++)
            {
                x[i] = rand.Next(1, 8);
                if (i == 0)
                {
                    if (x[i] == 1)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox1.Image = finalhw1103868.Properties.Resources.squirrel;
                    }
                }
                if (i == 1)
                {
                    if (x[i] == 1)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox2.Image = finalhw1103868.Properties.Resources.squirrel;
                    }
                }
                if (i == 2)
                {
                    if (x[i] == 1)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.dog;
                    }
                    if (x[i] == 2)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.sheep;
                    }
                    if (x[i] == 3)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.cow;
                    }
                    if (x[i] == 4)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.crocodile;
                    }
                    if (x[i] == 5)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.monkey;
                    }
                    if (x[i] == 6)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.rabbit;
                    }
                    if (x[i] == 7)
                    {
                        pictureBox3.Image = finalhw1103868.Properties.Resources.squirrel;
                    }
                }

            }

            if (clockTime >= 100)
            {
               
                timer1.Stop();
                
                if (timer1.Enabled == false)
                {
                    ex2.controls.pause();
                    
                }

            }
           
            labar[0] = 0;
            labar[1] = 0;
           
            
            if (x[0] == x[1])
            {
                labar[1] = 2;
                labar[0] = x[0];
            }

            if (x[0] == x[2])
            {
                labar[1] = 2;
                labar[0] = x[0];
            }

            if (x[2] == x[1])
            {
                labar[1] = 2;
                labar[0] = x[1];
            }

            if (x[0] == x[1] && x[0] == x[2])
            {
                labar[1] = 3;
                labar[0] = x[0];
            }

            if (labar[1] == 2)
                 
            {

                ex3.URL = "cheers.wav";
                ex3.controls.play();
                if (labar[0] == 1) textBox1.Text = " 恭喜您抽中兩隻漂亮黑狗，可獲得100元獎金!! ";
                if (labar[0] == 2) textBox1.Text = " 恭喜您抽中兩隻可愛羊駝，可獲得200元獎金!! ";
                if (labar[0] == 3) textBox1.Text = " 恭喜您抽中兩隻紅牛，可獲得300元獎金!! ";
                if (labar[0] == 4) textBox1.Text = " 恭喜您抽中兩隻鱷魚先生，可獲得400元獎金!! ";
                if (labar[0] == 5) textBox1.Text = " 恭喜您抽中兩隻懶懶猴，可獲得500元獎金!! ";
                if (labar[0] == 6) textBox1.Text = " 恭喜您抽中兩隻兔兔魔法師，可獲得600元獎金!! ";
                if (labar[0] == 7) textBox1.Text = " 恭喜您抽中兩隻呆呆松鼠，可獲得700元獎金!! ";

                
            }
            else if (labar[1] == 3)
            {
                ex3.URL = "cheers.wav";
                ex3.controls.play();
                if (labar[0] == 1) textBox1.Text = " 恭喜您抽中三隻漂亮黑狗，可獲得1000元獎金!! ";
                if (labar[0] == 2) textBox1.Text = " 恭喜您抽中三隻可愛羊駝，可獲得2000元獎金!! ";
                if (labar[0] == 3) textBox1.Text = " 恭喜您抽中三隻紅牛，可獲得3000元獎金!! ";
                if (labar[0] == 4) textBox1.Text = " 恭喜您抽中三隻鱷魚先生，可獲得4000元獎金!! ";
                if (labar[0] == 5) textBox1.Text = " 恭喜您抽中三隻懶懶猴，可獲得5000元獎金!! ";
                if (labar[0] == 6) textBox1.Text = " 恭喜您抽中三隻兔兔魔法師，可獲得6000元獎金!! ";
                if (labar[0] == 7) textBox1.Text = " 恭喜您抽中三隻呆呆松鼠，可獲得7000元獎金!! ";
                
            }
            else
            {
                ex3.URL = "0023.wav";
                ex3.controls.play();
                textBox1.Text = " 無抽中相同動物，下次再來:( ";
              

            }

            




        }
    }
    }



























