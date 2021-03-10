
namespace Rozetka
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
            this.btnAddFilterValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFilterValue
            // 
            this.btnAddFilterValue.Location = new System.Drawing.Point(301, 11);
            this.btnAddFilterValue.Name = "btnAddFilterValue";
            this.btnAddFilterValue.Size = new System.Drawing.Size(173, 37);
            this.btnAddFilterValue.TabIndex = 7;
            this.btnAddFilterValue.Text = "Додати параметр в фільтр";
            this.btnAddFilterValue.UseVisualStyleBackColor = true;
            this.btnAddFilterValue.Click += new System.EventHandler(this.btnAddFilterValue_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 538);
            this.Controls.Add(this.btnAddFilterValue);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір товару";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button btnFilterBrand;
        //private System.Windows.Forms.Button btnFilterPower;
        //private System.Windows.Forms.Button btnClosedBrand;
        //private System.Windows.Forms.Button btnClosedPower;
        //private System.Windows.Forms.Panel pnlFilterBrand;
        //private System.Windows.Forms.Panel pnlFilterPower;
        //private System.Windows.Forms.Button btnSaveChoiceBrand;
        //private System.Windows.Forms.Button btnSaveChoicePower;
        private System.Windows.Forms.Button btnAddFilterValue;
    }
}

