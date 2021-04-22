using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.UserEditPage
{
    public class BtnPageUserEdit : BtnSelected
    {
        public BtnPageUserEdit()
        {
            WireUpBtnPageUserEdit();
        }

        private void WireUpBtnPageUserEdit()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.PersonEditDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageUserEdit());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageUserEdit;
            Refresh();
        }

        [DefaultValue(typeof(string), "Edit User")]
        public override string Text { get; set; } = Resource_Localization.btnPageUserEdit;
    }
}
