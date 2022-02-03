namespace NEA_sociology_simulation
{
    partial class QuizSelectionForm
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
            this.QuizSubmit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.QuizComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuizSubmit
            // 
            this.QuizSubmit.Location = new System.Drawing.Point(31, 40);
            this.QuizSubmit.Name = "QuizSubmit";
            this.QuizSubmit.Size = new System.Drawing.Size(75, 23);
            this.QuizSubmit.TabIndex = 4;
            this.QuizSubmit.Text = "Submit";
            this.QuizSubmit.UseVisualStyleBackColor = true;
            this.QuizSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuizComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(141, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // QuizComboBox
            // 
            this.QuizComboBox.Name = "QuizComboBox";
            this.QuizComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // QuizSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 73);
            this.ControlBox = false;
            this.Controls.Add(this.QuizSubmit);
            this.Controls.Add(this.toolStrip1);
            this.Name = "QuizSelectionForm";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuizSubmit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripComboBox QuizComboBox;
    }
}