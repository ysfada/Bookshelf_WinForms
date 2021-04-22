using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Globalization;

namespace Bookshelf.Forms.Visitor
{
    public partial class VisitorForm : BaseForm
    {
        public VisitorForm()
        {
            InitializeComponent();

            WireUpVisitorForm();
        }

        private void WireUpVisitorForm()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void VisitorForm_Load(object sender, EventArgs e)
        {
            btnPageHome.PerformClick();
        }

        private void VisitorForm_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Text = $@"{Resource_Localization.TitleApp} -- {Text}";
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            var oldText = Resource_Localization.ResourceManager.GetString(
                "TitleVisitor",
                CultureInfo.GetCultureInfo(Localization.CurrentLanguage == Localization.English
                    ? Localization.Turkish
                    : Localization.English));
            var newText = Resource_Localization.TitleVisitor;
            if (Text == oldText || Text == newText) Text = newText;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    ctlHeader.BackColor = Themes.Colors.Light.Background.ToColor();
                    ctlHeader.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlNavigation.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlNavigation.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnPageHome.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageHome.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    pnlMain.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlMain.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    ctlHeader.BackColor = Themes.Colors.Dark.Background.ToColor();
                    ctlHeader.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlNavigation.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlNavigation.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnPageHome.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageHome.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    pnlMain.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlMain.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    ctlHeader.BackColor = Themes.Colors.Light.Background.ToColor();
                    ctlHeader.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlNavigation.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlNavigation.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnPageHome.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageHome.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    pnlMain.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlMain.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }
    }
}
