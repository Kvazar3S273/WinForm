
namespace UserRoles
{
    partial class EditForm
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
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(107, 170);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(230, 23);
            this.cbRole.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTitle.Location = new System.Drawing.Point(111, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 21);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Введіть нові дані:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(25, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Ім\'я";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 23);
            this.tbName.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(25, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(107, 83);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(230, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 112);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(69, 20);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Телефон";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(107, 112);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(230, 23);
            this.tbPhoneNumber.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(25, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(107, 141);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(230, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(25, 170);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(60, 20);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Посада";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(77, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImage.Location = new System.Drawing.Point(133, 210);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(97, 20);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Зображення";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(33, 243);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(296, 187);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 523);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbRole);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbImage;
    }
}