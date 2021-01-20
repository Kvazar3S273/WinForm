
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
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSurname,
            this.colGender,
            this.colPhone});
            this.dataGridView1.Location = new System.Drawing.Point(13, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(549, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSurname.HeaderText = "Прізвище, ім\'я";
            this.colSurname.Name = "colSurname";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Телефонний довідник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tboxSurname;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxPhone;
    }
}

