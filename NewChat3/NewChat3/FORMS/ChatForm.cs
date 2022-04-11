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
            if (db.ShowMessages(_IdChat, _MessagesList,ref _CountWritten))
                while (CountW < _CountWritten)
                    MessagesListBox.Items.Add(_MessagesList[CountW++]);
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
            if ((ArrImage = db.ShowImage(_IdChat)) != null)
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
                _CountWritten = 0;
                _NameChat = ChatToolStripComboBox.SelectedItem.ToString();
                _IdChat = _ChatsKeyValuePairs.ElementAt(ChatToolStripComboBox.SelectedIndex).Key;
                byte[] ArrImage=null;
                LoadImage(ArrImage);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (db.InsertMessage(_NameUser, _IdChat, MessageTextBox.Text))
            {
                MessagesListBox.Items.Add(DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString() + " "+_NameUser+" -> "+MessageTextBox.Text);
                MessagesListBox.SelectedIndex = MessagesListBox.Items.Count - 1;
                ++_CountWritten;
            }
            else
                MessageBox.Show("The message was not sent successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChatForm create = new CreateChatForm(_NameUser);
            //this.Visible = false;
            create.Show();
        }

        private void editChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_IdChat >= 0)
            {
                EditChatForm editChatForm = new EditChatForm(_NameUser, _IdChat, _NameChat);
                //this.Visible = false;
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
            //if (tabControl1.SelectedIndex == 1)
            //{
                
            //}
        }
    }
}
