using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
namespace COMP_MAN
{
    public partial class Job : Form
    {
        private Game _game;
        public Job(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=Gg4RxjR_CiQ&ab") { UseShellExecute = true });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.job = "Дворник";
            Properties.Settings1.Default.salary = 10;
            _game.label22.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + "в день";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.point >= 15)
            {
                button2.Enabled = true;
                Properties.Settings1.Default.job = "Грузчик";
                Properties.Settings1.Default.salary = 20;
                _game.label22.Text = Properties.Settings1.Default.job + "/" + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            }
            else if (Properties.Settings1.Default.point < 15)
            {
                button2.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Job_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.point < 15)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            button3.Enabled = false;
            button4.Enabled = false;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.point >= 60)
            {
                button5.Enabled = true;
                Properties.Settings1.Default.job = "Хакер";
                Properties.Settings1.Default.salary = 250;
                _game.label22.Text = Properties.Settings1.Default.job + " / " + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            }
            else if (Properties.Settings1.Default.point < 50)
            {
                button5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.point >= 30)
            {
                button5.Enabled = true;
                Properties.Settings1.Default.job = "Програмист";
                Properties.Settings1.Default.salary = 50;
                _game.label22.Text = Properties.Settings1.Default.job + " / " + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            }
            else if (Properties.Settings1.Default.point < 30)
            {
                button5.Enabled = false;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.point >= 40)
            {
                button4.Enabled = true;
                Properties.Settings1.Default.job = "Сис-Админ";
                Properties.Settings1.Default.salary = 100;
                _game.label22.Text = Properties.Settings1.Default.job + " / " + Convert.ToString(Properties.Settings1.Default.salary) + " в день";
            }
            else if (Properties.Settings1.Default.point < 40)
            {
                button4.Enabled = false;
            }
        }
    }
}
    

