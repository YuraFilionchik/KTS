﻿namespace KTS
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
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профилактикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.dgvExecuted = new System.Windows.Forms.DataGridView();
            this.dgvFix = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profilacticIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilacticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботникаToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.профилактикиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.менюToolStripMenuItem.Text = "Списки";
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьРаботникаToolStripMenuItem.Text = "Работники...";
            this.добавитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьРаботникаToolStripMenuItem_Click);
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование...";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // профилактикиToolStripMenuItem
            // 
            this.профилактикиToolStripMenuItem.Name = "профилактикиToolStripMenuItem";
            this.профилактикиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.профилактикиToolStripMenuItem.Text = "Профилактики...";
            this.профилактикиToolStripMenuItem.Click += new System.EventHandler(this.профилактикиToolStripMenuItem_Click);
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
            // dgvExecuted
            // 
            this.dgvExecuted.AllowUserToAddRows = false;
            this.dgvExecuted.AllowUserToDeleteRows = false;
            this.dgvExecuted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExecuted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExecuted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecuted.Location = new System.Drawing.Point(666, 53);
            this.dgvExecuted.Name = "dgvExecuted";
            this.dgvExecuted.ReadOnly = true;
            this.dgvExecuted.Size = new System.Drawing.Size(471, 465);
            this.dgvExecuted.TabIndex = 4;
            // 
            // dgvFix
            // 
            this.dgvFix.AllowUserToAddRows = false;
            this.dgvFix.AllowUserToDeleteRows = false;
            this.dgvFix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFix.AutoGenerateColumns = false;
            this.dgvFix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profilacticIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn});
            this.dgvFix.DataSource = this.profilacticBindingSource;
            this.dgvFix.Location = new System.Drawing.Point(253, 53);
            this.dgvFix.Name = "dgvFix";
            this.dgvFix.ReadOnly = true;
            this.dgvFix.RowHeadersVisible = false;
            this.dgvFix.ShowCellErrors = false;
            this.dgvFix.ShowCellToolTips = false;
            this.dgvFix.ShowEditingIcon = false;
            this.dgvFix.ShowRowErrors = false;
            this.dgvFix.Size = new System.Drawing.Size(407, 465);
            this.dgvFix.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список профилактик для оборудоания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(701, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выполненные профилактики";
            // 
            // profilacticIdDataGridViewTextBoxColumn
            // 
            this.profilacticIdDataGridViewTextBoxColumn.DataPropertyName = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.HeaderText = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.Name = "profilacticIdDataGridViewTextBoxColumn";
            this.profilacticIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.profilacticIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "№";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 43;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 64.93507F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Содержание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.FillWeight = 135.0649F;
            this.periodDataGridViewTextBoxColumn.HeaderText = "Период(мес)";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 96;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceDataGridViewTextBoxColumn.Visible = false;
            // 
            // profilacticBindingSource
            // 
            this.profilacticBindingSource.DataSource = typeof(KTS.Profilactic);
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
            this.ClientSize = new System.Drawing.Size(1148, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFix);
            this.Controls.Add(this.dgvExecuted);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 574);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профилактикиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvExecuted;
        private System.Windows.Forms.DataGridView dgvFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilacticIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profilacticBindingSource;
    }
}

