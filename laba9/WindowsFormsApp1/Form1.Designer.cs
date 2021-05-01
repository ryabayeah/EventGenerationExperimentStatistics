
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.Num3 = new System.Windows.Forms.NumericUpDown();
            this.Num4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Num5B = new System.Windows.Forms.Button();
            this.StartB = new System.Windows.Forms.Button();
            this.Trials = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Trials);
            this.panel1.Controls.Add(this.StartB);
            this.panel1.Controls.Add(this.Num5B);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Num4);
            this.panel1.Controls.Add(this.Num3);
            this.panel1.Controls.Add(this.Num2);
            this.panel1.Controls.Add(this.Num1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 386);
            this.panel1.TabIndex = 0;
            // 
            // Num1
            // 
            this.Num1.DecimalPlaces = 1;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num1.Location = new System.Drawing.Point(124, 23);
            this.Num1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(83, 23);
            this.Num1.TabIndex = 0;
            this.Num1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Num2
            // 
            this.Num2.DecimalPlaces = 1;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num2.Location = new System.Drawing.Point(124, 65);
            this.Num2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(83, 23);
            this.Num2.TabIndex = 1;
            this.Num2.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // Num3
            // 
            this.Num3.DecimalPlaces = 1;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num3.Location = new System.Drawing.Point(124, 112);
            this.Num3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(83, 23);
            this.Num3.TabIndex = 2;
            this.Num3.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Num4
            // 
            this.Num4.DecimalPlaces = 1;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Num4.Location = new System.Drawing.Point(124, 157);
            this.Num4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(83, 23);
            this.Num4.TabIndex = 3;
            this.Num4.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prob 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prob 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prob 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prob 5";
            // 
            // Num5B
            // 
            this.Num5B.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Num5B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num5B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Num5B.Location = new System.Drawing.Point(124, 204);
            this.Num5B.Name = "Num5B";
            this.Num5B.Size = new System.Drawing.Size(83, 33);
            this.Num5B.TabIndex = 9;
            this.Num5B.Text = "Auto";
            this.Num5B.UseVisualStyleBackColor = false;
            this.Num5B.Click += new System.EventHandler(this.Num5B_Click);
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StartB.Location = new System.Drawing.Point(106, 336);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(75, 31);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.button2_Click);
            // 
            // Trials
            // 
            this.Trials.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Trials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Trials.Location = new System.Drawing.Point(160, 280);
            this.Trials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Trials.Name = "Trials";
            this.Trials.ReadOnly = true;
            this.Trials.Size = new System.Drawing.Size(102, 23);
            this.Trials.TabIndex = 10;
            this.Trials.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(21, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of\r\nexperiments";
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.LightBlue;
            chartArea3.Name = "Freq.";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(304, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "Freq.";
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(484, 386);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Freq.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Hello";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Trials;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button Num5B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num4;
        private System.Windows.Forms.NumericUpDown Num3;
        private System.Windows.Forms.NumericUpDown Num2;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

