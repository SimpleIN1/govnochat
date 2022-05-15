using System;
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
    public partial class ChatForm : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        private string _NameUser;
        private string _NameChat=null;
        private int _IdChat=-1;
        private static int _CountWritten=0;
        int CountW=0;
        private int _CountSecond=0;
        private Dictionary<int, string> _ChatsKeyValuePairs = new Dictionary<int, string>();
        private List<int> _KeyChats = new List<int>();
        private List<string> _MessagesList = new List<string>();
        private bool CheckMessage = false;

        public ChatForm()
        {
            InitializeComponent();
        }

        public ChatForm(string NameUser)
        {
            this._NameUser = NameUser;
            InitializeComponent();
        } 

        private void ChatForm_Load(object sender, EventArgs e)
        {
            IntervledShowChats();
            SendButton.Enabled = false;
            db.UpdateStatusUser(_NameUser, true);
            //MessagesListBox.lin
            //ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton.PerformClick();
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.UpdateStatusUser(_NameUser,false);
        }

        private void IntervledShowChats()
        {
            db.ShowChats(_ChatsKeyValuePairs,_NameUser);
            foreach(var element in _ChatsKeyValuePairs)
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
            if (db.ShowMessages(_IdChat, _MessagesList, ref _CountWritten))
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
            if ((ArrImage = db.ShowImageChat(_IdChat)) != null)
            {
                MemoryStream streamImg = new MemoryStream(ArrImage);
                toolStripButton1.Image = Image.FromStream(streamImg);
            }
            else
                toolStripButton1.Image = null;
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
                byte[] ArrImage=null;
                LoadImage(ArrImage);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Trim()!="" && db.InsertMessage(_NameUser, _IdChat, MessageTextBox.Text.Trim()))
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
            CreateChatForm create = new CreateChatForm(_NameUser);
            //this.Visible = false;
            this.Close();
            create.Show();
        }

        private void editChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_IdChat >= 0)
            {
                EditChatForm editChatForm = new EditChatForm(_NameUser, _IdChat, _NameChat);
                //this.Visible = false;
                this.Close();
                editChatForm.Show();
            }
            else
            {
                MessageBox.Show("Choose the something chat", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddFriendsButton_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                Users users = new Users();
                users.login = _NameUser;
                if (db.ShowProfileUser(users))
                {
                    AddFriendsButton.Visible = false;
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
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfileForm = new EditProfileForm(_NameUser);
            //this.Visible = false;
            this.Close();
            editProfileForm.Show();   
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainPageForm mainPageForm = new MainPageForm();
            mainPageForm.Show();
            this.Close();
        }

        private void ChatTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
