using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newchat2.ClASSES;

namespace newchat2
{
    public partial class CreateChat : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPage.connection);
        private string _name_user;

        public CreateChat(string name_user)
        {
            this._name_user = name_user;
            InitializeComponent();
        }

        private void CreateChat_Load(object sender, EventArgs e)
        {
            name_chat_txt.Enabled = false;
            db.show_users(users_ListBox,_name_user);
        }

        private void create_chat_Click(object sender, EventArgs e)
        {
            if(users_ListBox.SelectedItems.Count>0)
            {
                if (name_chat_txt.Text.Trim(' ') != "")
                {
                    db.create_chat(_name_user, users_ListBox, name_chat_txt.Text.Trim(' '));
                    this.Close();
                }
                else
                    MessageBox.Show("Enter the something the chat name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //users_ListBox.SelectedItems;
            //label1.Text = "";
            //foreach (object element in users_ListBox.SelectedItems)
            //{
            //    label1.Text += element.ToString() + '\n';
            //}

            //db.get_file_name();

            //this.Close();

        }

        private void users_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (users_ListBox.SelectedItems.Count > 1)
            {
                name_chat_txt.Text = "";
                name_chat_txt.Enabled = true;
            }
            else if (users_ListBox.SelectedItems.Count == 1)
            {
                //name_chat_txt.Text = users_ListBox.SelectedItem.ToString();
                name_chat_txt.Text = users_ListBox.SelectedItem.ToString() + "_" + _name_user;
                name_chat_txt.Enabled = false;
            }
            else
            {
                name_chat_txt.Text = "";
                name_chat_txt.Enabled = false;
            }
        }
    }
}
