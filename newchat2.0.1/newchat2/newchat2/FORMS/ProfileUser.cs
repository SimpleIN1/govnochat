using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace newchat2
{
    public partial class ProfileUser : Form
    {
        private string _name_user;
        public ProfileUser(string name_user)
        {
            InitializeComponent();
            this._name_user = name_user;
        }

        private void ProfileUser_Load(object sender, EventArgs e)
        {
            this.Text = _name_user;
        }

        private void ProfileUser_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
