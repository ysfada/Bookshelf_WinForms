using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.LineCharts._3DLine
{
    /// <summary>
    ///     Summary description for LineCurves3D.
    /// </summary>
    public class LineCurves3D : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxChartType;
        private ComboBox _comboBoxPointLabels;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _labelSampleComment;
        private Panel _panel1;
        private CheckBox _showMarkerLines;

        public LineCurves3D()
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
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._showMarkerLines = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._comboBoxPointLabels = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
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
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 38;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointDepth = 200;
            chartArea1.Area3DStyle.Rotation = 9;
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
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 2F;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Series.Add(series3);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F);
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates Line, Spline and StepLine chart types with 3D enabled. T" +
                "he label style and the display of data point marker lines can be set using custo" +
                "m attributes.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._showMarkerLines);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._comboBoxPointLabels);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 64);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // ShowMarkerLines
            // 
            this._showMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.Location = new System.Drawing.Point(14, 104);
            this._showMarkerLines.Name = "_showMarkerLines";
            this._showMarkerLines.Size = new System.Drawing.Size(168, 24);
            this._showMarkerLines.TabIndex = 5;
            this._showMarkerLines.Text = "Show Marker &Lines:";
            this._showMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.CheckedChanged += new System.EventHandler(this.ShowMarkerLines_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(14, 72);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShowMargin.TabIndex = 4;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxPointLabels
            // 
            this._comboBoxPointLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPointLabels.Items.AddRange(new object[]
            {
                "None",
                "Auto",
                "TopLeft",
                "Top",
                "TopRight",
                "Right",
                "BottomRight",
                "Bottom",
                "BottomLeft",
                "Left",
                "Center"
            });
            this._comboBoxPointLabels.Location = new System.Drawing.Point(168, 40);
            this._comboBoxPointLabels.Name = "_comboBoxPointLabels";
            this._comboBoxPointLabels.Size = new System.Drawing.Size(104, 22);
            this._comboBoxPointLabels.TabIndex = 3;
            this._comboBoxPointLabels.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(51, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(112, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Point &Labels:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Line",
                "Spline",
                "StepLine"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(104, 22);
            this._comboBoxChartType.TabIndex = 1;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(51, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(112, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LineCurves3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "LineCurves3D";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.LineCurves3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Loop through all series
            foreach (var series in _chart1.Series)
            {
                // Set series chart type
                series.ChartType = (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text, true);

                // Set point labels
                if (_comboBoxPointLabels.Text != @"None")
                {
                    series.IsValueShownAsLabel = true;
                    if (_comboBoxPointLabels.Text != @"Auto") series["LabelStyle"] = _comboBoxPointLabels.Text;
                }
                else
                {
                    series.IsValueShownAsLabel = false;
                }

                // Enable / disable Marker Lines
                series["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();
            }

            // Set X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;
        }

        private void LineCurves3D_Load(object sender, EventArgs e)
        {
            _comboBoxChartType.SelectedIndex = 1;
            _comboBoxPointLabels.SelectedIndex = 0;

            // Populate series data
            var random = new Random();
            for (var pointIndex = 0; pointIndex < 10; pointIndex++)
            {
                _chart1.Series["Series1"].Points.AddY(random.Next(45, 95));
                _chart1.Series["Series2"].Points.AddY(random.Next(5, 75));
                _chart1.Series["Series3"].Points.AddY(random.Next(2, 50));
            }

            UpdateChartSettings();
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void ShowMarkerLines_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}