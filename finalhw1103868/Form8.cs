using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using System.Runtime.ConstrainedExecution;

namespace finalhw1103868
{
    public partial class Form8 : Form

    {
        int i = 1;
        int page = 1;
        int ss = 1;
        int sc = 0;

        WMPLib.WindowsMediaPlayer mus = new WMPLib.WindowsMediaPlayer();
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            page++;
            Ask(page);
            
        }
        private void Ask(int q)
        {
            switch (q)
            {
                case 1:
                    textBox1.Text = "題目共有10題";
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 2:
                    textBox1.Text = "全對者便能獲得杰倫演唱會門票一張";
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 3:
                    textBox1.Text = "啊啊啊真的假的!";
                    pictureBox4.Visible = false;
                    pictureBox6.Visible = true;
                    break;
                case 4:
                    textBox1.Text = "那佩吉參賽選手準備好了嗎!!!!";
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 5:
                    textBox1.Text = "我準備好了!";
                    pictureBox6.Visible = true;
                    pictureBox4.Visible = false;
                    break;
                case 6:
                    textBox1.Text = "那就開始吧!";
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 7:
                    song();
                    break;
                case 8:
                    if (sc == 10)
                        textBox1.Text = "恭喜佩吉獲得演唱會門票";
                    else
                        textBox1.Text = "可惜了佩吉，下次再努力!";
                    pictureBox4.Visible = true;
                    pictureBox6.Visible = false;
                    break;
                case 9:
                    if (sc == 10)
                        textBox1.Text ="謝謝主持人!掰掰";
                    else
                        textBox1.Text = "唉真的差一點!主持人下次見";
                    pictureBox4.Visible =false;
                    pictureBox6.Visible = true;
                    break;



            }  


           
        }

       

