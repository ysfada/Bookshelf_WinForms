using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.RangeCharts._3DRange
{
    /// <summary>
    ///     Summary description for Range3D.
    /// </summary>
    public class Range3D : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxChartType;
        private ComboBox _comboBoxLineTension;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private ComboBox _lightingType;
        private Panel _panel1;
        private CheckBox _showMarkerLines;
        private CheckBox _usePerspective;

        public Range3D()
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
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._usePerspective = new System.Windows.Forms.CheckBox();
            this._lightingType = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._showMarkerLines = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._comboBoxLineTension = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 32;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 29;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
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
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 96F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.Y = 2F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 48);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 0);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 42);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates Range and Spline Range chart types. The Spline Range cha" +
                "rt supports line tension adjustment. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._usePerspective);
            this._panel1.Controls.Add(this._lightingType);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._showMarkerLines);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._comboBoxLineTension);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 56);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 280);
            this._panel1.TabIndex = 2;
            // 
            // UsePerspective
            // 
            this._usePerspective.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._usePerspective.Location = new System.Drawing.Point(-2, 168);
            this._usePerspective.Name = "_usePerspective";
            this._usePerspective.Size = new System.Drawing.Size(184, 24);
            this._usePerspective.TabIndex = 8;
            this._usePerspective.Text = "Use 10% &Perspective:";
            this._usePerspective.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._usePerspective.CheckedChanged += new System.EventHandler(this.UsePerspective_CheckedChanged);
            // 
            // LightingType
            // 
            this._lightingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._lightingType.Items.AddRange(new object[]
            {
                "None",
                "Simplistic",
                "Realistic"
            });
            this._lightingType.Location = new System.Drawing.Point(168, 72);
            this._lightingType.Name = "_lightingType";
            this._lightingType.Size = new System.Drawing.Size(112, 22);
            this._lightingType.TabIndex = 5;
            this._lightingType.SelectedIndexChanged += new System.EventHandler(this.LightingType_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(28, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(136, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "L&ighting:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowMarkerLines
            // 
            this._showMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.Location = new System.Drawing.Point(-2, 136);
            this._showMarkerLines.Name = "_showMarkerLines";
            this._showMarkerLines.Size = new System.Drawing.Size(184, 24);
            this._showMarkerLines.TabIndex = 7;
            this._showMarkerLines.Text = "Show Marker &Lines:";
            this._showMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showMarkerLines.CheckedChanged += new System.EventHandler(this.ShowMarkerLines_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(-2, 104);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(184, 24);
            this._checkBoxShowMargin.TabIndex = 6;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxLineTension
            // 
            this._comboBoxLineTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLineTension.Items.AddRange(new object[]
            {
                "1.2",
                "0.8",
                "0.4",
                "0.2"
            });
            this._comboBoxLineTension.Location = new System.Drawing.Point(168, 40);
            this._comboBoxLineTension.Name = "_comboBoxLineTension";
            this._comboBoxLineTension.Size = new System.Drawing.Size(112, 22);
            this._comboBoxLineTension.TabIndex = 3;
            this._comboBoxLineTension.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxLineTension_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(4, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(160, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Spline &Tension:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Spline Range",
                "Range"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(112, 22);
            this._comboBoxChartType.TabIndex = 1;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxLineTension_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(4, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(160, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Range3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "Range3D";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.Range3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            if (_comboBoxChartType.Text == "") return;

            // Loop through all series
            foreach (var series in _chart1.Series)
            {
                // Set marker lines
                series["ShowMarkerLines"] = _showMarkerLines.Checked.ToString();

                // Set chart type and line tension
                if (_comboBoxChartType.Text == @"Spline Range")
                {
                    series.ChartType = SeriesChartType.SplineRange;
                    _comboBoxLineTension.Enabled = true;
                    series["LineTension"] = _comboBoxLineTension.Text;
                }
                else
                {
                    series.ChartType = SeriesChartType.Range;
                    _comboBoxLineTension.Enabled = false;
                    series.DeleteCustomProperty("LineTension");
                }
            }

            // Disable/enable X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;

            // Set area lighting
            if (_lightingType.Text != "")
                _chart1.ChartAreas["Default"].Area3DStyle.LightStyle =
                    (LightStyle) Enum.Parse(typeof(LightStyle), _lightingType.Text);

            if (_usePerspective.Checked)
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Perspective = 10;
                _chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
            }
            else
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Perspective = 0;
                _chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 100;
            }
        }

        private void Range3D_Load(object sender, EventArgs e)
        {
            // Populate series data with data
            double[] yValue11 = {56, 74, 45, 59, 34, 87, 50, 87, 64, 34};
            double[] yValue12 = {42, 65, 30, 42, 25, 47, 40, 70, 34, 20};
            _chart1.Series["Default"].Points.DataBindY(yValue11, yValue12);

            double[] yValue21 = {46, 64, 55, 69, 34, 57, 20, 67, 64, 34};
            double[] yValue22 = {12, 45, 50, 12, 15, 27, 10, 40, 24, 30};
            _chart1.Series["Series2"].Points.DataBindY(yValue21, yValue22);

            // Set selection
            _comboBoxLineTension.SelectedIndex = 1;
            _comboBoxChartType.SelectedIndex = 0;
            _lightingType.SelectedIndex = 2;
        }

        private void comboBoxLineTension_SelectedIndexChanged(object sender, EventArgs e)
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

        private void LightingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void UsePerspective_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}