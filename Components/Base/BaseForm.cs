using Bookshelf.Properties;
using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseForm : Form
    {
        protected BaseForm()
        {
            WireUpBaseForm();
        }

        private void WireUpBaseForm()
        {
            ClientSize = Themes.ClientSize.ToSize();
            MinimumSize = Themes.WindowSize.ToSize();
            Font = Themes.Font.ToFont();
            DoubleBuffered = true;
            Icon = Resources.AppIconLight;

            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
        }

        [DefaultValue(typeof(Size), Themes.ClientSize)]
        public new Size ClientSize
        {
            get => base.ClientSize;
            set => base.ClientSize = value;
        }

        [DefaultValue(typeof(Size), Themes.WindowSize)]
        public sealed override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = value;
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