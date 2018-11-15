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
    public partial class Form1 : Form
    {
        //Declaring Variables
        int click = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            string user = bunifuMaterialTextbox1.Text;
            string pass = bunifuMaterialTextbox2.Text;
            if (login.login(user, pass) == "true")
            {
                Welcome wel = new Welcome();
                MessageBox.Show("Welcome " + user);
                wel.getusername = user;
                wel.Show();
                this.Hide();
            }
            else if (login.login(user, pass) == "false")
            {
                MessageBox.Show("Invalid Username or password", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
               );
            }
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            click++;
            if (click == 1)
            {
                bunifuMaterialTextbox1.Visible = false;
                bunifuMaterialTextbox2.Visible = false;
                bunifuMaterialTextbox3.Visible = true;
                bunifuMaterialTextbox4.Visible = true;
                bunifuThinButton21.Visible = false;
                bunifuThinButton22.Visible = true;
                click--;
            }
            else if(click == 0)
            {
                bunifuMaterialTextbox1.Visible = true;
                bunifuMaterialTextbox2.Visible = true;
                bunifuMaterialTextbox3.Visible = false;
                bunifuMaterialTextbox4.Visible = false;
                bunifuThinButton22.Visible = false;
                bunifuThinButton21.Visible = true;
            }
            click = 0;
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                bunifuMaterialTextbox1.Visible = true;
                bunifuMaterialTextbox2.Visible = true;
                bunifuMaterialTextbox3.Visible = false;
                bunifuMaterialTextbox4.Visible = false;
                bunifuThinButton22.Visible = false;
                bunifuThinButton21.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox1.Visible = false;
                bunifuMaterialTextbox2.Visible = false;
                bunifuMaterialTextbox3.Visible = true;
                bunifuMaterialTextbox4.Visible = true;
                bunifuThinButton21.Visible = false;
                bunifuThinButton22.Visible = true;
            }
        }

        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                bunifuMaterialTextbox1.Visible = true;
                bunifuMaterialTextbox2.Visible = true;
                bunifuMaterialTextbox3.Visible = false;
                bunifuMaterialTextbox4.Visible = false;
                bunifuThinButton22.Visible = false;
                bunifuThinButton21.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox1.Visible = false;
                bunifuMaterialTextbox2.Visible = false;
                bunifuMaterialTextbox3.Visible = true;
                bunifuMaterialTextbox4.Visible = true;
                bunifuThinButton21.Visible = false;
                bunifuThinButton22.Visible = true;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Login create = new Login();
            string username = bunifuMaterialTextbox3.Text;
            string password = bunifuMaterialTextbox4.Text;
            if (create.validation(username, password) == "true")
            {
                MessageBox.Show("Account created!");
            }
            else if (create.validation(username, password) == "alreadacc")
            {
                MessageBox.Show("Already Account with the username" + username, "Error - Already account with that username",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show("Invalid Username or password", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Idkausername", "Credits",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand
                );
        }
    }
}
