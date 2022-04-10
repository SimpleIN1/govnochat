using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using newchat2.ClASSES;
using System.IO;

namespace newchat2
{
    public partial class Edit_chat : Form
    {
        private int _id_chat;
        private string _name_user;
        ConnectionWithDb connectionWithDb = new ConnectionWithDb(MainPage.connection);
        public Edit_chat(int id_chat, string name_user)
        {
            InitializeComponent();
            this._id_chat = id_chat;
            this._name_user = name_user;
        }

        private void Edit_chat_Load(object sender, EventArgs e)
        {
            connectionWithDb.show_users(All_Users_ListBox, _name_user);
            connectionWithDb.show_users_chat(Participants_ListBox, _id_chat);
            byte[] arr_image;
            if ((arr_image = connectionWithDb.show_image(_id_chat)) != null)
            {
                MemoryStream streamImg = new MemoryStream(arr_image);
                //Image image = Image.FromStream(streamImg);
                pictureBox1.Image = Image.FromStream(streamImg);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = null;
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Bitmap img = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = img;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            All_Users_ListBox.Items.Clear();
            connectionWithDb.show_users(All_Users_ListBox, _name_user);
            Participants_ListBox.Items.Clear();
            connectionWithDb.show_users_chat(Participants_ListBox, _id_chat);
        }

        private string get_collection(ListBox l)
        {
            string items = "";
            int count_sep = 0;
            foreach (object item in l.SelectedItems)
            {
                items +="'"+item+"'";
                //l.Items.RemoveAt(l.SelectedIndex);
                if (++count_sep < l.SelectedItems.Count)
                    items += ",";
            }
            return items;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (connectionWithDb.delete_user(get_collection(Participants_ListBox), _id_chat,_name_user))
            {
                MessageBox.Show("user(s) is removed","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            List<string> users = new List<string>();
            foreach (object item in All_Users_ListBox.SelectedItems)
                users.Add(item.ToString());

            if(connectionWithDb.add_user_chat(users, _name_user, _id_chat))
            {
                MessageBox.Show("User is added","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectionWithDb.show_users_chat(Participants_ListBox, _id_chat);
            }
            
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] arr = (byte[])imageConverter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            if (name_chat_txt.Text.Trim()!="" && connectionWithDb.update_chat_image_name(arr,name_chat_txt.Text,_id_chat))
            {
                MessageBox.Show("Chat is updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
