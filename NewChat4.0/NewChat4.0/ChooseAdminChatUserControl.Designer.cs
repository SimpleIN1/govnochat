namespace NewChat4._0
{
    partial class ChooseAdminChatUserControl
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
            this.ChooseButton = new System.Windows.Forms.Button();
            this.AdminNameTitleLabel = new System.Windows.Forms.Label();
            this.UserChatListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(303, 309);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(90, 23);
            this.ChooseButton.TabIndex = 5;
            this.ChooseButton.Text = "Choose user";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // AdminNameTitleLabel
            // 
            this.AdminNameTitleLabel.AutoSize = true;
            this.AdminNameTitleLabel.Location = new System.Drawing.Point(239, 91);
            this.AdminNameTitleLabel.Name = "AdminNameTitleLabel";
            this.AdminNameTitleLabel.Size = new System.Drawing.Size(140, 13);
            this.AdminNameTitleLabel.TabIndex = 4;
            this.AdminNameTitleLabel.Text = "Choose new admin this chat";
            // 
            // UserChatListBox
            // 
            this.UserChatListBox.FormattingEnabled = true;
            this.UserChatListBox.Location = new System.Drawing.Point(279, 117);
            this.UserChatListBox.Name = "UserChatListBox";
            this.UserChatListBox.Size = new System.Drawing.Size(149, 186);
            this.UserChatListBox.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // ChooseAdminChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AdminNameTitleLabel);
            this.Controls.Add(this.UserChatListBox);
            this.Name = "ChooseAdminChatUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.ChooseAdminChatUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Label AdminNameTitleLabel;
        private System.Windows.Forms.ListBox UserChatListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton;
    }
}
