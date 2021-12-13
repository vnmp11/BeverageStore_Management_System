using Beverage_Management_System.Presenters;
using Beverage_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Beverage_Management_System
{
    public partial class Statistic : Form
    {


        OrderBillPresenter presenter = new OrderBillPresenter();
        OrderFormPresenter orderFormPresenter = new OrderFormPresenter();


        public int temp = 0;
        public string search { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        DateTime today = DateTime.Now;

        int day = 0;
        int month = 0;
        int year = 0;
        public Statistic()
        {
            day = today.Day;
            month = today.Month;
            year = today.Year;

            InitializeComponent();
            presenter.loadListOrderBill(day, month, year);


            label3.Text = presenter.total.ToString();
            label5.Text = presenter.customer.ToString();
            label2.Text = presenter.total_quantity.ToString();

        }



        private void Sale_Click(object sender, EventArgs e)
        {

        }


        //private void setChart(string series)
        //{

        //    chart1.Series[series].IsValueShownAsLabel = true;
        //    //chart1.Series.Add(series).;

        //    if (orderFormPresenter.a[1] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Soft drink", orderFormPresenter.a[1]);
        //    }
        //    if (orderFormPresenter.a[2] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Milk tea", orderFormPresenter.a[2]);
        //    }
        //    if (orderFormPresenter.a[3] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Tea", orderFormPresenter.a[3]);
        //    }
        //    if (orderFormPresenter.a[4] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Pure water", orderFormPresenter.a[4]);
        //    }
        //    if (orderFormPresenter.a[5] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Juice", orderFormPresenter.a[5]);
        //    }
        //    if (orderFormPresenter.a[6] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Beer", orderFormPresenter.a[6]);
        //    }
        //    if (orderFormPresenter.a[7] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Energy", orderFormPresenter.a[7]);
        //    }
        //    if (orderFormPresenter.a[8] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Ionic mineral water", orderFormPresenter.a[8]);
        //    }
        //    if (orderFormPresenter.a[9] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Yogurt", orderFormPresenter.a[9]);
        //    }
        //    if (orderFormPresenter.a[10] != 0)
        //    {
        //        chart1.Series[series].Points.AddXY("Others", orderFormPresenter.a[10]);
        //    }


        //}


        private void DrawPieChart()
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            //chart1.Legends.Clear();
            
            //Add a new Legend(if needed) and do some formating
            //chart1.Legends.Add("MyLegend");
            //chart1.Legends[0].LegendStyle = LegendStyle.Table;
            //chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].Alignment = StringAlignment.Near;
            chart1.Legends[0].Title = "KIND OF DRINKS";
            //chart1.Legends[0].BorderColor = Color.White;
            //chart1.Legends[0].Ar

            //Add a new chart-series
            string series = "Series1";
            chart1.Series.Add(series);
            chart1.Series[series].IsValueShownAsLabel = true;
            //set the chart-type to "Pie"
            chart1.Series[series].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
           

            if (orderFormPresenter.a[1] != 0)
            {
                chart1.Series[series].Points.AddXY("Soft drink", orderFormPresenter.a[1]);
            }
            if (orderFormPresenter.a[2] != 0)
            {
                chart1.Series[series].Points.AddXY("Milk tea", orderFormPresenter.a[2]);
            }
            if (orderFormPresenter.a[3] != 0)
            {
                chart1.Series[series].Points.AddXY("Tea", orderFormPresenter.a[3]);
            }
            if (orderFormPresenter.a[4] != 0)
            {
                chart1.Series[series].Points.AddXY("Pure water", orderFormPresenter.a[4]);
            }
            if (orderFormPresenter.a[5] != 0)
            {
                chart1.Series[series].Points.AddXY("Juice", orderFormPresenter.a[5]);
            }
            if (orderFormPresenter.a[6] != 0)
            {
                chart1.Series[series].Points.AddXY("Beer", orderFormPresenter.a[6]);
            }
            if (orderFormPresenter.a[7] != 0)
            {
                chart1.Series[series].Points.AddXY("Energy", orderFormPresenter.a[7]);
            }
            if (orderFormPresenter.a[8] != 0)
            {
                chart1.Series[series].Points.AddXY("Ionic mineral water", orderFormPresenter.a[8]);
            }
            if (orderFormPresenter.a[9] != 0)
            {
                chart1.Series[series].Points.AddXY("Yogurt", orderFormPresenter.a[9]);
            }
            if (orderFormPresenter.a[10] != 0)
            {
                chart1.Series[series].Points.AddXY("Others", orderFormPresenter.a[10]);
            }

        }
        private void Statistic_Load(object sender, EventArgs e)
        {
           // string char1 = chart1;
            orderFormPresenter.getOrderFormList(day, month, year);
            //setChart("Series1");
            DrawPieChart();



        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void cb_idOrderBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_idOrderBill.SelectedIndex == 0)
            {
            
                presenter.loadListOrderBill(day, month, year);
                label3.Text = presenter.total.ToString();
                label5.Text = presenter.customer.ToString();
                label2.Text = presenter.total_quantity.ToString();

                orderFormPresenter.getOrderFormList(day, month, year);
                DrawPieChart();



            }
            else if(cb_idOrderBill.SelectedIndex == 1)
            {
                presenter.loadListOrderBill(0, month, year);
                label3.Text = presenter.total.ToString();
                label5.Text = presenter.customer.ToString();
                label2.Text = presenter.total_quantity.ToString();

                orderFormPresenter.getOrderFormList(0, month, year);
                DrawPieChart();
            }
            else if (cb_idOrderBill.SelectedIndex == 2)
            {
                presenter.loadListOrderBill(0, 0, year);
                label3.Text = presenter.total.ToString();
                label5.Text = presenter.customer.ToString();
                label2.Text = presenter.total_quantity.ToString();

                orderFormPresenter.getOrderFormList(0, 0, year);
                DrawPieChart();
            }


        }
    }
}
