using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    public partial class FormStats : Form {

        public FormStats() {
            FormClosing += OnClosing;

            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chart1.Legends[0].BackColor = SystemColors.Control;
            chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart2.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chart2.Legends[0].BackColor = SystemColors.Control;
            chart3.ChartAreas["ChartArea1"].AxisX.Interval = 5;
            chart3.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            chart3.Legends[0].BackColor = SystemColors.Control;
            chart3.Location = new Point(chart1.Location.X, chart1.Location.Y + chart1.Height);
            chart2.Location = new Point(chart3.Location.X, chart3.Location.Y + chart3.Height);
        }

        private void Stats_Load(object sender, EventArgs e) {
            LoadStats();
        }

        private void OnClosing(Object sender, FormClosingEventArgs e) {
            Program.formStats = null;
        }

        public void LoadStats() {
            FillSeries(DB.GetStatsGenre(), chart1.Series["Movies by Genre"], 8);
            FillSeries(DB.GetStatsBy("director"), chart2.Series["Most Frequent Directors"], 10, false);
            FillSeriesYears(DB.GetStatsBy("year", "year", "asc"), chart3.Series["Movies By Year"]);
        }

        void FillSeries(List<Tuple<string, int>> stats, System.Windows.Forms.DataVisualization.Charting.Series series, int columns, bool showOther = true) {
            series.Points.Clear();
            int other = 0;
            for (int i = 0; i < stats.Count; i++) {
                if (i < columns) {
                    series.Points.AddXY(stats[i].Item1, stats[i].Item2);
                }
                else {
                    other += stats[i].Item2;
                }
            }
            if (showOther && other > 0) {
                series.Points.AddXY("Other", other);
            }
        }

        void FillSeriesYears(List<Tuple<string, int>> stats, System.Windows.Forms.DataVisualization.Charting.Series series) {
            series.Points.Clear();
            int lastYear = 1920;
            for (int i = 0; i < stats.Count; i++) {
                int year = Int32.Parse(stats[i].Item1);
                if(lastYear + 1 < year) {
                    while(lastYear + 1 < year) {
                        series.Points.AddXY(lastYear.ToString(), 0);
                        lastYear++;
                    }
                }
                series.Points.AddXY(stats[i].Item1, stats[i].Item2);
                lastYear = year;
            }
        }
    }
}
