using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.BookEditPage
{
    public class BtnPageBookEdit : BtnSelected
    {
        public BtnPageBookEdit()
        {
            WireUpBtnPageBookEdit();
        }

        private void WireUpBtnPageBookEdit()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.BookEditDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageBookEdit());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageBookEdit;
            Refresh();
        }

        [DefaultValue(typeof(string), "Edit book")]
        public override string Text { get; set; } = Resource_Localization.btnPageBookEdit;
    }
}
