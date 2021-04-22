using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Bookshelf.Components.Pages.ReportPage
{
    public partial class CtlPageReport : BaseUserControl
    {
        public CtlPageReport()
        {
            InitializeComponent();

            WireUpCtlPageReport();
        }

        private void WireUpCtlPageReport()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            //https://github.com/dotnet/winforms-datavisualization/blob/main/sample/ChartSamples/ChartTypes/PieDoughnutCharts/PieCollected/PieCollected.cs
            //var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            //var chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            //chart1.ChartAreas.Add(chartArea1);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageReport;
            if (ParentForm != null) ParentForm.Text = Text;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlButtons.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlButtons.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlTableLayout.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlTableLayout.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlFibonacciPie.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlFibonacciPie.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    if (pnlFibonacciPie.Visible)
                    {
                        pnlFibonacciPie.Hide();
                        pnlFibonacciPie.Show();
                        DrawFibonacciPie();
                    }

                    lblP1.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP1.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP2.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP2.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP3.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP3.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP4.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP4.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP5.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP5.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP6.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP6.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblNote.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblNote.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlButtons.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlButtons.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlTableLayout.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlTableLayout.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlFibonacciPie.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlFibonacciPie.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    if (pnlFibonacciPie.Visible)
                    {
                        pnlFibonacciPie.Hide();
                        pnlFibonacciPie.Show();
                        DrawFibonacciPie();
                    }

                    lblP1.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP1.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblP2.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP2.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblP3.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP3.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblP4.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP4.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblP5.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP5.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblP6.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblP6.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblNote.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblNote.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlButtons.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlButtons.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlTableLayout.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlTableLayout.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlFibonacciPie.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlFibonacciPie.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    if (pnlFibonacciPie.Visible)
                    {
                        pnlFibonacciPie.Hide();
                        pnlFibonacciPie.Show();
                        DrawFibonacciPie();
                    }

                    lblP1.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP1.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP2.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP2.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP3.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP3.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP4.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP4.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP5.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP5.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblP6.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblP6.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblNote.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblNote.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    // Draw
        //    DrawPie();
        //}

        private void pnlTableLayout_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawFibonacciPie();
        }

        private void btnTogglePie_Click(object sender, System.EventArgs e)
        {
            if (pnlFibonacciPie.Visible)
                pnlFibonacciPie.Hide();
            else
            {
                pnlFibonacciPie.Show();
                DrawFibonacciPie();
            }
        }

        // Pie chart
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.creategraphics?view=net-5.0
        // https://github.com/dotnet/winforms-datavisualization
        private void DrawFibonacciPie()
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
            var g = pnlFibonacciPie.CreateGraphics();

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;

            // Draw pie graph
            var pieSize = new Size(200, 200);
            //var pieSize = new Size(pnlPie.Width - 100, pnlPie.Height - 25);
            //var pnlPieRatio = 1f * pnlPie.Width / pnlPie.Height;

            //if (pnlPieRatio < 1)
            //    pieSize.Height = pieSize.Width;
            //else
            //    pieSize.Width = pieSize.Height;

            //var rect = new Rectangle(new Point(0, 0), pieSize);
            var rect = new Rectangle(new Point(0, 0), pieSize);

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
            g.DrawLine(goldPen, new Point(pieSize.Width + 10, 50), new Point(pieSize.Width + 15, 50));

            var indigoPen = new Pen(Brushes.Indigo)
            {
                Width = 5
            };
            g.DrawLine(indigoPen, new Point(pieSize.Width + 10, 70), new Point(pieSize.Width + 15, 70));

            var chartreusePen = new Pen(Brushes.Chartreuse)
            {
                Width = 5
            };
            g.DrawLine(chartreusePen, new Point(pieSize.Width + 10, 90), new Point(pieSize.Width + 15, 90));

            var blueVioletPen = new Pen(Brushes.BlueViolet)
            {
                Width = 5
            };
            g.DrawLine(blueVioletPen, new Point(pieSize.Width + 10, 110), new Point(pieSize.Width + 15, 110));

            var crimsonPen = new Pen(Brushes.Crimson)
            {
                Width = 5
            };
            g.DrawLine(crimsonPen, new Point(pieSize.Width + 10, 130), new Point(pieSize.Width + 15, 130));

            var tealPen = new Pen(Brushes.Teal)
            {
                Width = 5
            };
            g.DrawLine(tealPen, new Point(pieSize.Width + 10, 150), new Point(pieSize.Width + 15, 150));

            g.Dispose();
        }
    }
}
