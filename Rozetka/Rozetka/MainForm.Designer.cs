
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFilterValue
            // 
            this.btnAddFilterValue.Location = new System.Drawing.Point(547, 12);
            this.btnAddFilterValue.Name = "btnAddFilterValue";
            this.btnAddFilterValue.Size = new System.Drawing.Size(173, 37);
            this.btnAddFilterValue.TabIndex = 7;
            this.btnAddFilterValue.Text = "Додати параметр в фільтр";
            this.btnAddFilterValue.UseVisualStyleBackColor = true;
            this.btnAddFilterValue.Click += new System.EventHandler(this.btnAddFilterValue_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColPrice,
            this.ColImage});
            this.dgvProducts.Location = new System.Drawing.Point(164, 55);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(556, 548);
            this.dgvProducts.TabIndex = 8;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.Name = "ColName";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Ціна";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 50;
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "Фото";
            this.ColImage.Name = "ColImage";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 565);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(146, 38);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Застосувати фільтри";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 615);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddFilterValue);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір товару";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
    }
}

