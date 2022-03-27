﻿using System;
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
    }
}