using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_Login_With.bin_file
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Interval = 700;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progressbar.Value += 10;

            if (Progressbar.Value != 100)
            {
                Progressbar.Value += 5;
            }
            if (Progressbar.Value >= 100)
            {
                timer1.Stop();
                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }
    }
}
