using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.UserAddPage
{
    public class BtnPageUserAdd : BtnSelected
    {
        public BtnPageUserAdd()
        {
            WireUpBtnPageUserAdd();
        }

        private void WireUpBtnPageUserAdd()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.PersonAddDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageUserAdd());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageUserAdd;
            Refresh();
        }

        [DefaultValue(typeof(string), "Add user")]
        public override string Text { get; set; } = Resource_Localization.btnPageUserAdd;
    }
}
