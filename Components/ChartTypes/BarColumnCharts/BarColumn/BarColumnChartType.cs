using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.BarColumnCharts.BarColumn
{
    /// <summary>
    ///     Summary description for BarColumnChartType.
    /// </summary>
    public class BarColumnChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private ComboBox _comboBoxChartType;
        private ComboBox _comboBoxDrawingStyle;
        private ComboBox _comboBoxPointWidth;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public BarColumnChartType()
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
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36890, 32);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36891, 56);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36892, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36893, 12);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36894, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36895, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36896, 23);
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36890, 67);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36891, 24);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36892, 12);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36893, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36894, 46);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36895, 14);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(36896, 76);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._comboBoxDrawingStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxPointWidth = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this._chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))),
                ((int)(((byte)(193)))));
            this._chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this._chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))),
                ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this._chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this._chart1.BorderlineWidth = 2;
            this._chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MM-dd";
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "C0";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 64);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))),
                ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))),
                ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Column Chart";
            this._chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 39);
            this._labelSampleComment.TabIndex = 2;
            this._labelSampleComment.Text = "This sample demonstrates the Column and Bar chart types.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._comboBoxDrawingStyle);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxChartType);
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxPointWidth);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 64);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 0;
            // 
            // comboBoxDrawingStyle
            // 
            this._comboBoxDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxDrawingStyle.Items.AddRange(new object[]
            {
                "Default",
                "Emboss",
                "Cylinder",
                "Wedge",
                "LightToDark"
            });
            this._comboBoxDrawingStyle.Location = new System.Drawing.Point(168, 72);
            this._comboBoxDrawingStyle.Name = "_comboBoxDrawingStyle";
            this._comboBoxDrawingStyle.Size = new System.Drawing.Size(112, 22);
            this._comboBoxDrawingStyle.TabIndex = 11;
            this._comboBoxDrawingStyle.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxDrawingEffect_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(51, 72);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(112, 23);
            this._label2.TabIndex = 10;
            this._label2.Text = "Drawing Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[]
            {
                "Column",
                "Bar"
            });
            this._comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(112, 22);
            this._comboBoxChartType.TabIndex = 9;
            this._comboBoxChartType.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(22, 103);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(160, 24);
            this._checkBoxShow3D.TabIndex = 5;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(43, 8);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(120, 23);
            this._label3.TabIndex = 7;
            this._label3.Text = "Chart &Type:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPointWidth
            // 
            this._comboBoxPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPointWidth.Items.AddRange(new object[]
            {
                "1.0",
                "0.8",
                "0.6",
                "0.4"
            });
            this._comboBoxPointWidth.Location = new System.Drawing.Point(168, 40);
            this._comboBoxPointWidth.Name = "_comboBoxPointWidth";
            this._comboBoxPointWidth.Size = new System.Drawing.Size(112, 22);
            this._comboBoxPointWidth.TabIndex = 2;
            this._comboBoxPointWidth.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxPointWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(64, 40);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(96, 23);
            this._label1.TabIndex = 3;
            this._label1.Text = "Point &Width:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarColumnChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BarColumnChartType";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.BarColumnChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            foreach (var series in _chart1.Series)
            {
                // Set series type
                if (_comboBoxChartType.SelectedItem.ToString() == "Bar")
                {
                    series.ChartType = SeriesChartType.Bar;
                    _chart1.Titles[0].Text = "Bar Chart";
                }
                else
                {
                    series.ChartType = SeriesChartType.Column;
                    _chart1.Titles[0].Text = "Column Chart";
                }

                // Set point width of the series
                series["PointWidth"] = _comboBoxPointWidth.Text;

                // Set drawing style
                series["DrawingStyle"] = _comboBoxDrawingStyle.Text;
            }
        }

        private void BarColumnChartType_Load(object sender, EventArgs e)
        {
            _comboBoxChartType.SelectedIndex = 0;
            _comboBoxDrawingStyle.SelectedIndex = 0;
            _comboBoxPointWidth.SelectedIndex = 1;
            _checkBoxShow3D.Checked = false;
            _chart1.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;
            _chart1.ChartAreas[0].AxisX.LabelStyle.IntervalOffsetType = DateTimeIntervalType.Days;
            _chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 2;
            _chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Days;

            UpdateChartSettings();
        }

        //private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        //private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        private void comboBoxPointWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        //private void comboBoxPointLabels_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        //private void checkBoxEndLabels_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateChartSettings();
        //}

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            _chart1.ChartAreas[0].Area3DStyle.Enable3D = _checkBoxShow3D.Checked;
        }

        private void comboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxDrawingEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        //      private void checkBoxCylinder_CheckedChanged(object sender, System.EventArgs e)
        //      {
        //          // Set "DrawingStyle" custom attribute
        //          foreach(Series series in chart1.Series)
        //          {
        //              series.DeleteCustomProperty("DrawingStyle");
        //              if(checkBoxCylinder.Checked)
        //              {
        //                  series["DrawingStyle"] = "Cylinder";
        //              }
        //          }
        //
        //          // Invalidate and update the chart
        //          chart1.Invalidate();
        //          chart1.Update();
        //      }
    }
}