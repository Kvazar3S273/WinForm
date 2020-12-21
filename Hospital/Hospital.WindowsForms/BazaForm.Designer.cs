namespace Hospital.WindowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColSurname
            // 
            this.ColSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSurname.HeaderText = "Прізвище ім\'я";
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColLogin
            // 
            this.ColLogin.HeaderText = "Логін";
            this.ColLogin.Name = "ColLogin";
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Пароль";
            this.ColPassword.Name = "ColPassword";
            // 
            // ColDepartment
            // 
            this.ColDepartment.HeaderText = "Відділення";
            this.ColDepartment.Name = "ColDepartment";
            // 
            // ColStage
            // 
            this.ColStage.HeaderText = "Стаж";
            this.ColStage.Name = "ColStage";
            // 
            // ColPhoto
            // 
            this.ColPhoto.HeaderText = "Фото";
            this.ColPhoto.Name = "ColPhoto";
            // 
            // BazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSurname,
            this.ColLogin,
            this.ColPassword,
            this.ColDepartment,
            this.ColStage,
            this.ColPhoto});
            this.dataGridView1.Location = new System.Drawing.Point(57, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BazaForm";
            this.Text = "BazaForm";
            this.Load += new System.EventHandler(this.BazaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhoto;
    }
}