using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.UserSearchPage
{
    public class BtnPageUserSearch : BtnSelected
    {
        public BtnPageUserSearch()
        {
            WireUpBtnPageUserSearch();
        }

        private void WireUpBtnPageUserSearch()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.PersonSearchDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageUserSearch());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageUserSearch;
            Refresh();
        }

        [DefaultValue(typeof(string), "Search user")]
        public override string Text { get; set; } = Resource_Localization.btnPageUserSearch;
    }
}
