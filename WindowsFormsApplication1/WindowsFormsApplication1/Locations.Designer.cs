﻿namespace WindowsFormsApplication1
{
    partial class Locations
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_District12 = new System.Windows.Forms.Button();
            this.button_District10 = new System.Windows.Forms.Button();
            this.button_District9 = new System.Windows.Forms.Button();
            this.button_District5 = new System.Windows.Forms.Button();
            this.button_District3 = new System.Windows.Forms.Button();
            this.button_District6 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button_District12);
            this.panel1.Controls.Add(this.button_District10);
            this.panel1.Controls.Add(this.button_District9);
            this.panel1.Controls.Add(this.button_District5);
            this.panel1.Controls.Add(this.button_District3);
            this.panel1.Controls.Add(this.button_District6);
            this.panel1.Location = new System.Drawing.Point(40, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 148);
            this.panel1.TabIndex = 1;
            // 
            // button_District12
            // 
            this.button_District12.Location = new System.Drawing.Point(22, 125);
            this.button_District12.Margin = new System.Windows.Forms.Padding(2);
            this.button_District12.Name = "button_District12";
            this.button_District12.Size = new System.Drawing.Size(162, 20);
            this.button_District12.TabIndex = 9;
            this.button_District12.Text = "Rotterdam Centrum";
            this.button_District12.UseVisualStyleBackColor = true;
            this.button_District12.Click += new System.EventHandler(this.button_District12_Click);
            // 
            // button_District10
            // 
            this.button_District10.Location = new System.Drawing.Point(22, 99);
            this.button_District10.Margin = new System.Windows.Forms.Padding(2);
            this.button_District10.Name = "button_District10";
            this.button_District10.Size = new System.Drawing.Size(162, 22);
            this.button_District10.TabIndex = 8;
            this.button_District10.Text = "Rotterdam-Zuid";
            this.button_District10.UseVisualStyleBackColor = true;
            this.button_District10.Click += new System.EventHandler(this.button_District10_Click);
            // 
            // button_District9
            // 
            this.button_District9.Location = new System.Drawing.Point(22, 74);
            this.button_District9.Margin = new System.Windows.Forms.Padding(2);
            this.button_District9.Name = "button_District9";
            this.button_District9.Size = new System.Drawing.Size(162, 21);
            this.button_District9.TabIndex = 7;
            this.button_District9.Text = "Feyenoord";
            this.button_District9.UseVisualStyleBackColor = true;
            this.button_District9.Click += new System.EventHandler(this.button_District9_Click);
            // 
            // button_District5
            // 
            this.button_District5.Location = new System.Drawing.Point(22, 26);
            this.button_District5.Margin = new System.Windows.Forms.Padding(2);
            this.button_District5.Name = "button_District5";
            this.button_District5.Size = new System.Drawing.Size(162, 20);
            this.button_District5.TabIndex = 5;
            this.button_District5.Text = "De Noordhoek";
            this.button_District5.UseVisualStyleBackColor = true;
            this.button_District5.Click += new System.EventHandler(this.button_District5_Click);
            // 
            // button_District3
            // 
            this.button_District3.Location = new System.Drawing.Point(22, 2);
            this.button_District3.Margin = new System.Windows.Forms.Padding(2);
            this.button_District3.Name = "button_District3";
            this.button_District3.Size = new System.Drawing.Size(162, 20);
            this.button_District3.TabIndex = 3;
            this.button_District3.Text = "Rotterdam-West";
            this.button_District3.UseVisualStyleBackColor = true;
            this.button_District3.Click += new System.EventHandler(this.button_District3_Click);
            // 
            // button_District6
            // 
            this.button_District6.Location = new System.Drawing.Point(22, 50);
            this.button_District6.Margin = new System.Windows.Forms.Padding(2);
            this.button_District6.Name = "button_District6";
            this.button_District6.Size = new System.Drawing.Size(162, 20);
            this.button_District6.TabIndex = 4;
            this.button_District6.Text = "District Oost";
            this.button_District6.UseVisualStyleBackColor = true;
            this.button_District6.Click += new System.EventHandler(this.button_District6_Click);
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea5.AxisX.IsStartedFromZero = false;
            chartArea5.AxisX.LabelStyle.Interval = 1D;
            chartArea5.AxisX.Maximum = 9D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea5.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Enabled = false;
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(262, 60);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Fietsdiefstal";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Straatroof";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(787, 400);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1142, 576);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Locations";
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.Locations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_District3;
        private System.Windows.Forms.Button button_District6;
        private System.Windows.Forms.Button button_District5;
        private System.Windows.Forms.Button button_District12;
        private System.Windows.Forms.Button button_District10;
        private System.Windows.Forms.Button button_District9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}