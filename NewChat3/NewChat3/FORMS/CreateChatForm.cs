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
    public partial class CreateChatForm : Form
    {
        private string _NameUser;
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        private List<string> _SelectedItemList = new List<string>();
        private List<string> _users = new List<string>();
        private byte[] ImageArr = null;
        private int _CountUsers = 0;

        public CreateChatForm(string NameUser)
        {
            InitializeComponent();
            this._NameUser = NameUser;
        }

        private void UpdateUsers()
        {
            int i = _CountUsers;
            if (db.ShowUsers(_users, _NameUser, ref _CountUsers))
            {
                foreach (object element in _users)
                    if (UsersListBox.FindStringExact(element.ToString()) < 0)
                        UsersListBox.Items.Add(element.ToString());
            }
            else
                MessageBox.Show("error update users", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void CreateChatForm_Load(object sender, EventArgs e)
        {
            UpdateUsers();
            UpdateButtonToolTip.SetToolTip(UpdateButton, "Cliking on the button to upadte list");
        }

        private void CreateChatButton_Click(object sender, EventArgs e)
        {
            foreach (object element in UsersListBox.SelectedItems)
                _SelectedItemList.Add(element.ToString());
            if (ChatNameTextBox.Text.Trim(' ') != "")
            {
                string error=null;
                if (db.CreateChat(_NameUser, _SelectedItemList, ChatNameTextBox.Text, ImageArr,ref error))
                {
                    
                    MessageBox.Show("Chat is created", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter the something the chat name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Bitmap img = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = img;
                    ImageConverter imageConverter = new ImageConverter();
                    ImageArr = (byte[])imageConverter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                }
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedItems.Count > 1)
            {
                ChatNameTextBox.Text = "";
                ChatNameTextBox.Enabled = true;
            }
            else if (UsersListBox.SelectedItems.Count == 1)
            {
                ChatNameTextBox.Text = UsersListBox.SelectedItem.ToString() + "_" + _NameUser;
                ChatNameTextBox.Enabled = false;
            }
            else
            {
                ChatNameTextBox.Text = "";
                ChatNameTextBox.Enabled = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateUsers();
        }

        private void CreateChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatForm chat = new ChatForm(_NameUser);
            chat.Show();
        }
    }
}
