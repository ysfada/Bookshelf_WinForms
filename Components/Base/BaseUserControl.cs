using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            WireUpBaseUserControl();
        }

        private void WireUpBaseUserControl()
        {
            ClientSize = Themes.UserControlSize.ToSize();
            Font = Themes.Font.ToFont();
            DoubleBuffered = true;
            Margin = Padding.Empty;

            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
        }

        [DefaultValue(typeof(Size), Themes.UserControlSize)]
        public new Size ClientSize
        {
            get => base.ClientSize;
            set => base.ClientSize = value;
        }

        [DefaultValue(typeof(Font), Themes.Font)]
        public sealed override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }

        [DefaultValue(typeof(bool), "1")]
        protected sealed override bool DoubleBuffered
        {
            get => base.DoubleBuffered;
            set => base.DoubleBuffered = value;
        }

        [DefaultValue(typeof(Padding), "0, 0, 0, 0")]
        public new Padding Margin
        {
            get => base.Margin;
            set => base.Margin = value;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public sealed override string Text { get; set; } = string.Empty;

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
