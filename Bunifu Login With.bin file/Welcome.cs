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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            timer1.Interval = 100;
            Dropdown.AddItem("Apple");
            Dropdown.AddItem("Normal companies");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private string username;

        public string getusername
        {
            get { return username; }
            set { username = value; }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            PanelHome.Visible = false;
            lbluser.Text = username;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            PanelHome.Visible = true;
            panelUsers.Visible = false;
        }

        private void Dropdown_TabIndexChanged(object sender, EventArgs e)
        {
            if (Dropdown.selectedIndex == 0)
            {
                bunifuiOSSwitch2.Value = true;
                bunifuiOSSwitch1.Value = true;
            }
            else if (Dropdown.selectedIndex == 1)
            {
                bunifuiOSSwitch2.Value = false;
                bunifuiOSSwitch1.Value = false;
            }
        }
    }
}
