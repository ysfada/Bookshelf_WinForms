using Bookshelf.Utilities;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Base
{
    public class BaseComboBox : ComboBox
    {
        public BaseComboBox()
        {
            WireUpBaseComboBox();
        }

        private void WireUpBaseComboBox()
        {
            FlatStyle = FlatStyle.Popup;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Margin = Padding.Empty;

            BackColor = Themes.Colors.Light.Background.ToColor();
            ForeColor = Themes.Colors.Light.OnBackground.ToColor();
        }

        [DefaultValue(typeof(FlatStyle), "1")]
        public new FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set => base.FlatStyle = value;
        }

        [DefaultValue(typeof(ComboBoxStyle), "2")]
        public new ComboBoxStyle DropDownStyle
        {
            get => base.DropDownStyle;
            set => base.DropDownStyle = value;
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
