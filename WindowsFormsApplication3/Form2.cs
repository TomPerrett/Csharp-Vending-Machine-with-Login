using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();

        }

        int itemcount = 0;//this is declaring the item count
        double totalcost = 0;//this is declaring the total cost


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.Title = "TITLE";
            savefile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";//this is the file types you can save your file as
            savefile.FileName = "Order.txt";//this is the default name for saving your file

            if (savefile.ShowDialog() == DialogResult.OK)
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(savefile.FileName))
                {

                    file.WriteLine("Your order:");//this applies the heading, your order into the save file
                    file.WriteLine(txtOrder.Text.Substring(0, txtOrder.Text.Length - 2));//this adds your order to your save file

                    file.WriteLine("");
                    file.WriteLine("Amount of items: " + lblNumber.Text);//this adds your number of items to the save file

                    file.WriteLine("");
                    file.WriteLine("Total: " + lblTotal.Text);//this adds your total to your save file


                }

            }
            MessageBox.Show("You have saved your order");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out");
            Application.Restart();//this restarts the program which essentially logs you out as you are taken back to the first form
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtOrder.Text = txtOrder.Text + lblFanta.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox2 = 1;//declaring the price of the item
            totalcost = totalcost + dpictureBox2;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtOrder.Text = txtOrder.Text + lblCocaCola.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox1 = 1;//declaring the price of the item
            totalcost = totalcost + dpictureBox1;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtOrder.Text = txtOrder.Text + lblSprite.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox3 = 1;//declaring the price of the item
            totalcost = totalcost + dpictureBox3;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            txtOrder.Text = txtOrder.Text + lblMarsBar.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox6 = 0.89;//declaring the price of the item
            totalcost = totalcost + dpictureBox6;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            txtOrder.Text = txtOrder.Text + lblGalaxy.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox5 = 0.89;//declaring the price of the item
            totalcost = totalcost + dpictureBox5;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            txtOrder.Text = txtOrder.Text + lblDairyMilk.Text + Environment.NewLine;//this adds your item to the order box
            double dpictureBox4 = 0.89;//declaring the price of the item
            totalcost = totalcost + dpictureBox4;//this is declaring what the new total cost should be
            double dTotal = totalcost;
            lblTotal.Text = Math.Round(dTotal, 2).ToString();//this outputs the price of your new order

            itemcount++;//this adds 1 to the item count
            lblNumber.Text = itemcount.ToString();//this allows you to output the integer number to string

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {//this piece of code puts together essentially your receipt, it states what should be shown on the message box
            MessageBox.Show(("Order:") + Environment.NewLine + txtOrder.Text + Environment.NewLine + ("Number of items: ") + (lblNumber.Text) + Environment.NewLine + ("Total: £") + (lblTotal.Text) + Environment.NewLine + ("You have succesfully purchased your order"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully cleared your order!");
            txtOrder.Text = string.Empty;//this empties the order box
            totalcost = 0;//this declares what the new total cost should be
            itemcount = 0;//this declares what the new item count should be
            lblTotal.Text = totalcost.ToString();//this allows the numbers to be outputted as text
            lblNumber.Text = itemcount.ToString();//this allows the numbers to be outputted as text
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          SaveFileDialog savefile = new SaveFileDialog();//this states the dialog that should be use

            savefile.Title = "TITLE";
            savefile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";//this is the file types you can save your file as
            savefile.FileName = "Order.txt";//this is the default name for saving your file

            if (savefile.ShowDialog() == DialogResult.OK)
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(savefile.FileName))
                {

                    file.WriteLine("Your order:");//this applies the heading, your order into the save file
                    file.WriteLine(txtOrder.Text.Substring(0, txtOrder.Text.Length - 2));//this adds your order to your save file

                    file.WriteLine("");
                    file.WriteLine("Amount of items: " + lblNumber.Text);//this adds your number of items to the save file

                    file.WriteLine("");
                    file.WriteLine("Total: " + lblTotal.Text);//this adds your total to your save file


                }

            }
            MessageBox.Show("You have saved your order");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var countRegEx = new Regex(@"Amount of items: ");
            var costRegEx = new Regex(@"Total: ");
            OpenFileDialog openfile = new OpenFileDialog();//this states the dialog that should be used
            List<string> sLines = new List<string>();

            openfile.Title = "TITLE";
            openfile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";//this shows the file types that can be opened

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                foreach (var i in File.ReadAllLines(openfile.FileName))//this read the file you've opened
               {
                   sLines.Add(i);
               }

                itemcount = sLines.Count();


                foreach (var i in sLines.ToArray())
                {
                    var match = countRegEx.Match(i);
                    if (match.Success)
                    {
                        //itemcount = 
                        
                        int x = i.IndexOf(":");
                        itemcount = Convert.ToInt32(i.Substring(x + 1));
                    }
                    match = costRegEx.Match(i);
                    if (match.Success) 
                    {
                        int y = i.IndexOf("l:");
                        totalcost = Convert.ToDouble(i.Substring(y + 3));
                    }

                }

                txtOrder.Text = "";

                for ( var i = 1; i < itemcount + 1; i++)
                {
                    txtOrder.Text += sLines[i];
                    txtOrder.Text += Environment.NewLine;
                }

                lblTotal.Text = totalcost.ToString();//this outputs your total cost when you load it
                lblNumber.Text = itemcount.ToString();//this outputs your number of items when you load it
            }


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var countRegEx = new Regex(@"Amount of items: ");
            var costRegEx = new Regex(@"Total: ");
            OpenFileDialog openfile = new OpenFileDialog();//this states the dialog that should be used
            List<string> sLines = new List<string>();

            openfile.Title = "TITLE";
            openfile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";//this shows the file types that can be opened

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                foreach (var i in File.ReadAllLines(openfile.FileName))//this read the file you've opened
                {
                    sLines.Add(i);
                }

                itemcount = sLines.Count();


                foreach (var i in sLines.ToArray())
                {
                    var match = countRegEx.Match(i);
                    if (match.Success)
                    {
                        //itemcount = 

                        int x = i.IndexOf(":");
                        itemcount = Convert.ToInt32(i.Substring(x + 1));
                    }
                    match = costRegEx.Match(i);
                    if (match.Success)
                    {
                        int y = i.IndexOf("l:");
                        totalcost = Convert.ToDouble(i.Substring(y + 3));
                    }

                }

                txtOrder.Text = "";

                for (var i = 1; i < itemcount + 1; i++)
                {
                    txtOrder.Text += sLines[i];
                    txtOrder.Text += Environment.NewLine;
                }

                lblTotal.Text = totalcost.ToString();//this outputs your total cost when you load it
                lblNumber.Text = itemcount.ToString();//this outputs your number of items when you load it
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);//this navigates you to the help provider, which navigates you to the help page
        }
    }
}




