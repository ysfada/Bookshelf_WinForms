using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseButton : Button
    {
        public BaseButton()
        {
            WireUpBaseButton();
        }

        private void WireUpBaseButton()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Margin = Padding.Empty;

            BackColor = Themes.Colors.Light.Primary.ToColor();
            ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
        }

        [DefaultValue(typeof(AutoSizeMode), "0")]
        public new AutoSizeMode AutoSizeMode
        {
            get => base.AutoSizeMode;
            set => base.AutoSizeMode = value;
        }

        [DefaultValue(typeof(FlatStyle), "0")]
        public new FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set => base.FlatStyle = value;
        }

        [DefaultValue(typeof(Padding), "0, 0, 0, 0")]
        public new Padding Margin
        {
            get => base.Margin;
            set => base.Margin = value;
        }

        [DefaultValue(typeof(Color), "0x6200EE")]
        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        [DefaultValue(typeof(Color), "0xFFFFFF")]
        public sealed override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
    }
}
