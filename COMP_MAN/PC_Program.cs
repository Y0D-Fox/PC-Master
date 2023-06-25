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

namespace COMP_MAN
{
    public partial class PC_Program : Form
    {
        int j = 0;
        private Game _game;
        private void NewMethod()
        {
            label7.Text = "";
            label7.Visible = false;
        }
        public PC_Program(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void button7_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Один из наиболее известных языков программирования,\n используется для обучения программированию";
        }

        private void button7_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Транслятор программы из текста на языке ассемблера,\n в программу на машинном языке";

        }

        private void button8_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Язык программирования, а также интегрированная среда \n разработки программного обеспечения,\n разрабатываемые корпорацией Microsoft.";
        }

        private void button9_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button10_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button10_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Интегрированная среда разработки ПО для Microsoft Windows,\n macOS, iOS и Android \nна языке Delphi (ранее носившем название Object Pascal)";
        }

        private void button3_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Общее название поколения операционных систем Windows\n от корпорации Microsoft, выпущенных с 1990 года(Windows 3.0)\n по 1994 год(Windows 3.2).";

        }

        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button5_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button6_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button4_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Графическая многозадачная операционная система корпорации Microsoft. ";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Последняя версия семейства сетевых\n операционных систем Microsoft Windows NT.";
        }

        private void button6_MouseMove_1(object sender, MouseEventArgs e)
        {
            label7.Visible = true;
            label7.Text = "Операционная система фирмы IBM,\n в определённый период времени разрабатывавшаяся с участием Microsoft.";

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = "";
            j++;
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
                    label6.Text = "Подождите.";
                    Task.Delay(20000);

                }

                else if (j == 2 || j == 6 || j == 10)
                {
                    label6.Text = "Подождите..";
                    Task.Delay(20000);

                }
                else if (j == 3 || j == 7 || j == 11)
                {
                    label6.Text = "Подождите...";
                    Task.Delay(20000);
                }
            }
            else
            {
                label6.Text = "Успешно установленно";
                timer1.Stop();
            }

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 50 && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 50;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.system = "OS/2 5.0 Warp";
                button6.Enabled = false;
                Task.Delay(130000);
                label6.Text = "";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Мало денег");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 30 && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.system = "Windows NT 4.0";
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 30;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                _game.label29.Text = Properties.Settings1.Default.system;
                button5.Enabled = false;
                Task.Delay(130000);
                label6.Text = "";
                timer1.Start();
            }
            else { MessageBox.Show("Мало денег"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 25 && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 25;
                sndPlayer.Play();
                Properties.Settings1.Default.system = "Windows 95";
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                label3.Text = Properties.Settings1.Default.system;
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "";
                button4.Enabled = false;
                Task.Delay(130000);
                timer1.Start();
            }
            else { MessageBox.Show("Мало денег"); }
        }

        private void PC_Program_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.antivirus == "Есть")
            {
                button1.Enabled = false;
            }
            if (Properties.Settings1.Default.flash == "пока нет" && Properties.Settings1.Default.pc == "пока нет" && Properties.Settings1.Default.cd == "пока нет" && Properties.Settings1.Default.hard == "пока нет")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }

            if (Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            if (Properties.Settings1.Default.system == "Windows 3.11" && Properties.Settings1.Default.program == "Pascal" && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = false;
                button4.Enabled = true;
                label3.Text = Properties.Settings1.Default.system;
                label5.Text = Properties.Settings1.Default.program;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = true;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
            else if (Properties.Settings1.Default.system == "Windows 95" && Properties.Settings1.Default.program == "Assembler" && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                label3.Text = Properties.Settings1.Default.system;
                label5.Text = Properties.Settings1.Default.program;
                button5.Enabled = true;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = true;
                button10.Enabled = false;
                label6.Text = "";
            }
            else if (Properties.Settings1.Default.system == "Windows NT 4.0" && Properties.Settings1.Default.program == "Visual Basic" && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                label3.Text = Properties.Settings1.Default.system;
                label5.Text = Properties.Settings1.Default.program;
                button5.Enabled = false;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = true;
                label6.Text = "";
            }
            else if (Properties.Settings1.Default.system == "OS/2 5.0 Warp" && Properties.Settings1.Default.program =="Delphi 3.0" && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                label3.Text = Properties.Settings1.Default.system;
                label5.Text = Properties.Settings1.Default.program;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                label6.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 10 && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 10;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.system = "Windows 3.11";
                label3.Text = Properties.Settings1.Default.system;
                _game.label29.Text = Properties.Settings1.Default.system;
                label6.Text = "";
                button3.Enabled = false;
                Task.Delay(130000);
                timer1.Start();
            }
            else { MessageBox.Show("Мало денег"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "пока нет" && Properties.Settings1.Default.pc == "пока нет" && Properties.Settings1.Default.cd == "пока нет" && Properties.Settings1.Default.hard == "пока нет")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                timer1.Start();
                Properties.Settings1.Default.antivirus = "Есть";
                _game.label28.Text = Properties.Settings1.Default.antivirus;
                Task.Delay(130000);
                button1.Enabled = false;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 20 && Properties.Settings1.Default.flash == "Куплено" && Properties.Settings1.Default.pc == "Куплено" && Properties.Settings1.Default.cd == "Куплено" && Properties.Settings1.Default.hard == "Куплено" && Properties.Settings1.Default.system == "Windows 3.11")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 20;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.program = "Pascal";
                label5.Text = Properties.Settings1.Default.program;
                _game.label30.Text = Properties.Settings1.Default.program;

                label6.Text = "";
                timer1.Start();
                Task.Delay(130000);
                button7.Enabled = false;

            }
            else { MessageBox.Show("Мало денег"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 20 && Properties.Settings1.Default.system == "Windows 95")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 20;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.program = "Assembler";
                label5.Text = Properties.Settings1.Default.program;
                _game.label30.Text = Properties.Settings1.Default.program;

                label6.Text = "";
                timer1.Start();
                Task.Delay(130000);
                button8.Enabled = false;

            }
            else { MessageBox.Show("Мало денег или слабая ОС"); }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 30 && Properties.Settings1.Default.system == "Windows NT 4.0")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 30;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.program = "Visual Basic";
                label5.Text = Properties.Settings1.Default.program;
                _game.label30.Text = Properties.Settings1.Default.program;

                label6.Text = "";
                timer1.Start();
                Task.Delay(130000);
                button9.Enabled = false;

            }
            else { MessageBox.Show("Мало денег или слабая ОС"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 40 && Properties.Settings1.Default.system == "OS/2 5.0 Warp")
            {
                System.IO.Stream str = (Properties.Resources.SoundConnect1);
                System.Media.SoundPlayer sndPlayer = new
                System.Media.SoundPlayer(str);
                sndPlayer.Play();
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 40;
                Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                Properties.Settings1.Default.program = "Delphi 3.0";
                label5.Text = Properties.Settings1.Default.program;
                _game.label30.Text = Properties.Settings1.Default.program;

                label6.Text = "";
                timer1.Start();
                Task.Delay(130000);
                button10.Enabled = false;

            }
            else { MessageBox.Show("Мало денег или слабая ОС"); }

        }
    }
}
