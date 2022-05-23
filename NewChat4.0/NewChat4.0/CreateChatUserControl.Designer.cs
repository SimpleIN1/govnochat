namespace NewChat4._0
{
    partial class CreateChatUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChatUserControl));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ChatNameLabel = new System.Windows.Forms.Label();
            this.CreateChatButton = new System.Windows.Forms.Button();
            this.ChatNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.UpdateButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateButton.Location = new System.Drawing.Point(214, 131);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(32, 28);
            this.UpdateButton.TabIndex = 26;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(272, 115);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 25;
            this.UsersLabel.Text = "Users";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(416, 131);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 24;
            this.ImageLabel.Text = "Image";
            // 
            // ChatNameLabel
            // 
            this.ChatNameLabel.AutoSize = true;
            this.ChatNameLabel.Location = new System.Drawing.Point(404, 252);
            this.ChatNameLabel.Name = "ChatNameLabel";
            this.ChatNameLabel.Size = new System.Drawing.Size(58, 13);
            this.ChatNameLabel.TabIndex = 23;
            this.ChatNameLabel.Text = "Chat name";
            // 
            // CreateChatButton
            // 
            this.CreateChatButton.Location = new System.Drawing.Point(387, 294);
            this.CreateChatButton.Name = "CreateChatButton";
            this.CreateChatButton.Size = new System.Drawing.Size(96, 23);
            this.CreateChatButton.TabIndex = 22;
            this.CreateChatButton.Text = "Create";
            this.CreateChatButton.UseVisualStyleBackColor = true;
            this.CreateChatButton.Click += new System.EventHandler(this.CreateChatButton_Click);
            // 
            // ChatNameTextBox
            // 
            this.ChatNameTextBox.Location = new System.Drawing.Point(387, 268);
            this.ChatNameTextBox.Name = "ChatNameTextBox";
            this.ChatNameTextBox.Size = new System.Drawing.Size(96, 20);
            this.ChatNameTextBox.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(387, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(251, 131);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsersListBox.Size = new System.Drawing.Size(130, 186);
            this.UsersListBox.TabIndex = 19;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(722, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 35);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CreateChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ChatNameLabel);
            this.Controls.Add(this.CreateChatButton);
            this.Controls.Add(this.ChatNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersListBox);
            this.Name = "CreateChatUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.CreateChatUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Label ChatNameLabel;
        private System.Windows.Forms.Button CreateChatButton;
        private System.Windows.Forms.TextBox ChatNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.ToolTip UpdateButtonToolTip;
        private System.Windows.Forms.Button CloseButton;
    }
}
