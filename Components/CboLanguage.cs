using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Globalization;

namespace Bookshelf.Components
{
    public class CboLanguage : BaseComboBox
    {
        public CboLanguage()
        {
            WireUpCboLanguage();
        }

        private void WireUpCboLanguage()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectedIndex)
            {
                case 0 when Localization.CurrentLanguage != Localization.English:
                    Localization.CurrentLanguage = Localization.English;
                    break;
                case 1 when Localization.CurrentLanguage != Localization.Turkish:
                    Localization.CurrentLanguage = Localization.Turkish;
                    break;
            }
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Items.Clear();
            Items.Add(Resource_Localization.ResourceManager.GetString(
                $"Language{nameof(Localization.English)}",
                CultureInfo.GetCultureInfo(Localization.CurrentLanguage))!);
            Items.Add(Resource_Localization.ResourceManager.GetString(
                $"Language{nameof(Localization.Turkish)}",
                CultureInfo.GetCultureInfo(Localization.CurrentLanguage))!);

            SelectedIndex = Localization.CurrentLanguage == Localization.Turkish ? 1 : 0;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }
    }
}
