using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        string sUsername = "Tom";//this is my username for the login system
        string sPassword = "Perrett";//this is my password for the login system
        int iCount = 0;//this is the starting for my iCount

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)//this is my log in button
        {
            verify();//this allows you to hit the enter key on the keyboard to log in
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)//this is the text box for my password
        {
            if (e.KeyChar == (char)13)//this is selecting the key on the keyboard which you can press instead of log in
            {
                verify();
            }
        }

        public void verify()
        {
            string sUsernameCheck = txtUsername.Text;//this checks my username
            string sPasswordCheck = txtPassword.Text;//this checks my password
            if (iCount < 3)//this allows you to still attempt to log in if you have tried less than 3 times

                if (sUsername == sUsernameCheck && sPassword == sPasswordCheck)//if all of your credentials are correct you are able to log in
                {
                    MessageBox.Show("Login successful!");
                    Form2 nextform = new Form2();//this starts up the next form(the vending machine iteself)
                    nextform.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Try again!");
                    iCount++;//adds one to the iCount
                }
            else
            {
                MessageBox.Show("You Have Been Locked Out!");
                this.Close();//this closes the program when you have exceeded your login attempts
            }
        }

    }
}
