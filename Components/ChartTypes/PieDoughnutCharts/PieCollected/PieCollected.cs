using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PieDoughnutCharts.PieCollected
{
    /// <summary>
    ///     Summary description for PieCollected.
    /// </summary>
    public class PieCollected : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxCollectPieSlices;
        private CheckBox _checkBoxShowExploded;
        private ComboBox _comboBoxChartType;
        private ComboBox _comboBoxCollectedColor;
        private ComboBox _comboBoxCollectedThreshold;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label4;
        private Label _label5;
        private Label _label6;
        private Label _labelSampleComment;
        private Panel _panel1;
        private TextBox _textBoxCollectedLabel;
        private TextBox _textBoxCollectedLegend;

        public PieCollected()
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
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 39);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 18);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 15);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 12);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.2000000476837158);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._comboBoxCollectedThreshold = new System.Windows.Forms.ComboBox();
            this._textBoxCollectedLabel = new System.Windows.Forms.TextBox();
            this._label6 = new System.Windows.Forms.Label();
            this._label5 = new System.Windows.Forms.Label();
            this._comboBoxCollectedColor = new System.Windows.Forms.ComboBox();
            this._label4 = new System.Windows.Forms.Label();
            this._checkBoxCollectPieSlices = new System.Windows.Forms.CheckBox();
            this._checkBoxShowExploded = new System.Windows.Forms.CheckBox();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._textBoxCollectedLegend = new System.Windows.Forms.TextBox();
            this._label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))),
                ((int)(((byte)(240)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 900;
            chartArea1.Area3DStyle.Rotation = 162;
            chartArea1.Area3DStyle.WallWidth = 25;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Area1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            this._chart1.IsSoftShadows = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 61);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "Area1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))),
                ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties =
                "DoughnutRadius=25, PieDrawingStyle=Concave, CollectedLabel=Other, MinimumRelative" +
                "PieSize=20";
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            series1.Label = "#PERCENT{P1}";
            series1.Legend = "Default";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            dataPoint1.CustomProperties = "OriginalPointIndex=0";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.LegendText = "RUS";
            dataPoint2.CustomProperties = "OriginalPointIndex=1";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.LegendText = "CAN";
            dataPoint3.CustomProperties = "OriginalPointIndex=2";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.LegendText = "USA";
            dataPoint4.CustomProperties = "OriginalPointIndex=3";
            dataPoint4.LegendText = "PRC";
            dataPoint5.CustomProperties = "OriginalPointIndex=5";
            dataPoint5.LegendText = "DEN";
            dataPoint6.LegendText = "AUS";
            dataPoint7.CustomProperties = "OriginalPointIndex=4";
            dataPoint7.LegendText = "IND";
            dataPoint8.LegendText = "ARG";
            dataPoint9.LegendText = "FRA";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this._chart1.Series.Add(series1);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 45);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates how to group many small segments of a pie or doughnut ch" +
                "art into one collected slice to improve chart readability.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCollectedThreshold
            // 
            this._comboBoxCollectedThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCollectedThreshold.Font = new System.Drawing.Font("Verdana", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxCollectedThreshold.ItemHeight = 14;
            this._comboBoxCollectedThreshold.Items.AddRange(new object[]
            {
                "5",
                "8",
                "12",
                "15"
            });
            this._comboBoxCollectedThreshold.Location = new System.Drawing.Point(184, 40);
            this._comboBoxCollectedThreshold.Name = "_comboBoxCollectedThreshold";
            this._comboBoxCollectedThreshold.Size = new System.Drawing.Size(104, 22);
            this._comboBoxCollectedThreshold.TabIndex = 2;
            this._comboBoxCollectedThreshold.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCollectedThreshold_SelectedIndexChanged);
            // 
            // textBoxCollectedLabel
            // 
            this._textBoxCollectedLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxCollectedLabel.Location = new System.Drawing.Point(184, 104);
            this._textBoxCollectedLabel.MaxLength = 12;
            this._textBoxCollectedLabel.Name = "_textBoxCollectedLabel";
            this._textBoxCollectedLabel.Size = new System.Drawing.Size(104, 22);
            this._textBoxCollectedLabel.TabIndex = 4;
            this._textBoxCollectedLabel.TextChanged += new System.EventHandler(this.textBoxCollectedLabel_TextChanged);
            // 
            // label6
            // 
            this._label6.BackColor = System.Drawing.Color.White;
            this._label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label6.Location = new System.Drawing.Point(35, 104);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(144, 23);
            this._label6.TabIndex = 4;
            this._label6.Text = "Collected &Label:";
            this._label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this._label5.BackColor = System.Drawing.Color.White;
            this._label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label5.Location = new System.Drawing.Point(35, 72);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(144, 23);
            this._label5.TabIndex = 3;
            this._label5.Text = "Collected &Color:";
            this._label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCollectedColor
            // 
            this._comboBoxCollectedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCollectedColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxCollectedColor.ItemHeight = 14;
            this._comboBoxCollectedColor.Items.AddRange(new object[]
            {
                "Green",
                "Gold",
                "Gray",
                "Magenta"
            });
            this._comboBoxCollectedColor.Location = new System.Drawing.Point(184, 72);
            this._comboBoxCollectedColor.Name = "_comboBoxCollectedColor";
            this._comboBoxCollectedColor.Size = new System.Drawing.Size(104, 22);
            this._comboBoxCollectedColor.TabIndex = 3;
            this._comboBoxCollectedColor.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxCollectedColor_SelectedIndexChanged);
            // 
            // label4
            // 
            this._label4.BackColor = System.Drawing.Color.White;
            this._label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label4.Location = new System.Drawing.Point(4, 40);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(176, 23);
            this._label4.TabIndex = 2;
            this._label4.Text = "Collected &Threshold (in %):";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxCollectPieSlices
            // 
            this._checkBoxCollectPieSlices.BackColor = System.Drawing.Color.White;
            this._checkBoxCollectPieSlices.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxCollectPieSlices.Font = new System.Drawing.Font("Verdana", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxCollectPieSlices.Location = new System.Drawing.Point(38, 8);
            this._checkBoxCollectPieSlices.Name = "_checkBoxCollectPieSlices";
            this._checkBoxCollectPieSlices.Size = new System.Drawing.Size(160, 24);
            this._checkBoxCollectPieSlices.TabIndex = 1;
            this._checkBoxCollectPieSlices.Text = "Collect &Pie Slices:     ";
            this._checkBoxCollectPieSlices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxCollectPieSlices.UseVisualStyleBackColor = false;
            this._checkBoxCollectPieSlices.CheckedChanged +=
                new System.EventHandler(this.checkBoxCollectPieSlices_CheckedChanged);
            // 
            // checkBoxShowExploded
            // 
            this._checkBoxShowExploded.BackColor = System.Drawing.Color.White;
            this._checkBoxShowExploded.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowExploded.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxShowExploded.Location = new System.Drawing.Point(62, 165);
            this._checkBoxShowExploded.Name = "_checkBoxShowExploded";
            this._checkBoxShowExploded.Size = new System.Drawing.Size(136, 24);
            this._checkBoxShowExploded.TabIndex = 6;
            this._checkBoxShowExploded.Text = "&Show Exploded: ";
            this._checkBoxShowExploded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowExploded.UseVisualStyleBackColor = false;
            this._checkBoxShowExploded.CheckedChanged +=
                new System.EventHandler(this.checkBoxcollectSmallSegments_CheckedChanged);
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxChartType.ItemHeight = 14;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Pie",
                "Doughnut"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(184, 195);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(104, 22);
            this._comboBoxChartType.TabIndex = 7;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.BackColor = System.Drawing.Color.White;
            this._label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.Location = new System.Drawing.Point(99, 194);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(80, 23);
            this._label1.TabIndex = 7;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this._panel1.BackColor = System.Drawing.Color.White;
            this._panel1.Controls.Add(this._textBoxCollectedLegend);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxCollectedThreshold);
            this._panel1.Controls.Add(this._textBoxCollectedLabel);
            this._panel1.Controls.Add(this._label6);
            this._panel1.Controls.Add(this._label5);
            this._panel1.Controls.Add(this._comboBoxCollectedColor);
            this._panel1.Controls.Add(this._label4);
            this._panel1.Controls.Add(this._checkBoxCollectPieSlices);
            this._panel1.Controls.Add(this._checkBoxShowExploded);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._panel1.Location = new System.Drawing.Point(432, 69);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 0;
            // 
            // textBoxCollectedLegend
            // 
            this._textBoxCollectedLegend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxCollectedLegend.Location = new System.Drawing.Point(184, 136);
            this._textBoxCollectedLegend.MaxLength = 12;
            this._textBoxCollectedLegend.Name = "_textBoxCollectedLegend";
            this._textBoxCollectedLegend.Size = new System.Drawing.Size(104, 22);
            this._textBoxCollectedLegend.TabIndex = 5;
            this._textBoxCollectedLegend.TextChanged +=
                new System.EventHandler(this.textBoxCollectedLegend_TextChanged);
            // 
            // label2
            // 
            this._label2.BackColor = System.Drawing.Color.White;
            this._label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label2.Location = new System.Drawing.Point(27, 136);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(152, 23);
            this._label2.TabIndex = 5;
            this._label2.Text = "Collected &Legend Text:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PieCollected
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PieCollected";
            this.Size = new System.Drawing.Size(728, 368);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this._panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            var series1 = _chart1.Series[0];

            if (_checkBoxCollectPieSlices.Checked)
            {
                _comboBoxChartType.Enabled = true;
                _comboBoxCollectedColor.Enabled = true;
                _comboBoxCollectedThreshold.Enabled = true;
                _textBoxCollectedLabel.Enabled = true;
                _textBoxCollectedLegend.Enabled = true;
                _checkBoxCollectPieSlices.Enabled = true;
                _checkBoxCollectPieSlices.Enabled = true;
                _checkBoxShowExploded.Enabled = true;

                // Set the threshold under which all points will be collected
                series1["CollectedThreshold"] =
                    _comboBoxCollectedThreshold.GetItemText(_comboBoxCollectedThreshold.SelectedItem);

                // Set the label of the collected pie slice
                series1["CollectedLabel"] = _textBoxCollectedLabel.Text;

                // Set the legend text of the collected pie slice
                series1["CollectedLegendText"] = _textBoxCollectedLegend.Text;

                // Set the collected pie slice to be exploded
                series1["CollectedSliceExploded"] = _checkBoxShowExploded.Checked.ToString();

                // Set collected color
                series1["CollectedColor"] = _comboBoxCollectedColor.GetItemText(_comboBoxCollectedColor.SelectedItem);

                // Set chart type
                series1.ChartType =
                    (SeriesChartType) Enum.Parse(typeof(SeriesChartType), _comboBoxChartType.Text, true);
            }

            else
            {
                series1["CollectedThreshold"] = "0";
                _comboBoxChartType.Enabled = false;
                _comboBoxCollectedColor.Enabled = false;
                _comboBoxCollectedThreshold.Enabled = false;
                _textBoxCollectedLabel.Enabled = false;
                _textBoxCollectedLegend.Enabled = false;
                _checkBoxShowExploded.Enabled = false;
            }
        }

        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Set series font
            _chart1.Series[0].Font = new Font("Trebuchet MS", 8, FontStyle.Bold);

            // Set current selection
            _checkBoxCollectPieSlices.Checked = false;
            _comboBoxChartType.SelectedIndex = 0;
            _comboBoxCollectedColor.SelectedIndex = 0;
            _comboBoxCollectedThreshold.SelectedIndex = 0;
            _textBoxCollectedLabel.Text = @"Other";
            _textBoxCollectedLegend.Text = @"Other";

            _chart1.Series[0]["CollectedToolTip"] = "Other";

            // Update chart
            UpdateChartSettings();
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxcollectSmallSegments_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxCollectedColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void textBoxCollectedLabel_TextChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxCollectedThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void textBoxCollectedLegend_TextChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxCollectPieSlices_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}