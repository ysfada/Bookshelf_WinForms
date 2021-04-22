using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.RangeCharts._3DRangeBar
{
    /// <summary>
    ///     Summary description for RangeBar3D.
    /// </summary>
    public class RangeBar3D : UserControl
    {
        private Chart _chart1;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private readonly double _dToday = 4;
        private NumericUpDown _inclination;
        private Label _label1;
        private Label _label2;
        private Label _labelSampleComment;
        private Panel _panel1;
        private NumericUpDown _rotation; // assume fourth day in the data set

        public RangeBar3D()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            LoadData();
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
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 =
                new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 =
                new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 =
                new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 =
                new System.Windows.Forms.DataVisualization.Charting.Title();
            this._chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._labelSampleComment = new System.Windows.Forms.Label();
            this._panel1 = new System.Windows.Forms.Panel();
            this._rotation = new System.Windows.Forms.NumericUpDown();
            this._inclination = new System.Windows.Forms.NumericUpDown();
            this._label2 = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).BeginInit();
            this._panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this._rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this._inclination)).BeginInit();
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
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointDepth = 200;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "dd MMM";
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
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this._chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legendItem1.Color = System.Drawing.Color.Red;
            legendItem1.Name = "Completed";
            legendItem2.Color = System.Drawing.Color.Gray;
            legendItem2.Name = "Late";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this._chart1.Legends.Add(legend1);
            this._chart1.Location = new System.Drawing.Point(16, 45);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (65)))),
                ((int) (((byte) (140)))), ((int) (((byte) (240)))));
            series1.CustomProperties = "DrawSideBySide=True";
            series1.Legend = "Default";
            series1.Name = "Estimated";
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (26)))),
                ((int) (((byte) (59)))), ((int) (((byte) (105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.Color = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (252)))),
                ((int) (((byte) (180)))), ((int) (((byte) (65)))));
            series2.CustomProperties = "DrawSideBySide=True, PointWidth=0.3";
            series2.Legend = "Default";
            series2.Name = "Actual";
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
            this._chart1.Size = new System.Drawing.Size(412, 296);
            this._chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (26)))), ((int) (((byte) (59)))),
                ((int) (((byte) (105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Range Bar Chart";
            this._chart1.Titles.Add(title1);
            this._chart1.PostPaint +=
                new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(
                    this.chart1_PostPaint);
            // 
            // labelSampleComment
            // 
            this._labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this._labelSampleComment.Name = "_labelSampleComment";
            this._labelSampleComment.Size = new System.Drawing.Size(702, 29);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text = "This sample demonstrates a 3D Range Bar chart.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._rotation);
            this._panel1.Controls.Add(this._inclination);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 53);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 280);
            this._panel1.TabIndex = 2;
            // 
            // Rotation
            // 
            this._rotation.Increment = new decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._rotation.Location = new System.Drawing.Point(168, 56);
            this._rotation.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._rotation.Minimum = new decimal(new int[]
            {
                1000,
                0,
                0,
                -2147483648
            });
            this._rotation.Name = "_rotation";
            this._rotation.Size = new System.Drawing.Size(64, 22);
            this._rotation.TabIndex = 3;
            this._rotation.Value = new decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._rotation.ValueChanged += new System.EventHandler(this.Rotation_ValueChanged);
            // 
            // Inclination
            // 
            this._inclination.Increment = new decimal(new int[]
            {
                10,
                0,
                0,
                0
            });
            this._inclination.Location = new System.Drawing.Point(168, 16);
            this._inclination.Maximum = new decimal(new int[]
            {
                1000,
                0,
                0,
                0
            });
            this._inclination.Minimum = new decimal(new int[]
            {
                1000,
                0,
                0,
                -2147483648
            });
            this._inclination.Name = "_inclination";
            this._inclination.Size = new System.Drawing.Size(64, 22);
            this._inclination.TabIndex = 1;
            this._inclination.Value = new decimal(new int[]
            {
                15,
                0,
                0,
                0
            });
            this._inclination.ValueChanged += new System.EventHandler(this.Inclination_ValueChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(40, 56);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(120, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Rotate &Y:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(40, 15);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(120, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Rotate &X:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RangeBar3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "Range Bar 3D";
            this.Size = new System.Drawing.Size(728, 424);
            this.Load += new System.EventHandler(this.RangeBar3D_Load);
            ((System.ComponentModel.ISupportInitialize) (this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this._rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this._inclination)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void LoadData()
        {
            var dStartDate = DateTime.Today.ToOADate();
            _chart1.ChartAreas["Default"].AxisY.Minimum = dStartDate - 1;
            _chart1.ChartAreas["Default"].AxisY.LabelStyle.Interval = 3;
            _chart1.ChartAreas["Default"].AxisY.LabelStyle.IntervalType = DateTimeIntervalType.Days;


            string[] task =
            {
                "Task 1",
                "Task 2", "Task 2",
                "Task 3",
                "Task 4",
                "Task 5", "Task 5",
                "Task 6",
                "Task 7"
            };

            double[] start = {3, 1, 6, 0, 3, 2, 5.5, 2, 4};
            double[] end = {5, 3.5, 8, 5.5, 4, 3.5, 8, 5, 5};

            var ser = _chart1.Series[0];
            var pos = 1;
            var lastValue = "";
            for (var i = 0; i < start.Length - 1; i++)
            {
                var xValue = task[i];
                if (lastValue != xValue)
                    pos++;

                var yValues = dStartDate + start[i] + "," + (dStartDate + end[i]);
                var pt = new DataPoint(pos, yValues);
                pt.AxisLabel = xValue;
                ser.Points.Add(pt);

                lastValue = xValue;
            }


            double[] actualStart = {3, 1, 6, 0, 3, 2, 5.5, 2, 4};
            double[] actualEnd = {4.5, 4.5, 6, 4.5, 4, 3.5, 5.5, 4.5, 4.5};
            ser = _chart1.Series[1];
            pos = 1;
            lastValue = "";
            for (var i = 0; i < start.Length - 1; i++)
            {
                var xValue = task[i];
                if (lastValue != xValue)
                    pos++;

                var yValues = dStartDate + actualStart[i] + "," + (dStartDate + actualEnd[i]);
                var pt = new DataPoint(pos, yValues);
                pt.AxisLabel = xValue;
                ser.Points.Add(pt);

                if (dStartDate + _dToday > actualStart[i])
                {
                    if (start[i] < actualStart[i] || end[i] < actualEnd[i])
                        pt.Color = Color.Red;
                    else if (dStartDate + _dToday < end[i])
                        pt.Color = Color.Lime;
                    else if (Math.Abs(end[i] - actualEnd[i]) < double.Epsilon)
                        pt.Color = Color.Gray;
                }

                lastValue = xValue;
            }

            var stripLine = new StripLine();
            stripLine.StripWidth = 1;
            stripLine.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            stripLine.Text = "Today";
            stripLine.TextOrientation = TextOrientation.Rotated90;
            stripLine.BorderColor = Color.Black;
            stripLine.BackColor = Color.PaleTurquoise;
            stripLine.IntervalOffset = dStartDate + _dToday;
            stripLine.TextAlignment = StringAlignment.Center;
            stripLine.TextLineAlignment = StringAlignment.Near;

            _chart1.ChartAreas[0].AxisY.StripLines.Add(stripLine);

            foreach (var pt in _chart1.Series["Actual"].Points)
                if (Math.Abs(pt.YValues[0] - pt.YValues[1]) < double.Epsilon)
                    pt.Color = Color.Transparent;
        }

        private void chart1_PostPaint(object sender, ChartPaintEventArgs e)
        {
            if (sender is ChartArea)
            {
                var area = (ChartArea) sender;
                if (area.Name == "Default")
                {
                    var pt3d = new Point3D[4];
                    pt3d[0] = new Point3D();
                    pt3d[1] = new Point3D();
                    pt3d[2] = new Point3D();
                    pt3d[3] = new Point3D();

                    var depth = area.GetSeriesDepth(_chart1.Series[0]);
                    //var zpos = area.GetSeriesZPosition(_chart1.Series[0]);

                    pt3d[0].Y = (float) area.AxisX.ValueToPosition(_chart1.Series["Estimated"].Points[7].XValue);
                    pt3d[0].X = (float) area.AxisY.ValueToPosition(_chart1.Series["Estimated"].Points[7].YValues[1]);
                    pt3d[0].Z = depth;

                    pt3d[1].Y = (float) area.AxisX.ValueToPosition(_chart1.Series["Estimated"].Points[6].XValue);
                    pt3d[1].X = (float) area.AxisY.ValueToPosition(_chart1.Series["Estimated"].Points[6].YValues[0]);
                    pt3d[1].Z = depth;

                    pt3d[2].Y = (float) area.AxisX.ValueToPosition(_chart1.Series["Estimated"].Points[3].XValue);
                    pt3d[2].X = (float) area.AxisY.ValueToPosition(_chart1.Series["Estimated"].Points[3].YValues[1]);
                    pt3d[2].Z = depth;

                    pt3d[3].Y = (float) area.AxisX.ValueToPosition(_chart1.Series["Estimated"].Points[2].XValue);
                    pt3d[3].X = (float) area.AxisY.ValueToPosition(_chart1.Series["Estimated"].Points[2].YValues[0]);
                    pt3d[3].Z = depth;


                    area.TransformPoints(pt3d);


                    var ptF1 = e.ChartGraphics.GetAbsolutePoint(pt3d[0].PointF);
                    var ptF2 = new PointF();
                    var ptF3 = e.ChartGraphics.GetAbsolutePoint(pt3d[1].PointF);
                    var ptF4 = e.ChartGraphics.GetAbsolutePoint(pt3d[2].PointF);
                    var ptF5 = new PointF();
                    var ptF6 = e.ChartGraphics.GetAbsolutePoint(pt3d[3].PointF);

                    ptF2.X = ptF3.X;
                    ptF2.Y = ptF1.Y;

                    ptF5.X = ptF6.X;
                    ptF5.Y = ptF4.Y;

                    // Take Graphics object from chart
                    var graph = e.ChartGraphics.Graphics;

                    graph.DrawLine(new Pen(Color.Black, 1), ptF1, ptF2);
                    graph.DrawLine(new Pen(Color.Black, 1), ptF2, ptF3);
                    graph.DrawLine(new Pen(Color.Black, 1), ptF4, ptF5);
                    graph.DrawLine(new Pen(Color.Black, 1), ptF5, ptF6);

                    DrawArrow(graph, Color.Black, ptF3, ptF2, 22.5);
                    DrawArrow(graph, Color.Black, ptF6, ptF5, 22.5);
                }
            }
        }


        /// <summary>
        ///     This Method will draw an arrow head on at the end of a line segment
        ///     as defined by two points, p1 and p2
        /// </summary>
        private void DrawArrow(Graphics graph, Color brushcolor, PointF p1, PointF p2, double angleDeg)
        {
            // using the two points, p1 and p2, we must first calculate the two
            // other points to use for the triangular arrow.  The provided angle
            // must be in degrees and be converted to radians.

            var rad = angleDeg * Math.PI / 180;

            // to simplify calcuations find dx and dy for points p1 and p2
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;

            var c = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

            // to create an approximately 7px arrow, we need c to be 70 and a line_legnth of 0.1
            // There are instances where c will be less causing the 10% scale to be such that
            // the arrow head will be invisible. Similarly, when c is really large the arrow
            // head can be huge.
            double pixels = 12;
            var lineLength = 1 / (c / pixels);

            PointF arrowSegment1 = Point.Empty;
            PointF arrowSegment2 = Point.Empty;

            arrowSegment1.X = p1.X - (float) ((dx * Math.Cos(rad) - dy * Math.Sin(rad)) * lineLength);
            arrowSegment1.Y = p1.Y - (float) ((dy * Math.Cos(rad) + dx * Math.Sin(rad)) * lineLength);

            arrowSegment2.X = p1.X - (float) ((dx * Math.Cos(-rad) - dy * Math.Sin(-rad)) * lineLength);
            arrowSegment2.Y = p1.Y - (float) ((dy * Math.Cos(-rad) + dx * Math.Sin(-rad)) * lineLength);

            PointF[] arrowhead =
            {
                p1,
                arrowSegment1,
                arrowSegment2
            };

            var brush = new SolidBrush(brushcolor);
            graph.FillPolygon(brush, arrowhead);
        }

        private void RangeBar3D_Load(object sender, EventArgs e)
        {
        }

        private void Inclination_ValueChanged(object sender, EventArgs e)
        {
            if (_inclination.Value > 90)
                _inclination.Value = 90;
            if (_inclination.Value < -90)
                _inclination.Value = -90;
            _chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int) _inclination.Value;

            if (_inclination.Value < 0)
                _chart1.ChartAreas["Default"].AxisY.StripLines[0].TextLineAlignment = StringAlignment.Far;
            if (_inclination.Value > 0)
                _chart1.ChartAreas["Default"].AxisY.StripLines[0].TextLineAlignment = StringAlignment.Near;
        }

        private void Rotation_ValueChanged(object sender, EventArgs e)
        {
            if (_rotation.Value > 44)
                _rotation.Value = 44;
            if (_rotation.Value < -44)
                _rotation.Value = -44;
            _chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int) _rotation.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}