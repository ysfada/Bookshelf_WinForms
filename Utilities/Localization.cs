using System;
using System.Globalization;
using System.Threading;

namespace Bookshelf.Utilities
{
    internal static class Localization
    {
        public const string English = "en-US";
        public const string Turkish = "tr-TR";

        private static string _currentLanguage = English;

        public static string CurrentLanguage
        {
            get => _currentLanguage;
            set => OnLanguageChangedEvent(value);
        }

        public static event EventHandler<string> LanguageChangedEvent;

        private static void OnLanguageChangedEvent(string language)
        {
            _currentLanguage = language switch
            {
                Turkish => Turkish,
                _ => English
            };

            var culture = CultureInfo.CreateSpecificCulture(_currentLanguage);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            LanguageChangedEvent?.Invoke(null, _currentLanguage);
        }
    }
}
