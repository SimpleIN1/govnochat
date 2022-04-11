using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace NewChat3
{
    public partial class MainPageForm : Form
    {
        //<<<<<<< HEAD
        public static string connection = @"Data Source=dbsrv\sql2021;Initial Catalog=chat2.0;Integrated Security=True";//@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True"; 
        //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS1;Integrated Security=True;User ID=aa;Password=1;";  //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True";
        //@"Data Source=dbsrv\sql2021;Initial Catalog=chat2.0;Integrated Security=True";//  @"Data Source=dbsrv\sql2021;Initial Catalog=chat2.0;Integrated Security=True";
        //=======
        //public static string connection = @"Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True;User ID=aa";//@"Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True";
        //>>>>>>> fa6ab9932ba1c7586d61958a8bf69de91d9869f2
        //Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True";
        //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS1;Integrated Security=True;User ID=aa;Password=1";
        ConnectionWithDb db = new ConnectionWithDb(connection);
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            regGroupBox.BackColor = Color.Transparent;
            LoginGroupBox.BackColor = Color.Transparent;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (nameRegTextBox.Text.IndexOf(' ') >= 0 || passwordRegTextBox.Text.IndexOf(' ') >= 0 || nameRegTextBox.Text == "Name" || passwordRegTextBox.Text == "Password")
            {
                nameRegTextBox.Text = "Name";
                passwordRegTextBox.PasswordChar = '\0';
                passwordRegTextBox.Text = "Password";
                MessageBox.Show("Incorrect nickname or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (db.InsertUser(nameRegTextBox.Text, passwordRegTextBox.Text))
                {
                    nameRegTextBox.Text = "Name";
                    passwordRegTextBox.PasswordChar = '\0';
                    passwordRegTextBox.Text = "Password";
                    MessageBox.Show("You are registering", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ConnectionWithDb.checkError)
                    { MessageBox.Show("User exists with this nickname", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ConnectionWithDb.checkError = false; }
                    else
                        MessageBox.Show("Trouble with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (db.LogInUser(nameLogTextBox.Text, passwordLogTextBox.Text))
            {
                this.Visible = false;
                ChatForm chatForm = new ChatForm(nameLogTextBox.Text);
                chatForm.Show();
            }
            else
            {
                if (ConnectionWithDb.checkError)
                { MessageBox.Show("wrong a name and password", "Error logIn", MessageBoxButtons.OK, MessageBoxIcon.Warning); ConnectionWithDb.checkError = false; }
                else
                    MessageBox.Show("Trouble with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameLogTextBox_Enter(object sender, EventArgs e)
        {
            if (nameLogTextBox.Text == "Name")
                nameLogTextBox.Text = "";
        }

        private void nameLogTextBox_Leave(object sender, EventArgs e)
        {
            if (nameLogTextBox.Text == "")
                nameLogTextBox.Text = "Name";
        }

        private void passwordLogTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordLogTextBox.Text == "Password")
            {
                passwordLogTextBox.Text = "";
                passwordLogTextBox.PasswordChar = '*';
            }
        }

        private void passwordLogTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordLogTextBox.Text == "")
            {
                passwordLogTextBox.PasswordChar = '\0';
                passwordLogTextBox.Text = "Password";
            }
        }

        private void nameRegTextBox_Enter(object sender, EventArgs e)
        {
            if (nameRegTextBox.Text == "Name")
                nameRegTextBox.Text = "";
        }

        private void nameRegTextBoxLeave(object sender, EventArgs e)
        {
            if (nameRegTextBox.Text == "")
                nameRegTextBox.Text = "Name";
        }

        private void passwordRegTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordRegTextBox.Text == "Password")
            {
                passwordRegTextBox.Text = "";
                passwordRegTextBox.PasswordChar = '*';
            }
        }
        private void passwordRegTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordRegTextBox.Text == "")
            {
                passwordRegTextBox.PasswordChar = '\0';
                passwordRegTextBox.Text = "Password";
            }
        }

        private void passwordLogTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterLogBtn.PerformClick();
            }
        }

        private void passwordRegTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerBtn.PerformClick();
            }
        }
    }
}
