using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderCoffeeSystem
{
    public partial class SalesAnalyzerForm : Form
    {
        private SalesAnalyzer salesAnalyzer = new SalesAnalyzer();

        public SalesAnalyzerForm()
        {
            InitializeComponent();
        }

        private void SalesAnalyzerForm_Load(object sender, EventArgs e)
        {
            salesAnalyzer.LoadSales("sales.txt");

            menuSelect.Items.Add("연도별 분석");
            menuSelect.Items.Add("월별 분석");
            menuSelect.Items.Add("일별 분석");
            menuSelect.Items.Add("최고 / 최저 매출 분석");
            menuSelect.Items.Add("고객 객단가 분석");
            menuSelect.Items.Add("시간대별 매출 현황");

            YearSelect.Items.Add("2026"); YearSelect.Items.Add("2027");
            for (int i = 1; i <= 12; i++) MonthSelect.Items.Add(i.ToString());
            for (int i = 1; i <= 31; i++) DaySelect.Items.Add(i.ToString());

            menuSelect.SelectedIndex = 0;
            YearSelect.SelectedIndex = 0;
            MonthSelect.SelectedIndex = 0;
            DaySelect.SelectedIndex = 0;
        }

        private void menuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = menuSelect.Text;

            if (selectedType == "연도별 분석")
            {
                YearSelect.Enabled = true; MonthSelect.Enabled = false; DaySelect.Enabled = false;
            }
            else if (selectedType == "월별 분석")
            {
                YearSelect.Enabled = true; MonthSelect.Enabled = true; DaySelect.Enabled = false;
            }
            else if (selectedType == "일별 분석")
            {
                YearSelect.Enabled = true; MonthSelect.Enabled = true; DaySelect.Enabled = true;
            }
            else
            {
                YearSelect.Enabled = false; MonthSelect.Enabled = false; DaySelect.Enabled = false;
            }
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
            string result = "";
            string selectedType = menuSelect.Text;

            if (selectedType == "연도별 분석")
            {
                result = salesAnalyzer.PrintSales(YearSelect.Text);
            }
            else if (selectedType == "월별 분석")
            {
                result = salesAnalyzer.PrintSales(YearSelect.Text, MonthSelect.Text);
            }
            else if (selectedType == "일별 분석")
            {
                result = salesAnalyzer.PrintSales(YearSelect.Text, MonthSelect.Text, DaySelect.Text);
            }
            else if (selectedType == "최고 / 최저 매출 분석")
            {
                result = salesAnalyzer.PrintExtremes();
            }
            else if (selectedType == "고객 객단가 분석")
            {
                result = salesAnalyzer.PrintAverageOrderAmount();
            }
            else if (selectedType == "시간대별 매출 현황")
            {
                result = salesAnalyzer.PrintSalesByHour();
            }

            resultTextBox.Text = result;
        }
    }
}
