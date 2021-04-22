using System;

namespace Bookshelf.Utilities
{
    internal static class Themes
    {
        private static Theme _currentTheme = Theme.Light;

        public static Theme CurrentTheme
        {
            get => _currentTheme;
            set => OnThemeChangedEvent(value);
        }

        public static event EventHandler<Theme> ThemeChangedEvent;

        private static void OnThemeChangedEvent(Theme theme)
        {
            _currentTheme = theme;

            ThemeChangedEvent?.Invoke(null, _currentTheme);
        }

        public const string WindowSize = "916, 539";
        public const string ClientSize = "900, 500";

        public const string WindowSizeFixed = "366, 539";
        public const string ClientSizeFixed = "350, 500";

        public const string UserControlSize = "700, 460";

        public const string Font = "Tahoma, 12";

        public readonly struct Colors
        {
            public readonly struct Light
            {
                public const int Primary = 0x6200EE;
                public const int PrimaryVariant = 0x3700B3;
                public const int Secondary = 0x03DAC6;
                public const int SecondaryVariant = 0x018786;
                public const int Background = 0xFFFFFF;
                public const int Surface = 0xFFFFFF;
                public const int Error = 0xB00020;
                public const int Info = 0x2196F3;
                public const int Success = 0x4caf50;
                public const int Warning = 0xf9a825;
                public const int OnPrimary = 0xFFFFFF;
                public const int OnSecondary = 0x000000;
                public const int OnBackground = 0x000000;
                public const int OnSurface = 0x000000;
                public const int OnError = 0xFFFFFF;
                public const int OnInfo = 0xFFFFFF;
                public const int OnSuccess = 0xFFFFFF;
                public const int OnWarning = 0xFFFFFF;
            }

            public readonly struct Dark
            {
                public const int Primary = 0xBB86FC;
                public const int PrimaryVariant = 0x3700B3;
                public const int Secondary = 0x03DAC0;
                public const int SecondaryVariant = 0x03DAC6;
                public const int Background = 0x121212;
                public const int Surface = 0x121212;
                public const int Error = 0xCF6679;
                public const int Info = 0x2196F3;
                public const int Success = 0x4caf50;
                public const int Warning = 0xf9a825;
                public const int OnPrimary = 0x000000;
                public const int OnSecondary = 0x000000;
                public const int OnBackground = 0xFFFFFF;
                public const int OnSurface = 0xFFFFFF;
                public const int OnError = 0x000000;
                public const int OnInfo = 0x000000;
                public const int OnSuccess = 0x000000;
                public const int OnWarning = 0x000000;
            }
        }
    }

    internal enum Theme
    {
        Light,
        Dark
    }
}
