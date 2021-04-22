using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.BarColumnCharts._3DBarColumn
{
    /// <summary>
    ///     Summary description for BarColumn3D.
    /// </summary>
    public class BarColumn3D : UserControl
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Chart _chart1;
        private CheckBox _checkBoxShowMargin;
        private CheckBox _checkClustered;

        private NumericUpDown _inclination;
        private Label _label1;
        private Label _label2;
        private Label _labelSampleComment;
        private Panel _panel1;
        private RadioButton _radioButtonBar;
        private RadioButton _radioButtonColumn;
        private CheckBox _rightAngleAxis;
        private NumericUpDown _rotation;

        public BarColumn3D()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5.6999998092651367);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.2000000476837158);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6.5);
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.Series series3 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._checkClustered = new System.Windows.Forms.CheckBox();
            this._rotation = new System.Windows.Forms.NumericUpDown();
            this._inclination = new System.Windows.Forms.NumericUpDown();
            this._label2 = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._rightAngleAxis = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._radioButtonColumn = new System.Windows.Forms.RadioButton();
            this._radioButtonBar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this._inclination)).BeginInit();
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
            chartArea1.Area3DStyle.Enable3D = true;
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
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
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
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (224)))),
                ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
            series3.Points.Add(dataPoint22);
            series3.Points.Add(dataPoint23);
            series3.Points.Add(dataPoint24);
            series3.Points.Add(dataPoint25);
            series3.Points.Add(dataPoint26);
            series3.Points.Add(dataPoint27);
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
            title1.Text = "3D Bar and Column charts.";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 42);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates 3D Column and Bar charts. It also shows chart area rotat" +
                "ion and isometric projection, as well as clustering of series. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkClustered);
            this._panel1.Controls.Add(this._rotation);
            this._panel1.Controls.Add(this._inclination);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Controls.Add(this._rightAngleAxis);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._radioButtonColumn);
            this._panel1.Controls.Add(this._radioButtonBar);
            this._panel1.Location = new System.Drawing.Point(432, 66);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkClustered
            // 
            this._checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkClustered.Checked = true;
            this._checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkClustered.Location = new System.Drawing.Point(37, 136);
            this._checkClustered.Name = "_checkClustered";
            this._checkClustered.Size = new System.Drawing.Size(144, 24);
            this._checkClustered.TabIndex = 4;
            this._checkClustered.Text = "&Clustered:";
            this._checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkClustered.CheckedChanged += new System.EventHandler(this.checkClustered_CheckedChanged);
            // 
            // Rotation
            // 
            this._rotation.Increment = new decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._rotation.Location = new System.Drawing.Point(168, 200);
            this._rotation.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._rotation.Minimum = new decimal(new int[]
            {
                1000,
                0,
                0,
                -2147483648
            });
            this._rotation.Name = "_rotation";
            this._rotation.Size = new System.Drawing.Size(56, 22);
            this._rotation.TabIndex = 8;
            this._rotation.Value = new decimal(new int[]
            {
                15,
                0,
                0,
                0
            });
            this._rotation.ValueChanged += new System.EventHandler(this.Rotation_ValueChanged);
            // 
            // Inclination
            // 
            this._inclination.Increment = new decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._inclination.Location = new System.Drawing.Point(168, 168);
            this._inclination.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._inclination.Minimum = new decimal(new int[]
            {
                1000,
                0,
                0,
                -2147483648
            });
            this._inclination.Name = "_inclination";
            this._inclination.Size = new System.Drawing.Size(56, 22);
            this._inclination.TabIndex = 6;
            this._inclination.Value = new decimal(new int[]
            {
                15,
                0,
                0,
                0
            });
            this._inclination.ValueChanged += new System.EventHandler(this.Inclination_ValueChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(61, 200);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(104, 23);
            this._label2.TabIndex = 7;
            this._label2.Text = "Rotate &Y:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(69, 168);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(96, 23);
            this._label1.TabIndex = 5;
            this._label1.Text = "Rotate &X:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightAngleAxis
            // 
            this._rightAngleAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._rightAngleAxis.Location = new System.Drawing.Point(37, 104);
            this._rightAngleAxis.Name = "_rightAngleAxis";
            this._rightAngleAxis.Size = new System.Drawing.Size(144, 24);
            this._rightAngleAxis.TabIndex = 3;
            this._rightAngleAxis.Text = "&Right Angle Axes:";
            this._rightAngleAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._rightAngleAxis.CheckedChanged += new System.EventHandler(this.RightAngleAxis_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Checked = true;
            this._checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(5, 72);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(176, 24);
            this._checkBoxShowMargin.TabIndex = 2;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            this._radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonColumn.Checked = true;
            this._radioButtonColumn.Location = new System.Drawing.Point(27, 40);
            this._radioButtonColumn.Name = "_radioButtonColumn";
            this._radioButtonColumn.Size = new System.Drawing.Size(152, 24);
            this._radioButtonColumn.TabIndex = 1;
            this._radioButtonColumn.TabStop = true;
            this._radioButtonColumn.Text = "3D C&olumn Chart:";
            this._radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonColumn.CheckedChanged += new System.EventHandler(this.radioButtonColumn_CheckedChanged);
            // 
            // radioButtonBar
            // 
            this._radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonBar.Location = new System.Drawing.Point(43, 8);
            this._radioButtonBar.Name = "_radioButtonBar";
            this._radioButtonBar.Size = new System.Drawing.Size(136, 24);
            this._radioButtonBar.TabIndex = 0;
            this._radioButtonBar.Text = "3D &Bar Chart:";
            this._radioButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonBar.CheckedChanged += new System.EventHandler(this.radioButtonBar_CheckedChanged);
            // 
            // BarColumn3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "BarColumn3D";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.BarColumn3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this._inclination)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            if (_radioButtonBar.Checked)
            {
                // Set chart type to Bar
                _chart1.Series["Default"].ChartType = SeriesChartType.Bar;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
                _chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
            }
            else
            {
                // Set chart type to Column
                _chart1.Series["Default"].ChartType = SeriesChartType.Column;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Column;
                _chart1.Series["Series3"].ChartType = SeriesChartType.Column;
            }

            // Disable/enable X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;

            // Disable/enable right angle axis
            _chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = _rightAngleAxis.Checked;

            // Disable/enable clustered series
            _chart1.ChartAreas["Default"].Area3DStyle.IsClustered = _checkClustered.Checked;
        }

        private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        //private void checkBoxShowMarkers_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        //private void comboBoxTension_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        private void RightAngleAxis_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void Inclination_ValueChanged(object sender, EventArgs e)
        {
            if (_inclination.Value > 90)
                _inclination.Value = -90;
            if (_inclination.Value < -90)
                _inclination.Value = 90;

            _chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int) _inclination.Value;
        }

        private void Rotation_ValueChanged(object sender, EventArgs e)
        {
            if (_rotation.Value > 180)
                _rotation.Value = -180;
            if (_rotation.Value < -180)
                _rotation.Value = 180;

            _chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int) _rotation.Value;
        }

        private void checkClustered_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void BarColumn3D_Load(object sender, EventArgs e)
        {
        }
    }
}