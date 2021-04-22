using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PieDoughnutCharts._3DPie
{
    /// <summary>
    ///     Summary description for PieChart3D.
    /// </summary>
    public class PieChart3D : UserControl
    {
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
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 65.62);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 75.54);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 60.45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 55.73);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 70.42);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._label6 = new System.Windows.Forms.Label();
            this._comboBoxPieDrawingStyle = new System.Windows.Forms.ComboBox();
            this._checkBoxRotate = new System.Windows.Forms.CheckBox();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._comboBoxRadius = new System.Windows.Forms.ComboBox();
            this._label4 = new System.Windows.Forms.Label();
            this._showLegend = new System.Windows.Forms.CheckBox();
            this._comboBoxExploded = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 0;
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
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 40);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.CustomProperties = "DoughnutRadius=60, PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.CustomProperties = "Exploded=false";
            dataPoint1.Label = "France";
            dataPoint2.CustomProperties = "Exploded=false";
            dataPoint2.Label = "Canada";
            dataPoint3.CustomProperties = "Exploded=false";
            dataPoint3.Label = "UK";
            dataPoint4.CustomProperties = "Exploded=false";
            dataPoint4.Label = "USA";
            dataPoint5.CustomProperties = "Exploded=false";
            dataPoint5.Label = "Italy";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Doughnut Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 26);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text =
                "This sample demonstrates the Pie and Doughnut chart types in both 2D and 3D.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._label6);
            this._panel1.Controls.Add(this._comboBoxPieDrawingStyle);
            this._panel1.Controls.Add(this._checkBoxRotate);
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._comboBoxRadius);
            this._panel1.Controls.Add(this._label4);
            this._panel1.Controls.Add(this._showLegend);
            this._panel1.Controls.Add(this._comboBoxExploded);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxLabelStyle);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 48);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 1;
            // 
            // label6
            // 
            this._label6.Location = new System.Drawing.Point(49, 229);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(112, 23);
            this._label6.TabIndex = 14;
            this._label6.Text = "&Drawing Style:";
            this._label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPieDrawingStyle
            // 
            this._comboBoxPieDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPieDrawingStyle.Items.AddRange(new object[]
            {
                "Default",
                "SoftEdge",
                "Concave"
            });
            this._comboBoxPieDrawingStyle.Location = new System.Drawing.Point(167, 229);
            this._comboBoxPieDrawingStyle.Name = "_comboBoxPieDrawingStyle";
            this._comboBoxPieDrawingStyle.Size = new System.Drawing.Size(112, 22);
            this._comboBoxPieDrawingStyle.TabIndex = 13;
            this._comboBoxPieDrawingStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxDrawingStyle_SelectedIndexChanged);
            // 
            // checkBoxRotate
            // 
            this._checkBoxRotate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxRotate.Location = new System.Drawing.Point(13, 166);
            this._checkBoxRotate.Name = "_checkBoxRotate";
            this._checkBoxRotate.Size = new System.Drawing.Size(168, 24);
            this._checkBoxRotate.TabIndex = 12;
            this._checkBoxRotate.Text = "Rotate C&hart:";
            this._checkBoxRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(14, 197);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShow3D.TabIndex = 11;
            this._checkBoxShow3D.Text = "Display &chart as 3D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxRadius
            // 
            this._comboBoxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxRadius.Items.AddRange(new object[]
            {
                "20",
                "30",
                "40",
                "50",
                "60",
                "70"
            });
            this._comboBoxRadius.Location = new System.Drawing.Point(168, 104);
            this._comboBoxRadius.Name = "_comboBoxRadius";
            this._comboBoxRadius.Size = new System.Drawing.Size(112, 22);
            this._comboBoxRadius.TabIndex = 3;
            this._comboBoxRadius.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxRadius_SelectedIndexChanged);
            // 
            // label4
            // 
            this._label4.Location = new System.Drawing.Point(11, 104);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(152, 23);
            this._label4.TabIndex = 8;
            this._label4.Text = "Doughnut &Radius (%):";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowLegend
            // 
            this._showLegend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showLegend.Checked = true;
            this._showLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this._showLegend.Location = new System.Drawing.Point(21, 136);
            this._showLegend.Name = "_showLegend";
            this._showLegend.Size = new System.Drawing.Size(160, 24);
            this._showLegend.TabIndex = 4;
            this._showLegend.Text = "Show &Legend:";
            this._showLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showLegend.CheckedChanged += new System.EventHandler(this.ShowLegend_CheckedChanged);
            // 
            // comboBoxExploded
            // 
            this._comboBoxExploded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxExploded.Items.AddRange(new object[]
            {
                "None",
                "France",
                "Canada",
                "UK",
                "USA",
                "Italy"
            });
            this._comboBoxExploded.Location = new System.Drawing.Point(168, 72);
            this._comboBoxExploded.Name = "_comboBoxExploded";
            this._comboBoxExploded.Size = new System.Drawing.Size(112, 22);
            this._comboBoxExploded.TabIndex = 2;
            this._comboBoxExploded.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(11, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(152, 23);
            this._label3.TabIndex = 7;
            this._label3.Text = "&Exploded Point:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelStyle
            // 
            this._comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelStyle.Items.AddRange(new object[]
            {
                "Inside",
                "Outside",
                "Disabled"
            });
            this._comboBoxLabelStyle.Location = new System.Drawing.Point(168, 40);
            this._comboBoxLabelStyle.Name = "_comboBoxLabelStyle";
            this._comboBoxLabelStyle.Size = new System.Drawing.Size(112, 22);
            this._comboBoxLabelStyle.TabIndex = 1;
            this._comboBoxLabelStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(11, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(152, 23);
            this._label2.TabIndex = 6;
            this._label2.Text = "Label &Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Pie",
                "Doughnut"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(112, 22);
            this._comboBoxChartType.TabIndex = 0;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(11, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(152, 23);
            this._label1.TabIndex = 5;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this._timer1.Enabled = true;
            this._timer1.Interval = 20;
            this._timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PieChart3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "PieChart3D";
            this.Size = new System.Drawing.Size(728, 440);
            this.Load += new System.EventHandler(this.PieChart3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            _chart1.Legends[0].Enabled = _showLegend.Checked;

            // Set chart type and title
            _chart1.Series["Default"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text, true);
            _chart1.Titles[0].Text = _comboBoxChartType.Text + " Chart";

            // Set labels style
            _chart1.Series["Default"]["PieLabelStyle"] = _comboBoxLabelStyle.Text;

            // Set Doughnut hole size
            _chart1.Series["Default"]["DoughnutRadius"] = _comboBoxRadius.Text;

            // Disable Doughnut hole size control for Pie chart
            _comboBoxRadius.Enabled = _comboBoxChartType.Text != @"Pie";

            // Explode selected country
            foreach (var point in _chart1.Series["Default"].Points)
            {
                point["Exploded"] = "false";
                if (point.AxisLabel == _comboBoxExploded.Text) point["Exploded"] = "true";
            }

            // Enable 3D
            _chart1.ChartAreas[0].Area3DStyle.Enable3D = _checkBoxShow3D.Checked;

            // Pie drawing style
            if (_checkBoxShow3D.Checked)
                _comboBoxPieDrawingStyle.Enabled = false;

            else
                _comboBoxPieDrawingStyle.Enabled = true;
        }

        private void PieChart3D_Load(object sender, EventArgs e)
        {
            // Populate series data
            double[] yValues = {65.62, 75.54, 60.45, 55.73, 70.42};
            string[] xValues = {"France", "Canada", "UK", "USA", "Italy"};
            _chart1.Series["Default"].Points.DataBindXY(xValues, yValues);

            // Set selection
            _comboBoxChartType.SelectedIndex = 1;
            _comboBoxPieDrawingStyle.SelectedIndex = 1;
            _comboBoxLabelStyle.SelectedIndex = 0;
            _comboBoxExploded.SelectedIndex = 0;
            _comboBoxRadius.SelectedIndex = 4;
            _chart1.Legends[0].Enabled = _showLegend.Checked;
        }

        private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_checkBoxRotate.Checked)
            {
                _angle += 1;
                if (_angle >= 360) _angle = 0;
                _chart1.Series["Default"]["PieStartAngle"] = _angle.ToString();
            }
        }

        private void ShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxRadius_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        //private void LabelLineSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart1.Series[0]["PieDrawingStyle"] = _comboBoxPieDrawingStyle.SelectedItem.ToString();
        }

        # region Fields

        private Chart _chart1;
        private Label _labelSampleComment;
        private Panel _panel1;
        private Label _label1;
        private ComboBox _comboBoxChartType;
        private Label _label2;
        private ComboBox _comboBoxLabelStyle;
        private Label _label3;
        private ComboBox _comboBoxExploded;
        private Timer _timer1;
        private CheckBox _showLegend;
        private ComboBox _comboBoxRadius;
        private Label _label4;
        private CheckBox _checkBoxShow3D;
        private CheckBox _checkBoxRotate;
        private IContainer components;
        private Label _label6;
        private ComboBox _comboBoxPieDrawingStyle;
        private int _angle;

        #endregion

        # region Constructor

        public PieChart3D()
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

        #endregion
    }
}