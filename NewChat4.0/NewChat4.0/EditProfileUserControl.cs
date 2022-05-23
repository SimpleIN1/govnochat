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
    public partial class EditProfileUserControl : UserControl
    {
        EditProfileUserControlDbClass ControlDbClass = new EditProfileUserControlDbClass(MainPageUserControl.connection);
        private string _NameUser;
        byte[] ImageArr = null;
        Panel panel;
        public EditProfileUserControl(string NameUser, Panel panel)
        {
            InitializeComponent();
            this._NameUser = NameUser;
            this.panel = panel;
        }

        private void EditProfileUserControl_Load(object sender, EventArgs e)
        {
            NamePageTextBox.Text = _NameUser;

            byte[] arr_image;
            if ((arr_image = ControlDbClass.ShowImageUser(_NameUser)) != null)
            {
                MemoryStream streamImg = new MemoryStream(arr_image);
                ImagePictureBox.Image = Image.FromStream(streamImg);
                //ImageConverter imageConverter = new ImageConverter();
                //ImageArr = (byte[])imageConverter.ConvertTo(ImagePictureBox.Image, typeof(byte[]));
            }
        }

        private void DeletePageButton_Click(object sender, EventArgs e)
        {
            if (ControlDbClass.DeleteUser(_NameUser))
            {
                MessageBox.Show("Your page is deleted is successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel.Controls.Clear();
                panel.Controls.Add(new  MainPageUserControl(panel));
            }
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
            if (NamePageTextBox.Text.Trim(' ') != "" && ControlDbClass.UpdateProfileUser(ref _NameUser, NamePageTextBox.Text, ImageArr))
            {
                MessageBox.Show("Information at the page is updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel.Controls.Clear();
                panel.Controls.Add(new ChatFormUserControl(_NameUser, panel));
            }
            else
                MessageBox.Show("Infomation cannot update", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new ChatFormUserControl(_NameUser, panel));
        }
    }
}
