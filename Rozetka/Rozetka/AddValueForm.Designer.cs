
namespace Rozetka
{
    partial class AddValueForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGetName = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.lblNewFilter = new System.Windows.Forms.Label();
            this.tbNewFilter = new System.Windows.Forms.TextBox();
            this.btnAddNewFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Виберіть фільтр, до якого\r\nбажаєте додати новий параметр:";
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetName.Location = new System.Drawing.Point(12, 115);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(191, 21);
            this.lblGetName.TabIndex = 0;
            this.lblGetName.Text = "Введіть назву параметра:";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(16, 66);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(281, 23);
            this.cbFilter.TabIndex = 1;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(16, 139);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(280, 23);
            this.tbValue.TabIndex = 2;
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(16, 180);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(280, 53);
            this.btnAddParameter.TabIndex = 3;
            this.btnAddParameter.Text = "Додати параметр";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // lblNewFilter
            // 
            this.lblNewFilter.AutoSize = true;
            this.lblNewFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewFilter.Location = new System.Drawing.Point(16, 284);
            this.lblNewFilter.Name = "lblNewFilter";
            this.lblNewFilter.Size = new System.Drawing.Size(223, 21);
            this.lblNewFilter.TabIndex = 0;
            this.lblNewFilter.Text = "Введіть назву нового фільтра:";
            // 
            // tbNewFilter
            // 
            this.tbNewFilter.Location = new System.Drawing.Point(16, 308);
            this.tbNewFilter.Name = "tbNewFilter";
            this.tbNewFilter.Size = new System.Drawing.Size(280, 23);
            this.tbNewFilter.TabIndex = 2;
            // 
            // btnAddNewFilter
            // 
            this.btnAddNewFilter.Location = new System.Drawing.Point(16, 351);
            this.btnAddNewFilter.Name = "btnAddNewFilter";
            this.btnAddNewFilter.Size = new System.Drawing.Size(280, 53);
            this.btnAddNewFilter.TabIndex = 4;
            this.btnAddNewFilter.Text = "Додати новий фільтр";
            this.btnAddNewFilter.UseVisualStyleBackColor = true;
            this.btnAddNewFilter.Click += new System.EventHandler(this.btnAddNewFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "АБО";
            // 
            // AddValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewFilter);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.tbNewFilter);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblGetName);
            this.Controls.Add(this.lblNewFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати фільтр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.Label lblNewFilter;
        private System.Windows.Forms.TextBox tbNewFilter;
        private System.Windows.Forms.Button btnAddNewFilter;
        private System.Windows.Forms.Label label1;
    }
}