namespace NewChat3
{
    partial class ChooseAdminForm
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
            this.UserChatListBox = new System.Windows.Forms.ListBox();
            this.AdminNameTitleLabel = new System.Windows.Forms.Label();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UserChatListBox
            // 
            this.UserChatListBox.FormattingEnabled = true;
            this.UserChatListBox.Location = new System.Drawing.Point(60, 43);
            this.UserChatListBox.Name = "UserChatListBox";
            this.UserChatListBox.Size = new System.Drawing.Size(149, 186);
            this.UserChatListBox.TabIndex = 0;
            // 
            // AdminNameTitleLabel
            // 
            this.AdminNameTitleLabel.AutoSize = true;
            this.AdminNameTitleLabel.Location = new System.Drawing.Point(20, 17);
            this.AdminNameTitleLabel.Name = "AdminNameTitleLabel";
            this.AdminNameTitleLabel.Size = new System.Drawing.Size(140, 13);
            this.AdminNameTitleLabel.TabIndex = 1;
            this.AdminNameTitleLabel.Text = "Choose new admin this chat";
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(84, 235);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(90, 23);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Choose user";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChooseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 289);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AdminNameTitleLabel);
            this.Controls.Add(this.UserChatListBox);
            this.Name = "ChooseAdminForm";
            this.Text = "ChooseAdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.ChooseAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserChatListBox;
        private System.Windows.Forms.Label AdminNameTitleLabel;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Timer timer1;
    }
}