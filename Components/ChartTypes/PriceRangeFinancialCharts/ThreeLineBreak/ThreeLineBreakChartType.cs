using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PriceRangeFinancialCharts.ThreeLineBreak
{
    /// <summary>
    ///     Summary description for ThreeLineBreakChartType.
    /// </summary>
    public class ThreeLineBreakChartType : UserControl
    {
        private Chart _chart1;
        private ComboBox _comboNumberOfLines;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public ThreeLineBreakChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboNumberOfLines = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
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
            chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 40);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ThreeLineBreak;
            series1.CustomProperties = "PriceUpColor=Black";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))),
                ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))),
                ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Three Line Break Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 26);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text = "This sample demonstrates the Three Line Break chart type.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboNumberOfLines);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 48);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(296, 280);
            this._panel1.TabIndex = 1;
            // 
            // comboNumberOfLines
            // 
            this._comboNumberOfLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboNumberOfLines.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "Default"
            });
            this._comboNumberOfLines.Location = new System.Drawing.Point(168, 16);
            this._comboNumberOfLines.Name = "_comboNumberOfLines";
            this._comboNumberOfLines.Size = new System.Drawing.Size(104, 22);
            this._comboNumberOfLines.TabIndex = 0;
            this._comboNumberOfLines.SelectedIndexChanged +=
                new System.EventHandler(this.comboNumberOfLines_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(8, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(152, 32);
            this._label1.TabIndex = 0;
            this._label1.Text = "Number of &Lines in Break:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this._label3.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label3.Font = new System.Drawing.Font("Verdana", 11F);
            this._label3.Location = new System.Drawing.Point(13, 342);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(702, 43);
            this._label3.TabIndex = 25;
            this._label3.Text = "The sensitivity of the reversal criteria can be adjusted by changing the number o" +
                                "f lines in break.";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThreeLineBreakChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label3);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThreeLineBreakChartType";
            this.Size = new System.Drawing.Size(728, 403);
            this.Load += new System.EventHandler(this.ThreeLineBreakChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion


        private void UpdateChartSettings()
        {
            var numberOfLines = _comboNumberOfLines.Text;

            // set series type
            _chart1.Series["Default"].ChartType = SeriesChartType.ThreeLineBreak;

            // set the PriceUpColor attribute
            _chart1.Series["Default"]["PriceUpColor"] = "White";

            // set the default color
            _chart1.Series["Default"].Color = Color.Black;

            if (numberOfLines == "Default")
                // clear attribute, let the default NumberOfLinesInBreak to be calculated
                _chart1.Series["Default"].DeleteCustomProperty("NumberOfLinesInBreak");
            else
                // set the NumberOfLinesInBreak attribute
                _chart1.Series["Default"]["NumberOfLinesInBreak"] = numberOfLines;
        }

        private void ThreeLineBreakChartType_Load(object sender, EventArgs e)
        {
            _comboNumberOfLines.Text = @"1";

            // load series data
            FillData();

            // set up appearance
            UpdateChartSettings();
        }

        private void FillData()
        {
            double[] points =
            {
                27.375, 26.375, 26.062, 25.750, 26.125, 25.875, 25.750, 25.250, 24.375, 24.000,
                23.625, 23.875, 26.500, 26.750, 27.375, 27.375, 26.825, 27.000, 26.875, 26.625,
                27.627, 28.000, 27.125, 25.875, 27.250, 25.500, 24.875, 24.875, 24.125, 25.000,
                26.250, 27.375, 27.500, 28.000, 27.625, 27.125, 26.250, 26.250, 26.250, 26.375,
                26.625, 27.375, 28.500, 27.250, 26.250, 26.500, 26.125, 25.750, 26.000, 26.625,
                26.125, 26.250, 25.750, 25.375, 25.375, 24.750, 23.500, 24.062, 23.250, 23.500, 24.125, 24.625, 24.625
            };

            var date = DateTime.Today.AddDays(-points.Length);

            _chart1.Series["Default"].Points.Clear();

            for (var day = 0; day < points.Length; day++)
                _chart1.Series["Default"].Points.AddXY(date.AddDays(day), points[day]);
        }

        private void comboNumberOfLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}