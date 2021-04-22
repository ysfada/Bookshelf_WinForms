using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookAddPage
{
    public class BtnPageBookAdd : BtnSelected
    {
        public BtnPageBookAdd()
        {
            WireUpBtnPageBookAdd();
        }

        private void WireUpBtnPageBookAdd()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookAddDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookAdd());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookAdd;
            Refresh();
        }

        [DefaultValue(typeof(string), "Add book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookAdd;
    }
}
