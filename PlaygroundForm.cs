using Bookshelf.Components.Base;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class PlaygroundForm : BaseForm
    {
        public PlaygroundForm()
        {
            InitializeComponent();

            //https://github.com/dotnet/winforms-datavisualization/blob/main/sample/ChartSamples/ChartTypes/PieDoughnutCharts/PieCollected/PieCollected.cs
            //var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            //var chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            //chart1.ChartAreas.Add(chartArea1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawPie();
        }

        private void btnTogglePie_Click(object sender, EventArgs e)
        {
            if (pnlPie.Visible)
                pnlPie.Hide();
            else
            {
                pnlPie.Show();
                DrawPie();
            }
        }

        // Pie chart
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.creategraphics?view=net-5.0
        // https://github.com/dotnet/winforms-datavisualization
        private void DrawPie()
        {
            // Data
            const float p1 = 0f;
            const float p2 = 1f;
            const float p3 = 1f;
            const float p4 = 2f;
            const float p5 = 3f;
            const float p6 = 5f;

            // Put data into chart
            lblP1.Text = $@"p1: {p1}";
            lblP2.Text = $@"p2: {p2}";
            lblP3.Text = $@"p3: {p3}";
            lblP4.Text = $@"p4: {p4}";
            lblP5.Text = $@"p5: {p5}";
            lblP6.Text = $@"p6: {p6}";

            // Calculate pie graph
            const float t = p1 + p2 + p3 + p4 + p5 + p6;

            const float pie1 = (p1 / t) * 360;
            const float pie2 = (p2 / t) * 360;
            const float pie3 = (p3 / t) * 360;
            const float pie4 = (p4 / t) * 360;
            const float pie5 = (p5 / t) * 360;
            const float pie6 = (p6 / t) * 360;

            // Create graph
            var g = pnlPie.CreateGraphics();

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;

            // Draw pie graph

            var rect = new Rectangle(new Point(0, 0), new Size(200, 200));

            g.DrawPie(Pens.Transparent, rect, 0, pie1);
            g.FillPie(Brushes.Gold, rect, 0, pie1);

            g.DrawPie(Pens.Transparent, rect, pie1, pie2);
            g.FillPie(Brushes.Indigo, rect, pie1, pie2);

            g.DrawPie(Pens.Transparent, rect, pie1 + pie2, pie3);
            g.FillPie(Brushes.Chartreuse, rect, pie1 + pie2, pie3);

            g.DrawPie(Pens.Transparent, rect, pie1 + pie2 + pie3, pie4);
            g.FillPie(Brushes.BlueViolet, rect, pie1 + pie2 + pie3, pie4);

            g.DrawPie(Pens.Transparent, rect, pie1 + pie2 + pie3 + pie4, pie5);
            g.FillPie(Brushes.Crimson, rect, pie1 + pie2 + pie3 + pie4, pie5);

            g.DrawPie(Pens.Transparent, rect, pie1 + pie2 + pie3 + pie4 + pie5, pie6);
            g.FillPie(Brushes.Teal, rect, pie1 + pie2 + pie3 + pie4 + pie5, pie6);

            // Draw info

            var goldPen = new Pen(Brushes.Gold)
            {
                Width = 5
            };
            g.DrawLine(goldPen, new Point(210, 50), new Point(215, 50));

            var indigoPen = new Pen(Brushes.Indigo)
            {
                Width = 5
            };
            g.DrawLine(indigoPen, new Point(210, 70), new Point(215, 70));

            var chartreusePen = new Pen(Brushes.Chartreuse)
            {
                Width = 5
            };
            g.DrawLine(chartreusePen, new Point(210, 90), new Point(215, 90));

            var blueVioletPen = new Pen(Brushes.BlueViolet)
            {
                Width = 5
            };
            g.DrawLine(blueVioletPen, new Point(210, 110), new Point(215, 110));

            var crimsonPen = new Pen(Brushes.Crimson)
            {
                Width = 5
            };
            g.DrawLine(crimsonPen, new Point(210, 130), new Point(215, 130));

            var tealPen = new Pen(Brushes.Teal)
            {
                Width = 5
            };
            g.DrawLine(tealPen, new Point(210, 150), new Point(215, 150));

            g.Dispose();
        }
    }
}
