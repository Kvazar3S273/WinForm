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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxStage = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.btnSearchDepartment = new System.Windows.Forms.Button();
            this.btnSearchStage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPrev
            // 
            this.btnSearchPrev.Location = new System.Drawing.Point(12, 600);
            this.btnSearchPrev.Name = "btnSearchPrev";
            this.btnSearchPrev.Size = new System.Drawing.Size(45, 45);
            this.btnSearchPrev.TabIndex = 1;
            this.btnSearchPrev.Text = "<<";
            this.btnSearchPrev.UseVisualStyleBackColor = true;
            this.btnSearchPrev.Click += new System.EventHandler(this.btnSearchPrev_Click);
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.Location = new System.Drawing.Point(63, 600);
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
            this.btnBack.Location = new System.Drawing.Point(447, 602);
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
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(128, 59);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(269, 23);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxStage
            // 
            this.textBoxStage.Location = new System.Drawing.Point(128, 141);
            this.textBoxStage.Name = "textBoxStage";
            this.textBoxStage.Size = new System.Drawing.Size(269, 23);
            this.textBoxStage.TabIndex = 8;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(128, 100);
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
            this.dataGridView1.Size = new System.Drawing.Size(525, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Відділення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Стаж";
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.Location = new System.Drawing.Point(420, 54);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(117, 30);
            this.btnSearchLastName.TabIndex = 12;
            this.btnSearchLastName.Text = "Знайти";
            this.btnSearchLastName.UseVisualStyleBackColor = true;
            this.btnSearchLastName.Click += new System.EventHandler(this.btnSearchLastName_Click);
            // 
            // btnSearchDepartment
            // 
            this.btnSearchDepartment.Location = new System.Drawing.Point(420, 96);
            this.btnSearchDepartment.Name = "btnSearchDepartment";
            this.btnSearchDepartment.Size = new System.Drawing.Size(117, 30);
            this.btnSearchDepartment.TabIndex = 13;
            this.btnSearchDepartment.Text = "Знайти";
            this.btnSearchDepartment.UseVisualStyleBackColor = true;
            this.btnSearchDepartment.Click += new System.EventHandler(this.btnSearchDepartment_Click);
            // 
            // btnSearchStage
            // 
            this.btnSearchStage.Location = new System.Drawing.Point(420, 138);
            this.btnSearchStage.Name = "btnSearchStage";
            this.btnSearchStage.Size = new System.Drawing.Size(117, 30);
            this.btnSearchStage.TabIndex = 14;
            this.btnSearchStage.Text = "Знайти";
            this.btnSearchStage.UseVisualStyleBackColor = true;
            this.btnSearchStage.Click += new System.EventHandler(this.btnSearchStage_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 657);
            this.Controls.Add(this.btnSearchStage);
            this.Controls.Add(this.btnSearchDepartment);
            this.Controls.Add(this.btnSearchLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxStage);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchNext);
            this.Controls.Add(this.btnSearchPrev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchPrev;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxStage;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.Button btnSearchDepartment;
        private System.Windows.Forms.Button btnSearchStage;
    }
}