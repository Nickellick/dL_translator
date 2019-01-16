namespace dL_translator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.radio_wavelength = new System.Windows.Forms.RadioButton();
            this.radio_frequency = new System.Windows.Forms.RadioButton();
            this.comboBox_wavelength = new System.Windows.Forms.ComboBox();
            this.comboBox_frequency = new System.Windows.Forms.ComboBox();
            this.button_count = new System.Windows.Forms.Button();
            this.dependency_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.trackbar_reflection_coefficient = new System.Windows.Forms.TrackBar();
            this.progressBar_plotting = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_reflection_coefficient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dependency_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_reflection_coefficient)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_wavelength
            // 
            this.radio_wavelength.AutoSize = true;
            this.radio_wavelength.Location = new System.Drawing.Point(672, 12);
            this.radio_wavelength.Name = "radio_wavelength";
            this.radio_wavelength.Size = new System.Drawing.Size(136, 21);
            this.radio_wavelength.TabIndex = 0;
            this.radio_wavelength.Text = "По длине волны";
            this.radio_wavelength.UseVisualStyleBackColor = true;
            this.radio_wavelength.CheckedChanged += new System.EventHandler(this.radio_wavelength_CheckedChanged);
            // 
            // radio_frequency
            // 
            this.radio_frequency.AutoSize = true;
            this.radio_frequency.Location = new System.Drawing.Point(672, 40);
            this.radio_frequency.Name = "radio_frequency";
            this.radio_frequency.Size = new System.Drawing.Size(104, 21);
            this.radio_frequency.TabIndex = 1;
            this.radio_frequency.Text = "По частоте";
            this.radio_frequency.UseVisualStyleBackColor = true;
            this.radio_frequency.CheckedChanged += new System.EventHandler(this.radio_frequency_CheckedChanged);
            // 
            // comboBox_wavelength
            // 
            this.comboBox_wavelength.FormattingEnabled = true;
            this.comboBox_wavelength.Location = new System.Drawing.Point(545, 11);
            this.comboBox_wavelength.Name = "comboBox_wavelength";
            this.comboBox_wavelength.Size = new System.Drawing.Size(121, 24);
            this.comboBox_wavelength.TabIndex = 2;
            this.comboBox_wavelength.SelectedIndexChanged += new System.EventHandler(this.comboBox_wavelength_SelectedIndexChanged);
            // 
            // comboBox_frequency
            // 
            this.comboBox_frequency.FormattingEnabled = true;
            this.comboBox_frequency.Location = new System.Drawing.Point(545, 40);
            this.comboBox_frequency.Name = "comboBox_frequency";
            this.comboBox_frequency.Size = new System.Drawing.Size(121, 24);
            this.comboBox_frequency.TabIndex = 3;
            this.comboBox_frequency.SelectedIndexChanged += new System.EventHandler(this.comboBox_frequency_SelectedIndexChanged);
            // 
            // button_count
            // 
            this.button_count.Location = new System.Drawing.Point(687, 363);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(110, 38);
            this.button_count.TabIndex = 4;
            this.button_count.Text = "Рассчитать";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // dependency_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.dependency_chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.dependency_chart.Legends.Add(legend1);
            this.dependency_chart.Location = new System.Drawing.Point(12, 12);
            this.dependency_chart.Name = "dependency_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "ΔL";
            this.dependency_chart.Series.Add(series1);
            this.dependency_chart.Size = new System.Drawing.Size(527, 389);
            this.dependency_chart.TabIndex = 5;
            this.dependency_chart.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // trackbar_reflection_coefficient
            // 
            this.trackbar_reflection_coefficient.Location = new System.Drawing.Point(545, 70);
            this.trackbar_reflection_coefficient.Maximum = 9;
            this.trackbar_reflection_coefficient.Minimum = 1;
            this.trackbar_reflection_coefficient.Name = "trackbar_reflection_coefficient";
            this.trackbar_reflection_coefficient.Size = new System.Drawing.Size(252, 56);
            this.trackbar_reflection_coefficient.TabIndex = 7;
            this.trackbar_reflection_coefficient.Value = 1;
            this.trackbar_reflection_coefficient.Scroll += new System.EventHandler(this.trackbar_reflection_coefficient_Scroll);
            // 
            // progressBar_plotting
            // 
            this.progressBar_plotting.Location = new System.Drawing.Point(545, 363);
            this.progressBar_plotting.Name = "progressBar_plotting";
            this.progressBar_plotting.Size = new System.Drawing.Size(136, 38);
            this.progressBar_plotting.Step = 1;
            this.progressBar_plotting.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_reflection_coefficient
            // 
            this.label_reflection_coefficient.AutoSize = true;
            this.label_reflection_coefficient.Location = new System.Drawing.Point(557, 108);
            this.label_reflection_coefficient.Name = "label_reflection_coefficient";
            this.label_reflection_coefficient.Size = new System.Drawing.Size(191, 17);
            this.label_reflection_coefficient.TabIndex = 12;
            this.label_reflection_coefficient.Text = "Коэффициент отражения R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 428);
            this.Controls.Add(this.label_reflection_coefficient);
            this.Controls.Add(this.progressBar_plotting);
            this.Controls.Add(this.trackbar_reflection_coefficient);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dependency_chart);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.comboBox_frequency);
            this.Controls.Add(this.comboBox_wavelength);
            this.Controls.Add(this.radio_frequency);
            this.Controls.Add(this.radio_wavelength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Модель v.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dependency_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_reflection_coefficient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_wavelength;
        private System.Windows.Forms.RadioButton radio_frequency;
        private System.Windows.Forms.ComboBox comboBox_wavelength;
        private System.Windows.Forms.ComboBox comboBox_frequency;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart dependency_chart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TrackBar trackbar_reflection_coefficient;
        private System.Windows.Forms.ProgressBar progressBar_plotting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_reflection_coefficient;
    }
}

