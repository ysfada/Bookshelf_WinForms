using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.ErrorBar
{
    /// <summary>
    ///     Summary description for ErrorBarChartType.
    /// </summary>
    public class ErrorBarChartType : UserControl
    {
        private Chart _chart1;
        private ComboBox _comboBoxCalculationStyle;
        private ComboBox _comboBoxCenterMarkerStyle;
        private ComboBox _comboBoxErrorStyle;
        private ComboBox _comboBoxMarkersStyle;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _label4;
        private Label _label5;
        private Label _labelSampleComment;
        private Panel _panel1;

        public ErrorBarChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboBoxCenterMarkerStyle = new System.Windows.Forms.ComboBox();
            this._label4 = new System.Windows.Forms.Label();
            this._comboBoxMarkersStyle = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxErrorStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxCalculationStyle = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (223)))),
                ((int) (((byte) (240)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (165)))),
                ((int) (((byte) (191)))), ((int) (((byte) (228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 56);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "DataSeries";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (252)))), ((int) (((byte) (180)))),
                ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series2.MarkerSize = 6;
            series2.Name = "ErrorBar";
            series2.ShadowOffset = 1;
            series2.YValuesPerPoint = 3;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 40);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample shows how to use the Error Bar chart to display error bars for data s" +
                "eries using different error calculation methods. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboBoxCenterMarkerStyle);
            this._panel1.Controls.Add(this._label4);
            this._panel1.Controls.Add(this._comboBoxMarkersStyle);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxErrorStyle);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxCalculationStyle);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 56);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(312, 288);
            this._panel1.TabIndex = 2;
            // 
            // comboBoxCenterMarkerStyle
            // 
            this._comboBoxCenterMarkerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCenterMarkerStyle.Items.AddRange(new object[]
            {
                "None",
                "Line",
                "Square",
                "Circle",
                "Diamond",
                "Triangle",
                "Cross"
            });
            this._comboBoxCenterMarkerStyle.Location = new System.Drawing.Point(168, 104);
            this._comboBoxCenterMarkerStyle.Name = "_comboBoxCenterMarkerStyle";
            this._comboBoxCenterMarkerStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxCenterMarkerStyle.TabIndex = 7;
            this._comboBoxCenterMarkerStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCenterMarkerStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this._label4.Location = new System.Drawing.Point(16, 104);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(144, 23);
            this._label4.TabIndex = 6;
            this._label4.Text = "&Center Marker Style:";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkersStyle
            // 
            this._comboBoxMarkersStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxMarkersStyle.Items.AddRange(new object[]
            {
                "None",
                "Line",
                "Square",
                "Circle",
                "Diamond",
                "Triangle",
                "Cross"
            });
            this._comboBoxMarkersStyle.Location = new System.Drawing.Point(168, 72);
            this._comboBoxMarkersStyle.Name = "_comboBoxMarkersStyle";
            this._comboBoxMarkersStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxMarkersStyle.TabIndex = 5;
            this._comboBoxMarkersStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxMarkersStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(24, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(136, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "&Markers Style:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxErrorStyle
            // 
            this._comboBoxErrorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxErrorStyle.Items.AddRange(new object[]
            {
                "Both",
                "UpperError",
                "LowerError"
            });
            this._comboBoxErrorStyle.Location = new System.Drawing.Point(168, 40);
            this._comboBoxErrorStyle.Name = "_comboBoxErrorStyle";
            this._comboBoxErrorStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxErrorStyle.TabIndex = 3;
            this._comboBoxErrorStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxErrorStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(32, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(128, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Error &Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCalculationStyle
            // 
            this._comboBoxCalculationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCalculationStyle.Items.AddRange(new object[]
            {
                "StandardError",
                "StandardDeviation",
                "Percentage(15)",
                "FixedValue(10)"
            });
            this._comboBoxCalculationStyle.Location = new System.Drawing.Point(168, 8);
            this._comboBoxCalculationStyle.Name = "_comboBoxCalculationStyle";
            this._comboBoxCalculationStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxCalculationStyle.TabIndex = 1;
            this._comboBoxCalculationStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCalculationStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(16, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(144, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "&Error Calculation:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this._label5.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label5.Font = new System.Drawing.Font("Verdana", 11F);
            this._label5.Location = new System.Drawing.Point(28, 352);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(696, 32);
            this._label5.TabIndex = 22;
            this._label5.Text = "Error bars are used to display statistical information about the chart data.";
            this._label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorBarChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label5);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "ErrorBarChartType";
            this.Size = new System.Drawing.Size(752, 480);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set error calculation type
            _chart1.Series["ErrorBar"]["ErrorBarType"] = (string) _comboBoxCalculationStyle.SelectedItem;

            // Set error bar upper & lower error style
            _chart1.Series["ErrorBar"]["ErrorBarStyle"] = (string) _comboBoxErrorStyle.SelectedItem;

            // Set error bar center marker style
            _chart1.Series["ErrorBar"]["ErrorBarCenterMarkerStyle"] = (string) _comboBoxCenterMarkerStyle.SelectedItem;

            // Set error bar marker style
            var markerStyle = (string) _comboBoxMarkersStyle.SelectedItem;
            _chart1.Series["ErrorBar"]["PointWidth"] = "0.4";
            if (markerStyle == "Line")
            {
                _chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
            }
            else if (markerStyle == "None")
            {
                _chart1.Series["ErrorBar"]["PointWidth"] = "0";
                _chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
            }
            else if (markerStyle != null)
            {
                _chart1.Series["ErrorBar"].MarkerStyle = (MarkerStyle) Enum.Parse(typeof(MarkerStyle), markerStyle);
            }
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Populate series with data
            double[] yValues = {32.4, 56.9, 89.7, 80.5, 59.3, 33.8, 78.8, 44.6, 76.4, 68.9};
            _chart1.Series["DataSeries"].Points.DataBindY(yValues);

            // Link error bar series with data series
            _chart1.Series["ErrorBar"]["ErrorBarSeries"] = "DataSeries";

            // Set selection
            _comboBoxCalculationStyle.SelectedIndex = 0;
            _comboBoxErrorStyle.SelectedIndex = 0;
            _comboBoxMarkersStyle.SelectedIndex = 1;
            _comboBoxCenterMarkerStyle.SelectedIndex = 0;

            UpdateChartSettings();
        }

        private void comboBoxCalculationStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxErrorStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxMarkersStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxCenterMarkerStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}