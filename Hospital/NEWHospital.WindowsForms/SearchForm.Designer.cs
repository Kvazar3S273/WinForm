namespace NEWHospital.WindowsForms
{
    partial class SearchForm
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
            this.btnSearchPrev = new System.Windows.Forms.Button();
            this.btnSearchNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbtnLastName = new System.Windows.Forms.RadioButton();
            this.rbtnStage = new System.Windows.Forms.RadioButton();
            this.rbtnDepartment = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxStage = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchPrev
            // 
            this.btnSearchPrev.Location = new System.Drawing.Point(12, 432);
            this.btnSearchPrev.Name = "btnSearchPrev";
            this.btnSearchPrev.Size = new System.Drawing.Size(45, 45);
            this.btnSearchPrev.TabIndex = 1;
            this.btnSearchPrev.Text = "<<";
            this.btnSearchPrev.UseVisualStyleBackColor = true;
            this.btnSearchPrev.Click += new System.EventHandler(this.btnSearchPrev_Click);
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.Location = new System.Drawing.Point(63, 432);
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(45, 45);
            this.btnSearchNext.TabIndex = 2;
            this.btnSearchNext.Text = ">>";
            this.btnSearchNext.UseVisualStyleBackColor = true;
            this.btnSearchNext.Click += new System.EventHandler(this.btnSearchNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(447, 434);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад \r\nдо бази";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(178, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Пошук по фільтру";
            // 
            // rbtnLastName
            // 
            this.rbtnLastName.AutoSize = true;
            this.rbtnLastName.Location = new System.Drawing.Point(14, 15);
            this.rbtnLastName.Name = "rbtnLastName";
            this.rbtnLastName.Size = new System.Drawing.Size(79, 19);
            this.rbtnLastName.TabIndex = 5;
            this.rbtnLastName.TabStop = true;
            this.rbtnLastName.Text = "Прізвище";
            this.rbtnLastName.UseVisualStyleBackColor = true;
            this.rbtnLastName.CheckedChanged += new System.EventHandler(this.rbtnLastName_CheckedChanged);
            // 
            // rbtnStage
            // 
            this.rbtnStage.AutoSize = true;
            this.rbtnStage.Location = new System.Drawing.Point(14, 56);
            this.rbtnStage.Name = "rbtnStage";
            this.rbtnStage.Size = new System.Drawing.Size(53, 19);
            this.rbtnStage.TabIndex = 6;
            this.rbtnStage.TabStop = true;
            this.rbtnStage.Text = "Стаж";
            this.rbtnStage.UseVisualStyleBackColor = true;
            this.rbtnStage.CheckedChanged += new System.EventHandler(this.rbtnStage_CheckedChanged);
            // 
            // rbtnDepartment
            // 
            this.rbtnDepartment.AutoSize = true;
            this.rbtnDepartment.Location = new System.Drawing.Point(14, 97);
            this.rbtnDepartment.Name = "rbtnDepartment";
            this.rbtnDepartment.Size = new System.Drawing.Size(83, 19);
            this.rbtnDepartment.TabIndex = 7;
            this.rbtnDepartment.TabStop = true;
            this.rbtnDepartment.Text = "Відділення";
            this.rbtnDepartment.UseVisualStyleBackColor = true;
            this.rbtnDepartment.CheckedChanged += new System.EventHandler(this.rbtnDepartment_CheckedChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(128, 59);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(269, 23);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxStage
            // 
            this.textBoxStage.Location = new System.Drawing.Point(128, 101);
            this.textBoxStage.Name = "textBoxStage";
            this.textBoxStage.Size = new System.Drawing.Size(269, 23);
            this.textBoxStage.TabIndex = 8;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(128, 143);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(269, 23);
            this.textBoxDepartment.TabIndex = 8;
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
            // ColDepartment
            // 
            this.ColDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDepartment.HeaderText = "Відділення";
            this.ColDepartment.Name = "ColDepartment";
            this.ColDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLastName,
            this.ColFirstName,
            this.ColStage,
            this.ColDepartment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnDepartment);
            this.panel1.Controls.Add(this.rbtnStage);
            this.panel1.Controls.Add(this.rbtnLastName);
            this.panel1.Location = new System.Drawing.Point(11, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 130);
            this.panel1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(427, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 128);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 491);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxStage);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchNext);
            this.Controls.Add(this.btnSearchPrev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchPrev;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbtnLastName;
        private System.Windows.Forms.RadioButton rbtnStage;
        private System.Windows.Forms.RadioButton rbtnDepartment;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxStage;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
    }
}