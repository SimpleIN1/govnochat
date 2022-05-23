using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewChat4._0
{
    public partial class ChooseAdminChatUserControl : UserControl
    {
        ChooseAdminChatUserControlDbClass ControlDbClass = new ChooseAdminChatUserControlDbClass(MainPageUserControl.connection);
        private List<string> _UsersChatList = new List<string>();
        private List<string> _UsersChatListDelete = new List<string>();
        private int _IdChat;
        private int _CountUser = 0;
        private string _NameUser;
        Panel panel;
        public ChooseAdminChatUserControl(int IdChat, string NameUser, Panel panel)
        {
            InitializeComponent();
            this._IdChat = IdChat;
            this._NameUser = NameUser;
            this.panel = panel;
        }

        private void ChooseAdminChatUserControl_Load(object sender, EventArgs e)
        {
            FullChatList();
        }

        private void DeleteUserChat()
        {
            foreach (object item in _UsersChatListDelete)
            {
                //MessageBox.Show(_UsersChatList.FindIndex(p => p.ToString() == item.ToString()).ToString());
                int index;
                if ((index = _UsersChatList.FindIndex(p => p.ToString() == item.ToString())) > -1)
                {
                    _UsersChatList.RemoveAt(index);
                    UserChatListBox.Items.RemoveAt(index);
                    --_CountUser;
                }
            }
        }

        private void FullChatList()
        {
            if (_UsersChatList.Count > 0 && EditChatUserControlDbClass.ShowAllUsersDelete(_UsersChatList, _UsersChatListDelete))
            {
                //MessageBox.Show(string.Join(",",_UserChatListDelete.Select(x =>x.ToString()).ToArray()));
                if (_UsersChatListDelete.Count > 0)
                {
                    DeleteUserChat();
                    _UsersChatListDelete.Clear();
                }
            }

            if (EditChatUserControlDbClass.ShowUsersChat1(_UsersChatList, _IdChat, _NameUser))
            {
                FullChatListBox();
            }
            else
            {
                MessageBox.Show("Load is not succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FullChatListBox()
        {
            while (_CountUser < _UsersChatList.Count)
                UserChatListBox.Items.Add(_UsersChatList[_CountUser++]);
        }

        private void ExitEditingChat()
        {
            panel.Controls.Clear();
            panel.Controls.Add(new ChatFormUserControl(_NameUser, panel));
        }


        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (UserChatListBox.SelectedItems.Count == 1)
            {
                if (ControlDbClass.CheckUserChat(UserChatListBox.SelectedItem.ToString(), _IdChat))
                {
                    if (ControlDbClass.UpdateAdminChat(UserChatListBox.SelectedItem.ToString(), _IdChat))
                    {
                        MessageBox.Show("Successful");
                        ControlDbClass.DeleteUserChat(_NameUser, _IdChat, _NameUser);
                        ExitEditingChat();
                    }
                }
                else
                {
                    MessageBox.Show("User is not located in the chat");
                }
            }
            else
            {
                MessageBox.Show("Choose user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FullChatList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ExitEditingChat();
        }
    }
}
