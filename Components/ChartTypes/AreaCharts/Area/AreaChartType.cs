using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bookshelf.Components.ChartTypes.AreaCharts.Area
{
    /// <summary>
    ///     Summary description for AreaChartType.
    /// </summary>
    public class AreaChartType : UserControl
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Chart _chart1;
        private CheckBox _checkBoxShow3D;
        private CheckBox _checkBoxShowMargin;
        private CheckBox _checkBoxShowMarkers;
        private CheckBox _checkBoxTransparent;
        private ComboBox _comboBoxTension;

        private Label _label1;
        private Label _labelSampleComment;
        private Panel _panel1;
        private RadioButton _radioButtonArea;
        private RadioButton _radioButtonSplineArea;

        public AreaChartType()
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
            this._checkBoxTransparent = new System.Windows.Forms.CheckBox();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._comboBoxTension = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this._checkBoxShowMarkers = new System.Windows.Forms.CheckBox();
            this._checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this._radioButtonSplineArea = new System.Windows.Forms.RadioButton();
            this._radioButtonArea = new System.Windows.Forms.RadioButton();
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
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
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
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))),
                ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            this._chart1.Location = new System.Drawing.Point(16, 48);
            this._chart1.Name = "_chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.LabelFormat = "C";
            series1.Legend = "Default";
            series1.Name = "Default";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))),
                ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.LabelFormat = "C";
            series2.Legend = "Default";
            series2.Name = "Series2";
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
            this._labelSampleComment.Size = new System.Drawing.Size(702, 34);
            this._labelSampleComment.TabIndex = 0;
            this._labelSampleComment.Text = "This sample demonstrates Area and Spline Area charts.";
            this._labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelSampleComment.Click += new System.EventHandler(this.labelSampleComment_Click);
            // 
            // panel1
            // 
            this._panel1.Controls.Add(this._checkBoxTransparent);
            this._panel1.Controls.Add(this._checkBoxShow3D);
            this._panel1.Controls.Add(this._comboBoxTension);
            this._panel1.Controls.Add(this._label1);
            this._panel1.Controls.Add(this._checkBoxShowMarkers);
            this._panel1.Controls.Add(this._checkBoxShowMargin);
            this._panel1.Controls.Add(this._radioButtonSplineArea);
            this._panel1.Controls.Add(this._radioButtonArea);
            this._panel1.Location = new System.Drawing.Point(432, 56);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(292, 288);
            this._panel1.TabIndex = 2;
            // 
            // checkBoxTransparent
            // 
            this._checkBoxTransparent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxTransparent.Location = new System.Drawing.Point(19, 168);
            this._checkBoxTransparent.Name = "_checkBoxTransparent";
            this._checkBoxTransparent.Size = new System.Drawing.Size(216, 24);
            this._checkBoxTransparent.TabIndex = 6;
            this._checkBoxTransparent.Text = "Semi-&Transparent Colors:";
            this._checkBoxTransparent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxTransparent.CheckedChanged +=
                new System.EventHandler(this.checkBoxTransparent_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(51, 200);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(184, 24);
            this._checkBoxShow3D.TabIndex = 7;
            this._checkBoxShow3D.Text = "Display chart as 3&D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxTension
            // 
            this._comboBoxTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxTension.Items.AddRange(new object[]
            {
                "1.2",
                "0.8",
                "0.4",
                "0.2"
            });
            this._comboBoxTension.Location = new System.Drawing.Point(222, 70);
            this._comboBoxTension.Name = "_comboBoxTension";
            this._comboBoxTension.Size = new System.Drawing.Size(64, 22);
            this._comboBoxTension.TabIndex = 3;
            this._comboBoxTension.SelectedIndexChanged +=
                new System.EventHandler(this.comboBoxTension_SelectedIndexChanged);
            // 
            // label1
            // 
            this._label1.Location = new System.Drawing.Point(105, 70);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(112, 23);
            this._label1.TabIndex = 2;
            this._label1.Text = "Spline &Tension:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowMarkers
            // 
            this._checkBoxShowMarkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMarkers.Location = new System.Drawing.Point(3, 104);
            this._checkBoxShowMarkers.Name = "_checkBoxShowMarkers";
            this._checkBoxShowMarkers.Size = new System.Drawing.Size(232, 24);
            this._checkBoxShowMarkers.TabIndex = 4;
            this._checkBoxShowMarkers.Text = "Show Point &Markers and Labels:";
            this._checkBoxShowMarkers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMarkers.CheckedChanged +=
                new System.EventHandler(this.checkBoxShowMarkers_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this._checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.Location = new System.Drawing.Point(3, 136);
            this._checkBoxShowMargin.Name = "_checkBoxShowMargin";
            this._checkBoxShowMargin.Size = new System.Drawing.Size(232, 24);
            this._checkBoxShowMargin.TabIndex = 5;
            this._checkBoxShowMargin.Text = "Show X Axis M&argin:";
            this._checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            this._radioButtonSplineArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonSplineArea.Location = new System.Drawing.Point(48, 37);
            this._radioButtonSplineArea.Name = "_radioButtonSplineArea";
            this._radioButtonSplineArea.Size = new System.Drawing.Size(184, 24);
            this._radioButtonSplineArea.TabIndex = 1;
            this._radioButtonSplineArea.Text = "&Spline Area Chart:";
            this._radioButtonSplineArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonSplineArea.CheckedChanged +=
                new System.EventHandler(this.radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            this._radioButtonArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonArea.Checked = true;
            this._radioButtonArea.Location = new System.Drawing.Point(88, 8);
            this._radioButtonArea.Name = "_radioButtonArea";
            this._radioButtonArea.Size = new System.Drawing.Size(144, 24);
            this._radioButtonArea.TabIndex = 0;
            this._radioButtonArea.TabStop = true;
            this._radioButtonArea.Text = "&Area Chart:";
            this._radioButtonArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._radioButtonArea.CheckedChanged += new System.EventHandler(this.radioButtonArea_CheckedChanged);
            // 
            // AreaChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._labelSampleComment);
            this.Controls.Add(this._chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AreaChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.AreaChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this._chart1)).EndInit();
            this._panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private void UpdateChartSettings()
        {
            if (_radioButtonArea.Checked)
            {
                // Set chart type to Area
                _chart1.Series["Default"].ChartType = SeriesChartType.Area;
                _chart1.Series["Series2"].ChartType = SeriesChartType.Area;
                _chart1.Series["Default"].DeleteCustomProperty("LineTension");
                _chart1.Series["Series2"].DeleteCustomProperty("LineTension");
                _comboBoxTension.Enabled = false;
            }
            else
            {
                // Set chart type to SplineArea and set line tension
                _comboBoxTension.Enabled = true;
                _chart1.Series["Default"].ChartType = SeriesChartType.SplineArea;
                _chart1.Series["Default"]["LineTension"] = _comboBoxTension.Text;
                _chart1.Series["Series2"].ChartType = SeriesChartType.SplineArea;
                _chart1.Series["Series2"]["LineTension"] = _comboBoxTension.Text;
            }


            // Show solid or transparent color
            if (_checkBoxTransparent.Checked)
            {
                _chart1.Series["Default"].Color = Color.FromArgb(220, 65, 140, 240);
                _chart1.Series["Series2"].Color = Color.FromArgb(220, 252, 180, 65);
            }
            else
            {
                if (_checkBoxShow3D.Checked)
                {
                    _chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
                    _chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
                }
                else
                {
                    _chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
                    _chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
                }
            }

            // Enable points labels and markers
            if (_checkBoxShowMarkers.Checked)
            {
                _chart1.Series["Default"].IsValueShownAsLabel = true;
                _chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
                _chart1.Series["Default"].MarkerColor = Color.Gold;
                _chart1.Series["Series2"].IsValueShownAsLabel = true;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
                _chart1.Series["Series2"].MarkerColor = Color.Gold;
            }
            else
            {
                _chart1.Series["Default"].IsValueShownAsLabel = false;
                _chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
                _chart1.Series["Default"].MarkerColor = Color.Gold;
                _chart1.Series["Series2"].IsValueShownAsLabel = false;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
                _chart1.Series["Series2"].MarkerColor = Color.Gold;
            }

            // Disable/enable X axis margin
            _chart1.ChartAreas["Default"].AxisX.IsMarginVisible = _checkBoxShowMargin.Checked;

            // Show 3D or 2D charts
            if (_checkBoxShow3D.Checked)
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
                _chart1.Series["Default"].IsValueShownAsLabel = false;
                _chart1.Series["Series2"].IsValueShownAsLabel = false;
                _chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
            }
            else
            {
                _chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
            }

            if (_checkBoxShowMarkers.Checked)
            {
                _chart1.Series["Default"].IsValueShownAsLabel = true;
                _chart1.Series["Series2"].IsValueShownAsLabel = true;
                _chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
                _chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
            }
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void radioButtonSplineArea_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMarkers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxTension_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void AreaChartType_Load(object sender, EventArgs e)
        {
            _comboBoxTension.SelectedIndex = 1;
            _checkBoxTransparent.Checked = true;
            // Add data
            _chart1.Series["Default"].Points.AddY(8.1);
            _chart1.Series["Default"].Points.AddY(7.6);
            _chart1.Series["Default"].Points.AddY(9.5);
            _chart1.Series["Default"].Points.AddY(8.5);
            _chart1.Series["Default"].Points.AddY(9.0);
            _chart1.Series["Default"].Points.AddY(8.0);

            _chart1.Series["Series2"].Points.AddY(2.3);
            _chart1.Series["Series2"].Points.AddY(4.2);
            _chart1.Series["Series2"].Points.AddY(3.6);
            _chart1.Series["Series2"].Points.AddY(2.3);
            _chart1.Series["Series2"].Points.AddY(1.6);
            _chart1.Series["Series2"].Points.AddY(2.9);
        }

        private void checkBoxShow3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxTransparent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChartSettings();
        }

        private void labelSampleComment_Click(object sender, EventArgs e)
        {
        }
    }
}