namespace NewChat3
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ChatTabPage = new System.Windows.Forms.TabPage();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ChatToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaveTheChatToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProfileTabPage = new System.Windows.Forms.TabPage();
            this.AddFriendsButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BackPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ChatTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ProfileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ChatTabPage);
            this.tabControl1.Controls.Add(this.ProfileTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 366);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ChatTabPage
            // 
            this.ChatTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChatTabPage.BackgroundImage")));
            this.ChatTabPage.Controls.Add(this.MessageTextBox);
            this.ChatTabPage.Controls.Add(this.SendButton);
            this.ChatTabPage.Controls.Add(this.MessagesListBox);
            this.ChatTabPage.Controls.Add(this.toolStrip1);
            this.ChatTabPage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChatTabPage.Name = "ChatTabPage";
            this.ChatTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTabPage.Size = new System.Drawing.Size(317, 340);
            this.ChatTabPage.TabIndex = 0;
            this.ChatTabPage.Text = "Chat";
            this.ChatTabPage.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(40, 313);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(173, 22);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(219, 308);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(60, 31);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessagesListBox
            // 
            this.MessagesListBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessagesListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.ItemHeight = 16;
            this.MessagesListBox.Location = new System.Drawing.Point(40, 31);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(239, 276);
            this.MessagesListBox.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ChatToolStripComboBox,
            this.toolStripDropDownButton1,
            this.LeaveTheChatToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(311, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "ForImageToolStripButton";
            // 
            // ChatToolStripComboBox
            // 
            this.ChatToolStripComboBox.Name = "ChatToolStripComboBox";
            this.ChatToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.ChatToolStripComboBox.Text = "Choose the chat";
            this.ChatToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ChatToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.BackgroundImage")));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createChatToolStripMenuItem,
            this.editChatToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "OptionToolStripDropDownButton";
            // 
            // createChatToolStripMenuItem
            // 
            this.createChatToolStripMenuItem.Name = "createChatToolStripMenuItem";
            this.createChatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createChatToolStripMenuItem.Text = "Create chat";
            this.createChatToolStripMenuItem.Click += new System.EventHandler(this.createChatToolStripMenuItem_Click);
            // 
            // editChatToolStripMenuItem
            // 
            this.editChatToolStripMenuItem.Name = "editChatToolStripMenuItem";
            this.editChatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editChatToolStripMenuItem.Text = "Edit chat";
            this.editChatToolStripMenuItem.Click += new System.EventHandler(this.editChatToolStripMenuItem_Click);
            // 
            // LeaveTheChatToolStripButton
            // 
            this.LeaveTheChatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LeaveTheChatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LeaveTheChatToolStripButton.Image")));
            this.LeaveTheChatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeaveTheChatToolStripButton.Name = "LeaveTheChatToolStripButton";
            this.LeaveTheChatToolStripButton.Size = new System.Drawing.Size(86, 22);
            this.LeaveTheChatToolStripButton.Text = "LeaveTheChat";
            this.LeaveTheChatToolStripButton.Click += new System.EventHandler(this.LeaveTheChatToolStripButton_Click);
            // 
            // ProfileTabPage
            // 
            this.ProfileTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileTabPage.BackgroundImage")));
            this.ProfileTabPage.Controls.Add(this.ExitButton);
            this.ProfileTabPage.Controls.Add(this.AddFriendsButton);
            this.ProfileTabPage.Controls.Add(this.FriendsListBox);
            this.ProfileTabPage.Controls.Add(this.StatusLabel);
            this.ProfileTabPage.Controls.Add(this.UserNameLabel);
            this.ProfileTabPage.Controls.Add(this.ImagePictureBox);
            this.ProfileTabPage.Controls.Add(this.toolStrip2);
            this.ProfileTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProfileTabPage.Name = "ProfileTabPage";
            this.ProfileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTabPage.Size = new System.Drawing.Size(317, 340);
            this.ProfileTabPage.TabIndex = 1;
            this.ProfileTabPage.Text = "Profile";
            this.ProfileTabPage.UseVisualStyleBackColor = true;
            // 
            // AddFriendsButton
            // 
            this.AddFriendsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFriendsButton.BackgroundImage")));
            this.AddFriendsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFriendsButton.Location = new System.Drawing.Point(234, 251);
            this.AddFriendsButton.Name = "AddFriendsButton";
            this.AddFriendsButton.Size = new System.Drawing.Size(77, 37);
            this.AddFriendsButton.TabIndex = 9;
            this.AddFriendsButton.UseVisualStyleBackColor = true;
            this.AddFriendsButton.Click += new System.EventHandler(this.AddFriendsButton_Click);
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.Location = new System.Drawing.Point(23, 188);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(135, 43);
            this.FriendsListBox.TabIndex = 8;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(268, 28);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(49, 13);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "label4";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(180, 46);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(61, 15);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = "label3";
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(23, 46);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(135, 126);
            this.ImagePictureBox.TabIndex = 5;
            this.ImagePictureBox.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackPageToolStripButton,
            this.toolStripDropDownButton2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(311, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BackPageToolStripButton
            // 
            this.BackPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackPageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BackPageToolStripButton.Image")));
            this.BackPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackPageToolStripButton.Name = "BackPageToolStripButton";
            this.BackPageToolStripButton.Size = new System.Drawing.Size(106, 22);
            this.BackPageToolStripButton.Text = "Back to your page";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.BackgroundImage")));
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(231, 294);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 40);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChatForm";
            this.Text = "New Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ChatTabPage.ResumeLayout(false);
            this.ChatTabPage.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ProfileTabPage.ResumeLayout(false);
            this.ProfileTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ChatTabPage;
        private System.Windows.Forms.TabPage ProfileTabPage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox ChatToolStripComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editChatToolStripMenuItem;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox MessagesListBox;
        private System.Windows.Forms.ToolStripButton BackPageToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.Button AddFriendsButton;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripButton LeaveTheChatToolStripButton;
        private System.Windows.Forms.Button ExitButton;
    }
}