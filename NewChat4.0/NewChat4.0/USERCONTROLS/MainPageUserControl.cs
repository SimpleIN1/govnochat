using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewChat4._0
{
    public partial class MainPageUserControl : UserControl
    {
        public static string connection = @"Data Source=DESKTOP-CAV5533\SQLEXPRESS;Initial Catalog=Chat;Integrated Security=True";
        public MainPageUserControl(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }
        Panel panel;
        MainPageUserControlDbClass ControlDbClass = new MainPageUserControlDbClass(connection);


        private void MainPageUserControl_Load(object sender, EventArgs e)
        {
            regGroupBox.BackColor = Color.Transparent;
            LoginGroupBox.BackColor = Color.Transparent;
        }

        private void registerButton_Click(object sender, EventArgs e)
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
                if (ControlDbClass.InsertUser(nameRegTextBox.Text, passwordRegTextBox.Text))
                {
                    nameRegTextBox.Text = "Name";
                    passwordRegTextBox.PasswordChar = '\0';
                    passwordRegTextBox.Text = "Password";
                    MessageBox.Show("You are registering", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MainPageUserControlDbClass.CheckError)
                    { MessageBox.Show("User exists with this nickname", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); MainPageUserControlDbClass.CheckError = false; }
                    else
                        MessageBox.Show("Trouble with connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void enterLogButton_Click(object sender, EventArgs e)
        {
            if (ControlDbClass.LogInUser(nameLogTextBox.Text, passwordLogTextBox.Text))
            {
                //this.Visible = false;
                panel.Controls.Clear();
                ControlDbClass.UpdateStatusUser(nameLogTextBox.Text,true);
                panel.Controls.Add(new ChatFormUserControl(nameLogTextBox.Text.Trim(),panel));

            }
            else
            {
                if (MainPageUserControlDbClass.CheckError)
                { MessageBox.Show("wrong a name and password", "Error logIn", MessageBoxButtons.OK, MessageBoxIcon.Warning); MainPageUserControlDbClass.CheckError = false; }
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

        private void nameRegTextBox_Leave(object sender, EventArgs e)
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
                enterLogButton.PerformClick();
            }
        }

        private void passwordRegTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerButton.PerformClick();
            }
        }
    }
}
