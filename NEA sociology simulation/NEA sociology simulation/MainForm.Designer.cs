namespace NEA_sociology_simulation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TickYearButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Agentlist = new System.Windows.Forms.TextBox();
            this.AdvancedOptionsToggle = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Loadmenu = new System.Windows.Forms.Button();
            this.Housingavailablelabel = new System.Windows.Forms.Label();
            this.MakeQuiz = new System.Windows.Forms.Button();
            this.LoadQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TickYearButton
            // 
            this.TickYearButton.Location = new System.Drawing.Point(0, 0);
            this.TickYearButton.Name = "TickYearButton";
            this.TickYearButton.Size = new System.Drawing.Size(75, 23);
            this.TickYearButton.TabIndex = 0;
            this.TickYearButton.Text = "Next year";
            this.TickYearButton.UseVisualStyleBackColor = true;
            this.TickYearButton.Click += new System.EventHandler(this.TickYear);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Year";
            chartArea1.AxisY.Title = "Population";
            chartArea1.Name = "Population Graph";
            chartArea2.AxisX.Title = "Age Group";
            chartArea2.AxisY.Title = "Total Wealth";
            chartArea2.Name = "Income Distribution";
            chartArea3.AxisX.Title = "Age Group";
            chartArea3.AxisY.Title = "Population";
            chartArea3.Name = "Age Distribution";
            chartArea4.Name = "Dependancy Ratio";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legendCellColumn1.HeaderBackColor = System.Drawing.Color.Red;
            legendCellColumn1.Name = "Elderly";
            legend1.CellColumns.Add(legendCellColumn1);
            legendItem1.BackImageTransparentColor = System.Drawing.Color.White;
            legendItem1.BackSecondaryColor = System.Drawing.Color.White;
            legendItem1.Color = System.Drawing.Color.RoyalBlue;
            legendItem1.MarkerColor = System.Drawing.Color.Transparent;
            legendItem1.Name = "Elderly";
            legendItem1.SeparatorColor = System.Drawing.Color.Transparent;
            legendItem2.Color = System.Drawing.Color.Yellow;
            legendItem2.Name = "Children";
            legendItem3.Color = System.Drawing.Color.Red;
            legendItem3.Name = "Working Age";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 15.81028F;
            legend1.Position.Width = 14.87029F;
            legend1.Position.X = 85.12971F;
            legend1.Position.Y = 50.64946F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(133, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "Population Graph";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Population";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "Income Distribution";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Income Distribution";
            series3.ChartArea = "Age Distribution";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Age Distribution";
            series4.ChartArea = "Dependancy Ratio";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Dependancy ratio";
            dataPoint1.Label = "Elderly";
            dataPoint2.Label = "Children";
            dataPoint3.Label = "Working age";
            series4.Points.Add(dataPoint1);
            series4.Points.Add(dataPoint2);
            series4.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(664, 507);
            this.chart1.TabIndex = 2;
            title1.Name = "Title1";
            title1.Text = "Population, Wealth, Age, and Dependancy";
            this.chart1.Titles.Add(title1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.TickYear);
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(81, 0);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(75, 23);
            this.StartBTN.TabIndex = 3;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Agentlist
            // 
            this.Agentlist.Location = new System.Drawing.Point(0, 29);
            this.Agentlist.Multiline = true;
            this.Agentlist.Name = "Agentlist";
            this.Agentlist.ReadOnly = true;
            this.Agentlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Agentlist.Size = new System.Drawing.Size(130, 507);
            this.Agentlist.TabIndex = 8;
            // 
            // AdvancedOptionsToggle
            // 
            this.AdvancedOptionsToggle.Location = new System.Drawing.Point(722, 2);
            this.AdvancedOptionsToggle.Name = "AdvancedOptionsToggle";
            this.AdvancedOptionsToggle.Size = new System.Drawing.Size(75, 23);
            this.AdvancedOptionsToggle.TabIndex = 9;
            this.AdvancedOptionsToggle.Text = "Adv Opt";
            this.AdvancedOptionsToggle.UseVisualStyleBackColor = true;
            this.AdvancedOptionsToggle.Click += new System.EventHandler(this.AdvancedOptionsToggle_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(162, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Loadmenu
            // 
            this.Loadmenu.Location = new System.Drawing.Point(243, 0);
            this.Loadmenu.Name = "Loadmenu";
            this.Loadmenu.Size = new System.Drawing.Size(75, 23);
            this.Loadmenu.TabIndex = 11;
            this.Loadmenu.Text = "Load";
            this.Loadmenu.UseVisualStyleBackColor = true;
            this.Loadmenu.Click += new System.EventHandler(this.Loadmenu_Click);
            // 
            // Housingavailablelabel
            // 
            this.Housingavailablelabel.AutoSize = true;
            this.Housingavailablelabel.Location = new System.Drawing.Point(486, 5);
            this.Housingavailablelabel.Name = "Housingavailablelabel";
            this.Housingavailablelabel.Size = new System.Drawing.Size(118, 13);
            this.Housingavailablelabel.TabIndex = 12;
            this.Housingavailablelabel.Text = "100% housing available";
            // 
            // MakeQuiz
            // 
            this.MakeQuiz.Location = new System.Drawing.Point(324, 0);
            this.MakeQuiz.Name = "MakeQuiz";
            this.MakeQuiz.Size = new System.Drawing.Size(75, 23);
            this.MakeQuiz.TabIndex = 13;
            this.MakeQuiz.Text = "Make Quiz";
            this.MakeQuiz.UseMnemonic = false;
            this.MakeQuiz.UseVisualStyleBackColor = true;
            this.MakeQuiz.Click += new System.EventHandler(this.MakeQuiz_Click);
            // 
            // LoadQuiz
            // 
            this.LoadQuiz.Location = new System.Drawing.Point(405, 0);
            this.LoadQuiz.Name = "LoadQuiz";
            this.LoadQuiz.Size = new System.Drawing.Size(75, 23);
            this.LoadQuiz.TabIndex = 14;
            this.LoadQuiz.Text = "Play Quiz";
            this.LoadQuiz.UseMnemonic = false;
            this.LoadQuiz.UseVisualStyleBackColor = true;
            this.LoadQuiz.Click += new System.EventHandler(this.LoadQuiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 548);
            this.Controls.Add(this.LoadQuiz);
            this.Controls.Add(this.MakeQuiz);
            this.Controls.Add(this.Housingavailablelabel);
            this.Controls.Add(this.Loadmenu);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AdvancedOptionsToggle);
            this.Controls.Add(this.Agentlist);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TickYearButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sociological Population and Wealth Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TickYearButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Agentlist;
        private System.Windows.Forms.Button AdvancedOptionsToggle;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Loadmenu;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Housingavailablelabel;
        private System.Windows.Forms.Button MakeQuiz;
        private System.Windows.Forms.Button LoadQuiz;
    }
}

