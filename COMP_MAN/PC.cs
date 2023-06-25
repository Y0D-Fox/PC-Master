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
using System.Xml.Linq;

namespace COMP_MAN
{
    public partial class PC : Form
    {
        private Game _game;
        public PC(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.cd == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 50)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 50;
                    Properties.Settings1.Default.cd = "Куплено";
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                    _game.label2.Update();
                    _game.label20.Text = Properties.Settings1.Default.cd;
                    _game.label20.Update();
                    MessageBox.Show("Успешно");
                    button5.Enabled = false;
                }
                else if (Properties.Settings1.Default.monye < 50)
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 30)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 30;
                    Properties.Settings1.Default.pc = "Куплено";
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                    _game.label2.Update();
                    _game.label16.Text = Properties.Settings1.Default.pc;
                    _game.label16.Update();
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    MessageBox.Show("Успешно");
                    button1.Enabled= false;
                }
                else if (Properties.Settings1.Default.monye < 30)
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PC_Load(object sender, EventArgs e)
        {

            if (Properties.Settings1.Default.pc == "пока нет")
            {
                button1.Text = "Купить компьютер";

            }
            else if (Properties.Settings1.Default.pc == "Куплено")
            {
                button1.Enabled= false;
            }
            if (Properties.Settings1.Default.modem == "пока нет")
            {
                button4.Text = "Купить модем";
            }
            else if (Properties.Settings1.Default.modem == "Куплено")
            {
                button4.Enabled = false;
            }
            if (Properties.Settings1.Default.hard == "пока нет")
            {
                button3.Text = "Купить винчестер";
            }
            else if (Properties.Settings1.Default.hard == "Куплено")
            {
                button3.Enabled = false;
            }
            if (Properties.Settings1.Default.cd == "пока нет")
            {
                button5.Text = "Купить cd";
            }
            else if (Properties.Settings1.Default.cd == "Куплено")
            {
                button5.Enabled = false;
            }
            if (Properties.Settings1.Default.soundblaster == "пока нет")
            {
                button6.Text = "Купить soundblaster";
            }
            else if(Properties.Settings1.Default.soundblaster == "Куплено")
            {
                button6.Enabled = false;
            }
            if (Properties.Settings1.Default.flash == "пока нет")
            {
                button2.Text = "Купить память";

            }
            else if (Properties.Settings1.Default.flash == "Куплено")
            {
                button2.Enabled = false;
            }

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.pc == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить\r\n за 50$";

            }
      
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.flash == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить  за 30$";
            }
           

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.hard == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Сейчас можно купить винт за 60$";
            }



        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.modem == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Можно купить модем за 40$";
            }


        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.cd == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Доступен СD-RОМ\r\n за 30$";
            }


        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (Properties.Settings1.Default.soundblaster == "пока нет")
            {
                label1.Visible = true;
                label1.Text = "Вы можете купить\r\nSoundBlaster за 50$";
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.flash == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 30)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 30;
                    _game.label2.Update();
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                    Properties.Settings1.Default.flash = "Куплено";
                    button2.Enabled= false;
                    MessageBox.Show("Успешно");
                    _game.label17.Text = Properties.Settings1.Default.flash;
                    _game.label17.Update();
                    button2.Update();
                }
                else if (Properties.Settings1.Default.monye < 30)
                {
                    MessageBox.Show("Недостаточно денег");
                }
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.hard == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 60)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 6;
                    _game.label2.Update();
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 10;
                    Properties.Settings1.Default.hard = "Куплено";
                    button3.Enabled = false;
                    MessageBox.Show("Успешно");
                    _game.label18.Text = Properties.Settings1.Default.flash;
                    _game.label18.Update();
                    button3.Update();
                }
                else if (Properties.Settings1.Default.monye < 60)
                {
                    MessageBox.Show("Недостаточно денег");
                }


            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.modem == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 40)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 40;
                    _game.label2.Update();
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                    Properties.Settings1.Default.modem = "Куплено";
                    button4.Enabled = false;
                    MessageBox.Show("Успешно");
                    _game.label19.Text = Properties.Settings1.Default.modem;
                    _game.label19.Update();
                    button4.Update();
                }
                else if (Properties.Settings1.Default.monye < 40)
                {
                    MessageBox.Show("Недостаточно денег");
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.soundblaster == "пока нет")
            {
                if (Properties.Settings1.Default.monye >= 50)
                {
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 50;
                    _game.label2.Update();
                    Properties.Settings1.Default.point = Properties.Settings1.Default.point + 5;
                    Properties.Settings1.Default.soundblaster = "Куплено";
                    button6.Enabled = false;
                    MessageBox.Show("Успешно");
                    _game.label21.Text = Properties.Settings1.Default.modem;
                    _game.label21.Update();
                    button6.Update();
                }
                else if (Properties.Settings1.Default.monye < 50)
                {
                    MessageBox.Show("Недостаточно денег");
                }


            }
        }
    }
}