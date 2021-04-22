
namespace Bookshelf.Components.Base.PieChart
{
    partial class GenrePieChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.basePanel1 = new Bookshelf.Components.Base.BasePanel();
            this._label6 = new System.Windows.Forms.Label();
            this._comboBoxPieDrawingStyle = new System.Windows.Forms.ComboBox();
            this._checkBoxRotate = new System.Windows.Forms.CheckBox();
            this._checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this._comboBoxRadius = new System.Windows.Forms.ComboBox();
            this._label4 = new System.Windows.Forms.Label();
            this._showLegend = new System.Windows.Forms.CheckBox();
            this._comboBoxExploded = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
            this._label2 = new System.Windows.Forms.Label();
            this._comboBoxChartType = new System.Windows.Forms.ComboBox();
            this._label1 = new System.Windows.Forms.Label();
            this.basePanel2 = new Bookshelf.Components.Base.BasePanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.basePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel.Controls.Add(this.basePanel1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.basePanel2, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(700, 460);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // basePanel1
            // 
            this.basePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.basePanel1.Controls.Add(this._label6);
            this.basePanel1.Controls.Add(this._comboBoxPieDrawingStyle);
            this.basePanel1.Controls.Add(this._checkBoxRotate);
            this.basePanel1.Controls.Add(this._checkBoxShow3D);
            this.basePanel1.Controls.Add(this._comboBoxRadius);
            this.basePanel1.Controls.Add(this._label4);
            this.basePanel1.Controls.Add(this._showLegend);
            this.basePanel1.Controls.Add(this._comboBoxExploded);
            this.basePanel1.Controls.Add(this._label3);
            this.basePanel1.Controls.Add(this._comboBoxLabelStyle);
            this.basePanel1.Controls.Add(this._label2);
            this.basePanel1.Controls.Add(this._comboBoxChartType);
            this.basePanel1.Controls.Add(this._label1);
            this.basePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.basePanel1.Location = new System.Drawing.Point(400, 0);
            this.basePanel1.Name = "basePanel1";
            this.basePanel1.Size = new System.Drawing.Size(300, 460);
            this.basePanel1.TabIndex = 0;
            // 
            // _label6
            // 
            this._label6.Location = new System.Drawing.Point(8, 327);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(173, 23);
            this._label6.TabIndex = 27;
            this._label6.Text = "&Drawing Style:";
            this._label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _comboBoxPieDrawingStyle
            // 
            this._comboBoxPieDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPieDrawingStyle.Items.AddRange(new object[] {
            "Default",
            "SoftEdge",
            "Concave"});
            this._comboBoxPieDrawingStyle.Location = new System.Drawing.Point(182, 327);
            this._comboBoxPieDrawingStyle.Name = "_comboBoxPieDrawingStyle";
            this._comboBoxPieDrawingStyle.Size = new System.Drawing.Size(112, 27);
            this._comboBoxPieDrawingStyle.TabIndex = 26;
            this._comboBoxPieDrawingStyle.SelectedIndexChanged += new System.EventHandler(this._comboBoxPieDrawingStyle_SelectedIndexChanged);
            // 
            // _checkBoxRotate
            // 
            this._checkBoxRotate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxRotate.Location = new System.Drawing.Point(8, 264);
            this._checkBoxRotate.Name = "_checkBoxRotate";
            this._checkBoxRotate.Size = new System.Drawing.Size(173, 24);
            this._checkBoxRotate.TabIndex = 25;
            this._checkBoxRotate.Text = "Rotate C&hart:";
            this._checkBoxRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxRotate.CheckedChanged += new System.EventHandler(this._checkBoxRotate_CheckedChanged);
            // 
            // _checkBoxShow3D
            // 
            this._checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.Location = new System.Drawing.Point(8, 295);
            this._checkBoxShow3D.Name = "_checkBoxShow3D";
            this._checkBoxShow3D.Size = new System.Drawing.Size(174, 24);
            this._checkBoxShow3D.TabIndex = 24;
            this._checkBoxShow3D.Text = "Display &chart as 3D:";
            this._checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._checkBoxShow3D.CheckedChanged += new System.EventHandler(this._checkBoxShow3D_CheckedChanged);
            // 
            // _comboBoxRadius
            // 
            this._comboBoxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxRadius.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "60",
            "70"});
            this._comboBoxRadius.Location = new System.Drawing.Point(183, 202);
            this._comboBoxRadius.Name = "_comboBoxRadius";
            this._comboBoxRadius.Size = new System.Drawing.Size(112, 27);
            this._comboBoxRadius.TabIndex = 18;
            this._comboBoxRadius.SelectedIndexChanged += new System.EventHandler(this._comboBoxRadius_SelectedIndexChanged);
            // 
            // _label4
            // 
            this._label4.Location = new System.Drawing.Point(8, 202);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(173, 23);
            this._label4.TabIndex = 23;
            this._label4.Text = "Doughnut &Radius (%):";
            this._label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _showLegend
            // 
            this._showLegend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showLegend.Location = new System.Drawing.Point(8, 234);
            this._showLegend.Name = "_showLegend";
            this._showLegend.Size = new System.Drawing.Size(174, 24);
            this._showLegend.TabIndex = 19;
            this._showLegend.Text = "Show &Legend:";
            this._showLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._showLegend.CheckedChanged += new System.EventHandler(this._showLegend_CheckedChanged);
            // 
            // _comboBoxExploded
            // 
            this._comboBoxExploded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxExploded.Location = new System.Drawing.Point(183, 170);
            this._comboBoxExploded.Name = "_comboBoxExploded";
            this._comboBoxExploded.Size = new System.Drawing.Size(112, 27);
            this._comboBoxExploded.TabIndex = 17;
            this._comboBoxExploded.SelectedIndexChanged += new System.EventHandler(this._comboBoxExploded_SelectedIndexChanged);
            // 
            // _label3
            // 
            this._label3.Location = new System.Drawing.Point(8, 170);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(173, 23);
            this._label3.TabIndex = 22;
            this._label3.Text = "&Exploded Point:";
            this._label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _comboBoxLabelStyle
            // 
            this._comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxLabelStyle.Items.AddRange(new object[] {
            "Inside",
            "Outside",
            "Disabled"});
            this._comboBoxLabelStyle.Location = new System.Drawing.Point(183, 138);
            this._comboBoxLabelStyle.Name = "_comboBoxLabelStyle";
            this._comboBoxLabelStyle.Size = new System.Drawing.Size(112, 27);
            this._comboBoxLabelStyle.TabIndex = 16;
            this._comboBoxLabelStyle.SelectedIndexChanged += new System.EventHandler(this._comboBoxLabelStyle_SelectedIndexChanged);
            // 
            // _label2
            // 
            this._label2.Location = new System.Drawing.Point(8, 138);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(173, 23);
            this._label2.TabIndex = 21;
            this._label2.Text = "Label &Style:";
            this._label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _comboBoxChartType
            // 
            this._comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxChartType.Items.AddRange(new object[] {
            "Pie",
            "Doughnut"});
            this._comboBoxChartType.Location = new System.Drawing.Point(183, 106);
            this._comboBoxChartType.Name = "_comboBoxChartType";
            this._comboBoxChartType.Size = new System.Drawing.Size(112, 27);
            this._comboBoxChartType.TabIndex = 15;
            this._comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this._comboBoxChartType_SelectedIndexChanged);
            // 
            // _label1
            // 
            this._label1.Location = new System.Drawing.Point(8, 106);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(173, 23);
            this._label1.TabIndex = 20;
            this._label1.Text = "Chart &Type:";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // basePanel2
            // 
            this.basePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.basePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.basePanel2.Location = new System.Drawing.Point(0, 0);
            this.basePanel2.Name = "basePanel2";
            this.basePanel2.Size = new System.Drawing.Size(400, 460);
            this.basePanel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GenrePieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GenrePieChart";
            this.tableLayoutPanel.ResumeLayout(false);
            this.basePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private BasePanel basePanel1;
        private System.Windows.Forms.Label _label6;
        private System.Windows.Forms.ComboBox _comboBoxPieDrawingStyle;
        private System.Windows.Forms.CheckBox _checkBoxRotate;
        private System.Windows.Forms.CheckBox _checkBoxShow3D;
        private System.Windows.Forms.ComboBox _comboBoxRadius;
        private System.Windows.Forms.Label _label4;
        private System.Windows.Forms.CheckBox _showLegend;
        private System.Windows.Forms.ComboBox _comboBoxExploded;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.ComboBox _comboBoxLabelStyle;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.ComboBox _comboBoxChartType;
        private System.Windows.Forms.Label _label1;
        private BasePanel basePanel2;
        private System.Windows.Forms.Timer timer1;
    }
}
