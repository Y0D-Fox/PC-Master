using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;
using System.Numerics;
using static System.Windows.Forms.DataFormats;

namespace COMP_MAN
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
           
            InitializeComponent();
            System.IO.Stream str = (Properties.Resources.INTRO);
            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer(str);
            sndPlayer.Play();
           
        }
        public Form1(string text)
        {
            textBox1.Text = text;
        }
        private Game F2 = new Game();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.Rules_of_Nature);
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(str);
            if (������ToolStripMenuItem.Checked == true)
            {
                player.PlayLooping();
            }

            else
            {
                player.Stop();
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", "");

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.Rules_of_Nature);
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(str);
            System.IO.Stream str1 = (Properties.Resources.Red_Sun);
            System.Media.SoundPlayer player1 = new
            System.Media.SoundPlayer(str1);
            //SoundPlayer player1 = new SoundPlayer(@"F:\\������� �����\\Rules_of_Nature.wav");
            //SoundPlayer player = new SoundPlayer(@"F:\\������� �����\\Red_Sun.wav");
            if (������1ToolStripMenuItem.Checked == true && ������ToolStripMenuItem.Checked == true) {
                ������1ToolStripMenuItem.Text = "������ �2";

                player1.PlayLooping();}
        
            else if(������1ToolStripMenuItem.Checked == false && ������ToolStripMenuItem.Checked == false)
            {
                player1.Stop();
                ������1ToolStripMenuItem.Text = "������ �1";
            }
            else if (������1ToolStripMenuItem.Checked == false && ������ToolStripMenuItem.Checked == true)
            {
               
                ������1ToolStripMenuItem.Text = "������ �1";
                player.Play();
            }
            else if (������1ToolStripMenuItem.Checked == true && ������ToolStripMenuItem.Checked == false)
            {

                ������1ToolStripMenuItem.Text = "������ �1";
                player1.Stop();
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info1 info = new info1();
            info.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about   =     new About();  
            about.ShowDialog();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = (Properties.Resources.INTRO);
            System.Media.SoundPlayer player = new
            System.Media.SoundPlayer(str);
            {
                player.Play(); // can also use soundPlayer.PlaySync()
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Game output = new Game();

            if (textBox1.Text == "")
            {
                MessageBox.Show("������� ���", "���",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               Start start = new Start();
                start.ShowDialog();
               output.Text = "����������� " + this.textBox1.Text ; 
                output.ShowDialog();
                this.Hide();
      this.Close();
            } 
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}