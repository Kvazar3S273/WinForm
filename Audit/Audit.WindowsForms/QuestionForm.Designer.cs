
namespace Audit.WindowsForms
{
    partial class QuestionForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxTimer = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Запитання";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Location = new System.Drawing.Point(19, 137);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(557, 160);
            this.gbAnswers.TabIndex = 1;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Варіанти відповідей:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пройшло                          секунд";
            // 
            // tBoxTimer
            // 
            this.tBoxTimer.Location = new System.Drawing.Point(463, 26);
            this.tBoxTimer.Name = "tBoxTimer";
            this.tBoxTimer.Size = new System.Drawing.Size(65, 23);
            this.tBoxTimer.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(404, 58);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 59);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Зупинити таймер";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblQuestion);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 88);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(19, 323);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 15);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "label2";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(19, 356);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 15);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "label2";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(319, 314);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 57);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Наступне запитання";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Переглянути\r\nвсі свої сесії";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tBoxTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAnswers);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
    }
}