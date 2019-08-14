using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        const username As string = "guest";
    Const password As String = "secret";
        string sUsername = "Tom";//states what the username is
        string sPassword = "Perrett";//states what the password going with the username is
        int iCount = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUsernamecheck = txtUsername.Text;
            string sPasswordcheck = txtPassword.Text;

            if (iCount < 3)//showing how many attempts you have to login, 3
            {
                if (sUsername == sUsernamecheck && sPassword == sPasswordcheck)
                {
                    MessageBox.Show("You Have Logged In Correctly");//if you have got your details correct you will be logged in
                }
                else
                {
                    MessageBox.Show("You havent got your login details correct");//if not you will receive an error message and +1 to the iCount
                    iCount++;
                }
            }

        }
    }
}
