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
    public partial class EditChatForm : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        List<string> users = new List<string>();
        List<string> usersChat = new List<string>();
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

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            users.Clear();
            foreach (object item in AllUsersListBox.SelectedItems)
                users.Add(item.ToString()); 
            if (db.AddUserChat(users, _NameUser, _IdChat))
            {
                MessageBox.Show("User is added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                users.Clear();
            }
            else
                MessageBox.Show("Person have added yet", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetCollection(ListBox l)
        {
            string items = "";
            int CountSep = 0;
            foreach (object item in l.SelectedItems)
            {
                items += "'" + item + "'";
                if (++CountSep < l.SelectedItems.Count)
                    items += ",";
            }
            return items;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (db.DeleteUser(GetCollection(ParticipantsListBox), _IdChat, _NameUser))
                MessageBox.Show("user(s) is removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("You can not delete the user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string errorStr=null;
            if (db.UpdateChatImageName(ImageArr, NameChatTextBox.Text, _IdChat,ref errorStr))
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

        private void LoadUsersPart()
        {
            ParticipantsListBox.Items.Clear();
            if (db.ShowUsersChat(usersChat, _IdChat, ref _CountUserChat))
                foreach (object el in usersChat)
                    ParticipantsListBox.Items.Add(el);
            else
                MessageBox.Show("error in shwo users", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadUsersAll()
        {
            AllUsersListBox.Items.Clear();
            if (db.ShowUsers(users, _NameUser, ref _CountUser))
                foreach (object el in users)
                    AllUsersListBox.Items.Add(el);
            else
                MessageBox.Show("error in show users", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ParticipantsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _CountUserChat = 0;
            usersChat.Clear();
            LoadUsersPart();
        }

        private void AllUsersListBox_DoubleClick(object sender, EventArgs e)
        {
            _CountUser = 0;
            users.Clear();
            LoadUsersAll();
        }

        private void EditChatForm_Load(object sender, EventArgs e)
        {
            LoadUsersAll();
            LoadUsersPart();

            NameChatTextBox.Text = _NameChat;

            byte[] arr_image;
            if ((arr_image = db.ShowImage(_IdChat)) != null)
            {
                MemoryStream streamImg = new MemoryStream(arr_image);
                ImagePictureBox.Image = Image.FromStream(streamImg);
                ImageConverter imageConverter = new ImageConverter();
                ImageArr = (byte[])imageConverter.ConvertTo(ImagePictureBox.Image, typeof(byte[]));
            }
        }
    }
}
