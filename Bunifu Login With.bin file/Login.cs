using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bunifu_Login_With.bin_file
{
    class Login
    {
        //Declaring Variables Start
        List<string> data = new List<string>();
        private string username;
        private string password;
        string passgood = "";
        int passwordmade = 0;
        string usergood = "";
        string accountcreated;
        string validlogin = "false";
        //Declaring Variables End

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string usercheck
        {
            get { return usergood; }
        }

        public string passcheck
        {
            get { return passgood; }
        }

        public string passwordadd(string password)
        {
            int passlength = password.Length;
            int validationint = 0;
            if (passlength > 5 && passlength < 14)
            {
                validationint++;
            }
            foreach (char var in password)
            {
                if (var.ToString() == char.ToUpper(var).ToString())
                {
                    validationint++;
                }
                if (var.ToString() == char.IsDigit(var).ToString())
                {
                    validationint++;
                }
            }
            if (validationint >= 3)
            {
                passwordmade++;
                passgood = "good";
                return "good";
            }
            else
            {
                passgood = "Error";
                return "Error";
            }
        }

        public string usernameadd(string username)
        {
            int userlength = username.Length;
            if (userlength > 0)
            {
                usergood = "good";
                return "good";
            }
            else
            {
                usergood = "Error";
                return "Error";
            }

        }

        public string validation(string username, string password)
        {
            string registered = "false";
            int userlength = username.Length;
            if (userlength > 0)
            {
                data.Add(username);
                usergood = "good";
            }
            else
            {
                usergood = "Error";
            }

            string alreadacc = "false";
            FileStream fileStream = File.OpenRead("../../Data/users.bin");
            BinaryReader binaryReader = new BinaryReader(fileStream);
            while (binaryReader.PeekChar() != -1)
            {
                string userbin = binaryReader.ReadString();

                if ((userbin == username))
                {
                    alreadacc = "true";
                    return alreadacc;
                }
            }
            binaryReader.Close();

            int passlength = password.Length;
            int validationint = 0;
            if (passlength > 5 && passlength < 14)
            {
                validationint++;
            }
            foreach (char var in password)
            {
                if (var.ToString() == char.ToUpper(var).ToString())
                {
                    validationint++;
                }
                if (var.ToString() == char.IsDigit(var).ToString())
                {
                    validationint++;
                }
            }
            if (validationint >= 3)
            {
                passwordmade++;
                passgood = "good";
            }
            else
            {
                passgood = "Error";
            }

            if ((usergood == "good") && (passgood == "good"))
            {
                if (register(username, password) == "true")
                {
                    registered = "true";
                }
            }
            return registered;
        }

        public string register(string username, string password)
        {
            FileStream fileStream = new FileStream("../../Data/users.bin", FileMode.Append);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            {
                binaryWriter.Write(username);
                binaryWriter.Write(password);
                accountcreated = "true";
            }
            binaryWriter.Close();
            return accountcreated;
        }

        public string login(string username, string password)
        {
            FileStream fileStream = File.OpenRead("../../Data" +
                "/users.bin");
            BinaryReader binaryReader = new BinaryReader(fileStream);
            while (binaryReader.PeekChar() != -1)
            {
                string userbin = binaryReader.ReadString();
                string passbin = binaryReader.ReadString();

                if ((userbin == username) && (passbin == password))
                {
                    validlogin = "true";
                }
            }
            return validlogin;
        }
    }
}
