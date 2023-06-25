using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_MAN
{
    public partial class Fun : Form
    {
        Random rnd = new Random();
        public Fun()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int Value=rnd.Next(0,5);
            if (Value ==1 && Properties.Settings1.Default.monye>=4500)
            {
                

                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 4500;
                SecretEnd secret= new SecretEnd();
                secret.ShowDialog();
                this.Close(); 
            }
            else if (Value == 2 && Properties.Settings1.Default.monye >= 4500)
            {
                
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 4500;
                SecretEnd1 secret = new SecretEnd1();
                secret.ShowDialog();
                this.Close();
            }
            if (Value == 3 && Properties.Settings1.Default.monye >= 4500)
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 4500;
                SecretEnd2 secret = new SecretEnd2();
                secret.ShowDialog();
                this.Close();
                
            }
            if (Value == 4 && Properties.Settings1.Default.monye >= 4500)
            {
               
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 4500;
                SecretEnd3 secret = new SecretEnd3();
                secret.ShowDialog();
                this.Close();
            }
            else if (Value == 0 && Properties.Settings1.Default.monye >= 4500)
            {
                Properties.Settings1.Default.moonpoint = 7000;
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 4500;
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye+4000;
                label3.Text = "Вы правели отличное время \nи ничего не потеряли";

            }    
            else if( Properties.Settings1.Default.monye < 4500)
            {
                MessageBox.Show("Недостаточно денег");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Friends=rnd.Next(0,3);
            if (Properties.Settings1.Default.monye >= 1 && Friends == 1)
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 1;
                Properties.Settings1.Default.moonpoint = Properties.Settings1.Default.moonpoint + 5;
                label4.Text = "Вы правели отличное время";
            }
            else if(Properties.Settings1.Default.monye >= 1 && Friends == 2)
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 1;
                Properties.Settings1.Default.moonpoint = Properties.Settings1.Default.moonpoint + 0;
                label4.Text = "Вы правели... нормальное время";
            }
            else if (Properties.Settings1.Default.monye >= 1 && Friends ==0)
            {
                Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 1;
                Properties.Settings1.Default.moonpoint = Properties.Settings1.Default.moonpoint - 5;
                label4.Text = "Вы правели ужасное время.\n К черту их >:(";
            }
            else if(Properties.Settings1.Default.monye < 1)
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fun_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label1.Text = "Ваше настроение " + Properties.Settings1.Default.moon; 
            if (Properties.Settings1.Default.monye >= 4500)
            {
                button3.Enabled= true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.monye >= 20) { 
            Properties.Settings1.Default.monye = Properties.Settings1.Default.monye - 20;
            Properties.Settings1.Default.moonpoint = Properties.Settings1.Default.moonpoint + 20;
            label4.Text = "Вы правели отличное время в бане";}
            else if (Properties.Settings1.Default.monye <20)
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible= true;
            label3.Text = "Завести девушку";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
            label3.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
            label3.Text = "";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
            label3.Text = "";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
            label3.Text = "Сходить в баню";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
            label3.Text = "Сходить к друзьям";
        }
    }
}
