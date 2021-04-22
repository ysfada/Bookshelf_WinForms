using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.AreaCharts._3DArea
{
    /// <summary>
    ///     Summary description for AreaChart3D.
    /// </summary>
    public class AreaChart3D : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxTension;
        private Label _label1;
        private Label _label3;
        private Label _labelSampleComment;
        private ComboBox _lightingType;
        private Panel _panel1;
        private RadioButton _radioButtonArea;
        private RadioButton _radioButtonSplineArea;
        private CheckBox _showMarkerLines;
        private Timer _timer1;
        private IContainer components;

        public AreaChart3D()
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
            if (disposing) components?.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "5,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "8.10000038146973,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "9,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "7,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "5,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "5.5,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "7.80000019073486,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "7,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "8.5,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._lightingType = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._showMarkerLines = new System.Windows.Forms.CheckBox();
            this._comboBoxTension = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._radioButtonSplineArea = new System.Windows.Forms.RadioButton();
            this._radioButtonArea = new System.Windows.Forms.RadioButton();
            this._timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
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
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this._chart1.Location = new System.Drawing.Point(16, 57);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.CustomProperties = "ShowMarkerLines=true";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.CustomProperties = "ShowMarkerLines=true";
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
            this._labelSampleComment.Size = new System.Drawing.Size(702, 45);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates 3D Area and Spline Area charts. The X axis margin and da" +
                "ta point marker lines can be toggled on and off, and the lighting can also be mo" +
                "dified.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelSampleComment.Click += new System.EventHandler(this.labelSampleComment_Click);
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._lightingType);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._showMarkerLines);
            this._panel1.Controls.Add(this._comboBoxTension);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._radioButtonSplineArea);
            this._panel1.Controls.Add(this._radioButtonArea);
            this._panel1.Location = new System.Drawing.Point(432, 57);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // LightingType
            // 
            this._lightingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._lightingType.Items.AddRange(new object[]
            {
                "None",
                "Simplistic",
                "Realistic"
            });
            this._lightingType.Location = new System.Drawing.Point(168, 112);
            this._lightingType.Name = "_lightingType";
            this._lightingType.Size = new System.Drawing.Size(80, 22);
            this._lightingType.TabIndex = 5;
            this._lightingType.SelectedIndexChanged += new System.EventHandler(this.LightingType_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(61, 112);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(104, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "&Lighting:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowMarkerLines
            // 
            this._showMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.Location = new System.Drawing.Point(14, 176);
            this._showMarkerLines.Name = "_showMarkerLines";
            this._showMarkerLines.Size = new System.Drawing.Size(168, 24);
            this._showMarkerLines.TabIndex = 7;
            this._showMarkerLines.Text = "Show Marker &Lines:";
            this._showMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.CheckedChanged += new System.EventHandler(this.ShowMarkerLines_CheckedChanged);
            // 
            // comboBoxTension
            // 
            this._comboBoxTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxTension.Items.AddRange(new object[]
            {
                "1.2",
                "0.8",
                "0.4",
                "0.2"
            });
            this._comboBoxTension.Location = new System.Drawing.Point(168, 80);
            this._comboBoxTension.Name = "_comboBoxTension";
            this._comboBoxTension.Size = new System.Drawing.Size(80, 22);
            this._comboBoxTension.TabIndex = 3;
            this._comboBoxTension.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxTension_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(29, 80);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(136, 23);
            this._label1.TabIndex = 2;
            this._label1.Text = "Spline &Tension:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(-2, 144);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(184, 24);
            this._checkBoxShowMargin.TabIndex = 6;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            this._radioButtonSplineArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonSplineArea.Location = new System.Drawing.Point(36, 45);
            this._radioButtonSplineArea.Name = "_radioButtonSplineArea";
            this._radioButtonSplineArea.Size = new System.Drawing.Size(144, 24);
            this._radioButtonSplineArea.TabIndex = 1;
            this._radioButtonSplineArea.Text = "&Spline Area:";
            this._radioButtonSplineArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonSplineArea.CheckedChanged +=
                new System.EventHandler(this.radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            this._radioButtonArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonArea.Checked = true;
            this._radioButtonArea.Location = new System.Drawing.Point(36, 16);
            this._radioButtonArea.Name = "_radioButtonArea";
            this._radioButtonArea.Size = new System.Drawing.Size(144, 24);
            this._radioButtonArea.TabIndex = 0;
            this._radioButtonArea.TabStop = true;
            this._radioButtonArea.Text = "&Area:";
            this._radioButtonArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonArea.CheckedChanged += new System.EventHandler(this.radioButtonArea_CheckedChanged);
            // 
            // timer1
            // 
            this._timer1.Enabled = true;
            this._timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AreaChart3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "AreaChart3D";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.AreaChart3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            if (_radioButtonArea.Checked)
            {
                // Set chart type to Area
                _chart1.Series["Series1"].ChartType = SeriesChartType.Area;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Area;
                _chart1.Series["Series1"].DeleteCustomProperty("LineTension");
                _chart1.Series["Series2"].DeleteCustomProperty("LineTension");
                _comboBoxTension.Enabled = false;
            }
            else
            {
                // Set chart type to SplineArea and set line tension
                _comboBoxTension.Enabled = true;
                _chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
                _chart1.Series["Series1"]["LineTension"] = _comboBoxTension.Text;
                _chart1.Series["Series2"].ChartType = SeriesChartType.SplineArea;
                _chart1.Series["Series2"]["LineTension"] = _comboBoxTension.Text;
            }

            // Disable/enable X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;
            _chart1.Series["Series1"]["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();
            _chart1.Series["Series2"]["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();

            // Set area lighting
            if (_lightingType.Text != "")
                _chart1.ChartAreas["Default"].Area3DStyle.LightStyle =
                    (LightStyle) Enum.Parse(typeof(LightStyle), _lightingType.Text);
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void radioButtonSplineArea_CheckedChanged(object sender, EventArgs e)
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

        private void comboBoxTension_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void AreaChart3D_Load(object sender, EventArgs e)
        {
            _comboBoxTension.SelectedIndex = 1;
            _lightingType.SelectedIndex = 2;
        }

        private void ShowMarkerLines_CheckedChanged(object sender, EventArgs e)
        {
            _chart1.Series["Series1"]["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();
            _chart1.Series["Series2"]["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();
        }

        private void LightingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_chart1.ChartAreas[0].Area3DStyle.Rotation <= 177)
                _chart1.ChartAreas[0].Area3DStyle.Rotation += 3;
            else
                _chart1.ChartAreas[0].Area3DStyle.Rotation = -180;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void labelSampleComment_Click(object sender, EventArgs e)
        {
        }
    }
}