using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.UserRemovePage
{
    public class BtnPageUserRemove : BtnSelected
    {
        public BtnPageUserRemove()
        {
            WireUpBtnPageUserRemove();
        }

        private void WireUpBtnPageUserRemove()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.PersonRemoveDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageUserRemove());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageUserRemove;
            Refresh();
        }

        [DefaultValue(typeof(string), "Remove user")]
        public override string Text { get; set; } = Resource_Localization.btnPageUserRemove;
    }
}
