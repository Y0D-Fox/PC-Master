using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMP_MAN
{
    public partial class BBS_Station : Form
    {
        int j = 0;
        int t = 0;
        private Game _game;

        Random rnd= new Random(); 
        public BBS_Station(Game game)
        {

            _game = game;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Chat = rnd.Next(0, 5);
            if (Chat == 0)
            {
                textBox1.Text = "Как дела?";
            }
            else if (Chat == 1)
            {
                textBox1.Text = "Хочу халявный инет!";
            }
            else if (Chat == 2)
            {
                textBox1.Text = "Я живу тут!";
            }
            else if (Chat == 3)
            {
                textBox1.Text = "Ищу Максима Саркисяна!";
            }
            else if (Chat == 4)
            {
                textBox1.Text = "Люблю смотреть Ералаш!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BBS_Station_Load(object sender, EventArgs e)
        {
            label6.Text=Properties.Settings1.Default.status;
            label2.Update();
            label4.Text = Properties.Settings1.Default.othersoft;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = "";
            label7.Visible= true;
            j++;
            t++;
            if (j <= 13)
            {
                timer1.Start();
                if (j == 0 || j == 4 || j == 8 || j == 12)
                {
                    label6.Text = "Подождите";
                    Task.Delay(20000);
                }
                else if (j == 1 || j == 5 || j == 9 || j == 13)
                {
                    label7.Text = "Подождите.";
                    Task.Delay(20000);

                }

                else if (j == 2 || j == 6 || j == 10)
                {
                    label7.Text = "Подождите..";
                    Task.Delay(20000);

                }
                else if (j == 3 || j == 7 || j == 11)
                {
                    label7.Text = "Подождите...";
                    Task.Delay(20000);
                }
            }
            else
            {
                label7.Text = "Успешно установленно";
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.SoundConnect1);
            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer(str);
            sndPlayer.Play();
            timer1.Start();
            if(Properties.Settings1.Default.status== "Пользователь")
            { 
              if (t == 13)
              {
                int Dowland = rnd.Next(0, 5);
                if (Dowland == 1)
                {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 2;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                }
                else if(Dowland == 2)
                {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 3;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 3;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                else if (Dowland == 3)
                {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 4;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                else if (Dowland == 4)
                {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 1;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                else if (Dowland == 0)
                {
                    label2.Text = "Ошибка загрузки";
                }
              }
            }
            else if (Properties.Settings1.Default.status == "Продвинутый")
            {
                if (t == 13)
                {
                    int Dowland = rnd.Next(0, 5);
                    if (Dowland == 1)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 7;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 2)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 9;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 10;

                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 3)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 12;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 4)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 5;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 0)
                    {
                        label2.Text = "Ошибка загрузки";
                    }
                }
            }
            else if (Properties.Settings1.Default.status == "Программист")
            {
                if (t == 13)
                {
                    int Dowland = rnd.Next(0, 5);
                    if (Dowland == 1)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 25;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 2)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 32;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 10;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 3)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 4;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 4)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 20;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 7;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 0)
                    {
                        label2.Text = "Ошибка загрузки";
                    }
                }
            }
            else if (Properties.Settings1.Default.status == "Хакер")
            {
                if (t == 13)
                {
                    int Dowland = rnd.Next(0, 5);
                    if (Dowland == 1)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 20;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 2)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 30;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 3)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 40;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 4)
                    {
                        Properties.Settings1.Default.soft = Properties.Settings1.Default.soft + 50;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        label2.Text = Properties.Settings1.Default.soft + "Mb";
                    }
                    else if (Dowland == 0)
                    {
                        label2.Text = "Ошибка загрузки";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.SoundConnect1);
            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer(str);
            sndPlayer.Play();
            timer1.Start();
            if (Properties.Settings1.Default.status == "Пользователь")
            {
                if (t == 13)
                {
                    int Upload = rnd.Next(0, 5);
                    if (Upload == 1)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 2;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 2)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 3;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 3;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 3)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 4;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 4)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 1;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 0)
                    {
                        label4.Text = "Ошибка выгрузки";
                    }
                }
            }
            else if (Properties.Settings1.Default.status == "Продвинутый")
            {
                if (t == 13)
                {
                    int Upload = rnd.Next(0, 5);
                    if (Upload == 1)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 7;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 2)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 9;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 10;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 3)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 12;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 4)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 5;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 0)
                    {
                        label4.Text = "Ошибка выгрузки";
                    }
                }
            }
            else if (Properties.Settings1.Default.status == "Программист")
            {
                if (t == 13)
                {
                    int Upload = rnd.Next(0, 5);
                    if (Upload == 1)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 25;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 2)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 32;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 10;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 3)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 4;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 1;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 4)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 20;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 7;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 0)
                    {
                        label4.Text = "Ошибка выгрузки";
                    }
                }
            }
            else if (Properties.Settings1.Default.status == "Хакер")
            {
                if (t == 13)
                {
                    int Upload = rnd.Next(0, 5);
                    if (Upload == 1)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 20;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 2)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 30;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 3)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 40;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 4)
                    {
                        Properties.Settings1.Default.othersoft = Properties.Settings1.Default.othersoft + 50;
                        Properties.Settings1.Default.point = Properties.Settings1.Default.point + 15;
                        _game.label32.Text += Properties.Settings1.Default.othersoft;
                        label4.Text = Properties.Settings1.Default.othersoft + "Mb";
                    }
                    else if (Upload == 0)
                    {
                        label4.Text = "Ошибка выгрузки";
                    }
                }
            }
        }
    }
}

