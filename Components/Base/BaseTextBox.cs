using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseTextBox : TextBox
    {
        protected BaseTextBox()
        {
            WireUpBaseTextBox();
        }

        private void WireUpBaseTextBox()
        {
            Margin = Padding.Empty;

            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
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
    }
}
