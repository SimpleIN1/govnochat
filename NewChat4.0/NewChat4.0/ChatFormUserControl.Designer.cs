namespace NewChat4._0
{
    partial class ChatFormUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatFormUserControl));
            this.ChatFormTabControl = new System.Windows.Forms.TabControl();
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
            this.ProfileTabPage = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddFriendsButton = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BackPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateProfileInfToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.PeolpeTabPage = new System.Windows.Forms.TabPage();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SearchLoginUserButton = new System.Windows.Forms.Button();
            this.LoginUserSearchTextBox = new System.Windows.Forms.TextBox();
            this.AllUserListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UpdateUserListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ChatFormTabControl.SuspendLayout();
            this.ChatTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ProfileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.PeolpeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatFormTabControl
            // 
            this.ChatFormTabControl.Controls.Add(this.ChatTabPage);
            this.ChatFormTabControl.Controls.Add(this.ProfileTabPage);
            this.ChatFormTabControl.Controls.Add(this.PeolpeTabPage);
            this.ChatFormTabControl.Location = new System.Drawing.Point(3, 3);
            this.ChatFormTabControl.Name = "ChatFormTabControl";
            this.ChatFormTabControl.SelectedIndex = 0;
            this.ChatFormTabControl.Size = new System.Drawing.Size(769, 451);
            this.ChatFormTabControl.TabIndex = 1;
            this.ChatFormTabControl.SelectedIndexChanged += new System.EventHandler(this.ChatFormTabControl_SelectedIndexChanged);
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
            this.ChatTabPage.Size = new System.Drawing.Size(761, 425);
            this.ChatTabPage.TabIndex = 0;
            this.ChatTabPage.Text = "Chat";
            this.ChatTabPage.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(164, 339);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(173, 22);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(343, 334);
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
            this.MessagesListBox.Location = new System.Drawing.Point(35, 57);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(505, 276);
            this.MessagesListBox.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ChatToolStripComboBox,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            // ProfileTabPage
            // 
            this.ProfileTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileTabPage.BackgroundImage")));
            this.ProfileTabPage.Controls.Add(this.DeleteUserButton);
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
            this.ProfileTabPage.Size = new System.Drawing.Size(761, 425);
            this.ProfileTabPage.TabIndex = 1;
            this.ProfileTabPage.Text = "Profile";
            this.ProfileTabPage.UseVisualStyleBackColor = true;
            this.ProfileTabPage.Click += new System.EventHandler(this.ProfileTabPage_Click);
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
            // AddFriendsButton
            // 
            this.AddFriendsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFriendsButton.BackgroundImage")));
            this.AddFriendsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFriendsButton.Location = new System.Drawing.Point(231, 251);
            this.AddFriendsButton.Name = "AddFriendsButton";
            this.AddFriendsButton.Size = new System.Drawing.Size(80, 37);
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
            this.FriendsListBox.DoubleClick += new System.EventHandler(this.FriendsListBox_DoubleClick);
            this.FriendsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FriendsListBox_MouseDoubleClick);
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
            this.toolStripDropDownButton2,
            this.UpdateProfileInfToolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(755, 25);
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
            this.BackPageToolStripButton.Click += new System.EventHandler(this.BackPageToolStripButton_Click);
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
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // UpdateProfileInfToolStripButton2
            // 
            this.UpdateProfileInfToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateProfileInfToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("UpdateProfileInfToolStripButton2.Image")));
            this.UpdateProfileInfToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateProfileInfToolStripButton2.Name = "UpdateProfileInfToolStripButton2";
            this.UpdateProfileInfToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.UpdateProfileInfToolStripButton2.Text = "UpdateProfileInfToolStripButton2";
            this.UpdateProfileInfToolStripButton2.Click += new System.EventHandler(this.UpdateProfileInfToolStripButton2_Click);
            // 
            // PeolpeTabPage
            // 
            this.PeolpeTabPage.Controls.Add(this.LoginLabel);
            this.PeolpeTabPage.Controls.Add(this.SearchLoginUserButton);
            this.PeolpeTabPage.Controls.Add(this.LoginUserSearchTextBox);
            this.PeolpeTabPage.Controls.Add(this.AllUserListBox);
            this.PeolpeTabPage.Location = new System.Drawing.Point(4, 22);
            this.PeolpeTabPage.Name = "PeolpeTabPage";
            this.PeolpeTabPage.Size = new System.Drawing.Size(761, 425);
            this.PeolpeTabPage.TabIndex = 2;
            this.PeolpeTabPage.Text = "People";
            this.PeolpeTabPage.UseVisualStyleBackColor = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 27);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 13);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login of user";
            // 
            // SearchLoginUserButton
            // 
            this.SearchLoginUserButton.Location = new System.Drawing.Point(220, 23);
            this.SearchLoginUserButton.Name = "SearchLoginUserButton";
            this.SearchLoginUserButton.Size = new System.Drawing.Size(75, 21);
            this.SearchLoginUserButton.TabIndex = 2;
            this.SearchLoginUserButton.Text = "Search";
            this.SearchLoginUserButton.UseVisualStyleBackColor = true;
            this.SearchLoginUserButton.Click += new System.EventHandler(this.SearchLoginUserButton_Click);
            // 
            // LoginUserSearchTextBox
            // 
            this.LoginUserSearchTextBox.Location = new System.Drawing.Point(86, 23);
            this.LoginUserSearchTextBox.Name = "LoginUserSearchTextBox";
            this.LoginUserSearchTextBox.Size = new System.Drawing.Size(119, 20);
            this.LoginUserSearchTextBox.TabIndex = 1;
            this.LoginUserSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginUserSearchTextBox_KeyDown);
            // 
            // AllUserListBox
            // 
            this.AllUserListBox.FormattingEnabled = true;
            this.AllUserListBox.Location = new System.Drawing.Point(44, 60);
            this.AllUserListBox.Name = "AllUserListBox";
            this.AllUserListBox.Size = new System.Drawing.Size(227, 264);
            this.AllUserListBox.TabIndex = 0;
            this.AllUserListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllUserListBox_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(231, 208);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(80, 37);
            this.DeleteUserButton.TabIndex = 11;
            this.DeleteUserButton.Text = "Delete";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // ChatFormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChatFormTabControl);
            this.Name = "ChatFormUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.ChatFormUserControl_Load);
            this.ChatFormTabControl.ResumeLayout(false);
            this.ChatTabPage.ResumeLayout(false);
            this.ChatTabPage.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ProfileTabPage.ResumeLayout(false);
            this.ProfileTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.PeolpeTabPage.ResumeLayout(false);
            this.PeolpeTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ChatFormTabControl;
        private System.Windows.Forms.TabPage ChatTabPage;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox MessagesListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox ChatToolStripComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editChatToolStripMenuItem;
        private System.Windows.Forms.TabPage ProfileTabPage;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddFriendsButton;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BackPageToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.TabPage PeolpeTabPage;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button SearchLoginUserButton;
        private System.Windows.Forms.TextBox LoginUserSearchTextBox;
        private System.Windows.Forms.ListBox AllUserListBox;
        private System.Windows.Forms.ToolStripButton UpdateProfileInfToolStripButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip UpdateUserListToolTip;
        private System.Windows.Forms.Button DeleteUserButton;
    }
}
