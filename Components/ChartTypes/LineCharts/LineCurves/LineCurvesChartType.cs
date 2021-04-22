using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.LineCharts.LineCurves
{
    /// <summary>
    ///     Summary description for LineCurvesChartType.
    /// </summary>
    public class LineCurvesChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxChartType;
        private ComboBox _comboBoxPointLabels;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public LineCurvesChartType()
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
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._comboBoxPointLabels = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (223)))),
                ((int) (((byte) (193)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int) (((byte) (181)))),
                ((int) (((byte) (64)))), ((int) (((byte) (1)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 40;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 9;
            chartArea1.Area3DStyle.Rotation = 25;
            chartArea1.Area3DStyle.WallWidth = 3;
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
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
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
            this._chart1.Location = new System.Drawing.Point(16, 32);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.Legend = "Default";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.ShadowOffset = 2;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (224)))),
                ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series2.Legend = "Default";
            series2.MarkerSize = 9;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Series2";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 2;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
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
            this._labelSampleComment.Size = new System.Drawing.Size(702, 24);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text = "This sample demonstrates the Line, Spline and, StepLine chart types. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._comboBoxPointLabels);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 40);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 280);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(14, 104);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShow3D.TabIndex = 5;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
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
            this._label2.Location = new System.Drawing.Point(3, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(160, 23);
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
            this._label1.Location = new System.Drawing.Point(3, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(160, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this._label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._label3.Location = new System.Drawing.Point(13, 336);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(702, 40);
            this._label3.TabIndex = 4;
            this._label3.Text = "The label style can be set using the LabelStyle custom attribute, and the ShowMar" +
                                "kers custom attribute is used to display data point markers when the chart area " +
                                "is set to 3D.";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineCurvesChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label3);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "LineCurvesChartType";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.LineCurvesChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set series chart type
            _chart1.Series["Series1"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text, true);
            _chart1.Series["Series2"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text, true);

            // Set point labels
            if (_comboBoxPointLabels.Text != @"None")
            {
                _chart1.Series["Series1"].IsValueShownAsLabel = true;
                _chart1.Series["Series2"].IsValueShownAsLabel = true;
                if (_comboBoxPointLabels.Text != @"Auto")
                {
                    _chart1.Series["Series1"]["LabelStyle"] = _comboBoxPointLabels.Text;
                    _chart1.Series["Series2"]["LabelStyle"] = _comboBoxPointLabels.Text;
                }
            }
            else
            {
                _chart1.Series["Series1"].IsValueShownAsLabel = false;
                _chart1.Series["Series2"].IsValueShownAsLabel = false;
            }

            // Set X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;
        }

        private void LineCurvesChartType_Load(object sender, EventArgs e)
        {
            _comboBoxChartType.SelectedIndex = 0;
            _comboBoxPointLabels.SelectedIndex = 0;
            _checkBoxShow3D.Checked = false;

            // Populate series data
            var random = new Random();
            for (var pointIndex = 0; pointIndex < 10; pointIndex++)
            {
                _chart1.Series["Series1"].Points.AddY(random.Next(45, 95));
                _chart1.Series["Series2"].Points.AddY(random.Next(5, 65));
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

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            _chart1.ChartAreas[0].Area3DStyle.Enable3D = _checkBoxShow3D.Checked;
            if (_checkBoxShow3D.Checked)
            {
                _chart1.Series["Series1"].MarkerStyle = MarkerStyle.None;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
                _chart1.Series["Series1"].BorderWidth = 1;
                _chart1.Series["Series2"].BorderWidth = 1;
            }
            else
            {
                _chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Diamond;
                _chart1.Series["Series1"].BorderWidth = 3;
                _chart1.Series["Series2"].BorderWidth = 3;
            }
        }
    }
}