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
using newchat2.ClASSES;
using System.Net;

namespace newchat2
{
    public partial class MainPage : Form
    {
        //<<<<<<< HEAD
        public static string connection = @"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS1;Integrated Security=True;User ID=aa;Password=1;";  // @"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True";
        //@"Data Source=dbsrv\sql2021;Initial Catalog=chat2.0;Integrated Security=True";//  @"Data Source=dbsrv\sql2021;Initial Catalog=chat2.0;Integrated Security=True";
        //=======
        //public static string connection = @"Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True;User ID=aa";//@"Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True";
        //>>>>>>> fa6ab9932ba1c7586d61958a8bf69de91d9869f2
        //Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True";
        //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS1;Integrated Security=True;User ID=aa;Password=1";
        ConnectionWithDb db = new ConnectionWithDb(connection);
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            regGroupBox.BackColor = Color.Transparent;
            //regGroupBox.
            //regGroupBox.BackColor = .3;
            LoginGroupBox.BackColor = Color.Transparent;

            //LoginGroupBox.BackColor= Color.Transparent;
            //this.Opacity = .3;
            //groupBox1.
            //groupBox1.Opacity = opacity;
            //groupBox1.BackColor = Color.LimeGreen; 
            //groupBox1.TransparencyKey = Color.LimeGreen;
            //label1.Text = 
        }

        private void enter_Click(object sender, EventArgs e)
        {
            db.login_user(this,name.Text,password.Text);
        }

        private void register_Click(object sender, EventArgs e)
        {
            db.insert_user(name_reg.Text, password_reg.Text);
            if (ConnectionWithDb.check_changed_password)
            {
                name_reg.Text = "Name";
                password_reg.PasswordChar = '\0';
                password_reg.Text = "Password";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.PasswordChar = '*';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.PasswordChar = '\0';
                password.Text = "Password";
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Name")
                name.Text = "";
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
                name.Text = "Name";
        }

        private void name_reg_Enter(object sender, EventArgs e)
        {
            if (name_reg.Text == "Name")
                name_reg.Text = "";
        }

        private void name_reg_Leave(object sender, EventArgs e)
        {
            if (name_reg.Text == "")
                name_reg.Text = "Name";
        }

        private void password_reg_Enter(object sender, EventArgs e)
        {
            if(password_reg.Text == "Password" )
            {
                password_reg.Text = "";
                password_reg.PasswordChar = '*';
            }
        }
         
        private void password_reg_Leave(object sender, EventArgs e)
        {
            if (password_reg.Text == "")
            {
                password_reg.PasswordChar ='\0';
                password_reg.Text = "Password";
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enter_Btn.PerformClick();
            }
        }

        private void password_reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register_Btn.PerformClick();
            }
        }
    }
}
