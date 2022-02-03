
namespace NEA_sociology_simulation
{
    partial class AdvancedOptionsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Housingsupplyinput = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Reproductionchanceinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Minincomeinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Maxincomeinput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Deathchancemodinput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Housing available:";
            // 
            // Housingsupplyinput
            // 
            this.Housingsupplyinput.Location = new System.Drawing.Point(132, 6);
            this.Housingsupplyinput.MaxLength = 4;
            this.Housingsupplyinput.Multiline = true;
            this.Housingsupplyinput.Name = "Housingsupplyinput";
            this.Housingsupplyinput.Size = new System.Drawing.Size(99, 20);
            this.Housingsupplyinput.TabIndex = 8;
            this.Housingsupplyinput.Text = "100";
            this.Housingsupplyinput.TextChanged += new System.EventHandler(this.Housingsupplyinput_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(66, 136);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 9;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Reproductionchanceinput
            // 
            this.Reproductionchanceinput.Location = new System.Drawing.Point(132, 32);
            this.Reproductionchanceinput.MaxLength = 4;
            this.Reproductionchanceinput.Multiline = true;
            this.Reproductionchanceinput.Name = "Reproductionchanceinput";
            this.Reproductionchanceinput.Size = new System.Drawing.Size(99, 20);
            this.Reproductionchanceinput.TabIndex = 11;
            this.Reproductionchanceinput.Text = "25";
            this.Reproductionchanceinput.TextChanged += new System.EventHandler(this.Reproductionchanceinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Birth chance (%):";
            // 
            // Minincomeinput
            // 
            this.Minincomeinput.Location = new System.Drawing.Point(132, 58);
            this.Minincomeinput.MaxLength = 4;
            this.Minincomeinput.Multiline = true;
            this.Minincomeinput.Name = "Minincomeinput";
            this.Minincomeinput.Size = new System.Drawing.Size(99, 20);
            this.Minincomeinput.TabIndex = 13;
            this.Minincomeinput.Text = "20000";
            this.Minincomeinput.TextChanged += new System.EventHandler(this.Minincomeinput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min Income ($):";
            // 
            // Maxincomeinput
            // 
            this.Maxincomeinput.Location = new System.Drawing.Point(132, 84);
            this.Maxincomeinput.MaxLength = 4;
            this.Maxincomeinput.Multiline = true;
            this.Maxincomeinput.Name = "Maxincomeinput";
            this.Maxincomeinput.Size = new System.Drawing.Size(99, 20);
            this.Maxincomeinput.TabIndex = 15;
            this.Maxincomeinput.Text = "100000";
            this.Maxincomeinput.TextChanged += new System.EventHandler(this.Maxincomeinput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Max income ($):";
            // 
            // Deathchancemodinput
            // 
            this.Deathchancemodinput.Location = new System.Drawing.Point(132, 110);
            this.Deathchancemodinput.MaxLength = 4;
            this.Deathchancemodinput.Multiline = true;
            this.Deathchancemodinput.Name = "Deathchancemodinput";
            this.Deathchancemodinput.Size = new System.Drawing.Size(99, 20);
            this.Deathchancemodinput.TabIndex = 17;
            this.Deathchancemodinput.Text = "10";
            this.Deathchancemodinput.TextChanged += new System.EventHandler(this.Deathchancemodinput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chance to die (% = Age/):";
            // 
            // AdvancedOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 172);
            this.ControlBox = false;
            this.Controls.Add(this.Deathchancemodinput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Maxincomeinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Minincomeinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reproductionchanceinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Housingsupplyinput);
            this.Controls.Add(this.label2);
            this.Name = "AdvancedOptionsForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Housingsupplyinput;
        public System.Windows.Forms.TextBox Reproductionchanceinput;
        public System.Windows.Forms.TextBox Minincomeinput;
        public System.Windows.Forms.TextBox Maxincomeinput;
        public System.Windows.Forms.TextBox Deathchancemodinput;
    }
}