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
    public partial class BBS : Form
    {
        
        public BBS()
        {
           
            InitializeComponent();

        }

        private void BBS_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings1.Default.pc.Contains("пока нет") && !Properties.Settings1.Default.flash.Contains("пока нет") && !Properties.Settings1.Default.hard.Contains("пока нет") && !Properties.Settings1.Default.modem.Contains("пока нет"))
            {
                label1.Text = "Для работы вам нужен комп-\r\nпамять. винчестер и модем";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.pc == "пока нет" && Properties.Settings1.Default.flash == "пока нет" && Properties.Settings1.Default.hard == "пока нет" && Properties.Settings1.Default.modem == "пока нет")
            {
                MessageBox.Show("У вас нет ни одного из этих предметов");
            }
            else
            {
                Properties.Settings1.Default.bbs = textBox1.Text;
                MessageBox.Show("Успешно создано", "Внимание",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Properties.Settings1.Default.bbs== "пока нет")
            {
                MessageBox.Show("Нету BBS","Внимание",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else { 
            Conect conect = new Conect();
            conect.ShowDialog();
            }
        }
    }
}
