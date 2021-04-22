using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PyramidFunnelCharts.Funnel
{
    /// <summary>
    ///     Summary description for FunnelChartType.
    /// </summary>
    public class FunnelChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private ComboBox _comboBox3DDrawingStyle;
        private ComboBox _comboBoxFunnelStyle;
        private ComboBox _comboBoxLabelsPlacement;
        private ComboBox _comboBoxLabelsStyle;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _label3DDrawingStyle;
        private Label _label4;
        private Label _labelAngle;
        private Label _labelOutsideLabelsPlacement;
        private Label _labelSampleComment;
        private NumericUpDown _numericUpDownAngle;
        private NumericUpDown _numericUpDownGap;
        private NumericUpDown _numericUpDownMinHeight;
        private Panel _panel1;

        public FunnelChartType()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 216.19999694824219);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 125.80000305175781);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 90);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2.5999999046325684);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 55.700000762939453);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 25.299999237060547);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboBox3DDrawingStyle = new System.Windows.Forms.ComboBox();
            this._label3DDrawingStyle = new System.Windows.Forms.Label();
            this._numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this._labelAngle = new System.Windows.Forms.Label();
            this._numericUpDownMinHeight = new System.Windows.Forms.NumericUpDown();
            this._label4 = new System.Windows.Forms.Label();
            this._numericUpDownGap = new System.Windows.Forms.NumericUpDown();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxLabelsPlacement = new System.Windows.Forms.ComboBox();
            this._labelOutsideLabelsPlacement = new System.Windows.Forms.Label();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._comboBoxLabelsStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxFunnelStyle = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownMinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownGap)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor =
                System.Drawing.Color.FromArgb(((System.Byte) (211)), ((System.Byte) (223)), ((System.Byte) (240)));
            this._chart1.BackSecondaryColor = System.Drawing.Color.White;
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor =
                System.Drawing.Color.FromArgb(((System.Byte) (26)), ((System.Byte) (59)), ((System.Byte) (105)));
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
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte) (64)), ((System.Byte) (64)),
                ((System.Byte) (64)), ((System.Byte) (64)));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 81F;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 12F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.IsTextAutoFit = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 40);
            this._chart1.Name = "_chart1";
            this._chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte) (180)), ((System.Byte) (26)),
                ((System.Byte) (59)), ((System.Byte) (105)));
            series1.ChartType = SeriesChartType.Funnel;
            series1.CustomProperties = "FunnelMinPointHeight=1";
            series1.LabelFormat = "F1";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.IsValueShownAsLabel = true;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.ForeColor =
                System.Drawing.Color.FromArgb(((System.Byte) (26)), ((System.Byte) (59)), ((System.Byte) (105)));
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Position.Auto = false;
            title1.Position.Height = 6.470197F;
            title1.Position.Width = 90F;
            title1.Position.Y = 3F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte) (32)), ((System.Byte) (0)),
                ((System.Byte) (0)), ((System.Byte) (0)));
            title1.ShadowOffset = 3;
            title1.Text = "Funnel chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 24);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text = "A Funnel chart is used to display data that adds up to 100%.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this._comboBox3DDrawingStyle,
                this._label3DDrawingStyle,
                this._numericUpDownAngle,
                this._labelAngle,
                this._numericUpDownMinHeight,
                this._label4,
                this._numericUpDownGap,
                this._label3,
                this._comboBoxLabelsPlacement,
                this._labelOutsideLabelsPlacement,
                this._checkBoxShow3D,
                this._comboBoxLabelsStyle,
                this._label2,
                this._comboBoxFunnelStyle,
                this._label1
            });
            this._panel1.Location = new System.Drawing.Point(432, 48);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(312, 288);
            this._panel1.TabIndex = 0;
            // 
            // comboBox3DDrawingStyle
            // 
            this._comboBox3DDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox3DDrawingStyle.Items.AddRange(new object[]
            {
                "CircularBase",
                "SquareBase"
            });
            this._comboBox3DDrawingStyle.Location = new System.Drawing.Point(168, 232);
            this._comboBox3DDrawingStyle.Name = "_comboBox3DDrawingStyle";
            this._comboBox3DDrawingStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBox3DDrawingStyle.TabIndex = 14;
            this._comboBox3DDrawingStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBox3DDrawingStyle_SelectedIndexChanged);
            // 
            // label3DDrawingStyle
            // 
            this._label3DDrawingStyle.Location = new System.Drawing.Point(20, 232);
            this._label3DDrawingStyle.Name = "_label3DDrawingStyle";
            this._label3DDrawingStyle.Size = new System.Drawing.Size(144, 23);
            this._label3DDrawingStyle.TabIndex = 13;
            this._label3DDrawingStyle.Text = "&Drawing Style:";
            this._label3DDrawingStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownAngle
            // 
            this._numericUpDownAngle.Location = new System.Drawing.Point(168, 200);
            this._numericUpDownAngle.Maximum = new System.Decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._numericUpDownAngle.Minimum = new System.Decimal(new int[]
            {
                10,
                0,
                0,
                -2147483648
            });
            this._numericUpDownAngle.Name = "_numericUpDownAngle";
            this._numericUpDownAngle.Size = new System.Drawing.Size(144, 22);
            this._numericUpDownAngle.TabIndex = 12;
            this._numericUpDownAngle.Value = new System.Decimal(new int[]
            {
                5,
                0,
                0,
                0
            });
            this._numericUpDownAngle.ValueChanged += new System.EventHandler(this.numericUpDownAngle_ValueChanged);
            // 
            // labelAngle
            // 
            this._labelAngle.Location = new System.Drawing.Point(20, 200);
            this._labelAngle.Name = "_labelAngle";
            this._labelAngle.Size = new System.Drawing.Size(144, 23);
            this._labelAngle.TabIndex = 11;
            this._labelAngle.Text = "Rotation &Angle:";
            this._labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownMinHeight
            // 
            this._numericUpDownMinHeight.Location = new System.Drawing.Point(168, 136);
            this._numericUpDownMinHeight.Maximum = new System.Decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._numericUpDownMinHeight.Name = "_numericUpDownMinHeight";
            this._numericUpDownMinHeight.Size = new System.Drawing.Size(144, 22);
            this._numericUpDownMinHeight.TabIndex = 9;
            this._numericUpDownMinHeight.ValueChanged +=
                new System.EventHandler(this.numericUpDownMinHeight_ValueChanged);
            // 
            // label4
            // 
            this._label4.Location = new System.Drawing.Point(20, 136);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(144, 23);
            this._label4.TabIndex = 8;
            this._label4.Text = "&Min. Point Height:";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownGap
            // 
            this._numericUpDownGap.Location = new System.Drawing.Point(168, 104);
            this._numericUpDownGap.Maximum = new System.Decimal(new int[]
            {
                5,
                0,
                0,
                0
            });
            this._numericUpDownGap.Name = "_numericUpDownGap";
            this._numericUpDownGap.Size = new System.Drawing.Size(144, 22);
            this._numericUpDownGap.TabIndex = 7;
            this._numericUpDownGap.ValueChanged += new System.EventHandler(this.numericUpDownGap_ValueChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(20, 104);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(144, 23);
            this._label3.TabIndex = 6;
            this._label3.Text = "Points &Gap:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelsPlacement
            // 
            this._comboBoxLabelsPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelsPlacement.Items.AddRange(new object[]
            {
                "Right",
                "Left"
            });
            this._comboBoxLabelsPlacement.Location = new System.Drawing.Point(168, 72);
            this._comboBoxLabelsPlacement.Name = "_comboBoxLabelsPlacement";
            this._comboBoxLabelsPlacement.Size = new System.Drawing.Size(144, 22);
            this._comboBoxLabelsPlacement.TabIndex = 5;
            this._comboBoxLabelsPlacement.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxLabelsPlacement_SelectedIndexChanged);
            // 
            // labelOutsideLabelsPlacement
            // 
            this._labelOutsideLabelsPlacement.Location = new System.Drawing.Point(20, 72);
            this._labelOutsideLabelsPlacement.Name = "_labelOutsideLabelsPlacement";
            this._labelOutsideLabelsPlacement.Size = new System.Drawing.Size(144, 23);
            this._labelOutsideLabelsPlacement.TabIndex = 4;
            this._labelOutsideLabelsPlacement.Text = "Labels &Placement:";
            this._labelOutsideLabelsPlacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(6, 168);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(176, 24);
            this._checkBoxShow3D.TabIndex = 10;
            this._checkBoxShow3D.Text = "Display chart as &3D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxLabelsStyle
            // 
            this._comboBoxLabelsStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelsStyle.Items.AddRange(new object[]
            {
                "OutsideInColumn",
                "Outside",
                "Inside",
                "Disabled"
            });
            this._comboBoxLabelsStyle.Location = new System.Drawing.Point(168, 40);
            this._comboBoxLabelsStyle.Name = "_comboBoxLabelsStyle";
            this._comboBoxLabelsStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxLabelsStyle.TabIndex = 3;
            this._comboBoxLabelsStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxLabelsStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(20, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(144, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "&Labels Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxFunnelStyle
            // 
            this._comboBoxFunnelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxFunnelStyle.Items.AddRange(new object[]
            {
                "YIsHeight",
                "YIsWidth"
            });
            this._comboBoxFunnelStyle.Location = new System.Drawing.Point(168, 8);
            this._comboBoxFunnelStyle.Name = "_comboBoxFunnelStyle";
            this._comboBoxFunnelStyle.Size = new System.Drawing.Size(144, 22);
            this._comboBoxFunnelStyle.TabIndex = 1;
            this._comboBoxFunnelStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxFunnelStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(4, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(160, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Funnel &Style:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FunnelChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this._panel1,
                this._labelSampleComment,
                this._chart1
            });
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.Name = "FunnelChartType";
            this.Size = new System.Drawing.Size(744, 360);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownMinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownGap)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Bind chart data
            var yValues1 = new[] {216.1, 125.8, 2.6, 97.3, 45.7, 25.3};
            var yValues2 = new[] {232.8, 195.4, 172.9, 100.3, 45.7, 25.3};
            _chart1.Series["Default"].Points.DataBindY(_comboBoxFunnelStyle.SelectedIndex == 0 ? yValues1 : yValues2);

            // Set funnel style
            _chart1.Series["Default"]["FunnelStyle"] = (string) _comboBoxFunnelStyle.SelectedItem;

            // Set funnel data point labels style
            _chart1.Series["Default"]["FunnelLabelStyle"] = (string) _comboBoxLabelsStyle.SelectedItem;

            // Set labels placement
            if (_comboBoxLabelsStyle.SelectedIndex == 0 ||
                _comboBoxLabelsStyle.SelectedIndex == 1)
                _chart1.Series["Default"]["FunnelOutsideLabelPlacement"] =
                    (string) _comboBoxLabelsPlacement.SelectedItem;
            else
                _chart1.Series["Default"]["FunnelInsideLabelAlignment"] =
                    (string) _comboBoxLabelsPlacement.SelectedItem;

            // Set gap between points
            _chart1.Series["Default"]["FunnelPointGap"] = _numericUpDownGap.Value.ToString(CultureInfo.CurrentCulture);

            // Set minimum point height
            _chart1.Series["Default"]["FunnelMinPointHeight"] = _numericUpDownMinHeight.Value.ToString(CultureInfo.CurrentCulture);

            // Set 3D mode
            _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = _checkBoxShow3D.Checked;

            // Set 3D angle
            _chart1.Series["Default"]["Funnel3DRotationAngle"] = _numericUpDownAngle.Value.ToString(CultureInfo.CurrentCulture);

            // Set 3D drawing style
            _chart1.Series["Default"]["Funnel3DDrawingStyle"] = (string) _comboBox3DDrawingStyle.SelectedItem;

            // Disable/Enable controls
            _numericUpDownAngle.Enabled = _checkBoxShow3D.Checked;
            _labelAngle.Enabled = _checkBoxShow3D.Checked;
            _comboBox3DDrawingStyle.Enabled = _checkBoxShow3D.Checked;
            _label3DDrawingStyle.Enabled = _checkBoxShow3D.Checked;
            _comboBoxLabelsPlacement.Enabled = _comboBoxLabelsStyle.SelectedIndex != 3;
            _labelOutsideLabelsPlacement.Enabled = _comboBoxLabelsStyle.SelectedIndex != 3;

            _chart1.Invalidate();
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Set selection
            _comboBoxFunnelStyle.SelectedIndex = 0;
            _comboBoxLabelsStyle.SelectedIndex = 0;
            _comboBoxLabelsPlacement.SelectedIndex = 0;
            _comboBox3DDrawingStyle.SelectedIndex = 0;

            UpdateChartSettings();
        }

        private void comboBoxFunnelStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxLabelsStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxLabelsPlacement.Items.Clear();
            if (_comboBoxLabelsStyle.SelectedIndex == 0 ||
                _comboBoxLabelsStyle.SelectedIndex == 1)
            {
                _comboBoxLabelsPlacement.Items.Add("Right");
                _comboBoxLabelsPlacement.Items.Add("Left");
            }
            else
            {
                _comboBoxLabelsPlacement.Items.Add("Center");
                _comboBoxLabelsPlacement.Items.Add("Top");
                _comboBoxLabelsPlacement.Items.Add("Bottom");
            }

            _comboBoxLabelsPlacement.SelectedIndex = 0;
            UpdateChartSettings();
        }

        private void comboBoxLabelsPlacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownGap_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownMinHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBox3DDrawingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}