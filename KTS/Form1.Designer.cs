namespace KTS
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
            this.cbSelectUser = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.myContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectUser
            // 
            this.cbSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbSelectUser.ItemHeight = 24;
            this.cbSelectUser.Location = new System.Drawing.Point(12, 53);
            this.cbSelectUser.Name = "cbSelectUser";
            this.cbSelectUser.Size = new System.Drawing.Size(235, 32);
            this.cbSelectUser.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботникаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.добавитьРаботникаToolStripMenuItem.Text = "Добавить работника...";
            this.добавитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьРаботникаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Работник:";
            // 
            // lbDevices
            // 
            this.lbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 16;
            this.lbDevices.Location = new System.Drawing.Point(12, 98);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(235, 420);
            this.lbDevices.TabIndex = 3;
            // 
            // myContextBindingSource1
            // 
            this.myContextBindingSource1.DataSource = typeof(KTS.MyContext);
            // 
            // myContextBindingSource2
            // 
            this.myContextBindingSource2.DataSource = typeof(KTS.MyContext);
            // 
            // myContextBindingSource
            // 
            this.myContextBindingSource.DataSource = typeof(KTS.MyContext);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.BindingSource myContextBindingSource1;
        private System.Windows.Forms.BindingSource myContextBindingSource2;
        private System.Windows.Forms.BindingSource myContextBindingSource;
    }
}

