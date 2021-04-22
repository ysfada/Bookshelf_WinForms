using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.CircularCharts.Polar
{
    /// <summary>
    ///     Summary description for PolarChartType.
    /// </summary>
    public class PolarChartType : UserControl
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
        private Label _label4;
        private Label _label5;
        private Label _labelSampleComment;
        private Panel _panel1;

        public PolarChartType()
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
                new System.ComponentModel.ComponentResourceManager(typeof(PolarChartType));
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
            this._label4 = new System.Windows.Forms.Label();
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.MajorTickMark.Size = 0.6F;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (165)))),
                ((int) (((byte) (191)))), ((int) (((byte) (228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 78F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 15F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 14.23021F;
            legend1.Position.Width = 19.34047F;
            legend1.Position.X = 74.73474F;
            legend1.Position.Y = 74.08253F;
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 64);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Legend = "Default";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series1.MarkerColor = System.Drawing.Color.LightSkyBlue;
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            series2.MarkerColor = System.Drawing.Color.Gold;
            series2.MarkerSize = 7;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Polar Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 48);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample displays a polar chart, which is a circular graph on which data point" +
                "s are displayed using the angle and distance from the center point.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboBoxLabelStyle);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxAreaStyle);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxRadarStyle);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 72);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
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
            this._comboBoxLabelStyle.Location = new System.Drawing.Point(168, 72);
            this._comboBoxLabelStyle.Name = "_comboBoxLabelStyle";
            this._comboBoxLabelStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxLabelStyle.TabIndex = 5;
            this._comboBoxLabelStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(11, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(152, 23);
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
            this._comboBoxAreaStyle.Location = new System.Drawing.Point(168, 40);
            this._comboBoxAreaStyle.Name = "_comboBoxAreaStyle";
            this._comboBoxAreaStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxAreaStyle.TabIndex = 3;
            this._comboBoxAreaStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(-2, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(165, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "&Area Drawing Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRadarStyle
            // 
            this._comboBoxRadarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxRadarStyle.Items.AddRange(new object[]
            {
                "Marker",
                "Line"
            });
            this._comboBoxRadarStyle.Location = new System.Drawing.Point(168, 8);
            this._comboBoxRadarStyle.Name = "_comboBoxRadarStyle";
            this._comboBoxRadarStyle.Size = new System.Drawing.Size(96, 22);
            this._comboBoxRadarStyle.TabIndex = 1;
            this._comboBoxRadarStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(35, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(128, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "&Polar Style:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this._label5.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label5.Font = new System.Drawing.Font("Verdana", 11F);
            this._label5.Location = new System.Drawing.Point(16, 368);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(696, 24);
            this._label5.TabIndex = 24;
            this._label5.Text = "Try different settings for the chart\'s polar, label, and area drawing styles.";
            this._label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this._label4.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label4.Font = new System.Drawing.Font("Verdana", 11F);
            this._label4.Location = new System.Drawing.Point(16, 392);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(696, 88);
            this._label4.TabIndex = 25;
            this._label4.Text = resources.GetString("label4.Text");
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PolarChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label4);
            this.Controls.Add(this._label5);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "PolarChartType";
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
            _chart1.Series["Series1"]["PolarDrawingStyle"] = (string) _comboBoxRadarStyle.SelectedItem;
            _chart1.Series["Series2"]["PolarDrawingStyle"] = (string) _comboBoxRadarStyle.SelectedItem;
            if ((string) _comboBoxRadarStyle.SelectedItem == "Line")
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
            // Fill series data
            for (var angle = 0.0; angle <= 360.0; angle += 10.0)
            {
                var yValue = (1.0 + Math.Sin(angle / 180.0 * Math.PI)) * 10.0;
                _chart1.Series["Series1"].Points.AddXY(angle + 90.0, yValue);
                _chart1.Series["Series2"].Points.AddXY(angle + 270.0, yValue);
            }

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