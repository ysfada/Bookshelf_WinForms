using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Drawing;
using System.Globalization;

namespace Bookshelf.Forms.Admin
{
    public partial class AdminForm : BaseForm
    {
        public AdminForm()
        {
            InitializeComponent();

            WireUpAdminForm();
        }

        private void WireUpAdminForm()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            //btnPageHome.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookGive.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookTake.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookSearch.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookAdd.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookRemove.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageBookEdit.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageUserSearch.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageUserAdd.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageUserRemove.Width = 190 - SystemInformation.VerticalScrollBarWidth;
            //btnPageUserEdit.Width = 190 - SystemInformation.VerticalScrollBarWidth;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnPageHome.PerformClick();
        }

        private void AdminForm_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Text = $@"{Resource_Localization.TitleApp} -- {Text}";
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            var oldText = Resource_Localization.ResourceManager.GetString(
                "TitleAdmin",
                CultureInfo.GetCultureInfo(Localization.CurrentLanguage == Localization.English
                    ? Localization.Turkish
                    : Localization.English));
            var newText = Resource_Localization.TitleAdmin;
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

                    btnPageUserAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

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

                    btnPageUserAdd.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageUserAdd.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    btnPageUserRemove.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnPageUserRemove.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

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

                    btnPageUserAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    btnPageUserEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnPageUserEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    pnlMain.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlMain.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }

        private void pnlNavigation_Resize(object sender, EventArgs e)
        {
            if (pnlNavigation.VerticalScroll.Visible)
            {
                btnPageHome.Location = new Point(5, 0);
                btnPageBookGive.Location = new Point(5, 51);
                btnPageBookTake.Location = new Point(5, 102);
                btnPageBookSearch.Location = new Point(5, 153);
                btnPageBookAdd.Location = new Point(5, 204);
                btnPageBookRemove.Location = new Point(5, 255);
                btnPageBookEdit.Location = new Point(5, 306);
                btnPageUserSearch.Location = new Point(5, 357);
                btnPageUserAdd.Location = new Point(5, 408);
                btnPageUserRemove.Location = new Point(5, 459);
                btnPageUserEdit.Location = new Point(5, 510);
            }
            else if (pnlNavigation.Height >= 560)
            {
                pnlNavigation.AutoScroll = false;

                if (btnPageHome.Width == 173)
                {
                    btnPageHome.Width = 190;
                    btnPageBookGive.Width = 190;
                    btnPageBookTake.Width = 190;
                    btnPageBookSearch.Width = 190;
                    btnPageBookAdd.Width = 190;
                    btnPageBookRemove.Width = 190;
                    btnPageBookEdit.Width = 190;
                    btnPageUserSearch.Width = 190;
                    btnPageUserAdd.Width = 190;
                    btnPageUserRemove.Width = 190;
                    btnPageUserEdit.Width = 190;
                }

                var spacing = (pnlNavigation.Height - 560) / 2;

                btnPageHome.Location = new Point(5, 0 + spacing);
                btnPageBookGive.Location = new Point(5, 51 + spacing);
                btnPageBookTake.Location = new Point(5, 102 + spacing);
                btnPageBookSearch.Location = new Point(5, 153 + spacing);
                btnPageBookAdd.Location = new Point(5, 204 + spacing);
                btnPageBookRemove.Location = new Point(5, 255 + spacing);
                btnPageBookEdit.Location = new Point(5, 306 + spacing);
                btnPageUserSearch.Location = new Point(5, 357 + spacing);
                btnPageUserAdd.Location = new Point(5, 408 + spacing);
                btnPageUserRemove.Location = new Point(5, 459 + spacing);
                btnPageUserEdit.Location = new Point(5, 510 + spacing);
            }
            else
            {
                pnlNavigation.AutoScroll = true;

                btnPageHome.Width = 173;
                btnPageBookGive.Width = 173;
                btnPageBookTake.Width = 173;
                btnPageBookSearch.Width = 173;
                btnPageBookAdd.Width = 173;
                btnPageBookRemove.Width = 173;
                btnPageBookEdit.Width = 173;
                btnPageUserSearch.Width = 173;
                btnPageUserAdd.Width = 173;
                btnPageUserRemove.Width = 173;
                btnPageUserEdit.Width = 173;
            }
        }
    }
}
