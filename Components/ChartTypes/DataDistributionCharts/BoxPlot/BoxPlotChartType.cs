using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.DataDistributionCharts.BoxPlot
{
    /// <summary>
    ///     Summary description for BoxPlotChartType.
    /// </summary>
    public class BoxPlotChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShowAverage;
        private CheckBox _checkBoxShowMedian;
        private CheckBox _checkBoxShowUnusual;
        private ComboBox _comboBoxPercentiles;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label5;
        private Label _labelSampleComment;
        private Panel _panel1;

        public BoxPlotChartType()
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 0);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._checkBoxShowUnusual = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMedian = new System.Windows.Forms.CheckBox();
            this._checkBoxShowAverage = new System.Windows.Forms.CheckBox();
            this._comboBoxPercentiles = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this._chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle =
                System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle =
                System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 100;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            chartArea1.Name = "Data Chart Area";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 82F;
            chartArea1.Position.Width = 60F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 12F;
            chartArea2.AlignmentOrientation =
                System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.AlignWithChartArea = "Data Chart Area";
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 10;
            chartArea2.AxisX.Minimum = 0;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Maximum = 100;
            chartArea2.AxisY.Minimum = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.Name = "Box Chart Area";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 82F;
            chartArea2.Position.Width = 39F;
            chartArea2.Position.X = 61F;
            chartArea2.Position.Y = 12F;
            this._chart1.ChartAreas.Add(chartArea1);
            this._chart1.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 56);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series1.ChartArea = "Data Chart Area";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Default";
            series1.MarkerSize = 8;
            series1.Name = "DataSeries";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series1.ShadowOffset = 1;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int) (((byte) (130)))),
                ((int) (((byte) (224)))), ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series2.ChartArea = "Box Chart Area";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (64)))),
                ((int) (((byte) (10)))));
            series2.CustomProperties = "BoxPlotSeries=DataSeries, PointWidth=1.2";
            series2.Legend = "Default";
            series2.Name = "BoxPlotSeries";
            series2.YValuesPerPoint = 6;
            series3.ChartArea = "Box Chart Area";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.CustomProperties = "LabelStyle=Right";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            series3.Legend = "Default";
            series3.Name = "BoxPlotLabels";
            dataPoint1.Color = System.Drawing.Color.Transparent;
            dataPoint2.Color = System.Drawing.Color.Transparent;
            dataPoint3.Color = System.Drawing.Color.Transparent;
            dataPoint4.Color = System.Drawing.Color.Transparent;
            dataPoint5.Color = System.Drawing.Color.Transparent;
            dataPoint6.Color = System.Drawing.Color.Transparent;
            dataPoint7.Color = System.Drawing.Color.Transparent;
            dataPoint8.Color = System.Drawing.Color.Transparent;
            series3.Points.Add(dataPoint1);
            series3.Points.Add(dataPoint2);
            series3.Points.Add(dataPoint3);
            series3.Points.Add(dataPoint4);
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.SmartLabelStyle.Enabled = false;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Series.Add(series3);
            this._chart1.Size = new System.Drawing.Size(460, 296);
            this._chart1.TabIndex = 1;
            title1.DockedToChartArea = "Data Chart Area";
            title1.DockingOffset = -8;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 5.813029F;
            title1.Position.Width = 48.49561F;
            title1.Position.X = 10F;
            title1.Position.Y = 6F;
            title1.Text = "Data Series";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.DockedToChartArea = "Box Chart Area";
            title2.DockingOffset = -7;
            title2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title2";
            title2.Position.Auto = false;
            title2.Position.Height = 5.813029F;
            title2.Position.Width = 29.7426F;
            title2.Position.X = 69.30817F;
            title2.Position.Y = 6F;
            title2.Text = "Data Distribution";
            this._chart1.Titles.Add(title1);
            this._chart1.Titles.Add(title2);
            this._chart1.PrePaint +=
                new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(
                    this.chart1_PrePaint);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 48);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text = "This sample demonstrates how to use a Box Plot chart. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxShowUnusual);
            this._panel1.Controls.Add(this._checkBoxShowMedian);
            this._panel1.Controls.Add(this._checkBoxShowAverage);
            this._panel1.Controls.Add(this._comboBoxPercentiles);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(480, 64);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(240, 280);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxShowUnusual
            // 
            this._checkBoxShowUnusual.Checked = true;
            this._checkBoxShowUnusual.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowUnusual.Location = new System.Drawing.Point(32, 120);
            this._checkBoxShowUnusual.Name = "_checkBoxShowUnusual";
            this._checkBoxShowUnusual.Size = new System.Drawing.Size(192, 24);
            this._checkBoxShowUnusual.TabIndex = 4;
            this._checkBoxShowUnusual.Text = "Show &Unusual Points";
            this._checkBoxShowUnusual.CheckedChanged +=
                new System.EventHandler(this.checkBoxShowUnusual_CheckedChanged);
            // 
            // checkBoxShowMedian
            // 
            this._checkBoxShowMedian.Checked = true;
            this._checkBoxShowMedian.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowMedian.Location = new System.Drawing.Point(32, 88);
            this._checkBoxShowMedian.Name = "_checkBoxShowMedian";
            this._checkBoxShowMedian.Size = new System.Drawing.Size(192, 24);
            this._checkBoxShowMedian.TabIndex = 3;
            this._checkBoxShowMedian.Text = "Show &Median Line";
            this._checkBoxShowMedian.CheckedChanged += new System.EventHandler(this.checkBoxShowMedian_CheckedChanged);
            // 
            // checkBoxShowAverage
            // 
            this._checkBoxShowAverage.Checked = true;
            this._checkBoxShowAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowAverage.Location = new System.Drawing.Point(32, 56);
            this._checkBoxShowAverage.Name = "_checkBoxShowAverage";
            this._checkBoxShowAverage.Size = new System.Drawing.Size(192, 24);
            this._checkBoxShowAverage.TabIndex = 2;
            this._checkBoxShowAverage.Text = "Show &Average Line";
            this._checkBoxShowAverage.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxPercentiles
            // 
            this._comboBoxPercentiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPercentiles.Items.AddRange(new object[]
            {
                "15/85th Percentile",
                "10/90th Percentile",
                "5/95th Percentile",
                "0/100th Percentile (Min/Max)"
            });
            this._comboBoxPercentiles.Location = new System.Drawing.Point(32, 24);
            this._comboBoxPercentiles.Name = "_comboBoxPercentiles";
            this._comboBoxPercentiles.Size = new System.Drawing.Size(168, 22);
            this._comboBoxPercentiles.TabIndex = 1;
            this._comboBoxPercentiles.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(32, 2);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(160, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Whiskers &Percentiles:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this._label5.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label5.Font = new System.Drawing.Font("Verdana", 11F);
            this._label5.Location = new System.Drawing.Point(16, 352);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(696, 48);
            this._label5.TabIndex = 23;
            this._label5.Text = "The box and its whiskers can use different percentiles of the data series. Unusua" +
                                "l data points, median and average lines can also be shown or hidden.";
            this._label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BoxPlotChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label5);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "BoxPlotChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set whiskers percentile
            var whiskerPercentile = (3 - _comboBoxPercentiles.SelectedIndex) * 5;
            _chart1.Series["BoxPlotSeries"]["BoxPlotWhiskerPercentile"] = whiskerPercentile.ToString();

            // Show/Hide Average line
            _chart1.Series["BoxPlotSeries"]["BoxPlotShowAverage"] = _checkBoxShowAverage.Checked ? "true" : "false";

            // Show/Hide Median line
            _chart1.Series["BoxPlotSeries"]["BoxPlotShowMedian"] = _checkBoxShowMedian.Checked ? "true" : "false";

            // Show/Hide Unusual points
            _chart1.Series["BoxPlotSeries"]["BoxPlotShowUnusualValues"] =
                _checkBoxShowUnusual.Checked ? "true" : "false";
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Populate series data
            double[] yValues = {55.62, 45.54, 73.45, 9.73, 88.42, 45.9, 63.6, 85.1, 67.2, 23.6};
            _chart1.Series["DataSeries"].Points.DataBindY(yValues);

            // Specify data series name for the Box Plot
            _chart1.Series["BoxPlotSeries"]["BoxPlotSeries"] = "DataSeries";

            // Set selection
            _comboBoxPercentiles.SelectedIndex = 1;

            UpdateChartSettings();
        }

        private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMedian_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowUnusual_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void chart1_PrePaint(object sender, ChartPaintEventArgs e)
        {
            if (e.ChartElement is Chart)
            {
                // Position point chart type series on the points of the box plot to display labels
                _chart1.Series["BoxPlotLabels"].Points[0].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[0];
                _chart1.Series["BoxPlotLabels"].Points[1].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[1];
                _chart1.Series["BoxPlotLabels"].Points[2].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[2];
                _chart1.Series["BoxPlotLabels"].Points[3].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[3];
                _chart1.Series["BoxPlotLabels"].Points[4].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[4];
                _chart1.Series["BoxPlotLabels"].Points[5].YValues[0] =
                    _chart1.Series["BoxPlotSeries"].Points[0].YValues[5];

                _chart1.Series["BoxPlotLabels"].Points[6].Label = "";
                _chart1.Series["BoxPlotLabels"].Points[7].Label = "";
                if (_checkBoxShowUnusual.Checked)
                {
                    if (_chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 6)
                    {
                        _chart1.Series["BoxPlotLabels"].Points[6].YValues[0] =
                            _chart1.Series["BoxPlotSeries"].Points[0].YValues[6] - 3;
                        _chart1.Series["BoxPlotLabels"].Points[6].Label = "Unusual data point";
                    }

                    if (_chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 8)
                    {
                        _chart1.Series["BoxPlotLabels"].Points[7].YValues[0] =
                            _chart1.Series["BoxPlotSeries"].Points[0].YValues[8] + 3;
                        _chart1.Series["BoxPlotLabels"].Points[7].Label = "Unusual data point";
                    }
                    else if (_chart1.Series["BoxPlotSeries"].Points[0].YValues.Length > 7)
                    {
                        _chart1.Series["BoxPlotLabels"].Points[7].YValues[0] =
                            _chart1.Series["BoxPlotSeries"].Points[0].YValues[7] + 3;
                        _chart1.Series["BoxPlotLabels"].Points[7].Label = "Unusual data point";
                    }
                }


                // Define labels
                var whiskerPercentile = (3 - _comboBoxPercentiles.SelectedIndex) * 5;
                _chart1.Series["BoxPlotLabels"].Points[0].Label = whiskerPercentile + "th Percentile";
                _chart1.Series["BoxPlotLabels"].Points[1].Label = (100 - whiskerPercentile) + "th Percentile";
                if (whiskerPercentile == 0)
                {
                    _chart1.Series["BoxPlotLabels"].Points[0].Label = "Minimum";
                    _chart1.Series["BoxPlotLabels"].Points[1].Label = "Maximum";
                }

                _chart1.Series["BoxPlotLabels"].Points[2].Label = "25th Percentile (LQ)";
                _chart1.Series["BoxPlotLabels"].Points[3].Label = "75th Percentile (UQ)";
                _chart1.Series["BoxPlotLabels"].Points[4].Label = _checkBoxShowAverage.Checked ? "Average/Mean" : "";
                _chart1.Series["BoxPlotLabels"].Points[5].Label = _checkBoxShowMedian.Checked ? "Median" : "";

                // Add strip lines
                _chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Clear();
                var stripLine = new StripLine();
                stripLine.BackColor = Color.FromArgb(60, 252, 180, 65);
                stripLine.IntervalOffset = _chart1.Series["BoxPlotLabels"].Points[2].YValues[0];
                stripLine.StripWidth = _chart1.Series["BoxPlotLabels"].Points[3].YValues[0] - stripLine.IntervalOffset;
                stripLine.Text = "data points\n50% of";
                stripLine.Font = new Font("Microsoft Sans Serif", 7);
                stripLine.TextOrientation = TextOrientation.Rotated270;
                stripLine.TextLineAlignment = StringAlignment.Center;
                stripLine.TextAlignment = StringAlignment.Near;
                _chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Add(stripLine);

                stripLine = new StripLine();
                stripLine.BackColor = Color.FromArgb(60, 252, 180, 65);
                stripLine.IntervalOffset = _chart1.Series["BoxPlotLabels"].Points[0].YValues[0];
                stripLine.StripWidth = _chart1.Series["BoxPlotLabels"].Points[1].YValues[0] - stripLine.IntervalOffset;
                stripLine.ForeColor = Color.FromArgb(120, Color.Black);
                stripLine.Text = (100 - whiskerPercentile * 2) + "% of data points";
                stripLine.Font = new Font("Microsoft Sans Serif", 7);
                stripLine.TextOrientation = TextOrientation.Rotated270;
                stripLine.TextLineAlignment = StringAlignment.Center;
                _chart1.ChartAreas["Data Chart Area"].AxisY.StripLines.Add(stripLine);
            }
        }
    }
}