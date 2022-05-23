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
        private int _IdChat;
        int CountW = 0;
        private int _CountSecond = 0;
        private Dictionary<int, string> _ChatsKeyValuePairs = new Dictionary<int, string>();
        private static int _CountWritten = 0;
        private string _NameChat;
        private string SelectedFriend = null;

        private int _CountUserFriends = 0;

        Panel panel;

        ChatFormUserControlDbClass ControlDbClass = new ChatFormUserControlDbClass(MainPageUserControl.connection);

        private List<string> _AllUser = new List<string>();
        private List<string> _friends = new List<string>();
        private List<string> _FriendsDelete = new List<string>();
        private List<int> _KeyChats = new List<int>();
        private List<string> _MessagesList = new List<string>();
        private bool CheckMessage = false;


        public ChatFormUserControl(string NameUser, Panel panel)
        {
            this._NameUser = NameUser;
            InitializeComponent();
            this.panel = panel;
        }

            
        private void ChatFormUserControl_Load(object sender, EventArgs e)
        {
            UpdateUserListToolTip.SetToolTip(FriendsListBox, "Double cliking on the listbox updates the contents of the listbox");
            DeleteUserButton.Visible = false; IntervledShowChats();
            SendButton.Enabled = false;
            //db.UpdateStatusUser(_NameUser, true);
        }

        private void IntervledShowChats()
        {
            ControlDbClass.ShowChats(_ChatsKeyValuePairs, _NameUser);
            foreach (var element in _ChatsKeyValuePairs)
            {
                if (!_KeyChats.Contains(element.Key))
                {
                    _KeyChats.Add(element.Key);
                    ChatToolStripComboBox.Items.Add(element.Value);
                }
            }
        }

        private void LoadMessages()
        {
            CountW = _CountWritten;
            if (ControlDbClass.ShowMessages(_IdChat, _MessagesList, ref _CountWritten))
                while (CountW < _CountWritten)
                {
                    MessagesListBox.Items.Add(_MessagesList[CountW++]);
                    if (CheckMessage)
                    {
                        CheckMessage = false;
                        MessagesListBox.SelectedIndex = MessagesListBox.Items.Count - 1;
                    }

                }
            else
                MessageBox.Show("Read is not successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void SearchAllUser(string LoginUser)
        {
            _AllUser.Clear();
            if (ControlDbClass.SearchUsersAll(_AllUser, LoginUser))
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
                if (ControlDbClass.CheckStatusDeleteUser(SelectedFriend))
                {
                    ChatFormTabControl.SelectTab(ProfileTabPage);
                    _CountUserFriends = 0;
                    _friends.Clear();
                    FriendsListBox.Items.Clear();
                    LoadInformationProfile(SelectedFriend);
                    FillFriendsListBox(SelectedFriend);
                    CheckClearFriendsListBox(SelectedFriend);

                    if (ControlDbClass.CheckIsFriend(_NameUser,SelectedFriend))
                        DeleteUserButton.Visible = true;
                    else
                        DeleteUserButton.Visible = false;
                }
                else
                    MessageBox.Show("User is deleted");
            }
        }

        private void BackPageToolStripButton_Click(object sender, EventArgs e)
        {
            AddFriendsButton.Visible = false;
            DeleteUserButton.Visible = false;
            LoadInformationProfile(_NameUser);
        }


        private void LoadInformationProfile(string NameUser)
        {
            UsersClass users = new UsersClass();
            users.login = NameUser;

            AddFriendsButton.Visible = (_NameUser != NameUser ? true : false);

            if (ControlDbClass.ShowProfileUser(users))
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
            MainPageUserControl.CheckStatusEnterExitUser(false);
            panel.Controls.Add(new MainPageUserControl(panel));
        }

        private void AddFriendsButton_Click(object sender, EventArgs e)
        {
            if (SelectedFriend != null)
                if (ControlDbClass.AddFriendUser(_NameUser, SelectedFriend))
                {
                    MessageBox.Show("User is added is successfull");
                    DeleteUserButton.Visible = true;
                }
                else
                    MessageBox.Show("User is have adding yet");
            else
                MessageBox.Show("You have to choose the friend");
        }

        private void UpdateProfileInfToolStripButton2_Click(object sender, EventArgs e)
        {
            LoadInformationProfile(UserNameLabel.Text);
        }


        //add
        private void FillFriendsListBox(string NameUser)
        {
            if (ControlDbClass.ShowListFriends(_friends, NameUser))
                while (_CountUserFriends < _friends.Count)
                    FriendsListBox.Items.Add(_friends[_CountUserFriends++]);
        }

        private void FriendsListBox_DoubleClick(object sender, EventArgs e)
        {
            FillFriendsListBox(UserNameLabel.Text);
            CheckClearFriendsListBox(UserNameLabel.Text);

        }
        //dell
        private void CheckClearFriendsListBox(string NameUser)
        {
            //MessageBox.Show(string.Join(",", _FriendsDelete.Select(x => x.ToString()).ToArray()));
            if (_friends.Count > 0 && ControlDbClass.ShowListFriendsDelete(_friends,_FriendsDelete, NameUser))
            {
                if (_FriendsDelete.Count > 0)
                {
                    ClearFriendsListBox();
                    _FriendsDelete.Clear();
                }
            }
        }

        private void ClearFriendsListBox()
        {
            foreach (object item in _FriendsDelete)
            {
                //MessageBox.Show(item.ToString());
                int index;
                if ((index = _friends.FindIndex(p => p.ToString() == item.ToString())) > -1)
                {
                    //MessageBox.Show(item.ToString());
                    _friends.RemoveAt(index);
                    FriendsListBox.Items.RemoveAt(index);
                    --_CountUserFriends;
                }
            }
            
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (ControlDbClass.CheckIsFriend(_NameUser, SelectedFriend))
            {
                DeleteUserButton.Visible = false;
                if(ControlDbClass.DeleteFriend(_NameUser, SelectedFriend))
                    MessageBox.Show("Friend is delete");
                else
                    MessageBox.Show("Mistake when delete");
            }
        }

        private void FriendsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FriendsListBox.IndexFromPoint(e.Location) != System.Windows.Forms.ListBox.NoMatches)
            {
                SelectedFriend = FriendsListBox.SelectedItem.ToString().Split(' ')[0];
                if (ControlDbClass.CheckStatusDeleteUser(SelectedFriend))
                {
                    //ChatFormTabControl.SelectTab(ProfileTabPage);
                    _CountUserFriends = 0;
                    _friends.Clear();
                    FriendsListBox.Items.Clear();
                    LoadInformationProfile(SelectedFriend);
                    FillFriendsListBox(SelectedFriend);
                    CheckClearFriendsListBox(SelectedFriend);

                    if (ControlDbClass.CheckIsFriend(_NameUser, SelectedFriend))
                        DeleteUserButton.Visible = true;
                    else
                        DeleteUserButton.Visible = false;
                }
                else
                    MessageBox.Show("User is deleted");
            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_NameUser == UserNameLabel.Text)
            {
                panel.Controls.Clear();
                panel.Controls.Add(new EditProfileUserControl(_NameUser, panel));
            }
        }


        private void ChatFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ChatFormTabControl.SelectedIndex == 0)
            {
                DeleteUserButton.Visible = false;
            }
            if (ChatFormTabControl.SelectedIndex == 1)
            {
                LoadInformationProfile(_NameUser);
                if (_NameUser == UserNameLabel.Text)
                {
                    
                    FillFriendsListBox(_NameUser);
                    //MessageBox.Show("sss");
                    CheckClearFriendsListBox(_NameUser);
                }
                    
            }
            if (ChatFormTabControl.SelectedIndex == 2)
            {
                SearchAllUser("");
                DeleteUserButton.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_IdChat > -1)
            {
                LoadMessages();
            }
            if (_CountSecond++ > 10)
            {
                _CountSecond = 0;
                IntervledShowChats();
            }
        }

        private void LoadImage(byte[] ArrImage)
        {
            if ((ArrImage = ControlDbClass.ShowImageChat(_IdChat)) != null)
            {
                MemoryStream streamImg = new MemoryStream(ArrImage);
                toolStripButton1.Image = Image.FromStream(streamImg);
            }
            else
                toolStripButton1.Image = null;
        }

        private void editChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel.Controls.Clear();
            //panel.Controls.Add(new EditChatUserControl(_NameUser, _IdChat, _NameChat, panel));

            if (_IdChat >= 0)
            {
                panel.Controls.Clear();
                panel.Controls.Add(new EditChatUserControl(_NameUser, _IdChat, _NameChat, panel));
                //editChatForm.Show();
            }
            else
            {
                MessageBox.Show("Choose the something chat", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileTabPage_Click(object sender, EventArgs e)
        {

        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton.PerformClick();
            }
        }

        private void ChatToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChatToolStripComboBox.SelectedItem != null)
            {
                SendButton.Enabled = true;
                MessagesListBox.Items.Clear();
                _MessagesList.Clear();
                _CountWritten = 0;
                _NameChat = ChatToolStripComboBox.SelectedItem.ToString();
                _IdChat = _ChatsKeyValuePairs.ElementAt(ChatToolStripComboBox.SelectedIndex).Key;
                byte[] ArrImage = null;
                LoadImage(ArrImage);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Trim() != "" && ControlDbClass.InsertMessage(_NameUser, _IdChat, MessageTextBox.Text.Trim()))
            {
                //MessagesListBox.Items.Add(DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString() + " "+_NameUser+" -> "+MessageTextBox.Text);
                //MessagesListBox.SelectedIndex = MessagesListBox.Items.Count - 1;
                //++_CountWritten;
                CheckMessage = true;
            }
            else
                MessageBox.Show("The message was not sent successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new CreateChatUserControl(_NameUser,panel));
        }
    }
}
