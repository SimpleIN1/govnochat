﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewChat3
{
    public partial class EditChatForm : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        List<string> users = new List<string>();
        List<string> SelectedUserList = new List<string>();
        List<string> _UsersChat = new List<string>();
        private List<string> _UsersChatListDelete = new List<string>();
        private List<string> _AllUsersListDelete = new List<string>();
        private int _IdChat;
        private string _NameUser;
        private string _NameChat;
        private int _CountUserChat=0, _CountUser=0;
        byte[] ImageArr = null;
        public EditChatForm(string NameUser, int IdChat, string NameChat)
        {
            InitializeComponent();
            this._IdChat = IdChat;
            this._NameUser = NameUser;
            this._NameChat = NameChat;
        }

        private void AddSelectedUserList(List<string> SelectedUserList)
        {
            foreach (object item in AllUsersListBox.SelectedItems)
                SelectedUserList.Add(item.ToString());
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            SelectedUserList.Clear();
            AddSelectedUserList(SelectedUserList);
            if (db.AddUserChat(SelectedUserList, _NameUser, _IdChat))
            {
                MessageBox.Show("User is added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Person have added yet", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetItemList(ListBox l,ref bool check)
        {
            check = (l.SelectedItem.ToString().Trim() == _NameUser ? true:false);
            string item = l.SelectedItem.ToString();
            _UsersChat.RemoveAt(l.SelectedIndex);
            ParticipantsListBox.Items.RemoveAt(l.SelectedIndex);
            --_CountUserChat;
            return item;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool CheckUserInList = false;
            if (db.ShowDeleteUserChat(ParticipantsListBox.SelectedItem.ToString(), _IdChat, _NameUser))
            {
                if (CheckAdmin())
                {

                }
                else if (db.DeleteUserChat(GetItemList(ParticipantsListBox, ref CheckUserInList), _IdChat, _NameUser))
                {
                    MessageBox.Show("user(s) is removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //MessageBox.Show(string.Join(",", UsersChat.Select(x => x.ToString()).ToArray()));//list
                    //ParticipantsListBox.Items.RemoveAt(l.SelectedIndex);
                    if (CheckUserInList)
                        this.Close();
                }
            }
            else
                MessageBox.Show("You can not delete the user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string errorStr=null;
            if (NameChatTextBox.Text.Trim()!="" && db.UpdateChatImageName(ImageArr, NameChatTextBox.Text, _IdChat,ref errorStr))
            {
                MessageBox.Show("Chat is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Chat was not update successfully\n"+errorStr, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ImagePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Bitmap img = new Bitmap(image, ImagePictureBox.Width, ImagePictureBox.Height);
                    ImagePictureBox.Image = img;
                    ImageConverter imageConverter = new ImageConverter();
                    ImageArr = (byte[])imageConverter.ConvertTo(ImagePictureBox.Image, typeof(byte[]));
                }
            }
        }

        private void DeleteUserChat()
        {
            foreach (object item in _UsersChatListDelete)
            {
                //MessageBox.Show(_UsersChatList.FindIndex(p => p.ToString() == item.ToString()).ToString());
                int index;
                if ((index = _UsersChat.FindIndex(p => p.ToString() == item.ToString())) > -1)
                {
                    _UsersChat.RemoveAt(index);
                    ParticipantsListBox.Items.RemoveAt(index);
                    --_CountUserChat;
                }
            }
        }

        private void LoadUsersPart()
        {
            if (_UsersChat.Count > 0 && db.ShowUsersDeleteChat(_UsersChat, _UsersChatListDelete, _IdChat))
            {
                if (_UsersChatListDelete.Count > 0)
                {
                    DeleteUserChat();
                    _UsersChatListDelete.Clear();
                }
            }

            if (db.ShowUsersChat1(_UsersChat,_IdChat,""))
            {
                //MessageBox.Show(string.Join(",", UsersChat.Select(x => x.ToString()).ToArray()));//list
                FullChatParticipantListBox();
            }
            else
            {
                MessageBox.Show("error in show users", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FullChatParticipantListBox()
        {
            while (_CountUserChat < _UsersChat.Count)
            {
                ParticipantsListBox.Items.Add(_UsersChat[_CountUserChat++]);
            }
        }

        private void DeleteAllUsers()
        {
            foreach (object item in _AllUsersListDelete)
            {
                //MessageBox.Show(_UsersChatList.FindIndex(p => p.ToString() == item.ToString()).ToString());
                int index;
                if ((index = users.FindIndex(p => p.ToString() == item.ToString())) > -1)
                {
                    users.RemoveAt(index);
                    AllUsersListBox.Items.RemoveAt(index);
                    --_CountUser;
                }
            }
        }

        private void LoadUsersAll()
        {
            if (users.Count > 0 && db.ShowAllUsersDelete(users, _AllUsersListDelete))//rewrite this function+++
            {
                //MessageBox.Show(string.Join(",",_UserChatListDelete.Select(x =>x.ToString()).ToArray()));
                if (_AllUsersListDelete.Count > 0)
                {
                    DeleteAllUsers();
                    _AllUsersListDelete.Clear();
                }
            }


            if (db.ShowUsers1(users, _NameUser))
            {
                FullAllUsersListBox();
            }
            else
            {
                MessageBox.Show("error in show users", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FullAllUsersListBox()
        {
            while (_CountUser < users.Count)
            {
                AllUsersListBox.Items.Add(users[_CountUser++]);
            }
        }

        private void ParticipantsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadUsersPart();
        }

        private void AllUsersListBox_DoubleClick(object sender, EventArgs e)
        {
            LoadUsersAll();
        }

        private bool CheckAdmin()
        {
            if (db.CheckAdminChat(_NameUser, _IdChat))
            {
                //MessageBox.Show("Success");
                ChooseAdminForm chooseAdminForm = new ChooseAdminForm(_IdChat, _NameUser);
                chooseAdminForm.Show();
                this.Visible = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LeaveTheChatButton_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure want to exit from chat?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                if (CheckAdmin())
                {
                    MessageBox.Show("Success");
                }
                else if (db.DeleteUserChat(_NameUser, _IdChat, _NameUser))
                {
                    MessageBox.Show("You exit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    //_KeyChats.Clear();
                    //_ChatsKeyValuePairs.Clear();
                    //ChatToolStripComboBox.Text = "";
                    //ChatToolStripComboBox.Items.Clear();
                    //IntervledShowChats();
                }
                else
                    MessageBox.Show("Error of the exit", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatForm chatForm = new ChatForm(_NameUser);
            chatForm.Show();
        }

        private void AllUsersListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(tabControl1.SelectedIndex==0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (AllUsersListBox.SelectedIndices.Count > 0)
                    {
                        AddUserButton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("You have to choose a data");
                    }   
                }
            }
        }

        private void ParticipantsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (ParticipantsListBox.SelectedIndices.Count > 0)
                    {
                        DeleteButton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("You have to choose a data");
                    }
                }
            }
        }

        private void EditChatForm_Load(object sender, EventArgs e)
        {
            ParticipantAllUserToolTip.SetToolTip(ParticipantsListBox, "Double cliking on the listbox updates the contents of the listbox");
            ParticipantAllUserToolTip.SetToolTip(AllUsersListBox, "Double cliking on the listbox updates the contents of the listbox");
            LoadUsersAll();
            LoadUsersPart();

            NameChatTextBox.Text = _NameChat;
            string AdminName = null;
            if (db.GetNameAdminChat(_IdChat, ref AdminName))
                AdminNameLabel.Text = "Admin chat: " + AdminName;
            else
                MessageBox.Show("There is trouble with read the admin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            byte[] arr_image;
            if ((arr_image = db.ShowImageChat(_IdChat)) != null)
            {
                MemoryStream streamImg = new MemoryStream(arr_image);
                ImagePictureBox.Image = Image.FromStream(streamImg);
                ImageConverter imageConverter = new ImageConverter();
                ImageArr = (byte[])imageConverter.ConvertTo(ImagePictureBox.Image, typeof(byte[]));
            }
        }
    }
}
