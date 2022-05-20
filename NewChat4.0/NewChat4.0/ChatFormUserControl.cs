using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewChat4._0
{
    public partial class ChatFormUserControl : UserControl
    {
        private string _NameUser;

        Panel panel;

        ChatFormUserControlDbClass controlDbClass = new ChatFormUserControlDbClass(MainPageUserControl.connection);

        private List<string> _AllUser = new List<string>();
        private string SelectedFriend = null;

        public ChatFormUserControl(string NameUser, Panel panel)
        {
            this._NameUser = NameUser;
            InitializeComponent();
            this.panel = panel;
        }

            
        private void ChatFormUserControl_Load(object sender, EventArgs e)
        {

        }


        private void SearchAllUser(string LoginUser)
        {
            _AllUser.Clear();
            if (controlDbClass.SearchUsersAll(_AllUser, LoginUser))
            {
                if (_AllUser.Count > 0)
                {
                    AllUserListBox.Items.Clear();
                    foreach (object item in _AllUser)
                        AllUserListBox.Items.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("Need the enter or conntents");
            }
        }

        private void SearchLoginUserButton_Click(object sender, EventArgs e)
        {
            SearchAllUser(LoginUserSearchTextBox.Text.Trim());
        }

        private void LoginUserSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ChatFormTabControl.SelectedIndex == 2)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchLoginUserButton.PerformClick();
                }
            }
        }

        private void AllUserListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AllUserListBox.IndexFromPoint(e.Location) != System.Windows.Forms.ListBox.NoMatches)
            {
                SelectedFriend = AllUserListBox.SelectedItem.ToString().Split(' ')[0];

                if (_NameUser != SelectedFriend)
                    AddFriendsButton.Visible = true;

                ChatFormTabControl.SelectTab(ProfileTabPage);
                LoadInformationProfile(SelectedFriend);
            }
        }

        private void BackPageToolStripButton_Click(object sender, EventArgs e)
        {
            AddFriendsButton.Visible = false;
            LoadInformationProfile(_NameUser);
        }


        private void LoadInformationProfile(string NameUser)
        {
            UsersClass users = new UsersClass();
            users.login = NameUser;
            if (controlDbClass.ShowProfileUser(users))
            {
                StatusLabel.Text = (users.status ? "Online" : "Not online");
                UserNameLabel.Text = users.login;
                if (users.image != null)
                {
                    MemoryStream streamImg = new MemoryStream(users.image);
                    ImagePictureBox.Image = Image.FromStream(streamImg);
                }
            }
            else
            {
                MessageBox.Show("Loading is not successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            MainPageUserControlDbClass.UpdateStatusUser(_NameUser, false);
            panel.Controls.Add(new MainPageUserControl(panel));
        }

        private void AddFriendsButton_Click(object sender, EventArgs e)
        {
            if (SelectedFriend != null)
                if (controlDbClass.AddFriendUser(_NameUser, SelectedFriend))
                    MessageBox.Show("User is added is successfull");
                else
                    MessageBox.Show("User is have adding yet");
            else
                MessageBox.Show("You have to choose the friend");
        }




        private void ChatFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChatFormTabControl.SelectedIndex == 1)
            {
                LoadInformationProfile(_NameUser);
            }
            if (ChatFormTabControl.SelectedIndex == 2)
            {
                SearchAllUser("");
            }
        }


    }
}
