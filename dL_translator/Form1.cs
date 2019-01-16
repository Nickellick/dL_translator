using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//TODO Сделать отдельную функцию по отрисовке графика
//TODO Переделать отрисовку осей графика и поработать с скоростью отрисовки
namespace dL_translator
{
    public partial class Form1 : Form
    {
        public double refractive_index = 1;
        public double dL;
        public int wavelength = 840;
        public double reflection_index = 0.9;
        const double max_df = 6.282;
        public Form1()
        {
            InitializeComponent();
            radio_wavelength.Checked = true;
            label_reflection_coefficient.Text = "Коэффициент отражения R = " + reflection_index.ToString("0.#");
            List<int> wavelength_list = new List<int>() { 840, 960, 1100 };
            comboBox_wavelength.DataSource = wavelength_list;
            comboBox_wavelength.SelectedIndex = 0;
            dependency_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            trackbar_reflection_coefficient.Value = 9;
        }
        public void check_radio()
        {
            if (radio_wavelength.Checked)
            {
                radio_frequency.Checked = false;
                comboBox_frequency.Enabled = false;
                comboBox_wavelength.Enabled = true;
            }
            else
            {
                radio_frequency.Checked = true;
                comboBox_frequency.Enabled = true;
                comboBox_wavelength.Enabled = false;
            }
        }
        private void radio_wavelength_CheckedChanged(object sender, EventArgs e)
        {
            check_radio();
        }

        private void radio_frequency_CheckedChanged(object sender, EventArgs e)
        {
            check_radio();
        }

        private void comboBox_frequency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_wavelength_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox_refractive_index.Text = comboBox_wavelength.SelectedValue.ToString();
        }
        //private void textBox_refractive_index_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        refractive_index = Convert.ToDouble(textBox_refractive_index.Text);
        //    }
        //    catch (FormatException)
        //    {
        //        //TODO Полностью переделать метод обработки "неправильного показателя преломления"
        //        System.Media.SystemSounds.Question.Play();
        //        string s = textBox_refractive_index.Text;

        //        if (textBox_refractive_index.Text.Length > 0)
        //        {
        //            textBox_refractive_index.Text = textBox_refractive_index.Text.Remove(textBox_refractive_index.Text.Length - 1);
        //        }
        //    }
        //}

        private void button_count_Click(object sender, EventArgs e)
        {
            dL = max_df / (max_df / (wavelength/1000000000) );
            //textBox_dL.Text = dL.ToString();
            double x;
            dependency_chart.Series[0].Points.Clear();
            for (x = 0; x <= max_df; x += 0.001)
            {
                progressBar_plotting.Value = Convert.ToInt32((x / (2 * 3.1415)) * 100);
                double y = 1 / (1 + ((4 * reflection_index) / Math.Pow(1 - reflection_index, 2)) * Math.Pow(Math.Sin(x), 2));
                double z = x / max_df;
                dependency_chart.Series[0].Points.AddXY(z, y);
            }
            //progressBar_plotting.Value = 0;
        }

        private void trackbar_reflection_coefficient_Scroll(object sender, EventArgs e)
        {
            reflection_index = Convert.ToDouble(trackbar_reflection_coefficient.Value) / 10;
            label_reflection_coefficient.Text = "Коэффициент отражения R = " + reflection_index.ToString("0.#");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
