namespace NewChat3
{
    partial class CreateChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChatForm));
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.CreateChatButton = new System.Windows.Forms.Button();
            this.ChatNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(232, 72);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 16;
            this.ImageLabel.Text = "Image";
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.Location = new System.Drawing.Point(220, 193);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(58, 13);
            this.ChatNameLabel.TabIndex = 15;
            this.ChatNameLabel.Text = "Chat name";
            // 
            // CreateChatButton
            // 
            this.CreateChatButton.Location = new System.Drawing.Point(203, 235);
            this.CreateChatButton.Name = "CreateChatButton";
            this.CreateChatButton.Size = new System.Drawing.Size(96, 23);
            this.CreateChatButton.TabIndex = 14;
            this.CreateChatButton.Text = "Create";
            this.CreateChatButton.UseVisualStyleBackColor = true;
            this.CreateChatButton.Click += new System.EventHandler(this.CreateChatButton_Click);
            // 
            // ChatNameTextBox
            // 
            this.ChatNameTextBox.Location = new System.Drawing.Point(203, 209);
            this.ChatNameTextBox.Name = "ChatNameTextBox";
            this.ChatNameTextBox.Size = new System.Drawing.Size(96, 20);
            this.ChatNameTextBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(203, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(67, 72);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsersListBox.Size = new System.Drawing.Size(130, 186);
            this.UsersListBox.TabIndex = 11;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(88, 56);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 17;
            this.UsersLabel.Text = "Users";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Location = new System.Drawing.Point(30, 72);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(32, 28);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 338);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.CreateChatButton);
            this.Controls.Add(this.ChatNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersListBox);
            this.Name = "CreateChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateChatForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Label ChatNameLabel;
        private System.Windows.Forms.Button CreateChatButton;
        private System.Windows.Forms.TextBox ChatNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ToolTip UpdateButtonToolTip;
    }
}