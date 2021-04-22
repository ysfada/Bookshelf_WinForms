using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookTakePage
{
    public class BtnPageBookTake : BtnSelected
    {
        public BtnPageBookTake()
        {
            WireUpBtnPageBookTake();
        }

        private void WireUpBtnPageBookTake()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookGiveDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookTake());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookTake;
            Refresh();
        }

        [DefaultValue(typeof(string), "Take book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookTake;
    }
}
