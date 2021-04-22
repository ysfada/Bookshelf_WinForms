using Bookshelf.Components.Base;
using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bookshelf.Components.Custom
{
    public class BtnRound : BaseButton
    {
        public BtnRound()
        {
            WireUpBtnRound();
        }

        private void WireUpBtnRound()
        {
            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
        }

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            pevent.Graphics.InterpolationMode = InterpolationMode.High;

            var grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(grPath);

            using var brush = new SolidBrush(Color.Transparent);
            pevent.Graphics.FillEllipse(brush, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }

        public new ImageList ImageList = new()
        {
            ImageSize = new Size(32, 32),
            ColorDepth = ColorDepth.Depth32Bit
        };

        [DefaultValue(typeof(Color), "0xffffff")]
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        [DefaultValue(typeof(Color), "0x000000")]
        public new Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
    }
}
