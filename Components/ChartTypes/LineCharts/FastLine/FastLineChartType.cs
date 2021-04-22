using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.LineCharts.FastLine
{
    /// <summary>
    ///     Summary description for FastLineChartType.
    /// </summary>
    public class FastLineChartType : UserControl
    {
        private Button _buttonAddPoints;
        private Chart _chart1;
        private ComboBox _comboBoxChartType;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public FastLineChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FastLineChartType));
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._buttonAddPoints = new System.Windows.Forms.Button();
            this._label2 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitStyle =
                ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles) (((System.Windows.Forms
                        .DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms
                        .DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                    | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 10;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (64)))),
                ((int) (((byte) (10)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.ShadowColor = System.Drawing.Color.Black;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Two series with 20000 points each";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 45);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text =
                "The Fast Line and Fast Point chart types significantly reduce the drawing time of" +
                " a series that has many data points. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Controls.Add(this._buttonAddPoints);
            this._panel1.Location = new System.Drawing.Point(432, 66);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 1;
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Fast Line",
                "Fast Point"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(184, 8);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(104, 22);
            this._comboBoxChartType.TabIndex = 3;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(51, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(112, 23);
            this._label1.TabIndex = 2;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddPoints
            // 
            this._buttonAddPoints.BackColor = System.Drawing.SystemColors.Control;
            this._buttonAddPoints.Location = new System.Drawing.Point(104, 48);
            this._buttonAddPoints.Name = "_buttonAddPoints";
            this._buttonAddPoints.Size = new System.Drawing.Size(184, 23);
            this._buttonAddPoints.TabIndex = 1;
            this._buttonAddPoints.Text = "&Add 1000 Data Points";
            this._buttonAddPoints.UseVisualStyleBackColor = false;
            this._buttonAddPoints.Click += new System.EventHandler(this.buttonAddPoints_Click);
            // 
            // label2
            // 
            this._label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._label2.Location = new System.Drawing.Point(16, 362);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(702, 72);
            this._label2.TabIndex = 3;
            this._label2.Text = resources.GetString("label2.Text");
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this._label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._label3.Location = new System.Drawing.Point(16, 435);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(702, 27);
            this._label3.TabIndex = 4;
            this._label3.Text = "To further enhance performance, disable tooltips, anti-aliasing, and border skins" +
                                ".";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FastLineChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label3);
            this.Controls.Add(this._label2);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "FastLineChartType";
            this.Size = new System.Drawing.Size(728, 511);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Loop through all series
            foreach (var series in _chart1.Series)
                series.ChartType =
                    (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text.Replace(" ", ""));
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            _comboBoxChartType.SelectedIndex = 0;
            AddPoints(20000);
            UpdateChartSettings();
        }

        private void buttonAddPoints_Click(object sender, EventArgs e)
        {
            AddPoints(1000);
            _chart1.Titles[0].Text = "Two series with " + _chart1.Series["Series1"].Points.Count + " points each";
            _chart1.Invalidate();
        }

        private void AddPoints(int pointCount)
        {
            // Fill series data
            var yValue = 50.0;
            var yValue2 = 200.0;
            if (_chart1.Series["Series1"].Points.Count > 0)
            {
                yValue = _chart1.Series["Series1"].Points[_chart1.Series["Series1"].Points.Count - 1].YValues[0];
                yValue2 = _chart1.Series["Series2"].Points[_chart1.Series["Series1"].Points.Count - 1].YValues[0];
            }

            var random = new Random();
            for (var pointIndex = 0; pointIndex < pointCount; pointIndex++)
            {
                yValue = yValue + (float) (random.NextDouble() * 10.0 - 5.0);
                _chart1.Series["Series1"].Points.AddY(yValue);

                yValue2 = yValue2 + (float) (random.NextDouble() * 10.0 - 5.0);
                _chart1.Series["Series2"].Points.AddY(yValue2);
            }
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}