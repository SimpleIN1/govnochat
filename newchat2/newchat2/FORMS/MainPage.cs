﻿using System;
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
        public static string connection = @"Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True";
        //Data Source=dbsrv\sql2021;Initial Catalog=903a1_Serbinovich_GS;Integrated Security=True //@"Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True";
        //Data Source=DESKTOP-H4QAP6P;Initial Catalog=TOWORKWITHCS;Integrated Security=True
        ConnectionWithDb db = new ConnectionWithDb(connection);
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

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

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
