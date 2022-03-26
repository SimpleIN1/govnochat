
namespace newchat2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.send_message = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.create_chat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.edit_chat_button = new System.Windows.Forms.Button();
            this.chatNameComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MessagesTabPage = new System.Windows.Forms.TabPage();
            this.CreateChatTabPage = new System.Windows.Forms.TabPage();
            this.EditChatTabPage = new System.Windows.Forms.TabPage();
            this.ProfileTabPage = new System.Windows.Forms.TabPage();
            this.chat_name_label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.name_chat_txt = new System.Windows.Forms.TextBox();
            this.users_ListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.MessagesTabPage.SuspendLayout();
            this.CreateChatTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.Location = new System.Drawing.Point(71, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 316);
            this.listBox1.TabIndex = 0;
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(319, 423);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(101, 20);
            this.send_message.TabIndex = 1;
            this.send_message.Text = "send";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.Window;
            this.message.Location = new System.Drawing.Point(71, 424);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(242, 20);
            this.message.TabIndex = 2;
            this.message.Text = "Message";
            this.message.Enter += new System.EventHandler(this.message_Enter);
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            this.message.Leave += new System.EventHandler(this.message_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // create_chat
            // 
            this.create_chat.Location = new System.Drawing.Point(220, 73);
            this.create_chat.Name = "create_chat";
            this.create_chat.Size = new System.Drawing.Size(85, 23);
            this.create_chat.TabIndex = 10;
            this.create_chat.Text = "Create chat";
            this.create_chat.UseVisualStyleBackColor = true;
            this.create_chat.Click += new System.EventHandler(this.create_chat_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::newchat2.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(285, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 48);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2.png");
            this.imageList1.Images.SetKeyName(1, "3.png");
            this.imageList1.Images.SetKeyName(2, "4.png");
            this.imageList1.Images.SetKeyName(3, "5.png");
            this.imageList1.Images.SetKeyName(4, "6.png");
            this.imageList1.Images.SetKeyName(5, "7.png");
            this.imageList1.Images.SetKeyName(6, "8.png");
            this.imageList1.Images.SetKeyName(7, "9.png");
            this.imageList1.Images.SetKeyName(8, "10.png");
            this.imageList1.Images.SetKeyName(9, "11.png");
            this.imageList1.Images.SetKeyName(10, "12.png");
            this.imageList1.Images.SetKeyName(11, "13.png");
            // 
            // edit_chat_button
            // 
            this.edit_chat_button.Location = new System.Drawing.Point(334, 73);
            this.edit_chat_button.Name = "edit_chat_button";
            this.edit_chat_button.Size = new System.Drawing.Size(85, 23);
            this.edit_chat_button.TabIndex = 11;
            this.edit_chat_button.Text = "edit chat";
            this.edit_chat_button.UseVisualStyleBackColor = true;
            this.edit_chat_button.Click += new System.EventHandler(this.edit_chat_button_Click);
            // 
            // chatNameComboBox
            // 
            this.chatNameComboBox.FormattingEnabled = true;
            this.chatNameComboBox.Location = new System.Drawing.Point(71, 75);
            this.chatNameComboBox.Name = "chatNameComboBox";
            this.chatNameComboBox.Size = new System.Drawing.Size(120, 21);
            this.chatNameComboBox.TabIndex = 12;
            this.chatNameComboBox.SelectedIndexChanged += new System.EventHandler(this.chatNameComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MessagesTabPage);
            this.tabControl1.Controls.Add(this.CreateChatTabPage);
            this.tabControl1.Controls.Add(this.EditChatTabPage);
            this.tabControl1.Controls.Add(this.ProfileTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 520);
            this.tabControl1.TabIndex = 13;
            // 
            // MessagesTabPage
            // 
            this.MessagesTabPage.Controls.Add(this.listBox1);
            this.MessagesTabPage.Controls.Add(this.chatNameComboBox);
            this.MessagesTabPage.Controls.Add(this.send_message);
            this.MessagesTabPage.Controls.Add(this.edit_chat_button);
            this.MessagesTabPage.Controls.Add(this.message);
            this.MessagesTabPage.Controls.Add(this.create_chat);
            this.MessagesTabPage.Controls.Add(this.label4);
            this.MessagesTabPage.Controls.Add(this.button2);
            this.MessagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.MessagesTabPage.Name = "MessagesTabPage";
            this.MessagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MessagesTabPage.Size = new System.Drawing.Size(487, 494);
            this.MessagesTabPage.TabIndex = 0;
            this.MessagesTabPage.Text = "Messages";
            this.MessagesTabPage.UseVisualStyleBackColor = true;
            // 
            // CreateChatTabPage
            // 
            this.CreateChatTabPage.Controls.Add(this.chat_name_label1);
            this.CreateChatTabPage.Controls.Add(this.button1);
            this.CreateChatTabPage.Controls.Add(this.name_chat_txt);
            this.CreateChatTabPage.Controls.Add(this.users_ListBox);
            this.CreateChatTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreateChatTabPage.Name = "CreateChatTabPage";
            this.CreateChatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateChatTabPage.Size = new System.Drawing.Size(487, 494);
            this.CreateChatTabPage.TabIndex = 1;
            this.CreateChatTabPage.Text = "Create chat";
            this.CreateChatTabPage.UseVisualStyleBackColor = true;
            // 
            // EditChatTabPage
            // 
            this.EditChatTabPage.Location = new System.Drawing.Point(4, 22);
            this.EditChatTabPage.Name = "EditChatTabPage";
            this.EditChatTabPage.Size = new System.Drawing.Size(487, 494);
            this.EditChatTabPage.TabIndex = 2;
            this.EditChatTabPage.Text = "Edit chat";
            this.EditChatTabPage.UseVisualStyleBackColor = true;
            // 
            // ProfileTabPage
            // 
            this.ProfileTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProfileTabPage.Name = "ProfileTabPage";
            this.ProfileTabPage.Size = new System.Drawing.Size(487, 494);
            this.ProfileTabPage.TabIndex = 3;
            this.ProfileTabPage.Text = "Profile";
            this.ProfileTabPage.UseVisualStyleBackColor = true;
            // 
            // chat_name_label1
            // 
            this.chat_name_label1.AutoSize = true;
            this.chat_name_label1.BackColor = System.Drawing.Color.Transparent;
            this.chat_name_label1.Location = new System.Drawing.Point(204, 291);
            this.chat_name_label1.Name = "chat_name_label1";
            this.chat_name_label1.Size = new System.Drawing.Size(60, 13);
            this.chat_name_label1.TabIndex = 7;
            this.chat_name_label1.Text = "Chat Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // name_chat_txt
            // 
            this.name_chat_txt.Location = new System.Drawing.Point(184, 307);
            this.name_chat_txt.Name = "name_chat_txt";
            this.name_chat_txt.Size = new System.Drawing.Size(100, 20);
            this.name_chat_txt.TabIndex = 5;
            // 
            // users_ListBox
            // 
            this.users_ListBox.FormattingEnabled = true;
            this.users_ListBox.Location = new System.Drawing.Point(158, 76);
            this.users_ListBox.Name = "users_ListBox";
            this.users_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.users_ListBox.Size = new System.Drawing.Size(162, 212);
            this.users_ListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.MessagesTabPage.ResumeLayout(false);
            this.MessagesTabPage.PerformLayout();
            this.CreateChatTabPage.ResumeLayout(false);
            this.CreateChatTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button create_chat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button edit_chat_button;
        private System.Windows.Forms.ComboBox chatNameComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MessagesTabPage;
        private System.Windows.Forms.TabPage CreateChatTabPage;
        private System.Windows.Forms.TabPage EditChatTabPage;
        private System.Windows.Forms.TabPage ProfileTabPage;
        private System.Windows.Forms.Label chat_name_label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_chat_txt;
        private System.Windows.Forms.ListBox users_ListBox;
    }
}

