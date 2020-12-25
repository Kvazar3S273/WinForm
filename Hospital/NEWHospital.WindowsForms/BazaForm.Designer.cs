﻿namespace NEWHospital.WindowsForms
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
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Прізвище";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.Width = 120;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "Ім\'я";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.Width = 120;
            // 
            // ColStage
            // 
            this.ColStage.HeaderText = "Стаж";
            this.ColStage.Name = "ColStage";
            this.ColStage.Width = 50;
            // 
            // ColDepartment
            // 
            this.ColDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDepartment.HeaderText = "Відділення";
            this.ColDepartment.Name = "ColDepartment";
            // 
            // ColLogin
            // 
            this.ColLogin.HeaderText = "Логін";
            this.ColLogin.Name = "ColLogin";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(463, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 49);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад в меню";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // BazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 308);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLastName,
            this.ColFirstName,
            this.ColStage,
            this.ColDepartment,
            this.ColLogin});
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BazaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BazaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}