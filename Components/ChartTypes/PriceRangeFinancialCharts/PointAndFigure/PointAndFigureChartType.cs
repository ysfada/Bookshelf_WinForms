using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PriceRangeFinancialCharts.PointAndFigure
{
    /// <summary>
    ///     Summary description for PointAndFigureChartType.
    /// </summary>
    public class PointAndFigureChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkPropSymbols;
        private ComboBox _comboBoxSize;
        private ComboBox _comboReversalAmount;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public PointAndFigureChartType()
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
            this._checkPropSymbols = new System.Windows.Forms.CheckBox();
            this._comboBoxSize = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboReversalAmount = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))),
                ((int)(((byte)(240)))));
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))),
                ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
            series1.CustomProperties = "PriceUpColor=Black";
            series1.IsXValueIndexed = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))),
                ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))),
                ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Point and Figure Chart";
            this._chart1.Titles.Add(title1);
            this._chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 24);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text = "This sample demonstrates the Point and Figure chart type.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkPropSymbols);
            this._panel1.Controls.Add(this._comboBoxSize);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboReversalAmount);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 48);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            this._panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkPropSymbols
            // 
            this._checkPropSymbols.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkPropSymbols.Location = new System.Drawing.Point(5, 72);
            this._checkPropSymbols.Name = "_checkPropSymbols";
            this._checkPropSymbols.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._checkPropSymbols.Size = new System.Drawing.Size(176, 24);
            this._checkPropSymbols.TabIndex = 4;
            this._checkPropSymbols.Text = "&Proportional Symbols:";
            this._checkPropSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkPropSymbols.CheckedChanged += new System.EventHandler(this.checkPropSymbols_CheckedChanged);
            // 
            // comboBoxSize
            // 
            this._comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxSize.Items.AddRange(new object[]
            {
                "1",
                "1.2",
                "7%",
                "8%",
                "9%",
                "Default"
            });
            this._comboBoxSize.Location = new System.Drawing.Point(168, 8);
            this._comboBoxSize.Name = "_comboBoxSize";
            this._comboBoxSize.Size = new System.Drawing.Size(88, 22);
            this._comboBoxSize.TabIndex = 1;
            this._comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(59, 8);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(104, 23);
            this._label2.TabIndex = 0;
            this._label2.Text = "Box &Size:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboReversalAmount
            // 
            this._comboReversalAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboReversalAmount.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            });
            this._comboReversalAmount.Location = new System.Drawing.Point(168, 40);
            this._comboReversalAmount.Name = "_comboReversalAmount";
            this._comboReversalAmount.Size = new System.Drawing.Size(88, 22);
            this._comboReversalAmount.TabIndex = 3;
            this._comboReversalAmount.SelectedIndexChanged +=
                new System.EventHandler(this.comboReversalAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(27, 40);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(136, 23);
            this._label1.TabIndex = 2;
            this._label1.Text = "Reversal &Amount:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this._label3.Anchor =
                ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this._label3.Font = new System.Drawing.Font("Verdana", 11F);
            this._label3.Location = new System.Drawing.Point(13, 344);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(702, 40);
            this._label3.TabIndex = 23;
            this._label3.Text = "The ProportionalSymbols custom attribute indicates that the chart should try to d" +
                                "raw ‘X’ and ‘O’ symbols proportionally.";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointAndFigureChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label3);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PointAndFigureChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.PointAndFigureChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion


        private void UpdateChartSettings()
        {
            var reversalAmount = _comboReversalAmount.Text;
            var boxSize = _comboBoxSize.Text;
            var propSymbols = _checkPropSymbols.Checked.ToString();

            // set series type
            _chart1.Series["Default"].ChartType = SeriesChartType.PointAndFigure;

            // set the PriceUpColor attribute
            _chart1.Series["Default"]["PriceUpColor"] = "Blue";

            // set the Color attribute
            _chart1.Series["Default"].Color = Color.Red;

            if (reversalAmount == "Default")
                // clear attribute, let the default ReversalAmount to be calculated
                _chart1.Series["Default"].DeleteCustomProperty("ReversalAmount");
            else
                // set the ReversalAmount attribute
                _chart1.Series["Default"]["ReversalAmount"] = reversalAmount;

            if (boxSize == "Default")
                // clear attribute, let the default BoxSize to be calculated
                _chart1.Series["Default"].DeleteCustomProperty("BoxSize");
            else
                // set the BoxSize attribute
                _chart1.Series["Default"]["BoxSize"] = boxSize;
            // set the ProportionalSymbols attribute
            _chart1.Series["Default"]["ProportionalSymbols"] = propSymbols;
        }

        private void PointAndFigureChartType_Load(object sender, EventArgs e)
        {
            _comboBoxSize.Text = @"1";
            _comboReversalAmount.Text = @"1";
            _checkPropSymbols.Checked = false;

            // load series data
            FillData();

            // set up appearance
            UpdateChartSettings();
        }

        private void FillData()
        {
            double[] points =
            {
                47.625, 47.750, 47.500, 46.125, 45.125, 45.250, 44.500, 45.000, 45.250, 44.875, 44.250, 43.375, 42.500,
                42.750,
                42.000, 41.375, 40.000, 39.875, 40.125, 41.250, 42.250, 42.625, 43.375, 45.250, 47.500, 47.625, 46.500,
                46.125,
                46.250, 45.750, 45.125, 45.250, 43.500, 43.625, 44.125, 43.750, 44.000, 44.875, 44.625, 45.250, 45.250,
                45.250,
                45.125, 45.500, 45.625, 45.500, 45.625, 45.000, 44.750, 44.875, 45.250, 45.250, 45.125, 45.125, 45.625,
                45.500,
                45.375, 46.500, 47.000, 46.125, 45.125, 45.375, 45.875, 45.250, 45.250, 44.625, 45.125, 45.250, 46.125,
                46.750
            };

            var date = DateTime.Today.AddDays(-points.Length);

            //var rnd = new Random();

            _chart1.Series["Default"].Points.Clear();

            for (var days = 0; days < points.Length; days++)
                _chart1.Series["Default"].Points.AddXY(date.AddDays(days), points[days] + 0.500, points[days]);
        }

        private void comboReversalAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkPropSymbols_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}