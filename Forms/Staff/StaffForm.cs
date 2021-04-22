using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Globalization;

namespace Bookshelf.Forms.Staff
{
    public partial class StaffForm : BaseForm
    {
        public StaffForm()
        {
            InitializeComponent();

            WireUpStaffForm();
        }

        private void WireUpStaffForm()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            btnPageHome.PerformClick();
        }

        private void StaffForm_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Text = $@"{Resource_Localization.TitleApp} -- {Text}";
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            var oldText = Resource_Localization.ResourceManager.GetString(
                "TitleStaff",
                CultureInfo.GetCultureInfo(Localization.CurrentLanguage == Localization.English
                    ? Localization.Turkish
                    : Localization.English));
            var newText = Resource_Localization.TitleStaff;
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

                    btnPageBookGive.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookGive.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookTake.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookTake.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

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

                    btnPageBookGive.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookGive.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookTake.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookTake.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookAdd.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookAdd.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookRemove.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookRemove.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageBookEdit.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageBookEdit.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageUserSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageUserSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageUserEdit.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageUserEdit.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

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

                    btnPageBookGive.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookGive.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookTake.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookTake.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageBookEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageBookEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    pnlMain.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlMain.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }
    }
}
