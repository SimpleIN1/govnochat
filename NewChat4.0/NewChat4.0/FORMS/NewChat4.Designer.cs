namespace NewChat4._0
{
    partial class NewChat4
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
            this.NewChat4Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NewChat4Panel
            // 
            this.NewChat4Panel.Location = new System.Drawing.Point(0, -1);
            this.NewChat4Panel.Name = "NewChat4Panel";
            this.NewChat4Panel.Size = new System.Drawing.Size(772, 457);
            this.NewChat4Panel.TabIndex = 0;
            // 
            // NewChat4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 452);
            this.Controls.Add(this.NewChat4Panel);
            this.Name = "NewChat4";
            this.Text = "NewChat4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewChat4_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NewChat4Panel;
    }
}

