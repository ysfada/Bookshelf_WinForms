using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.CircularCharts.Radar
{
    /// <summary>
    ///     Summary description for RadarChartType.
    /// </summary>
    public class RadarChartType : UserControl
    {
        private Chart _chart1;
        private ComboBox _comboBoxAreaStyle;
        private ComboBox _comboBoxLabelStyle;
        private ComboBox _comboBoxRadarStyle;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _label5;
        private Label _labelSampleComment;
        private Panel _panel1;

        public RadarChartType()
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
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxAreaStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxRadarStyle = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor =
                System.Drawing.Color.FromArgb(((System.Byte) (243)), ((System.Byte) (223)), ((System.Byte) (193)));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor =
                System.Drawing.Color.FromArgb(((System.Byte) (181)), ((System.Byte) (64)), ((System.Byte) (1)));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.AxisY.MajorTickMark.Size = 0.6F;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 78F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 15F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.IsTextAutoFit = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 14.23021F;
            legend1.Position.Width = 19.34047F;
            legend1.Position.X = 74.73474F;
            legend1.Position.Y = 74.08253F;
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 56);
            this._chart1.Name = "_chart1";
            this._chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte) (180)), ((System.Byte) (26)),
                ((System.Byte) (59)), ((System.Byte) (105)));
            series1.ChartType = SeriesChartType.Radar;
            series1.Color = System.Drawing.Color.FromArgb(((System.Byte) (220)), ((System.Byte) (65)),
                ((System.Byte) (140)), ((System.Byte) (240)));
            series1.MarkerBorderColor =
                System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)), ((System.Byte) (64)));
            series1.MarkerSize = 9;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte) (180)), ((System.Byte) (26)),
                ((System.Byte) (59)), ((System.Byte) (105)));
            series2.ChartType = SeriesChartType.Radar;
            series2.Color = System.Drawing.Color.FromArgb(((System.Byte) (220)), ((System.Byte) (252)),
                ((System.Byte) (180)), ((System.Byte) (65)));
            series2.MarkerBorderColor =
                System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)), ((System.Byte) (64)));
            series2.MarkerSize = 9;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 288);
            this._chart1.TabIndex = 1;
            title1.ForeColor =
                System.Drawing.Color.FromArgb(((System.Byte) (26)), ((System.Byte) (59)), ((System.Byte) (105)));
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte) (32)), ((System.Byte) (0)),
                ((System.Byte) (0)), ((System.Byte) (0)));
            title1.ShadowOffset = 3;
            title1.Text = "Radar Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 42);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample displays a Radar chart, which is a circular graph used primarily as a" +
                " comparative tool. A 3D effect can also be added to the area background.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this._comboBoxLabelStyle,
                this._label3,
                this._comboBoxAreaStyle,
                this._label2,
                this._comboBoxRadarStyle,
                this._label1
            });
            this._panel1.Location = new System.Drawing.Point(432, 72);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 272);
            this._panel1.TabIndex = 2;
            // 
            // comboBoxLabelStyle
            // 
            this._comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelStyle.Items.AddRange(new object[]
            {
                "Circular",
                "Radial",
                "Horizontal"
            });
            this._comboBoxLabelStyle.Location = new System.Drawing.Point(168, 64);
            this._comboBoxLabelStyle.Name = "_comboBoxLabelStyle";
            this._comboBoxLabelStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxLabelStyle.TabIndex = 5;
            this._comboBoxLabelStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(19, 64);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(145, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "&Labels Style:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxAreaStyle
            // 
            this._comboBoxAreaStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxAreaStyle.Items.AddRange(new object[]
            {
                "Circle",
                "Polygon"
            });
            this._comboBoxAreaStyle.Location = new System.Drawing.Point(168, 32);
            this._comboBoxAreaStyle.Name = "_comboBoxAreaStyle";
            this._comboBoxAreaStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxAreaStyle.TabIndex = 3;
            this._comboBoxAreaStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(6, 32);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(157, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "&Area Drawing Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRadarStyle
            // 
            this._comboBoxRadarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxRadarStyle.Items.AddRange(new object[]
            {
                "Area",
                "Line",
                "Marker"
            });
            this._comboBoxRadarStyle.Location = new System.Drawing.Point(168, 0);
            this._comboBoxRadarStyle.Name = "_comboBoxRadarStyle";
            this._comboBoxRadarStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxRadarStyle.TabIndex = 1;
            this._comboBoxRadarStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(-14, 0);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(177, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Radar &Style:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this._label5.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right);
            this._label5.Font = new System.Drawing.Font("Verdana", 11F);
            this._label5.Location = new System.Drawing.Point(16, 352);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(696, 24);
            this._label5.TabIndex = 25;
            this._label5.Text = "Try different styles for the radar, area drawing and labels.";
            this._label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadarChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this._label5,
                this._panel1,
                this._labelSampleComment,
                this._chart1
            });
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.Name = "RadarChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set radar chart style
            _chart1.Series["Series1"]["RadarDrawingStyle"] = (string) _comboBoxRadarStyle.SelectedItem;
            _chart1.Series["Series2"]["RadarDrawingStyle"] = (string) _comboBoxRadarStyle.SelectedItem;
            if ((string) _comboBoxRadarStyle.SelectedItem == "Area")
            {
                _chart1.Series["Series1"].BorderColor = Color.FromArgb(100, 100, 100);
                _chart1.Series["Series1"].BorderWidth = 1;
                _chart1.Series["Series2"].BorderColor = Color.FromArgb(100, 100, 100);
                _chart1.Series["Series2"].BorderWidth = 1;
            }
            else if ((string) _comboBoxRadarStyle.SelectedItem == "Line")
            {
                _chart1.Series["Series1"].BorderColor = Color.Empty;
                _chart1.Series["Series1"].BorderWidth = 2;
                _chart1.Series["Series2"].BorderColor = Color.Empty;
                _chart1.Series["Series2"].BorderWidth = 2;
            }
            else if ((string) _comboBoxRadarStyle.SelectedItem == "Marker")
            {
                _chart1.Series["Series1"].BorderColor = Color.Empty;
                _chart1.Series["Series2"].BorderColor = Color.Empty;
            }

            // Set circular area drawing style
            _chart1.Series["Series1"]["AreaDrawingStyle"] = (string) _comboBoxAreaStyle.SelectedItem;
            _chart1.Series["Series2"]["AreaDrawingStyle"] = (string) _comboBoxAreaStyle.SelectedItem;

            // Set labels style
            _chart1.Series["Series1"]["CircularLabelsStyle"] = (string) _comboBoxLabelStyle.SelectedItem;
            _chart1.Series["Series2"]["CircularLabelsStyle"] = (string) _comboBoxLabelStyle.SelectedItem;
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Populate series data
            double[] yValues = {65.62, 75.54, 60.45, 34.73, 85.42, 55.9, 63.6, 55.1, 77.2};
            double[] yValues2 = {76.45, 23.78, 86.45, 30.76, 23.79, 35.67, 89.56, 67.45, 38.98};
            string[] xValues = {"France", "Canada", "Germany", "USA", "Italy", "Spain", "Russia", "Sweden", "Japan"};
            _chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            _chart1.Series["Series2"].Points.DataBindXY(xValues, yValues2);

            // Set selection
            _comboBoxRadarStyle.SelectedIndex = 0;
            _comboBoxAreaStyle.SelectedIndex = 0;
            _comboBoxLabelStyle.SelectedIndex = 2;

            UpdateChartSettings();
        }

        private void comboBoxExploded_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}