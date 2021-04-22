using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.HomePage
{
    public class BtnPageHome : BtnSelected
    {
        public BtnPageHome()
        {
            WireUpBtnPageHome();
        }

        private void WireUpBtnPageHome()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.HomeDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageHome());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageHome;
            Refresh();
        }

        [DefaultValue(typeof(string), "Home page")]
        public override string Text { get; set; } = Resource_Localization.btnPageHome;
    }
}
