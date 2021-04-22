using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bookshelf.Database.Entities;

namespace Bookshelf.Components.Base.PieChart
{
    public partial class GenrePieChart : BaseUserControl
    {
        private readonly Chart _chart1 = new();
        private readonly ChartArea _chartArea1 = new();
        private readonly Legend _legend1 = new();
        private readonly Title _title1 = new();
        private readonly Series _series1 = new();
        private int _angle;

        public GenrePieChart()
        {
            InitializeComponent();

            _chart1.BackColor = Color.WhiteSmoke;
            _chart1.BackGradientStyle = GradientStyle.TopBottom;
            _chart1.BackSecondaryColor = Color.White;
            _chart1.BorderlineColor = Color.FromArgb(26, 59, 105);
            _chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            _chart1.BorderlineWidth = 2;
            _chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            _chartArea1.Area3DStyle.IsClustered = true;
            _chartArea1.Area3DStyle.IsRightAngleAxes = false;
            _chartArea1.Area3DStyle.Perspective = 10;
            _chartArea1.Area3DStyle.PointGapDepth = 0;
            _chartArea1.Area3DStyle.Rotation = 0;
            _chartArea1.Area3DStyle.WallWidth = 0;
            _chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            _chartArea1.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            _chartArea1.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            _chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            _chartArea1.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            _chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            _chartArea1.BackColor = Color.Transparent;
            _chartArea1.BackSecondaryColor = Color.Transparent;
            _chartArea1.BorderColor = Color.FromArgb(64, 64, 64, 64);
            _chartArea1.BorderWidth = 0;
            _chartArea1.Name = "Default";
            _chartArea1.ShadowColor = Color.Transparent;

            _chart1.ChartAreas.Add(_chartArea1);

            _legend1.Alignment = StringAlignment.Center;
            _legend1.BackColor = Color.Transparent;
            _legend1.Docking = Docking.Bottom;
            _legend1.Enabled = false;
            _legend1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            _legend1.IsTextAutoFit = false;
            _legend1.Name = "Default";

            _chart1.Legends.Add(_legend1);
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
            _chart1.Dock = DockStyle.Fill;
            _chart1.TabIndex = 0;

            _title1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold);
            _title1.ForeColor = Color.FromArgb(26, 59, 105);
            _title1.Name = "Title1";
            _title1.ShadowColor = Color.FromArgb(32, 0, 0, 0);
            _title1.ShadowOffset = 3;
            _title1.Text = "Doughnut Chart";

            _chart1.Titles.Add(_title1);

            Load += PieChart_Load;

            basePanel2.Controls.Add(_chart1);

            ///////////////////////////////////////////////////////////////////////////////

            // TODO: Add any initialization after the InitForm call
            foreach (var genre in Enum.GetNames(typeof(Genre)))
            {
                var dataPoint1 = new DataPoint
                {
                    CustomProperties = "Exploded=false",
                    Label = genre
                };
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

        private void _comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _comboBoxLabelStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _comboBoxRadius_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _showLegend_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void _comboBoxPieDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart1.Series[0]["PieDrawingStyle"] = _comboBoxPieDrawingStyle.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_checkBoxRotate.Checked) return;

            _angle += 1;
            if (_angle >= 360) _angle = 0;
            _chart1.Series["Default"]["PieStartAngle"] = _angle.ToString();
        }
    }
}
