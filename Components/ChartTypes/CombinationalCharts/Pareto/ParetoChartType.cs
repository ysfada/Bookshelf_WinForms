using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.CombinationalCharts.Pareto
{
    /// <summary>
    ///     Summary description for ParetoChartType.
    /// </summary>
    public class ParetoChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private ComboBox _comboBoxNumberOfPoints;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _labelSampleComment;
        private Panel _panel1;

        public ParetoChartType()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call
        }

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing) _components?.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._comboBoxNumberOfPoints = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Interval = 25;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 43);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 32);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample shows how to create a Pareto chart by using Column and Line charts to" +
                "gether. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._comboBoxNumberOfPoints);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 51);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(14, 42);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShow3D.TabIndex = 2;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxNumberOfPoints
            // 
            this._comboBoxNumberOfPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxNumberOfPoints.Items.AddRange(new object[]
            {
                "5",
                "8",
                "10"
            });
            this._comboBoxNumberOfPoints.Location = new System.Drawing.Point(168, 8);
            this._comboBoxNumberOfPoints.Name = "_comboBoxNumberOfPoints";
            this._comboBoxNumberOfPoints.Size = new System.Drawing.Size(72, 22);
            this._comboBoxNumberOfPoints.TabIndex = 1;
            this._comboBoxNumberOfPoints.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxNumberOfPoints_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(43, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(120, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Number of Points:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ParetoChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ParetoChartType";
            this.Size = new System.Drawing.Size(728, 368);
            this.Load += new System.EventHandler(this.ParetoChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void comboBoxNumberOfPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Number of data points
            var numOfPoints = int.Parse(_comboBoxNumberOfPoints.Text);

            // Generate rundom data
            RandomData(_chart1.Series["Default"], numOfPoints);

            // Make Pareto Chart
            if (_chart1.Series.Count > 1)
                _chart1.Series.RemoveAt(1);
            MakeParetoChart(_chart1, "Default", "Pareto");

            // Set chart types for output data
            _chart1.Series["Pareto"].ChartType = SeriesChartType.Line;

            // Set Color of line Pareto chart
            _chart1.Series["Pareto"].Color = Color.FromArgb(252, 180, 65);

            // set the markers for each point of the Pareto Line
            _chart1.Series["Pareto"].IsValueShownAsLabel = true;
            _chart1.Series["Pareto"].MarkerColor = Color.Red;
            _chart1.Series["Pareto"].MarkerStyle = MarkerStyle.Circle;
            _chart1.Series["Pareto"].MarkerBorderColor = Color.MidnightBlue;
            _chart1.Series["Pareto"].MarkerSize = 8;
            _chart1.Series["Pareto"].LabelFormat = "0.#"; // format with one decimal and leading zero
        }

        private void ParetoChartType_Load(object sender, EventArgs e)
        {
            _comboBoxNumberOfPoints.SelectedIndex = 0;
        }

        private void RandomData(Series series, int numOfPoints)
        {
            var rand = new Random();

            // Generate random Y values
            series.Points.Clear();
            for (var point = 0; point < numOfPoints; point++) series.Points.AddY(rand.Next(250) + 1);
        }

        private void MakeParetoChart(Chart chart, string srcSeriesName, string destSeriesName)
        {
            // get name of the ChartAre of the source series
            var strChartArea = chart.Series[srcSeriesName].ChartArea;

            // ensure the source series is a column chart type
            chart.Series[srcSeriesName].ChartType = SeriesChartType.Column;

            // sort the data in the series to be by values in descending order
            chart.DataManipulator.Sort(PointSortOrder.Descending, srcSeriesName);

            // find the total of all points in the source series
            var total = 0.0;
            foreach (var pt in chart.Series[srcSeriesName].Points)
                total += pt.YValues[0];

            // set the max value on the primary axis to total
            chart.ChartAreas[strChartArea].AxisY.Maximum = total;

            // create the destination series and add it to the chart
            var destSeries = new Series(destSeriesName);
            chart.Series.Add(destSeries);

            // ensure the destination series is a Line or Spline chart type
            destSeries.ChartType = SeriesChartType.Line;

            destSeries.BorderWidth = 3;

            // assign the series to the same chart area as the column chart
            destSeries.ChartArea = chart.Series[srcSeriesName].ChartArea;

            // assign this series to use the secondary axis and set it maximum to be 100%
            destSeries.YAxisType = AxisType.Secondary;
            chart.ChartAreas[strChartArea].AxisY2.Maximum = 100;

            // locale specific percentage format with no decimals
            chart.ChartAreas[strChartArea].AxisY2.LabelStyle.Format = "P0";

            // turn off the end point values of the primary X axis
            chart.ChartAreas[strChartArea].AxisX.LabelStyle.IsEndLabelVisible = false;

            // for each point in the source series find % of total and assign to series
            var percentage = 0.0;

            foreach (var pt in chart.Series[srcSeriesName].Points)
            {
                percentage += pt.YValues[0] / total * 100.0;
                destSeries.Points.Add(Math.Round(percentage, 2));
            }
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkBoxShow3D.Checked)
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
                _chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Realistic;
                _chart1.ChartAreas["Default"].Area3DStyle.Inclination = 15;
                _chart1.ChartAreas["Default"].Area3DStyle.Rotation = 15;
                //show marker lines
                _chart1.Series["Pareto"]["ShowMarkerLines"] = "True";
                _chart1.Series["Pareto"].IsValueShownAsLabel = false;
            }
            else
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
                _chart1.Series["Pareto"].IsValueShownAsLabel = true;
            }
        }
    }
}