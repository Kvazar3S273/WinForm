﻿
namespace PhoneBook.WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblRange = new System.Windows.Forms.Label();
            this.cbCountShowOnePage = new System.Windows.Forms.ComboBox();
            this.gbBoxButton = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSurname,
            this.colName,
            this.colGender,
            this.colPhone});
            this.dataGridView1.Location = new System.Drawing.Point(13, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(549, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSurname.HeaderText = "Прізвище";
            this.colSurname.Name = "colSurname";
            // 
            // colName
            // 
            this.colName.HeaderText = "Ім\'я";
            this.colName.Name = "colName";
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Стать";
            this.colGender.Name = "colGender";
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Номер телефону";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 150;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(196, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Пошук по фільтру";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(11, 54);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Прізвище";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(149, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ім\'я";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(285, 54);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Телефон";
            // 
            // tboxSurname
            // 
            this.tboxSurname.Location = new System.Drawing.Point(13, 85);
            this.tboxSurname.Name = "tboxSurname";
            this.tboxSurname.Size = new System.Drawing.Size(130, 23);
            this.tboxSurname.TabIndex = 3;
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(149, 85);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(130, 23);
            this.tboxName.TabIndex = 3;
            // 
            // tboxPhone
            // 
            this.tboxPhone.Location = new System.Drawing.Point(285, 85);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(130, 23);
            this.tboxPhone.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(433, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 54);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(12, 489);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(73, 20);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Всього: 0";
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.Location = new System.Drawing.Point(399, 489);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(78, 30);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRight.Location = new System.Drawing.Point(483, 489);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(78, 30);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRange.Location = new System.Drawing.Point(72, 123);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(147, 20);
            this.lblRange.TabIndex = 2;
            this.lblRange.Text = "Показано: з 0 по 10";
            // 
            // cbCountShowOnePage
            // 
            this.cbCountShowOnePage.FormattingEnabled = true;
            this.cbCountShowOnePage.Location = new System.Drawing.Point(13, 123);
            this.cbCountShowOnePage.Name = "cbCountShowOnePage";
            this.cbCountShowOnePage.Size = new System.Drawing.Size(53, 23);
            this.cbCountShowOnePage.TabIndex = 6;
            // 
            // gbBoxButton
            // 
            this.gbBoxButton.Location = new System.Drawing.Point(16, 525);
            this.gbBoxButton.Name = "gbBoxButton";
            this.gbBoxButton.Size = new System.Drawing.Size(544, 67);
            this.gbBoxButton.TabIndex = 7;
            this.gbBoxButton.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Тестування";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "Тестування";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 607);
            this.Controls.Add(this.gbBoxButton);
            this.Controls.Add(this.cbCountShowOnePage);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Телефонний довідник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tboxSurname;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.ComboBox cbCountShowOnePage;
        private System.Windows.Forms.GroupBox gbBoxButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

