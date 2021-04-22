using Bookshelf.Components.Custom;
using Bookshelf.Forms.Visitor;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components
{
    public class BtnSignOut : BtnRound
    {
        public BtnSignOut()
        {
            WireUpBtnRound();
        }

        private void WireUpBtnRound()
        {
            Size = new Size(40, 40);
            ImageList.Images.Add(Resources.SignOutLight);
            ImageList.Images.Add(Resources.SignOutDark);
            Image = ImageList.Images[0];

            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    Image = ImageList.Images[0];
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    Image = ImageList.Images[1];
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    Image = ImageList.Images[0];
                    break;
            }
        }

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }

        private bool _isOnPaintCalled;

        // NOTE: This is needed because initial load does not changes background color.
        // If app starts with dark mode, BtnSignOut background stays light.
        // On light theme there is no issue on start up.
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // NOTE: This check is needed to prevent infinite call to OnPaint
            if (_isOnPaintCalled) return;

            _isOnPaintCalled = true;
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        protected override void OnClick(EventArgs e)
        {
            Store.CurrentUser = null;
            ContainerForm.AddForm(new SignInForm(), false);

            base.OnClick(e);
        }

        [DefaultValue(typeof(Size), "40, 40")]
        public new Size Size
        {
            get => base.Size;
            set => base.Size = value;
        }
    }
}