        private void song ()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            button3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label1.Visible = true;
           
        }
        private void pp()
        {
            page++;
            Ask(page);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label1.Visible = false;
            

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            page--;
            Ask(page);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (ss)
            {
                case 1:
                 
                    mus.URL = "telllove.mp3";
                    mus.controls.play();
                    break;
                case 2:
                    mus.URL = "good.mp3";
                    mus.controls.play();

                    break;
                case 3:
                    mus.URL = "grapa.mp3";
                    mus.controls.play();

                    break;
                case 4:
                    mus.URL = "love.mp3";
                    mus.controls.play();
                    break;
                case 5:
                    mus.URL = "eyea.mp3";
                    mus.controls.play();

                    break;
                case 6:
                    mus.URL = "sun.mp3";
                    mus.controls.play();

                    break;

                case 7:
                    mus.URL = "supman.mp3";
                    mus.controls.play();

                    break;
                case 8:
                    mus.URL = "bird.mp3";
                    mus.controls.play();
                    break;
                case 9:
                    mus.URL = "mila.mp3";
                    mus.controls.play();

                    break;
                case 10:
                    mus.URL = "easylove.mp3";
                    mus.controls.play();
                    
                    break;
                default:
                    break;
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            mus.controls.pause();
            switch (ss)
            {
                case 1:
                    label1.Text = "第二題";
                    button5.Text = "最偉大的作品";
                    button6.Text = "不能說的秘密";
                    button7.Text = "算什麼男人";
                    button8.Text = "軌跡";
                    break;
                case 2:
                    sc++;
                    label1.Text = "第三題";
                    button5.Text = "外婆";
                    button6.Text = "聽媽媽的話";
                    button7.Text = "聽爸爸的話";
                    button8.Text = "爺爺泡的茶";

                    break;
                case 3:
                    label1.Text = "第四題";
                    button5.Text = "愛在西元前";
                    button6.Text = "安靜";
                    button7.Text = "楓";
                    button8.Text = "擱淺";
                    
                    break;
                case 4:
                    label1.Text = "第五題";
                    button5.Text = "可愛女人";
                    button6.Text = "開不了口";
                    button7.Text = "她的睫毛";
                    button8.Text = "愛你沒差";
                    sc++;
                    break;
                case 5:
                    label1.Text = "第六題";
                    button5.Text = "星晴";
                    button6.Text = "安靜";
                    button7.Text = "晴天";
                    button8.Text = "退後";
                    break;
                   
                case 6:
                    label1.Text = "第七題";
                    button5.Text = "超人不會飛";
                    button6.Text = "世界末末日";
                    button7.Text = "最長的電影";
                    button8.Text = "說好的幸福呢";
                    sc++;

                    break;

                case 7:
                    label1.Text = "第八題";
                    button5.Text = "印地安老斑鳩";
                    button6.Text = "美人魚";
                    button7.Text = "鬥牛";
                    button8.Text = "龍站騎士";
                    sc++;
                    break;
                case 8:
                    label1.Text = "第九題";
                    button5.Text = "反方向的鐘";
                    button6.Text = "米蘭的大鐵匠";
                    button7.Text = "順方向的鐘";
                    button8.Text = "米蘭的小鐵匠";
                    sc++;
                    break;
                case 9:
                    label1.Text = "第十題";
                    button5.Text = "珊瑚海";
                    button6.Text = "東風破";
                    button7.Text = "簡單愛";
                    button8.Text = "攏捲風";

                    break;
                case 10:
                    if (sc ==10)
                    {
                        MessageBox.Show("恭喜佩吉全對" + Environment.NewLine+"獲得杰倫演唱會門票一張" );
                    }
                    else
                    {
                        MessageBox.Show("答對"+sc+ "題" + Environment.NewLine + "可惜沒全對" + Environment.NewLine+"下次再加油");
                    }
                    pp();
                   
                    break;


                default:
                    break;
            }

            ss++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mus.controls.pause();
            switch (ss)
            {
                case 1:
                    label1.Text = "第二題";
                    button5.Text = "最偉大的作品";
                    button6.Text = "不能說的秘密";
                    button7.Text = "算什麼男人";
                    button8.Text = "軌跡";
                    break;
                case 2:
                    label1.Text = "第三題";
                    button5.Text = "外婆";
                    button6.Text = "聽媽媽的話";
                    button7.Text = "聽爸爸的話";
                    button8.Text = "爺爺泡的茶";

                    break;
                case 3:
                    label1.Text = "第四題";
                    button5.Text = "愛在西元前";
                    button6.Text = "安靜";
                    button7.Text = "楓";
                    button8.Text = "擱淺";
                    break;
                case 4:
                    label1.Text = "第五題";
                    button5.Text = "可愛女人";
                    button6.Text = "開不了口";
                    button7.Text = "她的睫毛";
                    button8.Text = "愛你沒差";
                    break;
                case 5:
                    sc++;
                    label1.Text = "第六題";
                    button5.Text = "星晴";
                    button6.Text = "安靜";
                    button7.Text = "晴天";
                    button8.Text = "退後";
                    break;

                case 6:
                    sc++;
                    label1.Text = "第七題";
                    button5.Text = "超人不會飛";
                    button6.Text = "世界末末日";
                    button7.Text = "最長的電影";
                    button8.Text = "說好的幸福呢";

                    break;

                case 7:
                    label1.Text = "第八題";
                    button5.Text = "印地安老斑鳩";
                    button6.Text = "美人魚";
                    button7.Text = "鬥牛";
                    button8.Text = "龍站騎士";

                    break;
                case 8:
                    label1.Text = "第九題";
                    button5.Text = "反方向的鐘";
                    button6.Text = "米蘭的大鐵匠";
                    button7.Text = "順方向的鐘";
                    button8.Text = "米蘭的小鐵匠";
                    break;
                case 9:
                    label1.Text = "第十題";
                    button5.Text = "珊瑚海";
                    button6.Text = "東風破";
                    button7.Text = "簡單愛";
                    button8.Text = "攏捲風";

                    break;
                case 10:
                    sc++;
                    if (sc == 10)
                    {
                        MessageBox.Show("恭喜佩吉全對" + Environment.NewLine + "獲得杰倫演唱會門票一張");
                    }
                    else
                    {
                        MessageBox.Show("答對" + sc + "題" + Environment.NewLine + "可惜沒全對" + Environment.NewLine + "下次再加油");
                    }
                    pp();
                    
                    break;
                default:
                    break;
            }
            ss++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mus.controls.pause();
            switch (ss)
            {
                case 1:
                    label1.Text = "第二題";
                    button5.Text = "最偉大的作品";
                    button6.Text = "不能說的秘密";
                    button7.Text = "算什麼男人";
                    button8.Text = "軌跡";
                    break;
                case 2:
                    label1.Text = "第三題";
                    button5.Text = "外婆";
                    button6.Text = "聽媽媽的話";
                    button7.Text = "聽爸爸的話";
                    button8.Text = "爺爺泡的茶";

                    break;
                case 3:
                    sc++;
                    label1.Text = "第四題";
                    button5.Text = "愛在西元前";
                    button6.Text = "安靜";
                    button7.Text = "楓";
                    button8.Text = "擱淺";
                    break;
                case 4:
                    label1.Text = "第五題";
                    button5.Text = "可愛女人";
                    button6.Text = "開不了口";
                    button7.Text = "她的睫毛";
                    button8.Text = "愛你沒差";
                    break;
                case 5:
                    label1.Text = "第六題";
                    button5.Text = "星晴";
                    button6.Text = "安靜";
                    button7.Text = "晴天";
                    button8.Text = "退後";
                    break;

                case 6:
                    label1.Text = "第七題";
                    button5.Text = "超人不會飛";
                    button6.Text = "世界末末日";
                    button7.Text = "最長的電影";
                    button8.Text = "說好的幸福呢";

                    break;

                case 7:
                    label1.Text = "第八題";
                    button5.Text = "印地安老斑鳩";
                    button6.Text = "美人魚";
                    button7.Text = "鬥牛";
                    button8.Text = "龍站騎士";

                    break;
                case 8:
                    label1.Text = "第九題";
                    button5.Text = "反方向的鐘";
                    button6.Text = "米蘭的大鐵匠";
                    button7.Text = "順方向的鐘";
                    button8.Text = "米蘭的小鐵匠";
                    break;
                case 9:
                    sc++;
                    label1.Text = "第十題";
                    button5.Text = "珊瑚海";
                    button6.Text = "東風破";
                    button7.Text = "簡單愛";
                    button8.Text = "攏捲風";

                    break;
                case 10:
                    if (sc == 10)
                    {
                        MessageBox.Show("恭喜佩吉全對" + Environment.NewLine + "獲得杰倫演唱會門票一張");
                    }
                    else
                    {
                        MessageBox.Show("答對" + sc + "題" + Environment.NewLine + "可惜沒全對" + Environment.NewLine + "下次再加油");
                    }
                  
                    pp();
                   
                    break;
                 
                default:
                    break;
            }

            ss++;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            mus.controls.pause();


            switch (ss)
            {
                case 1:
                    sc++;
                    label1.Text = "第二題";
                    button5.Text = "最偉大的作品";
                    button6.Text = "不能說的秘密";
                    button7.Text = "算什麼男人";
                    button8.Text = "軌跡";
                    break;
                case 2:
                    label1.Text = "第三題";
                    button5.Text = "外婆";
                    button6.Text = "聽媽媽的話";
                    button7.Text = "聽爸爸的話";
                    button8.Text = "爺爺泡的茶";

                    break;
                case 3:
                    label1.Text = "第四題";
                    button5.Text = "愛在西元前";
                    button6.Text = "安靜";
                    button7.Text = "楓";
                    button8.Text = "擱淺";
                    break;
                case 4:
                    label1.Text = "第五題";
                    button5.Text = "可愛女人";
                    button6.Text = "開不了口";
                    button7.Text = "她的睫毛";
                    button8.Text = "愛你沒差";
                    break;
                case 5:
                    label1.Text = "第六題";
                    button5.Text = "星晴";
                    button6.Text = "安靜";
                    button7.Text = "晴天";
                    button8.Text = "退後";
                    break;

                case 6:
                    label1.Text = "第七題";
                    button5.Text = "超人不會飛";
                    button6.Text = "世界末末日";
                    button7.Text = "最長的電影";
                    button8.Text = "說好的幸福呢";

                    break;

                case 7:
                    label1.Text = "第八題";
                    button5.Text = "印地安老斑鳩";
                    button6.Text = "美人魚";
                    button7.Text = "鬥牛";
                    button8.Text = "龍站騎士";

                    break;
                case 8:
                    label1.Text = "第九題";
                    button5.Text = "反方向的鐘";
                    button6.Text = "米蘭的大鐵匠";
                    button7.Text = "順方向的鐘";
                    button8.Text = "米蘭的小鐵匠";
                    break;
                case 9:
                    label1.Text = "第十題";
                    button5.Text = "珊瑚海";
                    button6.Text = "東風破";
                    button7.Text = "簡單愛";
                    button8.Text = "攏捲風";

                    break;
                case 10:
                    if (sc == 10)
                    {
                        MessageBox.Show("恭喜佩吉全對" + Environment.NewLine + "獲得杰倫演唱會門票一張");
                    }
                    else
                    {
                        MessageBox.Show("答對" + sc + "題" + Environment.NewLine + "可惜沒全對" + Environment.NewLine + "下次再加油");
                    }
                   
                
                    pp();
                  
                    break;
                default:
                    break;
            }

            ss++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
