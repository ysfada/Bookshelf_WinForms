using Bookshelf.Components.Custom;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;

namespace Bookshelf.Components.Pages.ReportPage
{
    public class BtnPageReport : BtnSelected
    {
        public BtnPageReport()
        {
            WireUpBtnPageReport();
        }

        private void WireUpBtnPageReport()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;

            ImageList.Images.Add(Resources.ReportDark);
            Image = ImageList.Images[0];

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
        }

        protected override void OnClick(EventArgs e)
        {
            if (CurrentBtn != null && CurrentBtn.Equals(this)) return;

            FindForm().AddControlTo(ControlName, new CtlPageReport());

            base.OnClick(e);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.btnPageReport;
            Refresh();
        }

        [DefaultValue(typeof(string), "Report page")]
        public override string Text { get; set; } = Resource_Localization.btnPageReport;
    }
}
