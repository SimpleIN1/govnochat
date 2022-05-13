namespace newchat2
{
    partial class CreateChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChat));
            this.chat_name_label1 = new System.Windows.Forms.Label();
            this.create_chat = new System.Windows.Forms.Button();
            this.name_chat_txt = new System.Windows.Forms.TextBox();
            this.users_ListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chat_name_label1
            // 
            this.chat_name_label1.AutoSize = true;
            this.chat_name_label1.BackColor = System.Drawing.Color.Transparent;
            this.chat_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chat_name_label1.Location = new System.Drawing.Point(206, 180);
            this.chat_name_label1.Name = "chat_name_label1";
            this.chat_name_label1.Size = new System.Drawing.Size(83, 18);
            this.chat_name_label1.TabIndex = 3;
            this.chat_name_label1.Text = "Chat Name";
            // 
            // create_chat
            // 
            this.create_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_chat.Location = new System.Drawing.Point(12, 236);
            this.create_chat.Name = "create_chat";
            this.create_chat.Size = new System.Drawing.Size(286, 32);
            this.create_chat.TabIndex = 2;
            this.create_chat.Text = "Create";
            this.create_chat.UseVisualStyleBackColor = true;
            this.create_chat.Click += new System.EventHandler(this.create_chat_Click);
            // 
            // name_chat_txt
            // 
            this.name_chat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_chat_txt.Location = new System.Drawing.Point(185, 201);
            this.name_chat_txt.Name = "name_chat_txt";
            this.name_chat_txt.Size = new System.Drawing.Size(113, 24);
            this.name_chat_txt.TabIndex = 1;
            this.name_chat_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_chat_txt_KeyDown);
            // 
            // users_ListBox
            // 
            this.users_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users_ListBox.FormattingEnabled = true;
            this.users_ListBox.ItemHeight = 18;
            this.users_ListBox.Location = new System.Drawing.Point(12, 28);
            this.users_ListBox.Name = "users_ListBox";
            this.users_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.users_ListBox.Size = new System.Drawing.Size(147, 202);
            this.users_ListBox.TabIndex = 0;
            this.users_ListBox.SelectedIndexChanged += new System.EventHandler(this.users_ListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(185, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Users";
            // 
            // CreateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chat_name_label1);
            this.Controls.Add(this.create_chat);
            this.Controls.Add(this.name_chat_txt);
            this.Controls.Add(this.users_ListBox);
            this.Name = "CreateChat";
            this.Text = "CreateChat";
            this.Load += new System.EventHandler(this.CreateChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chat_name_label1;
        private System.Windows.Forms.Button create_chat;
        private System.Windows.Forms.TextBox name_chat_txt;
        private System.Windows.Forms.ListBox users_ListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}