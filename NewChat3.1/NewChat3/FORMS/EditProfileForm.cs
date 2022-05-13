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
    public partial class EditProfileForm : Form
    {
        ConnectionWithDb db = new ConnectionWithDb(MainPageForm.connection);
        private string _NameUser;
        byte[] ImageArr = null;
        public EditProfileForm(string  NameUser)
        {
            InitializeComponent();
            this._NameUser = NameUser;
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            NamePageTextBox.Text = _NameUser;

            byte[] arr_image;
            if ((arr_image = db.ShowImageUser(_NameUser)) != null)
            {
                MemoryStream streamImg = new MemoryStream(arr_image);
                ImagePictureBox.Image = Image.FromStream(streamImg);
                //ImageConverter imageConverter = new ImageConverter();
                //ImageArr = (byte[])imageConverter.ConvertTo(ImagePictureBox.Image, typeof(byte[]));
            }
        }

        private void DeletePageButton_Click(object sender, EventArgs e)
        {
            if (db.DeleteUser(_NameUser))
                MessageBox.Show("Your page is deleted is successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mistake was called when deleting", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (NamePageTextBox.Text.Trim(' ')!="" && db.UpdateProfileUser(ref _NameUser,NamePageTextBox.Text, ImageArr))
            {
                MessageBox.Show("Information at the page is updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();                
            }
            else
                MessageBox.Show("Infomation cannot update", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatForm chatForm = new ChatForm(_NameUser);
            chatForm.Show();
        }
    }
}
