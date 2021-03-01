
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
            this.chlbFilters = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chlbFilters
            // 
            this.chlbFilters.FormattingEnabled = true;
            this.chlbFilters.Location = new System.Drawing.Point(16, 21);
            this.chlbFilters.Name = "chlbFilters";
            this.chlbFilters.Size = new System.Drawing.Size(270, 400);
            this.chlbFilters.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.chlbFilters);
            this.Name = "MainForm";
            this.Text = "Вибір товару";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbFilters;
    }
}

