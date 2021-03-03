
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
            this.btnFilterBrand = new System.Windows.Forms.Button();
            this.btnFilterPower = new System.Windows.Forms.Button();
            this.btnClosedBrand = new System.Windows.Forms.Button();
            this.btnClosedPower = new System.Windows.Forms.Button();
            this.pnlFilterBrand = new System.Windows.Forms.Panel();
            this.pnlFilterPower = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnFilterBrand
            // 
            this.btnFilterBrand.Location = new System.Drawing.Point(12, 11);
            this.btnFilterBrand.Name = "btnFilterBrand";
            this.btnFilterBrand.Size = new System.Drawing.Size(185, 38);
            this.btnFilterBrand.TabIndex = 0;
            this.btnFilterBrand.Text = "Виробник";
            this.btnFilterBrand.UseVisualStyleBackColor = true;
            this.btnFilterBrand.Click += new System.EventHandler(this.btnFilterBrand_Click);
            // 
            // btnFilterPower
            // 
            this.btnFilterPower.Location = new System.Drawing.Point(12, 198);
            this.btnFilterPower.Name = "btnFilterPower";
            this.btnFilterPower.Size = new System.Drawing.Size(185, 38);
            this.btnFilterPower.TabIndex = 1;
            this.btnFilterPower.Text = "Потужність";
            this.btnFilterPower.UseVisualStyleBackColor = true;
            this.btnFilterPower.Click += new System.EventHandler(this.btnFilterPower_Click);
            // 
            // btnClosedBrand
            // 
            this.btnClosedBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClosedBrand.Location = new System.Drawing.Point(203, 11);
            this.btnClosedBrand.Name = "btnClosedBrand";
            this.btnClosedBrand.Size = new System.Drawing.Size(36, 38);
            this.btnClosedBrand.TabIndex = 2;
            this.btnClosedBrand.Text = "X";
            this.btnClosedBrand.UseVisualStyleBackColor = true;
            this.btnClosedBrand.Click += new System.EventHandler(this.btnClosedBrand_Click);
            // 
            // btnClosedPower
            // 
            this.btnClosedPower.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClosedPower.Location = new System.Drawing.Point(203, 198);
            this.btnClosedPower.Name = "btnClosedPower";
            this.btnClosedPower.Size = new System.Drawing.Size(36, 38);
            this.btnClosedPower.TabIndex = 3;
            this.btnClosedPower.Text = "X";
            this.btnClosedPower.UseVisualStyleBackColor = true;
            this.btnClosedPower.Click += new System.EventHandler(this.btnClosedPower_Click);
            // 
            // pnlFilterBrand
            // 
            this.pnlFilterBrand.Location = new System.Drawing.Point(12, 55);
            this.pnlFilterBrand.Name = "pnlFilterBrand";
            this.pnlFilterBrand.Size = new System.Drawing.Size(226, 100);
            this.pnlFilterBrand.TabIndex = 4;
            // 
            // pnlFilterPower
            // 
            this.pnlFilterPower.Location = new System.Drawing.Point(12, 242);
            this.pnlFilterPower.Name = "pnlFilterPower";
            this.pnlFilterPower.Size = new System.Drawing.Size(222, 106);
            this.pnlFilterPower.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 621);
            this.Controls.Add(this.pnlFilterPower);
            this.Controls.Add(this.pnlFilterBrand);
            this.Controls.Add(this.btnClosedPower);
            this.Controls.Add(this.btnFilterBrand);
            this.Controls.Add(this.btnFilterPower);
            this.Controls.Add(this.btnClosedBrand);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір товару";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilterBrand;
        private System.Windows.Forms.Button btnFilterPower;
        private System.Windows.Forms.Button btnClosedBrand;
        private System.Windows.Forms.Button btnClosedPower;
        private System.Windows.Forms.Panel pnlFilterBrand;
        private System.Windows.Forms.Panel pnlFilterPower;
    }
}

