
namespace NewChat3
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.enterLogBtn = new System.Windows.Forms.Button();
            this.passwordLogTextBox = new System.Windows.Forms.TextBox();
            this.nameLogTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.regGroupBox = new System.Windows.Forms.GroupBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.nameRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.LoginGroupBox.SuspendLayout();
            this.regGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginGroupBox.Controls.Add(this.enterLogBtn);
            this.LoginGroupBox.Controls.Add(this.passwordLogTextBox);
            this.LoginGroupBox.Controls.Add(this.nameLogTextBox);
            this.LoginGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(374, 125);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(141, 134);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "LogIn";
            // 
            // enterLogBtn
            // 
            this.enterLogBtn.Location = new System.Drawing.Point(23, 80);
            this.enterLogBtn.Name = "enterLogBtn";
            this.enterLogBtn.Size = new System.Drawing.Size(96, 23);
            this.enterLogBtn.TabIndex = 2;
            this.enterLogBtn.Text = "Enter";
            this.enterLogBtn.UseVisualStyleBackColor = true;
            this.enterLogBtn.Click += new System.EventHandler(this.enterBtn_Click);
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
            // regGroupBox
            // 
            this.regGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.regGroupBox.Controls.Add(this.registerBtn);
            this.regGroupBox.Controls.Add(this.nameRegTextBox);
            this.regGroupBox.Controls.Add(this.passwordRegTextBox);
            this.regGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.regGroupBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regGroupBox.Location = new System.Drawing.Point(70, 99);
            this.regGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Name = "regGroupBox";
            this.regGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.regGroupBox.Size = new System.Drawing.Size(186, 198);
            this.regGroupBox.TabIndex = 1;
            this.regGroupBox.TabStop = false;
            this.regGroupBox.Text = "Registration";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(36, 116);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(106, 29);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            this.nameRegTextBox.Leave += new System.EventHandler(this.nameRegTextBoxLeave);
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
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.regGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Name = "MainPageForm";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.regGroupBox.ResumeLayout(false);
            this.regGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button enterLogBtn;
        private System.Windows.Forms.TextBox passwordLogTextBox;
        private System.Windows.Forms.TextBox nameLogTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox regGroupBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox nameRegTextBox;
        private System.Windows.Forms.TextBox passwordRegTextBox;
    }
}