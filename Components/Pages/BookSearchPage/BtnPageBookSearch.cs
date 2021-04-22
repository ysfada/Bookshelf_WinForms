using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookSearchPage
{
    public class BtnPageBookSearch : BtnSelected
    {
        public BtnPageBookSearch()
        {
            WireUpBtnPageBookSearch();
        }

        private void WireUpBtnPageBookSearch()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookSearchDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookSearch());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookSearch;
            Refresh();
        }

        [DefaultValue(typeof(string), "Search book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookSearch;
    }
}
