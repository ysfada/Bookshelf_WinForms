using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bookshelf.Database.Entities;

namespace Bookshelf.Components.Base.PieChart
{
    /// <summary>
    ///     Summary description for PieChart.
    /// </summary>
    public class PieChart : UserControl
    {
        #region Component Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            var chartArea1 = new ChartArea();
            var legend1 = new Legend();
            var title1 = new Title();
            _series1 = new Series();
            _chart1 = new Chart();
            _labelSampleComment = new Label();
            _panel1 = new Panel();
            _label6 = new Label();
            _comboBoxPieDrawingStyle = new ComboBox();
            _checkBoxRotate = new CheckBox();
            _checkBoxShow3D = new CheckBox();
            _comboBoxRadius = new ComboBox();
            _label4 = new Label();
            _showLegend = new CheckBox();
            _comboBoxExploded = new ComboBox();
            _label3 = new Label();
            _comboBoxLabelStyle = new ComboBox();
            _label2 = new Label();
            _comboBoxChartType = new ComboBox();
            _label1 = new Label();
            _timer1 = new Timer(components);
            ((ISupportInitialize) _chart1).BeginInit();
            _panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            _chart1.BackColor = Color.WhiteSmoke;
            _chart1.BackGradientStyle = GradientStyle.TopBottom;
            _chart1.BackSecondaryColor = Color.White;
            _chart1.BorderlineColor = Color.FromArgb(26,59, 105);
            _chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            _chart1.BorderlineWidth = 2;
            _chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            chartArea1.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            chartArea1.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BackSecondaryColor = Color.Transparent;
            chartArea1.BorderColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = Color.Transparent;
            _chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.Transparent;
            legend1.Docking = Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            _chart1.Legends.Add(legend1);
            _chart1.Location = new Point(16, 40);
            _chart1.Name = "_chart1";
            _series1.BorderColor = Color.FromArgb(180, 26, 59, 105);
            _series1.ChartArea = "Default";
            _series1.ChartType = SeriesChartType.Doughnut;
            _series1.Color = Color.FromArgb(220, 65, 140, 240);
            _series1.CustomProperties = "DoughnutRadius=60, PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            _series1.Legend = "Default";
            _series1.Name = "Default";
            _series1.XValueType = ChartValueType.String;
            _series1.YValueType = ChartValueType.Double;
            _chart1.Series.Add(_series1);
            //_chart1.Size = new Size(412, 296);
            _chart1.Size = new Size(550, 395);
            _chart1.TabIndex = 0;
            title1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            title1.ForeColor = Color.FromArgb(26, 59, 105);
            title1.Name = "Title1";
            title1.ShadowColor = Color.FromArgb(32, 0, 0, 0);
            title1.ShadowOffset = 3;
            title1.Text = "Doughnut Chart";
            _chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            _labelSampleComment.Font = new Font("Verdana", 11F, FontStyle.Regular,
                GraphicsUnit.Point, ((byte) (0)));
            _labelSampleComment.Location = new Point(16, 8);
            _labelSampleComment.Name = "_labelSampleComment";
            _labelSampleComment.Size = new Size(702, 26);
            _labelSampleComment.TabIndex = 2;
            _labelSampleComment.Text = "This sample demonstrates the Pie and Doughnut chart types in both 2D and 3D.";
            _labelSampleComment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            _panel1.Controls.Add(_label6);
            _panel1.Controls.Add(_comboBoxPieDrawingStyle);
            _panel1.Controls.Add(_checkBoxRotate);
            _panel1.Controls.Add(_checkBoxShow3D);
            _panel1.Controls.Add(_comboBoxRadius);
            _panel1.Controls.Add(_label4);
            _panel1.Controls.Add(_showLegend);
            _panel1.Controls.Add(_comboBoxExploded);
            _panel1.Controls.Add(_label3);
            _panel1.Controls.Add(_comboBoxLabelStyle);
            _panel1.Controls.Add(_label2);
            _panel1.Controls.Add(_comboBoxChartType);
            _panel1.Controls.Add(_label1);
            //_panel1.Location = new Point(432, 48);
            _panel1.Location = new Point(_chart1.Location.X + _chart1.Width + 20, _chart1.Location.Y);
            _panel1.Name = "_panel1";
            _panel1.Size = new Size(292, 288);
            _panel1.TabIndex = 1;
            // 
            // label6
            // 
            _label6.Location = new Point(49, 229);
            _label6.Name = "_label6";
            _label6.Size = new Size(112, 23);
            _label6.TabIndex = 14;
            _label6.Text = "&Drawing Style:";
            _label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPieDrawingStyle
            // 
            _comboBoxPieDrawingStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxPieDrawingStyle.Items.AddRange(new object[]
            {
                "Default",
                "SoftEdge",
                "Concave"
            });
            _comboBoxPieDrawingStyle.Location = new Point(167, 229);
            _comboBoxPieDrawingStyle.Name = "_comboBoxPieDrawingStyle";
            _comboBoxPieDrawingStyle.Size = new Size(112, 22);
            _comboBoxPieDrawingStyle.TabIndex = 13;
            _comboBoxPieDrawingStyle.SelectedIndexChanged += new EventHandler(comboBoxDrawingStyle_SelectedIndexChanged);
            // 
            // checkBoxRotate
            // 
            _checkBoxRotate.CheckAlign = ContentAlignment.MiddleRight;
            _checkBoxRotate.Location = new Point(13, 166);
            _checkBoxRotate.Name = "_checkBoxRotate";
            _checkBoxRotate.Size = new Size(168, 24);
            _checkBoxRotate.TabIndex = 12;
            _checkBoxRotate.Text = "Rotate C&hart:";
            _checkBoxRotate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBoxShow3D
            // 
            _checkBoxShow3D.CheckAlign = ContentAlignment.MiddleRight;
            _checkBoxShow3D.Location = new Point(14, 197);
            _checkBoxShow3D.Name = "_checkBoxShow3D";
            _checkBoxShow3D.Size = new Size(168, 24);
            _checkBoxShow3D.TabIndex = 11;
            _checkBoxShow3D.Text = "Display &chart as 3D:";
            _checkBoxShow3D.TextAlign = ContentAlignment.MiddleRight;
            _checkBoxShow3D.CheckedChanged += new EventHandler(checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxRadius
            // 
            _comboBoxRadius.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxRadius.Items.AddRange(new object[]
            {
                "20",
                "30",
                "40",
                "50",
                "60",
                "70"
            });
            _comboBoxRadius.Location = new Point(168, 104);
            _comboBoxRadius.Name = "_comboBoxRadius";
            _comboBoxRadius.Size = new Size(112, 22);
            _comboBoxRadius.TabIndex = 3;
            _comboBoxRadius.SelectedIndexChanged += new EventHandler(comboBoxRadius_SelectedIndexChanged);
            // 
            // label4
            // 
            _label4.Location = new Point(11, 104);
            _label4.Name = "_label4";
            _label4.Size = new Size(152, 23);
            _label4.TabIndex = 8;
            _label4.Text = "Doughnut &Radius (%):";
            _label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ShowLegend
            // 
            _showLegend.CheckAlign = ContentAlignment.MiddleRight;
            _showLegend.Checked = false;
            _showLegend.CheckState = CheckState.Unchecked;
            _showLegend.Location = new Point(21, 136);
            _showLegend.Name = "_showLegend";
            _showLegend.Size = new Size(160, 24);
            _showLegend.TabIndex = 4;
            _showLegend.Text = "Show &Legend:";
            _showLegend.TextAlign = ContentAlignment.MiddleRight;
            _showLegend.CheckedChanged += new EventHandler(ShowLegend_CheckedChanged);
            // 
            // comboBoxExploded
            //
            _comboBoxExploded.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxExploded.Location = new Point(168, 72);
            _comboBoxExploded.Name = "_comboBoxExploded";
            _comboBoxExploded.Size = new Size(112, 22);
            _comboBoxExploded.TabIndex = 2;
            _comboBoxExploded.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            _label3.Location = new Point(11, 72);
            _label3.Name = "_label3";
            _label3.Size = new Size(152, 23);
            _label3.TabIndex = 7;
            _label3.Text = "&Exploded Point:";
            _label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelStyle
            // 
            _comboBoxLabelStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxLabelStyle.Items.AddRange(new object[]
            {
                "Inside",
                "Outside",
                "Disabled"
            });
            _comboBoxLabelStyle.Location = new Point(168, 40);
            _comboBoxLabelStyle.Name = "_comboBoxLabelStyle";
            _comboBoxLabelStyle.Size = new Size(112, 22);
            _comboBoxLabelStyle.TabIndex = 1;
            _comboBoxLabelStyle.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            _label2.Location = new Point(11, 40);
            _label2.Name = "_label2";
            _label2.Size = new Size(152, 23);
            _label2.TabIndex = 6;
            _label2.Text = "Label &Style:";
            _label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            _comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxChartType.Items.AddRange(new object[]
            {
                "Pie",
                "Doughnut"
            });
            _comboBoxChartType.Location = new Point(168, 8);
            _comboBoxChartType.Name = "_comboBoxChartType";
            _comboBoxChartType.Size = new Size(112, 22);
            _comboBoxChartType.TabIndex = 0;
            _comboBoxChartType.SelectedIndexChanged += new EventHandler(comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            _label1.Location = new Point(11, 8);
            _label1.Name = "_label1";
            _label1.Size = new Size(152, 23);
            _label1.TabIndex = 5;
            _label1.Text = "Chart &Type:";
            _label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            _timer1.Enabled = true;
            _timer1.Interval = 20;
            _timer1.Tick += new EventHandler(timer1_Tick);
            // 
            // PieChart
            // 
            BackColor = Color.White;
            Controls.Add(_panel1);
            Controls.Add(_labelSampleComment);
            Controls.Add(_chart1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PieChart";
            Size = new Size(728, 440);
            Load += new EventHandler(PieChart_Load);
            ((ISupportInitialize) (_chart1)).EndInit();
            _panel1.ResumeLayout(false);
            ResumeLayout(false);
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

            // Explode selected genres
            foreach (var point in _chart1.Series["Default"].Points)
            {
                point["Exploded"] = "false";
                // TODO: better way to handle this?
                // because of naming "Name (Value)" we must use point.AxisLabel.Split(' ')[0] instead of point.AxisLabel
                if (point.AxisLabel.Split(' ')[0] == _comboBoxExploded.Text) point["Exploded"] = "true";
            }

            // Enable 3D
            _chart1.ChartAreas[0].Area3DStyle.Enable3D = _checkBoxShow3D.Checked;

            // Pie drawing style
            _comboBoxPieDrawingStyle.Enabled = !_checkBoxShow3D.Checked;
        }

        private void PieChart_Load(object sender, EventArgs e)
        {
            // TODO: use real data here
            // Populate series data
            var xValues = Array.Empty<string>();
            double[] yValues = {3.0, 2.0, 3.0, 6.0, 5.0, 9.0, 7.0, 8.0};
            foreach (var (genre, index) in Enum.GetNames(typeof(Genre)).Select((value, i) => (value, i)))
                xValues = xValues.Append($"{genre} ({yValues[index]})").ToArray();
            _chart1.Series["Default"].Points.DataBindXY(xValues, yValues);

            // Set selection
            _comboBoxChartType.SelectedIndex = 1;
            _comboBoxPieDrawingStyle.SelectedIndex = 1;
            _comboBoxLabelStyle.SelectedIndex = 1;
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
            if (!_checkBoxRotate.Checked) return;

            _angle += 1;
            if (_angle >= 360) _angle = 0;
            _chart1.Series["Default"]["PieStartAngle"] = _angle.ToString();
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

        private Series _series1;
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

        public PieChart()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call
            foreach (var genre in Enum.GetNames(typeof(Genre)))
            {
                var dataPoint1 = new DataPoint();
                dataPoint1.CustomProperties = "Exploded=false";
                dataPoint1.Label = genre;
                _series1.Points.Add(dataPoint1);
            }

            var genres = new object[]
            {
                "None"
            };
            //foreach (var genre in Enum.GetNames(typeof(Genre)).Select((value, i) => (value, i)))
            //{
            //    genres[genre.i] = genre.value;
            //}
            //foreach (var genre in Enum.GetNames(typeof(Genre)))
            //{
            //    genres = genres.Append(genre).ToArray();
            //}
            genres = Enum.GetNames(typeof(Genre)).Aggregate(genres, (current, genre) => current.Append(genre).ToArray());

            _comboBoxExploded.Items.AddRange(genres);
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