using Bookshelf.Components.Base;
using Bookshelf.Database.Entities;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;

namespace Bookshelf.Components
{
    public partial class CtlHeader : BaseUserControl
    {
        public CtlHeader()
        {
            InitializeComponent();

            WireUpCtlHeader();
        }

        private void WireUpCtlHeader()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (!Store.CurrentUser.FirstName.IsNullOrEmpty() && !Store.CurrentUser.LastName.IsNullOrEmpty())
                lblCurrentUser.Text = $@"{Store.CurrentUser.FirstName} {Store.CurrentUser.LastName} ({Store.CurrentUser.Username})";
            else
                lblCurrentUser.Text = Store.CurrentUser.Role == Role.Visitor ? Resource_Localization.RoleVisitor : Store.CurrentUser.Username;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblClock.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblClock.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblCurrentUser.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblCurrentUser.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblClock.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblClock.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblCurrentUser.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblCurrentUser.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblClock.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblClock.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblCurrentUser.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblCurrentUser.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
