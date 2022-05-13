using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewChat3
{
    public partial class ChooseAdminForm : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        private List<string> _UsersChatList = new List<string>();
        private int _IdChat;
        private int _CountGet = 0, _CountCurrent = 0;
        private string _NameUser;

        public ChooseAdminForm(int IdChat,string NameUser)
        {
            InitializeComponent();
            this._IdChat = IdChat;
            this._NameUser = NameUser;
        }

        private void FullChatList()
        {
            _CountCurrent = _UsersChatList.Count;
            if (db.ShowUsersChat1(_UsersChatList, _IdChat, _NameUser))
            {
                _CountGet = _UsersChatList.Count;
            }
            else
            {
                _CountGet = _CountCurrent;
                MessageBox.Show("Load is not succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FullChatListBox()
        {
            for(int i = _CountCurrent; i < _CountGet; ++i)
            {
                UserChatListBox.Items.Add(_UsersChatList[i]);
            }
        }

        private void ChooseAdminForm_Load(object sender, EventArgs e)
        {
            FullChatList();
            FullChatListBox();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (UserChatListBox.SelectedItems.Count == 1)
            {
                if(db.UpdateAdminChat(UserChatListBox.SelectedItem.ToString(),_IdChat))
                {
                    MessageBox.Show("Successful");
                    db.DeleteUserChat("'" + _NameUser + "'", _IdChat, _NameUser);
                    this.Close();
                }                    
            }
            else
            {
                MessageBox.Show("Choose user","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ChooseAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatForm chatForm = new ChatForm(_NameUser);
            chatForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FullChatList();
            FullChatListBox();
        }
    }
}
