using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseLinkLabel : LinkLabel
    {
        public BaseLinkLabel()
        {
            WireUpBaseLinkLabel();
        }

        private void WireUpBaseLinkLabel()
        {
            Margin = Padding.Empty;

            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
            ActiveLinkColor = Themes.Colors.Light.PrimaryVariant.ToColor();
            LinkColor = Themes.Colors.Light.PrimaryVariant.ToColor();
            VisitedLinkColor = Themes.Colors.Light.PrimaryVariant.ToColor();
            DisabledLinkColor = Color.FromArgb(85, 85, 85);
        }

        [DefaultValue(typeof(Padding), "0, 0, 0, 0")]
        public new Padding Margin
        {
            get => base.Margin;
            set => base.Margin = value;
        }

        [DefaultValue(typeof(Color), "0xFFFFFF")]
        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        [DefaultValue(typeof(Color), "0x000000")]
        public sealed override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }

        [DefaultValue(typeof(Color), "0x3700B3")]
        public new Color ActiveLinkColor
        {
            get => base.ActiveLinkColor;
            set => base.ActiveLinkColor = value;
        }

        [DefaultValue(typeof(Color), "0x3700B3")]
        public new Color LinkColor
        {
            get => base.LinkColor;
            set => base.LinkColor = value;
        }

        [DefaultValue(typeof(Color), "0x3700B3")]
        public new Color VisitedLinkColor
        {
            get => base.VisitedLinkColor;
            set => base.VisitedLinkColor = value;
        }

        [DefaultValue(typeof(Color), "65, 65, 65")]
        public new Color DisabledLinkColor
        {
            get => base.DisabledLinkColor;
            set => base.DisabledLinkColor = value;
        }
    }
}
