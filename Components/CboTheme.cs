using Bookshelf.Components.Base;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Globalization;

namespace Bookshelf.Components
{
    public class CboTheme : BaseComboBox
    {
        public CboTheme()
        {
            WireUpCboTheme();
        }

        private void WireUpCboTheme()
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
                case 0 when Themes.CurrentTheme != Theme.Light:
                    Themes.CurrentTheme = Theme.Light;
                    break;
                case 1 when Themes.CurrentTheme != Theme.Dark:
                    Themes.CurrentTheme = Theme.Dark;
                    break;
            }
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Items.Clear();
            foreach (var theme in Enum.GetNames(typeof(Theme)))
                Items.Add(Resource_Localization.ResourceManager.GetString(
                    $"Theme{theme}",
                    CultureInfo.GetCultureInfo(Localization.CurrentLanguage))!);

            SelectedIndex = (int) Themes.CurrentTheme;
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