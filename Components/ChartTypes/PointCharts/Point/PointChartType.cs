using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.PointCharts.Point
{
    /// <summary>
    ///     Summary description for PointChartType.
    /// </summary>
    public class PointChartType : UserControl
    {
        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private ComboBox _comboBoxLabelPosition;
        private ComboBox _comboBoxMarkerShape;
        private ComboBox _comboMarkerSize;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Label _label1;
        private Label _label2;
        private Label _label3;
        private Label _labelSampleComment;
        private Panel _panel1;

        public PointChartType()
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
            this._comboMarkerSize = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxMarkerShape = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxLabelPosition = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
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
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))),
                ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this._chart1.Location = new System.Drawing.Point(16, 56);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series2.Legend = "Default";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            this._chart1.Series.Add(series1);
            this._chart1.Series.Add(series2);
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
                "This sample displays a Point chart. Try setting different marker sizes, shapes an" +
                "d point label positions.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._comboMarkerSize);
            this._panel1.Controls.Add(this._label3);
            this._panel1.Controls.Add(this._comboBoxMarkerShape);
            this._panel1.Controls.Add(this._label2);
            this._panel1.Controls.Add(this._comboBoxLabelPosition);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Location = new System.Drawing.Point(432, 64);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(13, 104);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this._checkBoxShow3D.TabIndex = 6;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboMarkerSize
            // 
            this._comboMarkerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboMarkerSize.Items.AddRange(new object[]
            {
                "5",
                "7",
                "10",
                "12",
                "18"
            });
            this._comboMarkerSize.Location = new System.Drawing.Point(168, 72);
            this._comboMarkerSize.Name = "_comboMarkerSize";
            this._comboMarkerSize.Size = new System.Drawing.Size(120, 22);
            this._comboMarkerSize.TabIndex = 5;
            this._comboMarkerSize.SelectedIndexChanged +=
                new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this._label3.Location = new System.Drawing.Point(20, 72);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(144, 23);
            this._label3.TabIndex = 4;
            this._label3.Text = "Marker Si&ze:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkerShape
            // 
            this._comboBoxMarkerShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxMarkerShape.Items.AddRange(new object[]
            {
                "Circle & Square",
                "Diamond & Triangle",
                "Cross & Star"
            });
            this._comboBoxMarkerShape.Location = new System.Drawing.Point(168, 40);
            this._comboBoxMarkerShape.Name = "_comboBoxMarkerShape";
            this._comboBoxMarkerShape.Size = new System.Drawing.Size(120, 22);
            this._comboBoxMarkerShape.TabIndex = 3;
            this._comboBoxMarkerShape.SelectedIndexChanged +=
                new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this._label2.Location = new System.Drawing.Point(20, 40);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(144, 23);
            this._label2.TabIndex = 2;
            this._label2.Text = "Marker &Shape:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelPosition
            // 
            this._comboBoxLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelPosition.Items.AddRange(new object[]
            {
                "None",
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
            this._comboBoxLabelPosition.Location = new System.Drawing.Point(168, 8);
            this._comboBoxLabelPosition.Name = "_comboBoxLabelPosition";
            this._comboBoxLabelPosition.Size = new System.Drawing.Size(120, 22);
            this._comboBoxLabelPosition.TabIndex = 1;
            this._comboBoxLabelPosition.SelectedIndexChanged +=
                new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(20, 8);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(144, 23);
            this._label1.TabIndex = 0;
            this._label1.Text = "Label &Position:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PointChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PointChartType";
            this.Size = new System.Drawing.Size(728, 368);
            this.Load += new System.EventHandler(this.PointChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            // Set point chart type
            _chart1.Series["Series1"].ChartType = SeriesChartType.Point;
            _chart1.Series["Series2"].ChartType = SeriesChartType.Point;

            // Enable data points labels
            if (_comboBoxLabelPosition.Text != @"None")
            {
                _chart1.Series["Series1"].IsValueShownAsLabel = true;
                _chart1.Series["Series2"].IsValueShownAsLabel = true;
                _chart1.Series["Series1"]["LabelStyle"] = _comboBoxLabelPosition.Text;
                _chart1.Series["Series2"]["LabelStyle"] = _comboBoxLabelPosition.Text;
            }
            else
            {
                _chart1.Series["Series1"].IsValueShownAsLabel = false;
                _chart1.Series["Series2"].IsValueShownAsLabel = false;
            }


            // Set marker size
            _chart1.Series["Series1"].MarkerSize = int.Parse(_comboMarkerSize.Text);
            _chart1.Series["Series2"].MarkerSize = int.Parse(_comboMarkerSize.Text);

            // Set marker shape
            if (_comboBoxMarkerShape.SelectedIndex == 1)
            {
                _chart1.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Triangle;
                _chart1.Series["Series2"].MarkerImage = "";
            }
            else if (_comboBoxMarkerShape.SelectedIndex == 2)
            {
                _chart1.Series["Series1"].MarkerStyle = MarkerStyle.Cross;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Star5;
            }
            else
            {
                _chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Square;
            }


            // Set X and Y axis scale
            _chart1.ChartAreas["Default"].AxisY.Maximum = 100.0;
            _chart1.ChartAreas["Default"].AxisY.Minimum = 0.0;
        }

        private void PointChartType_Load(object sender, EventArgs e)
        {
            // Populate series data with random data
            var random = new Random();
            for (var pointIndex = 0; pointIndex < 10; pointIndex++)
            {
                _chart1.Series["Series1"].Points.AddY(random.Next(5, 60));
                _chart1.Series["Series2"].Points.AddY(random.Next(50, 95));
            }

            // Set selected items
            _comboMarkerSize.SelectedIndex = 1;
            _comboBoxMarkerShape.SelectedIndex = 0;
            _comboBoxLabelPosition.SelectedIndex = 0;
        }

        private void comboMarkerSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            if (_checkBoxShow3D.Checked)
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
                _chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Realistic;
            }
            else
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
            }
        }
    }
}