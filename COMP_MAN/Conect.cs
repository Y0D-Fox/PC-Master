using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMP_MAN
{
    public partial class Conect : Form
    {

        int i = 0;
        int j = 0;
        Random rnd = new Random();
        public Conect()
        {
            InitializeComponent();

            System.IO.Stream str = (Properties.Resources.SoundConnect);
            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer(str);
            sndPlayer.Play();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ValueCall = rnd.Next(0, 3);
            i++;
          
            if (i == 31 && ValueCall == 1) 
            {
               label2.Text= "Успешно";
                button1.Text = "Ок";
                button1.Visible = true;
                button1.Enabled= true;
                timer2.Enabled = false;
            }
            else if(i == 31 && ValueCall == 0)
            {
                label2.Text = "Ошибка";
                timer2.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Ошибка подключения", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Close();
                }
            }
            else if (i == 31 && ValueCall == 2)
            {
                label2.Text = "Ошибка";
                timer2.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Чистка BBS, Подключение не возможно!", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Close();
                }
            }

        }

        private void Conect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BBS_Station bBS_Station = new BBS_Station();
            bBS_Station.ShowDialog();
            this.Hide();
            this.Close();
        }
        private readonly Stopwatch stopwatch = new Stopwatch();
        private void timer2_Tick(object sender, EventArgs e)
        {

            j++;
            if (j <= 31) 
            { timer2.Start();
                if (j == 0 || j == 4 || j == 8 || j == 12 ||  j == 16 || j == 20 || j == 24 || j == 28)
                {
                    label2.Text = "Подождите";
                    Task.Delay(20000);
                }
                else if (j == 1 || j == 5 || j == 9 || j == 13 || j == 17 || j == 21 || j == 25 || j == 29) {
                        label2.Text = "Подождите.";
                        Task.Delay(20000);
                       
                    }
                
               else if (j == 2 || j == 6 || j == 10 || j == 14 || j == 18 || j == 22 || j == 26 || j == 30)
                        {
                            label2.Text = "Подождите..";
                            Task.Delay(20000);
                            
                        }else if (j == 3 || j == 7 || j == 11 || j == 15 || j == 19 || j == 23 || j == 27 || j == 31)
                            {
                                label2.Text = "Подождите...";
                                Task.Delay(20000);
                            }
            }
            else
            {
                timer2.Stop();
            }
            
        }
    }
}
