using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PriceRangeFinancialCharts.Kagi
{
    /// <summary>
    ///     Summary description for KagiChartType.
    /// </summary>
    public class KagiChartType : UserControl
    {
        private Chart _chart1;
        private ComboBox _comboReversalAmount;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _labelSampleComment;
        private Panel _panel1;

        public KagiChartType()
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
            this._comboReversalAmount = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
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
            this._chart1.Location = new System.Drawing.Point(16, 35);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
            series1.Color = System.Drawing.Color.Tomato;
            series1.CustomProperties = "PriceUpColor=SkyBlue";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 2;
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
            title1.Text = "Kagi Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 21);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text = "This sample demonstrates the Kagi chart type.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboReversalAmount);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 43);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 1;
            this._panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboReversalAmount
            // 
            this._comboReversalAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboReversalAmount.Items.AddRange(new object[]
            {
                "0.6",
                "0.8",
                "1",
                "1.2",
                "1%",
                "2%",
                "4%",
                "Default"
            });
            this._comboReversalAmount.Location = new System.Drawing.Point(168, 8);
            this._comboReversalAmount.Name = "_comboReversalAmount";
            this._comboReversalAmount.Size = new System.Drawing.Size(112, 22);
            this._comboReversalAmount.TabIndex = 0;
            this._comboReversalAmount.SelectedIndexChanged +=
                new System.EventHandler(this.comboReversalAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(16, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(144, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Reversal &Amount:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this._label2.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label2.Font = new System.Drawing.Font("Verdana", 11F);
            this._label2.Location = new System.Drawing.Point(13, 339);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(702, 24);
            this._label2.TabIndex = 22;
            this._label2.Text = "The reversal amount can be a percentage or a fixed amount.";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KagiChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label2);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KagiChartType";
            this.Size = new System.Drawing.Size(728, 416);
            this.Load += new System.EventHandler(this.KagiChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion


        private void UpdateChartSettings()
        {
            var reversalAmount = _comboReversalAmount.Text;

            // set series chart type
            _chart1.Series["Default"].ChartType = SeriesChartType.Kagi;

            // set the PriceUpColor attribute
            _chart1.Series["Default"]["PriceUpColor"] = "0, 128, 255";
            _chart1.Series["Default"].Color = Color.FromArgb(255, 64, 64);

            if (reversalAmount == "Default")
                // clear attribute, let the default ReversalAmount to be calculated
                _chart1.Series["Default"].DeleteCustomProperty("ReversalAmount");
            else
                // set the ReversalAmount attribute
                _chart1.Series["Default"]["ReversalAmount"] = reversalAmount;
        }

        private void KagiChartType_Load(object sender, EventArgs e)
        {
            _comboReversalAmount.Text = @"1";

            // load series data
            FillData();

            // set up appearance
            UpdateChartSettings();
        }

        private void FillData()
        {
            double[] points =
            {
                35.250, 37.750, 39.000, 38.375, 37.750, 37.750, 37.375, 36.250, 35.750, 35.250, 36.250, 35.250, 34.500,
                35.625, 35.500, 36.625, 36.375, 36.250, 36.875, 37.250, 36.875, 36.500, 37.125, 36.375, 35.875, 36.625,
                37.125, 36.250, 37.000, 37.250, 37.500, 38.500, 39.500, 38.875, 38.500, 39.000, 38.500, 38.500, 39.000,
                39.000, 40.000, 39.875, 39.875, 38.875, 38.500, 38.250, 38.875, 39.375, 39.375, 39.750, 39.500, 39.375,
                38.500, 37.750, 37.625, 37.500, 36.500, 35.000, 36.625, 36.000, 35.875, 35.000, 35.250, 35.125, 35.050
            };

            var date = DateTime.Today.AddDays(-points.Length);

            _chart1.Series["Default"].Points.Clear();

            for (var day = 0; day < points.Length; day++)
                _chart1.Series["Default"].Points.AddXY(date.AddDays(day), points[day]);
        }


        private void comboReversalAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}