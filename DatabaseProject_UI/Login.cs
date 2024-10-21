using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string USN = UNtxtbox.Text;
            string PASS = PWtxtbox.Text;

            if (USN == "admin" && PASS == "1234")
            {
                Em_MainMenu childfrm = new Em_MainMenu();
                this.Hide(); // Hide the login form temporarily
                childfrm.ShowDialog(); 
                this.Close(); // Close the login form after the main menu is closed

            }
            else if (USN == "mclim" && PASS == "123")
            {
                Em_MainMenu childfrm = new Em_MainMenu();
                this.Hide();
                childfrm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist or incorrect username or password.");
            }
        }
    }
}
