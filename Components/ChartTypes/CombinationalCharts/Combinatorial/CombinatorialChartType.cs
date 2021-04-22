using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.CombinationalCharts.Combinatorial
{
    /// <summary>
    ///     Summary description for CombinatorialChartType.
    /// </summary>
    public class CombinatorialChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxSeries1;
        private ComboBox _comboBoxSeries2;
        private ComboBox _comboBoxSeries3;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public CombinatorialChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._comboBoxSeries3 = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxSeries2 = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxSeries1 = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (223)))),
                ((int) (((byte) (240)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 58);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (224)))),
                ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series3.Legend = "Default";
            series3.MarkerSize = 10;
            series3.Name = "Series3";
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Series.Add(series3);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Combination Charts";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates how to combine different chart types in one plot area an" +
                "d how to display a chart area in 3D. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._comboBoxSeries3);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxSeries2);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxSeries1);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 66);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(-3, 136);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(184, 24);
            this._checkBoxShow3D.TabIndex = 7;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Checked = true;
            this._checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(13, 104);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShowMargin.TabIndex = 6;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxSeries3
            // 
            this._comboBoxSeries3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxSeries3.Items.AddRange(new object[]
            {
                "Column",
                "Line",
                "Spline",
                "StepLine",
                "Area",
                "SplineArea",
                "Point"
            });
            this._comboBoxSeries3.Location = new System.Drawing.Point(168, 72);
            this._comboBoxSeries3.Name = "_comboBoxSeries3";
            this._comboBoxSeries3.Size = new System.Drawing.Size(104, 22);
            this._comboBoxSeries3.TabIndex = 5;
            this._comboBoxSeries3.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxSeries1_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(11, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(152, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "Series &3 Type:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSeries2
            // 
            this._comboBoxSeries2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxSeries2.Items.AddRange(new object[]
            {
                "Column",
                "Line",
                "Spline",
                "StepLine",
                "Area",
                "SplineArea",
                "Point"
            });
            this._comboBoxSeries2.Location = new System.Drawing.Point(168, 40);
            this._comboBoxSeries2.Name = "_comboBoxSeries2";
            this._comboBoxSeries2.Size = new System.Drawing.Size(104, 22);
            this._comboBoxSeries2.TabIndex = 3;
            this._comboBoxSeries2.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxSeries1_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(3, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(160, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Series &2 Type:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxSeries1
            // 
            this._comboBoxSeries1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxSeries1.Items.AddRange(new object[]
            {
                "Column",
                "Line",
                "Spline",
                "StepLine",
                "Area",
                "SplineArea",
                "Point"
            });
            this._comboBoxSeries1.Location = new System.Drawing.Point(168, 8);
            this._comboBoxSeries1.Name = "_comboBoxSeries1";
            this._comboBoxSeries1.Size = new System.Drawing.Size(104, 22);
            this._comboBoxSeries1.TabIndex = 1;
            this._comboBoxSeries1.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxSeries1_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(11, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(152, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Series &1 Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CombinatorialChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "CombinatorialChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.CombinatorialChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            if (_comboBoxSeries3.Text == "") return;

            // Set series chart types
            _chart1.Series["Series1"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxSeries1.Text, true);
            _chart1.Series["Series2"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxSeries2.Text, true);
            _chart1.Series["Series3"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxSeries3.Text, true);

            // Disable/enable X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;

            // Adjust all series appearance depending on the chart type
            foreach (var series in _chart1.Series)
            {
                // Adjust border width
                series.BorderWidth = 1;
                if (series.ChartType == SeriesChartType.Line || series.ChartType == SeriesChartType.Spline ||
                    series.ChartType == SeriesChartType.StepLine) series.BorderWidth = 3;

                // Disable shadow in area charts
                series.ShadowOffset = 2;
                if (series.ChartType == SeriesChartType.Area || series.ChartType == SeriesChartType.StackedArea ||
                    series.ChartType == SeriesChartType.SplineArea) series.ShadowOffset = 0;
            }

            // Check for 3D
            if (_checkBoxShow3D.Checked)
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
            else
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
        }

        private void CombinatorialChartType_Load(object sender, EventArgs e)
        {
            // Set selection
            _comboBoxSeries1.SelectedIndex = 0;
            _comboBoxSeries2.SelectedIndex = 2;
            _comboBoxSeries3.SelectedIndex = 0;

            // Populate series data with random data
            var random = new Random();
            for (var pointIndex = 0; pointIndex < 10; pointIndex++)
            {
                _chart1.Series["Series1"].Points.AddY(random.Next(5, 95));
                _chart1.Series["Series2"].Points.AddY(random.Next(5, 95));
                _chart1.Series["Series3"].Points.AddY(random.Next(5, 95));
            }

            UpdateChartSettings();
        }

        private void comboBoxSeries1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}