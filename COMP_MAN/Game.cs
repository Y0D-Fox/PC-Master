using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COMP_MAN
{
    public partial class Game : Form
    {
         private bool isMusicPlaying = false;
        int rtDate = Properties.Settings1.Default.day + 15;
        int month = Properties.Settings1.Default.month;
        int year = Properties.Settings1.Default.years;
        int i = 0;
        int day = Properties.Settings1.Default.day;
        public void status()
        {
            if (Properties.Settings1.Default.status == "ЛОХ")
            {
                DialogResult dialogResult = MessageBox.Show("Вы не просто ЛОХ, вы самый настоящий ЛОШАРА :)", "Повышение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings1.Default.status == "Пользователь")
            {
                DialogResult dialogResult = MessageBox.Show("Вы достигли чего-то большего вы теперь пользователь, а не ЛОХ :)", "Повышение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings1.Default.status == "Продвинутый")
            {

                MessageBox.Show("Ваши навыки растут и растут так держать", "Повышение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings1.Default.status == "Программист")
            {

                MessageBox.Show("Люблю програми... А знаете, что теперь вы програмист, а я пошёл спать", "Повышение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (Properties.Settings1.Default.status == "Хакер")
            {

                MessageBox.Show("Вы теперь Хакер ура вы потратили свою жизнь в никуда :)", "Повышение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void UpdateUser()
        {
            label22.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            label2.Text = Convert.ToString(Properties.Settings1.Default.monye);
            label6.Text = Convert.ToString(Properties.Settings1.Default.point);
            label7.Text = Properties.Settings1.Default.status;
            label8.Text = Properties.Settings1.Default.moon;
            label28.Text = Properties.Settings1.Default.antivirus;
            label30.Text = Properties.Settings1.Default.program;
            label31.Text = Properties.Settings1.Default.bbs;
            label29.Text = Properties.Settings1.Default.system;
            label16.Text = Properties.Settings1.Default.pc;
            label17.Text = Properties.Settings1.Default.flash;
            label18.Text = Properties.Settings1.Default.hard;
            label19.Text = Properties.Settings1.Default.cd;
            label21.Text = Properties.Settings1.Default.soundblaster;
            label32.Text = Convert.ToString(Properties.Settings1.Default.othersoft);
            label17.Text = Properties.Settings1.Default.modem;
        }
       
        public Game()
        {
            InitializeComponent();
        }
        public string textBoxValue

        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void вкратцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void описаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info1 info = new info1();
            info.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.Impression);
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(str);
            if (toolStripMenuItem6.Checked == true)
            {
                player.PlayLooping();
            }

            else
            {
                player.Stop();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.Impression);
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(str);
            System.IO.Stream str1 = (Properties.Resources.Melancholy);
            System.Media.SoundPlayer player1 = new
            System.Media.SoundPlayer(str1);
            if (toolStripMenuItem7.Checked == true && toolStripMenuItem6.Checked == true)
            {
                toolStripMenuItem7.Text = "Музыка №2";

                player1.PlayLooping();
            }

            else if (toolStripMenuItem7.Checked == false && toolStripMenuItem6.Checked == false)
            {
                player1.Stop();
                toolStripMenuItem7.Text = "Музыка №1";
            }
            else if (toolStripMenuItem7.Checked == false && toolStripMenuItem6.Checked == true)
            {

                toolStripMenuItem7.Text = "Музыка №1";
                player.Play();
            }
            else if (toolStripMenuItem7.Checked == true && toolStripMenuItem6.Checked == false)
            {

                toolStripMenuItem7.Text = "Музыка №1";
                player1.Stop();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        public void UpdateMoon()
        {          
            if (Properties.Settings1.Default.moonpoint <= 50)
            {
                Properties.Settings1.Default.moon= "Нормальное";
            }
            if (Properties.Settings1.Default.moonpoint <= 100)
            {
                Properties.Settings1.Default.moon = "Отличное";
            }
            if (Properties.Settings1.Default.moonpoint <= 30)
            {
                Properties.Settings1.Default.moon = "Плохое";
            }
            if (Properties.Settings1.Default.moonpoint == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Ваше психическое сотояние упало до нулю вы покончили с собой","Конец игры",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                { 
                this.Close();
                }
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
        public void UpdateStatus()
        {
            if (Properties.Settings1.Default.system == "Windows 3.11" && Properties.Settings1.Default.program == "Pascal" && Properties.Settings1.Default.point >= 30)
            {
            Properties.Settings1.Default.status = "Пользователь";
            }
            if (Properties.Settings1.Default.system == "Windows 95" && Properties.Settings1.Default.program == "Assembler" && Properties.Settings1.Default.point >= 40)
            {
                Properties.Settings1.Default.status = "Продвинутый";
            }
            if (Properties.Settings1.Default.system == "Windows NT 4.0" && Properties.Settings1.Default.program == "VisualBasic" && Properties.Settings1.Default.point >= 50)
            {             
                Properties.Settings1.Default.status = "Программист";
            }
            if (Properties.Settings1.Default.system == "OS 2/5.0 Warp" && Properties.Settings1.Default.program== "Delphi" && Properties.Settings1.Default.point >= 60)
            {            
                Properties.Settings1.Default.status = "Хакер";
            }
            
        }
        public void Game_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label22.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            label2.Text = Convert.ToString(Properties.Settings1.Default.monye);
            label6.Text = Convert.ToString(Properties.Settings1.Default.point);
            label7.Text = Properties.Settings1.Default.status;
            label8.Text = Properties.Settings1.Default.moon;
            label28.Text = Properties.Settings1.Default.antivirus;
            label30.Text = Properties.Settings1.Default.program;
            label31.Text = Properties.Settings1.Default.bbs;
            label32.Text = Convert.ToString(Properties.Settings1.Default.othersoft) + "Mb";
            label29.Text = Properties.Settings1.Default.system;
            label16.Text = Properties.Settings1.Default.pc;
            label17.Text = Properties.Settings1.Default.flash;
            label18.Text = Properties.Settings1.Default.hard;
            label19.Text = Properties.Settings1.Default.modem;
            label20.Text = Properties.Settings1.Default.cd;
            label21.Text = Properties.Settings1.Default.soundblaster;
            label15.Text = Convert.ToString(rtDate);
            timer1.Start();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BBS bBS = new BBS();
            bBS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i >= 24)
            {

                i = 0;
                if (Properties.Settings1.Default.salary > 0)
                {
                    day++;
                    Properties.Settings1.Default.monye = Properties.Settings1.Default.salary + Properties.Settings1.Default.monye;
                    label2.Text = Convert.ToString(Properties.Settings1.Default.monye);
                }
                else
                {   Properties.Settings1.Default.moonpoint = Properties.Settings1.Default.moonpoint - 1;  
                    day++;

                    if (rtDate == day)
                    {
                        MessageBox.Show("Игра окончена");
                    }
                    
                }

            }
          label15.Text = (day + "." + month + "." + year);
          label34.Text = i.ToString("00") + ":00";
          this.UpdateUser();
          this.UpdateMoon();
          this.UpdateStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.status();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PC pc = new PC(this);
            pc.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fun fun = new Fun();
            fun.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Job job = new Job(this);
            job.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PC_Program pC_Program = new PC_Program(this);
            pC_Program.ShowDialog();
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Сходить в сауну, посетить друзей или сходить на прогулку";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Нужно найти себе работу!";
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Скачать и загрузить полезный Soft";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Заняться хакерством";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Установка ПО и Языка программирования";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Купить или обнавить свой ПК";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=iUVDHEGR31k&ab_channel=ComfortableJeans") { UseShellExecute = true });
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Document (*.fox) | *.fox| All Files (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = open.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        Properties.Settings1.Default.monye = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.point = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.moon = reader.ReadLine();
                        Properties.Settings1.Default.moonpoint = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.antivirus = reader.ReadLine();
                        Properties.Settings1.Default.program = reader.ReadLine();
                        Properties.Settings1.Default.bbs = reader.ReadLine();
                        Properties.Settings1.Default.system = reader.ReadLine();
                        Properties.Settings1.Default.pc = reader.ReadLine();
                        Properties.Settings1.Default.flash = reader.ReadLine();
                        Properties.Settings1.Default.hard = reader.ReadLine();
                        Properties.Settings1.Default.cd = reader.ReadLine();
                        Properties.Settings1.Default.soundblaster = reader.ReadLine();
                        Properties.Settings1.Default.modem = reader.ReadLine();
                        Properties.Settings1.Default.salary = int.Parse(reader.ReadLine());
                        Properties.Settings1.Default.status = reader.ReadLine();
                        Properties.Settings1.Default.job = reader.ReadLine();
                        Properties.Settings1.Default.Save();
                    }
                    MessageBox.Show("Данные успешно загружены");
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void сохронитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document (*.fox) | *.fox| All Files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(Properties.Settings1.Default.monye);
                        writer.WriteLine(Properties.Settings1.Default.point);
                        writer.WriteLine(Properties.Settings1.Default.moon);
                        writer.WriteLine(Properties.Settings1.Default.antivirus);
                        writer.WriteLine(Properties.Settings1.Default.program);
                        writer.WriteLine(Properties.Settings1.Default.bbs);
                        writer.WriteLine(Properties.Settings1.Default.system);
                        writer.WriteLine(Properties.Settings1.Default.pc);
                        writer.WriteLine(Properties.Settings1.Default.flash);
                        writer.WriteLine(Properties.Settings1.Default.status);
                        writer.WriteLine(Properties.Settings1.Default.hard);
                        writer.WriteLine(Properties.Settings1.Default.cd);
                        writer.WriteLine(Properties.Settings1.Default.soundblaster);
                        writer.WriteLine(Properties.Settings1.Default.modem);
                        writer.WriteLine(Properties.Settings1.Default.salary);
                        writer.WriteLine(Properties.Settings1.Default.job);
                        writer.WriteLine(Properties.Settings1.Default.moonpoint);
                        Properties.Settings1.Default.Save();
                    }
                    MessageBox.Show("Данные успешно сохранены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.monye =60 ;
            Properties.Settings1.Default.point = 0;
            Properties.Settings1.Default.moon = "Нормальное";
            Properties.Settings1.Default.antivirus = "пока нет";
            Properties.Settings1.Default.program = "пока нет";
            Properties.Settings1.Default.bbs = "пока нет";
            Properties.Settings1.Default.system = "пока нет";
            Properties.Settings1.Default.pc = "пока нет";
            Properties.Settings1.Default.flash = "пока нет";
            Properties.Settings1.Default.hard = "пока нет";
            Properties.Settings1.Default.cd = "пока нет";
            Properties.Settings1.Default.moonpoint = 60;
            Properties.Settings1.Default.soundblaster = "пока нет";
            Properties.Settings1.Default.modem= "пока нет";
            Properties.Settings1.Default.salary = 0;
            Properties.Settings1.Default.job = "Без работы";
            this.Close();
            Game game = new Game();
            game.Update();
            game.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Посмотреть ваш статус :)";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
