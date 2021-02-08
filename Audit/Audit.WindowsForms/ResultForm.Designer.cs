
namespace Audit.WindowsForms
{
    partial class ResultForm
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
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblIQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRightAnswers.Location = new System.Drawing.Point(16, 20);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(193, 21);
            this.lblRightAnswers.TabIndex = 0;
            this.lblRightAnswers.Text = "Правильних відповідей:";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrongAnswers.Location = new System.Drawing.Point(16, 54);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(211, 21);
            this.lblWrongAnswers.TabIndex = 0;
            this.lblWrongAnswers.Text = "Неправильних відповідей:";
            // 
            // lblIQ
            // 
            this.lblIQ.AutoSize = true;
            this.lblIQ.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIQ.Location = new System.Drawing.Point(16, 90);
            this.lblIQ.Name = "lblIQ";
            this.lblIQ.Size = new System.Drawing.Size(66, 21);
            this.lblIQ.TabIndex = 0;
            this.lblIQ.Text = "Ваш IQ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Всі сесії даного користувача:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColSurname,
            this.ColBegin,
            this.ColEnd});
            this.dataGridView1.Location = new System.Drawing.Point(16, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(592, 153);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Ім\'я";
            this.ColName.Name = "ColName";
            // 
            // ColSurname
            // 
            this.ColSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSurname.HeaderText = "Прізвище";
            this.ColSurname.Name = "ColSurname";
            // 
            // ColBegin
            // 
            this.ColBegin.HeaderText = "Час початку";
            this.ColBegin.Name = "ColBegin";
            // 
            // ColEnd
            // 
            this.ColEnd.HeaderText = "Час закінчення";
            this.ColEnd.Name = "ColEnd";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIQ);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblRightAnswers);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат тестування";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblIQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnd;
    }
}