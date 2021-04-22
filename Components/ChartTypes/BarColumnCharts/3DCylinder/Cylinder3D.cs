using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.BarColumnCharts._3DCylinder
{
    /// <summary>
    ///     Summary description for Cylinder3D.
    /// </summary>
    public class Cylinder3D : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkClustered;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label3;
        private Label _label4;
        private Label _labelSampleComment;
        private Point _mouseDownPoint = Point.Empty;
        private NumericUpDown _numericUpDownPointDepth;
        private NumericUpDown _numericUpDownPointGapDepth;
        private int _origInclination;
        private int _origRotation;
        private Panel _panel1;
        private RadioButton _radioButtonBar;
        private RadioButton _radioButtonColumn;

        public Cylinder3D()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5.6999998092651367);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8.5);
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.Series series3 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 =
                new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._numericUpDownPointGapDepth = new System.Windows.Forms.NumericUpDown();
            this._numericUpDownPointDepth = new System.Windows.Forms.NumericUpDown();
            this._label3 = new System.Windows.Forms.Label();
            this._label4 = new System.Windows.Forms.Label();
            this._checkClustered = new System.Windows.Forms.CheckBox();
            this._radioButtonColumn = new System.Windows.Forms.RadioButton();
            this._radioButtonBar = new System.Windows.Forms.RadioButton();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownPointGapDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownPointDepth)).BeginInit();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 0;
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
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            this._chart1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (224)))),
                ((int) (((byte) (64)))), ((int) (((byte) (10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Series.Add(series3);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Cylinder";
            this._chart1.Titles.Add(title1);
            this._chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            this._chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this._chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
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
                "This sample demonstrates how to display 3D Bar and Column charts as cylinders. Cy" +
                "linders may be applied to an entire data series or to specific points within a s" +
                "eries. ";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._numericUpDownPointGapDepth);
            this._panel1.Controls.Add(this._numericUpDownPointDepth);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._label4);
            this._panel1.Controls.Add(this._checkClustered);
            this._panel1.Controls.Add(this._radioButtonColumn);
            this._panel1.Controls.Add(this._radioButtonBar);
            this._panel1.Location = new System.Drawing.Point(432, 61);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 280);
            this._panel1.TabIndex = 2;
            // 
            // numericUpDownPointGapDepth
            // 
            this._numericUpDownPointGapDepth.Increment = new decimal(new int[]
            {
                50,
                0,
                0,
                0
            });
            this._numericUpDownPointGapDepth.Location = new System.Drawing.Point(168, 136);
            this._numericUpDownPointGapDepth.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._numericUpDownPointGapDepth.Name = "_numericUpDownPointGapDepth";
            this._numericUpDownPointGapDepth.Size = new System.Drawing.Size(56, 22);
            this._numericUpDownPointGapDepth.TabIndex = 6;
            this._numericUpDownPointGapDepth.Value = new decimal(new int[]
            {
                100,
                0,
                0,
                0
            });
            this._numericUpDownPointGapDepth.ValueChanged +=
                new System.EventHandler(this.numericUpDownPointGapDepth_ValueChanged);
            // 
            // numericUpDownPointDepth
            // 
            this._numericUpDownPointDepth.Increment = new decimal(new int[]
            {
                25,
                0,
                0,
                0
            });
            this._numericUpDownPointDepth.Location = new System.Drawing.Point(168, 104);
            this._numericUpDownPointDepth.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._numericUpDownPointDepth.Name = "_numericUpDownPointDepth";
            this._numericUpDownPointDepth.Size = new System.Drawing.Size(56, 22);
            this._numericUpDownPointDepth.TabIndex = 4;
            this._numericUpDownPointDepth.Value = new decimal(new int[]
            {
                100,
                0,
                0,
                0
            });
            this._numericUpDownPointDepth.ValueChanged +=
                new System.EventHandler(this.numericUpDownPointDepth_ValueChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(18, 136);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(144, 23);
            this._label3.TabIndex = 5;
            this._label3.Text = "&Gap Depth:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this._label4.Location = new System.Drawing.Point(10, 104);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(152, 23);
            this._label4.TabIndex = 3;
            this._label4.Text = "Point &Depth:";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkClustered
            // 
            this._checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkClustered.Checked = true;
            this._checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkClustered.Location = new System.Drawing.Point(45, 72);
            this._checkClustered.Name = "_checkClustered";
            this._checkClustered.Size = new System.Drawing.Size(136, 24);
            this._checkClustered.TabIndex = 2;
            this._checkClustered.Text = "C&lustered:";
            this._checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkClustered.CheckedChanged += new System.EventHandler(this.checkClustered_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            this._radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonColumn.Checked = true;
            this._radioButtonColumn.Location = new System.Drawing.Point(13, 40);
            this._radioButtonColumn.Name = "_radioButtonColumn";
            this._radioButtonColumn.Size = new System.Drawing.Size(168, 24);
            this._radioButtonColumn.TabIndex = 1;
            this._radioButtonColumn.TabStop = true;
            this._radioButtonColumn.Text = "3D &Column Cylinder:";
            this._radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonColumn.CheckedChanged += new System.EventHandler(this.radioButtonColumn_CheckedChanged);
            // 
            // radioButtonBar
            // 
            this._radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonBar.Location = new System.Drawing.Point(29, 8);
            this._radioButtonBar.Name = "_radioButtonBar";
            this._radioButtonBar.Size = new System.Drawing.Size(152, 24);
            this._radioButtonBar.TabIndex = 0;
            this._radioButtonBar.Text = "3D &Bar Cylinder:";
            this._radioButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonBar.CheckedChanged += new System.EventHandler(this.radioButtonBar_CheckedChanged);
            // 
            // label1
            // 
            this._label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._label1.Location = new System.Drawing.Point(16, 349);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(702, 32);
            this._label1.TabIndex = 3;
            this._label1.Text = "Click on the chart and drag the mouse to rotate the chart.";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cylinder3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._label1);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "Cylinder3D";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.Cylinder3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownPointGapDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this._numericUpDownPointDepth)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set Cylinder drawing style attribute
            _chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
            _chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
            _chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";

            if (_radioButtonBar.Checked)
            {
                // Set chart type to Bar
                _chart1.Series["Default"].ChartType = SeriesChartType.Bar;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
                _chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
            }
            else
            {
                // Set chart type to Column
                _chart1.Series["Default"].ChartType = SeriesChartType.Column;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Column;
                _chart1.Series["Series3"].ChartType = SeriesChartType.Column;
            }

            // Disable/enable clustered series
            _chart1.ChartAreas["Default"].Area3DStyle.IsClustered = _checkClustered.Checked;

            // Set point depth
            _chart1.ChartAreas["Default"].Area3DStyle.PointDepth = (int) _numericUpDownPointDepth.Value;
            _chart1.ChartAreas["Default"].Area3DStyle.PointGapDepth = (int) _numericUpDownPointGapDepth.Value;
        }

        private void radioButtonBar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void radioButtonColumn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkClustered_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownPointDepth_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void numericUpDownPointGapDepth_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            _chart1.Cursor = Cursors.NoMove2D;
            _mouseDownPoint = new Point(e.X, e.Y);
            _origRotation = _chart1.ChartAreas[0].Area3DStyle.Rotation;
            _origInclination = _chart1.ChartAreas[0].Area3DStyle.Inclination;
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            _chart1.Cursor = Cursors.Hand;
            _mouseDownPoint = Point.Empty;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDownPoint.IsEmpty)
            {
                var rotationDelta = _mouseDownPoint.X - e.X;
                var rotation = _origRotation;
                for (var i = 0; i != rotationDelta;)
                {
                    if (rotationDelta > 0)
                    {
                        if (rotation >= 180) rotation = -180;

                        ++rotation;
                    }
                    else
                    {
                        if (rotation <= -180) rotation = 180;

                        --rotation;
                    }

                    i += rotationDelta > 0 ? 1 : -1;
                }

                _chart1.ChartAreas[0].Area3DStyle.Rotation = rotation;

                var inclinationDelta = e.Y - _mouseDownPoint.Y;
                var inclination = _origInclination;
                for (var i = 0; i != inclinationDelta;)
                {
                    if (inclinationDelta > 0)
                    {
                        if (inclination >= 90) inclination = -90;

                        ++inclination;
                    }
                    else
                    {
                        if (inclination <= -90) inclination = 90;

                        --inclination;
                    }

                    i += inclinationDelta > 0 ? 1 : -1;
                }

                _chart1.ChartAreas[0].Area3DStyle.Inclination = inclination;

                _chart1.Invalidate();
                _chart1.Update();
            }
        }

        private void Cylinder3D_Load(object sender, EventArgs e)
        {
            // Set Cylinder drawing style attribute
            _chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
            _chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
            _chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";
        }
    }
}