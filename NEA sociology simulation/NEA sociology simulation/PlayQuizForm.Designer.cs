namespace NEA_sociology_simulation
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.AnswerSubmitQuiz = new System.Windows.Forms.Button();
            this.NameInputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AnswerSubmitQuiz
            // 
            this.AnswerSubmitQuiz.Location = new System.Drawing.Point(1150, 14);
            this.AnswerSubmitQuiz.Name = "AnswerSubmitQuiz";
            this.AnswerSubmitQuiz.Size = new System.Drawing.Size(75, 23);
            this.AnswerSubmitQuiz.TabIndex = 0;
            this.AnswerSubmitQuiz.Text = "Submit";
            this.AnswerSubmitQuiz.UseVisualStyleBackColor = true;
            this.AnswerSubmitQuiz.Click += new System.EventHandler(this.Submit);
            // 
            // NameInputTextbox
            // 
            this.NameInputTextbox.Location = new System.Drawing.Point(1138, 43);
            this.NameInputTextbox.Name = "NameInputTextbox";
            this.NameInputTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameInputTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // ScoreList
            // 
            this.ScoreList.AcceptsReturn = true;
            this.ScoreList.Location = new System.Drawing.Point(1101, 67);
            this.ScoreList.Multiline = true;
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.ReadOnly = true;
            this.ScoreList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScoreList.Size = new System.Drawing.Size(136, 385);
            this.ScoreList.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 452);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInputTextbox);
            this.Controls.Add(this.AnswerSubmitQuiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Play Quiz";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnswerSubmitQuiz;
        private System.Windows.Forms.TextBox NameInputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScoreList;
    }
}