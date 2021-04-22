using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookGivePage
{
    public class BtnPageBookGive : BtnSelected
    {
        public BtnPageBookGive()
        {
            WireUpBtnPageBookGive();
        }

        private void WireUpBtnPageBookGive()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookGiveDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookGive());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookGive;
            Refresh();
        }

        [DefaultValue(typeof(string), "Give book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookGive;
    }
}
