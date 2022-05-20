namespace NewChat4._0
{
    partial class MainPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageUserControl));
            this.regGroupBox = new System.Windows.Forms.GroupBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.nameRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.enterLogButton = new System.Windows.Forms.Button();
            this.passwordLogTextBox = new System.Windows.Forms.TextBox();
            this.nameLogTextBox = new System.Windows.Forms.TextBox();
            this.regGroupBox.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // regGroupBox
            // 
            this.regGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.regGroupBox.Controls.Add(this.registerButton);
            this.regGroupBox.Controls.Add(this.nameRegTextBox);
            this.regGroupBox.Controls.Add(this.passwordRegTextBox);
            this.regGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.regGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regGroupBox.Location = new System.Drawing.Point(122, 115);
            this.regGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Name = "regGroupBox";
            this.regGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Size = new System.Drawing.Size(186, 198);
            this.regGroupBox.TabIndex = 3;
            this.regGroupBox.TabStop = false;
            this.regGroupBox.Text = "Registration";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(36, 116);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(106, 29);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameRegTextBox
            // 
            this.nameRegTextBox.Location = new System.Drawing.Point(36, 54);
            this.nameRegTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameRegTextBox.Name = "nameRegTextBox";
            this.nameRegTextBox.Size = new System.Drawing.Size(106, 27);
            this.nameRegTextBox.TabIndex = 2;
            this.nameRegTextBox.Text = "Name";
            this.nameRegTextBox.Enter += new System.EventHandler(this.nameRegTextBox_Enter);
            this.nameRegTextBox.Leave += new System.EventHandler(this.nameRegTextBox_Leave);
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(36, 85);
            this.passwordRegTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.Size = new System.Drawing.Size(106, 27);
            this.passwordRegTextBox.TabIndex = 2;
            this.passwordRegTextBox.Text = "Password";
            this.passwordRegTextBox.Enter += new System.EventHandler(this.passwordRegTextBox_Enter);
            this.passwordRegTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordRegTextBox_KeyDown);
            this.passwordRegTextBox.Leave += new System.EventHandler(this.passwordRegTextBox_Leave);
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginGroupBox.Controls.Add(this.enterLogButton);
            this.LoginGroupBox.Controls.Add(this.passwordLogTextBox);
            this.LoginGroupBox.Controls.Add(this.nameLogTextBox);
            this.LoginGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(466, 144);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(141, 134);
            this.LoginGroupBox.TabIndex = 2;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "LogIn";
            // 
            // enterLogButton
            // 
            this.enterLogButton.Location = new System.Drawing.Point(23, 80);
            this.enterLogButton.Name = "enterLogButton";
            this.enterLogButton.Size = new System.Drawing.Size(96, 23);
            this.enterLogButton.TabIndex = 2;
            this.enterLogButton.Text = "Enter";
            this.enterLogButton.UseVisualStyleBackColor = true;
            this.enterLogButton.Click += new System.EventHandler(this.enterLogButton_Click);
            // 
            // passwordLogTextBox
            // 
            this.passwordLogTextBox.Location = new System.Drawing.Point(23, 50);
            this.passwordLogTextBox.Name = "passwordLogTextBox";
            this.passwordLogTextBox.Size = new System.Drawing.Size(96, 27);
            this.passwordLogTextBox.TabIndex = 1;
            this.passwordLogTextBox.Text = "Password";
            this.passwordLogTextBox.Enter += new System.EventHandler(this.passwordLogTextBox_Enter);
            this.passwordLogTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordLogTextBox_KeyDown);
            this.passwordLogTextBox.Leave += new System.EventHandler(this.passwordLogTextBox_Leave);
            // 
            // nameLogTextBox
            // 
            this.nameLogTextBox.Location = new System.Drawing.Point(23, 19);
            this.nameLogTextBox.Name = "nameLogTextBox";
            this.nameLogTextBox.Size = new System.Drawing.Size(96, 27);
            this.nameLogTextBox.TabIndex = 0;
            this.nameLogTextBox.Text = "Name";
            this.nameLogTextBox.Enter += new System.EventHandler(this.nameLogTextBox_Enter);
            this.nameLogTextBox.Leave += new System.EventHandler(this.nameLogTextBox_Leave);
            // 
            // MainPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.regGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "MainPageUserControl";
            this.Size = new System.Drawing.Size(772, 457);
            this.Load += new System.EventHandler(this.MainPageUserControl_Load);
            this.regGroupBox.ResumeLayout(false);
            this.regGroupBox.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox regGroupBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox nameRegTextBox;
        private System.Windows.Forms.TextBox passwordRegTextBox;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button enterLogButton;
        private System.Windows.Forms.TextBox passwordLogTextBox;
        private System.Windows.Forms.TextBox nameLogTextBox;
    }
}
