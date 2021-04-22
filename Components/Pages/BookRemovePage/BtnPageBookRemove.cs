using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookRemovePage
{
    public class BtnPageBookRemove : BtnSelected
    {
        public BtnPageBookRemove()
        {
            WireUpBtnPageBookRemove();
        }

        private void WireUpBtnPageBookRemove()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookRemoveDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookRemove());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookRemove;
            Refresh();
        }

        [DefaultValue(typeof(string), "Remove book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookRemove;
    }
}
