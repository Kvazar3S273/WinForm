namespace NEWHospital.WindowsForms
{
    partial class BazaForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(435, 609);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 45);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад в меню";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Прізвище";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLastName.Width = 120;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "Ім\'я";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFirstName.Width = 120;
            // 
            // ColStage
            // 
            this.ColStage.HeaderText = "Стаж";
            this.ColStage.Name = "ColStage";
            this.ColStage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColStage.Width = 50;
            // 
            // ColLogin
            // 
            this.ColLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLogin.HeaderText = "Логін";
            this.ColLogin.Name = "ColLogin";
            this.ColLogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLastName,
            this.ColFirstName,
            this.ColStage,
            this.ColLogin});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 570);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(14, 609);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(70, 45);
            this.btnFirstPage.TabIndex = 1;
            this.btnFirstPage.Text = "Перша сторінка";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(90, 609);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(45, 45);
            this.btnPrevPage.TabIndex = 2;
            this.btnPrevPage.Text = "<<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(197, 609);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(45, 45);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(248, 609);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(70, 45);
            this.btnLastPage.TabIndex = 4;
            this.btnLastPage.Text = "Остання сторінка";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearch.Location = new System.Drawing.Point(324, 609);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPage.Location = new System.Drawing.Point(141, 619);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(52, 21);
            this.lblCurrentPage.TabIndex = 7;
            this.lblCurrentPage.Text = "label1";
            // 
            // BazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 666);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BazaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База лікарів";
            this.Load += new System.EventHandler(this.BazaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogin;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCurrentPage;
    }
}