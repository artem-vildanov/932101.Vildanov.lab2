using System.Windows.Forms.DataVisualization.Charting;

namespace vildanov_lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblDollar = new System.Windows.Forms.Label();
            this.EdDollar = new System.Windows.Forms.NumericUpDown();
            this.EdEuro = new System.Windows.Forms.NumericUpDown();
            this.LblEuro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EdDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDollar
            // 
            this.LblDollar.AutoSize = true;
            this.LblDollar.Location = new System.Drawing.Point(43, 73);
            this.LblDollar.Name = "LblDollar";
            this.LblDollar.Size = new System.Drawing.Size(45, 17);
            this.LblDollar.TabIndex = 0;
            this.LblDollar.Text = "Dollar";
            // 
            // EdDollar
            // 
            this.EdDollar.DecimalPlaces = 4;
            this.EdDollar.Location = new System.Drawing.Point(119, 68);
            this.EdDollar.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EdDollar.Name = "EdDollar";
            this.EdDollar.Size = new System.Drawing.Size(120, 22);
            this.EdDollar.TabIndex = 1;
            this.EdDollar.Value = new decimal(new int[] {
            74,
            0,
            0,
            0});
            // 
            // EdEuro
            // 
            this.EdEuro.DecimalPlaces = 4;
            this.EdEuro.Location = new System.Drawing.Point(443, 68);
            this.EdEuro.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EdEuro.Name = "EdEuro";
            this.EdEuro.Size = new System.Drawing.Size(120, 22);
            this.EdEuro.TabIndex = 3;
            this.EdEuro.Value = new decimal(new int[] {
            76,
            0,
            0,
            0});
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Location = new System.Drawing.Point(365, 70);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(38, 17);
            this.LblEuro.TabIndex = 2;
            this.LblEuro.Text = "Euro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "\r\nExchange rate to the ruble\r\n";
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(716, 32);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(162, 38);
            this.BtnStartStop.TabIndex = 5;
            this.BtnStartStop.Text = "Start/Stop";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(46, 139);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Dollar";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Euro";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(847, 544);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "Chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(716, 89);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(162, 35);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 707);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdEuro);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.EdDollar);
            this.Controls.Add(this.LblDollar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EdDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDollar;
        private System.Windows.Forms.NumericUpDown EdDollar;
        private System.Windows.Forms.NumericUpDown EdEuro;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnClear;
    }
}

