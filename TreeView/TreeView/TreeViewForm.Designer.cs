
namespace TreeView
{
    partial class TreeViewForm
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
            this.tvBreed = new System.Windows.Forms.TreeView();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbAddElement = new System.Windows.Forms.TextBox();
            this.tbAddParent = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvBreed
            // 
            this.tvBreed.Location = new System.Drawing.Point(14, 12);
            this.tvBreed.Name = "tvBreed";
            this.tvBreed.Size = new System.Drawing.Size(259, 426);
            this.tvBreed.TabIndex = 0;
            this.tvBreed.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBreed_BeforeExpand);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(284, 12);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(192, 46);
            this.btnAddElement.TabIndex = 1;
            this.btnAddElement.Text = "Додати елемент";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(284, 108);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(192, 46);
            this.btnAddParent.TabIndex = 1;
            this.btnAddParent.Text = "Додати в корінь";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(284, 206);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExit.Location = new System.Drawing.Point(284, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbAddElement
            // 
            this.tbAddElement.Location = new System.Drawing.Point(284, 64);
            this.tbAddElement.Name = "tbAddElement";
            this.tbAddElement.Size = new System.Drawing.Size(192, 23);
            this.tbAddElement.TabIndex = 2;
            // 
            // tbAddParent
            // 
            this.tbAddParent.Location = new System.Drawing.Point(284, 160);
            this.tbAddParent.Name = "tbAddParent";
            this.tbAddParent.Size = new System.Drawing.Size(192, 23);
            this.tbAddParent.TabIndex = 2;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(284, 258);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(192, 23);
            this.tbEdit.TabIndex = 2;
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.tbAddParent);
            this.Controls.Add(this.tbAddElement);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.btnAddElement);
            this.Controls.Add(this.tvBreed);
            this.Name = "TreeViewForm";
            this.Text = "Продукти";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvBreed;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbAddElement;
        private System.Windows.Forms.TextBox tbAddParent;
        private System.Windows.Forms.TextBox tbEdit;
    }
}

