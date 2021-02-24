
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
            this.tbUrlSlug = new System.Windows.Forms.TextBox();
            this.lblNameAddElement = new System.Windows.Forms.Label();
            this.lblNameAddParent = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblUrlSlugAddParent = new System.Windows.Forms.Label();
            this.tbUrlSlugEdit = new System.Windows.Forms.TextBox();
            this.lblUrlSlugEdit = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbUrlSlugElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvBreed
            // 
            this.tvBreed.Location = new System.Drawing.Point(14, 12);
            this.tvBreed.Name = "tvBreed";
            this.tvBreed.Size = new System.Drawing.Size(250, 522);
            this.tvBreed.TabIndex = 0;
            this.tvBreed.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvBreed_BeforeExpand);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(277, 12);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(237, 46);
            this.btnAddElement.TabIndex = 1;
            this.btnAddElement.Text = "Додати елемент";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(277, 135);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(237, 46);
            this.btnAddParent.TabIndex = 1;
            this.btnAddParent.Text = "Додати в корінь";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(277, 257);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(237, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExit.Location = new System.Drawing.Point(277, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(237, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbAddElement
            // 
            this.tbAddElement.Location = new System.Drawing.Point(322, 64);
            this.tbAddElement.Name = "tbAddElement";
            this.tbAddElement.Size = new System.Drawing.Size(192, 23);
            this.tbAddElement.TabIndex = 2;
            // 
            // tbAddParent
            // 
            this.tbAddParent.Location = new System.Drawing.Point(322, 187);
            this.tbAddParent.Name = "tbAddParent";
            this.tbAddParent.Size = new System.Drawing.Size(192, 23);
            this.tbAddParent.TabIndex = 2;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(322, 309);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(192, 23);
            this.tbEdit.TabIndex = 2;
            // 
            // tbUrlSlug
            // 
            this.tbUrlSlug.Location = new System.Drawing.Point(322, 216);
            this.tbUrlSlug.Name = "tbUrlSlug";
            this.tbUrlSlug.Size = new System.Drawing.Size(192, 23);
            this.tbUrlSlug.TabIndex = 2;
            // 
            // lblNameAddElement
            // 
            this.lblNameAddElement.AutoSize = true;
            this.lblNameAddElement.Location = new System.Drawing.Point(277, 67);
            this.lblNameAddElement.Name = "lblNameAddElement";
            this.lblNameAddElement.Size = new System.Drawing.Size(39, 15);
            this.lblNameAddElement.TabIndex = 3;
            this.lblNameAddElement.Text = "Назва";
            // 
            // lblNameAddParent
            // 
            this.lblNameAddParent.AutoSize = true;
            this.lblNameAddParent.Location = new System.Drawing.Point(277, 190);
            this.lblNameAddParent.Name = "lblNameAddParent";
            this.lblNameAddParent.Size = new System.Drawing.Size(39, 15);
            this.lblNameAddParent.TabIndex = 3;
            this.lblNameAddParent.Text = "Назва";
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.AutoSize = true;
            this.lblNameEdit.Location = new System.Drawing.Point(277, 312);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(39, 15);
            this.lblNameEdit.TabIndex = 3;
            this.lblNameEdit.Text = "Назва";
            // 
            // lblUrlSlugAddParent
            // 
            this.lblUrlSlugAddParent.AutoSize = true;
            this.lblUrlSlugAddParent.Location = new System.Drawing.Point(277, 219);
            this.lblUrlSlugAddParent.Name = "lblUrlSlugAddParent";
            this.lblUrlSlugAddParent.Size = new System.Drawing.Size(30, 15);
            this.lblUrlSlugAddParent.TabIndex = 3;
            this.lblUrlSlugAddParent.Text = "Slug";
            // 
            // tbUrlSlugEdit
            // 
            this.tbUrlSlugEdit.Location = new System.Drawing.Point(322, 338);
            this.tbUrlSlugEdit.Name = "tbUrlSlugEdit";
            this.tbUrlSlugEdit.Size = new System.Drawing.Size(192, 23);
            this.tbUrlSlugEdit.TabIndex = 2;
            // 
            // lblUrlSlugEdit
            // 
            this.lblUrlSlugEdit.AutoSize = true;
            this.lblUrlSlugEdit.Location = new System.Drawing.Point(277, 341);
            this.lblUrlSlugEdit.Name = "lblUrlSlugEdit";
            this.lblUrlSlugEdit.Size = new System.Drawing.Size(30, 15);
            this.lblUrlSlugEdit.TabIndex = 3;
            this.lblUrlSlugEdit.Text = "Slug";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdate.Location = new System.Drawing.Point(277, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(236, 52);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Оновити дерево";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbUrlSlugElement
            // 
            this.tbUrlSlugElement.Location = new System.Drawing.Point(322, 93);
            this.tbUrlSlugElement.Name = "tbUrlSlugElement";
            this.tbUrlSlugElement.Size = new System.Drawing.Size(192, 23);
            this.tbUrlSlugElement.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slug";
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 550);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblNameEdit);
            this.Controls.Add(this.lblUrlSlugEdit);
            this.Controls.Add(this.lblUrlSlugAddParent);
            this.Controls.Add(this.lblNameAddParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameAddElement);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.tbUrlSlugEdit);
            this.Controls.Add(this.tbUrlSlug);
            this.Controls.Add(this.tbAddParent);
            this.Controls.Add(this.tbUrlSlugElement);
            this.Controls.Add(this.tbAddElement);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.btnAddElement);
            this.Controls.Add(this.tvBreed);
            this.Name = "TreeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox tbUrlSlug;
        private System.Windows.Forms.Label lblNameAddElement;
        private System.Windows.Forms.Label lblNameAddParent;
        private System.Windows.Forms.Label lblNameEdit;
        private System.Windows.Forms.Label lblUrlSlugAddParent;
        private System.Windows.Forms.TextBox tbUrlSlugEdit;
        private System.Windows.Forms.Label lblUrlSlugEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUrlSlugElement;
        private System.Windows.Forms.Label label1;
    }
}

