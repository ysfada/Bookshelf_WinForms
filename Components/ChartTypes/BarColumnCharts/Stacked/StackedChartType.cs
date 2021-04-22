using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.BarColumnCharts.Stacked
{
    /// <summary>
    ///     Summary description for StackedChartType.
    /// </summary>
    public class StackedChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxGrouped;
        private CheckBox _checkBoxHundredPercent;
        private CheckBox _checkBoxShow3D;
        private CheckBox _checkBoxShowLabels;
        private CheckBox _checkBoxShowMargin;
        private ComboBox _comboBoxChartType;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _labelSampleComment;
        private Panel _panel1;

        public StackedChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._checkBoxGrouped = new System.Windows.Forms.CheckBox();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._checkBoxShowLabels = new System.Windows.Forms.CheckBox();
            this._checkBoxHundredPercent = new System.Windows.Forms.CheckBox();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (223)))),
                ((int) (((byte) (240)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.Rotation = 10;
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
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 92F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 53);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series3.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (224)))),
                ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series4.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series4.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (5)))),
                ((int) (((byte) (100)))), ((int) (((byte) (146)))));
            series4.Legend = "Default";
            series4.Name = "Series4";
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Series.Add(series3);
            this._chart1.Series.Add(series4);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text =
                "This sample demonstrates Stacked Area, Stacked Bar, Stacked Column, 100% Stacked " +
                "Area, 100% Stacked Bar, and 100% Stacked Column chart types.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxGrouped);
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._checkBoxShowLabels);
            this._panel1.Controls.Add(this._checkBoxHundredPercent);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 61);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxGrouped
            // 
            this._checkBoxGrouped.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxGrouped.Location = new System.Drawing.Point(88, 176);
            this._checkBoxGrouped.Name = "_checkBoxGrouped";
            this._checkBoxGrouped.Size = new System.Drawing.Size(96, 24);
            this._checkBoxGrouped.TabIndex = 6;
            this._checkBoxGrouped.Text = "&Grouped:";
            this._checkBoxGrouped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxGrouped.CheckedChanged += new System.EventHandler(this.checkBoxGrouped_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(15, 144);
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
            this._checkBoxShowMargin.Checked = true;
            this._checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(15, 112);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShowMargin.TabIndex = 4;
            this._checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged +=
                new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxShowLabels
            // 
            this._checkBoxShowLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowLabels.Location = new System.Drawing.Point(15, 80);
            this._checkBoxShowLabels.Name = "_checkBoxShowLabels";
            this._checkBoxShowLabels.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShowLabels.TabIndex = 3;
            this._checkBoxShowLabels.Text = "Show Point &Labels:";
            this._checkBoxShowLabels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowLabels.CheckedChanged +=
                new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxHundredPercent
            // 
            this._checkBoxHundredPercent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxHundredPercent.Location = new System.Drawing.Point(15, 48);
            this._checkBoxHundredPercent.Name = "_checkBoxHundredPercent";
            this._checkBoxHundredPercent.Size = new System.Drawing.Size(168, 24);
            this._checkBoxHundredPercent.TabIndex = 2;
            this._checkBoxHundredPercent.Text = "100% &Stacked:";
            this._checkBoxHundredPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxHundredPercent.CheckedChanged +=
                new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "StackedArea",
                "StackedBar",
                "StackedColumn"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(168, 16);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(121, 22);
            this._comboBoxChartType.TabIndex = 1;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(44, 16);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(120, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Chart Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this._label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._label2.Location = new System.Drawing.Point(16, 357);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(702, 48);
            this._label2.TabIndex = 3;
            this._label2.Text = "When using the Stacked bar or Stacked column types, you can group different serie" +
                                "s into separate groups by setting the StackedGroupName custom attribute.";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StackedChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label2);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "StackedChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.StackedChartType_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set chart type
            var chartTypeName = _comboBoxChartType.Text;
            if (_checkBoxHundredPercent.Checked) chartTypeName = chartTypeName + "100";

            // Grouping cannot be done using stacked area charts
            if (chartTypeName == "StackedArea" || chartTypeName == "StackedArea100")
                _checkBoxGrouped.Enabled = false;

            else
                _checkBoxGrouped.Enabled = true;

            _chart1.Series["Series1"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), chartTypeName, true);
            _chart1.Series["Series2"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), chartTypeName, true);
            _chart1.Series["Series3"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), chartTypeName, true);
            _chart1.Series["Series4"].ChartType =
                (SeriesChartType) Enum.Parse(typeof(SeriesChartType), chartTypeName, true);

            // Show point labels
            _chart1.Series["Series1"].IsValueShownAsLabel = _checkBoxShowLabels.Checked;
            _chart1.Series["Series2"].IsValueShownAsLabel = _checkBoxShowLabels.Checked;
            _chart1.Series["Series3"].IsValueShownAsLabel = _checkBoxShowLabels.Checked;
            _chart1.Series["Series4"].IsValueShownAsLabel = _checkBoxShowLabels.Checked;

            // Enable/Disable margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;
        }

        private void StackedChartType_Load(object sender, EventArgs e)
        {
            // Populate series data
            var random = new Random();
            for (var pointIndex = 0; pointIndex < 10; pointIndex++)
            {
                _chart1.Series["Series1"].Points.AddY(random.Next(75, 170));
                _chart1.Series["Series2"].Points.AddY(random.Next(35, 125));
                _chart1.Series["Series3"].Points.AddY(random.Next(45, 140));
                _chart1.Series["Series4"].Points.AddY(random.Next(25, 110));
            }

            // Set selection
            _comboBoxChartType.SelectedIndex = 2;
        }

        private void checkBoxShowLabels_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkBoxShow3D.Checked)
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
                _chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Simplistic;
            }

            else
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
            }
        }

        private void checkBoxGrouped_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkBoxGrouped.Checked)
            {
                _chart1.Series["Series1"]["StackedGroupName"] = "Group1";
                _chart1.Series["Series2"]["StackedGroupName"] = "Group1";
                _chart1.Series["Series3"]["StackedGroupName"] = "Group2";
                _chart1.Series["Series4"]["StackedGroupName"] = "Group2";

                _chart1.ResetAutoValues();
                _chart1.Invalidate();
            }

            else
            {
                foreach (var series in _chart1.Series) series["StackedGroupName"] = "";

                _chart1.ResetAutoValues();
                _chart1.Invalidate();
            }
        }
    }
}