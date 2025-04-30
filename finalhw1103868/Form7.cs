using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;


namespace finalproject
{
    public partial class Form7 : Form
    {
        WMPLib.WindowsMediaPlayer ex1 = new WMPLib.WindowsMediaPlayer();
       
        int pspeed = 4;
        int gr = 5; 
        int sc = 0;
        public Form7()
        {
            InitializeComponent();
        }

     

        private void Form7_Load(object sender, EventArgs e)
        {   


            ex1.URL = "bgm.mp3";
            ex1.controls.play();
            ex1.settings.setMode("loop", true);
           
        }

        private void gamed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gr = -5;

            }
        }

        private void gameu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gr = 5;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top += gr;
            pictureBox3.Left -= pspeed;
            pictureBox5.Left -= pspeed;
            label1.Text = "得分:" + sc;
            

            if (pictureBox3.Left < -150)
            {
                pictureBox3.Left = 800;
                sc++;
            } 

            if (pictureBox5.Left < -180 )
            {
                pictureBox5.Left = 950;
                sc++;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds)|| pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox2.Top <= 0 )
            {
                EndGame();
               
            }
            if(pictureBox2.Top < -25)
            {
                EndGame();
               
            }
            if(pictureBox2.Top > 550)
            {
                EndGame();
                
            }
        }

        private void EndGame()
        {
            
            timer1.Stop();
           
           label1.Text= "您輸了，下一把再努力";
            ex1.controls.pause();


        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
