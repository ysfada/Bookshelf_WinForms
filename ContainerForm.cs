using Bookshelf.Components.Base;
using Bookshelf.Forms.Visitor;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf
{
    public partial class ContainerForm : BaseForm
    {
        private static ContainerForm _self;

        public ContainerForm()
        {
            InitializeComponent();

            WireUpContainerForm();
        }

        // Remove Screen Flickering Issue
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var handleParam = base.CreateParams;
        //        handleParam.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
        //        return handleParam;
        //    }
        //}

        private void WireUpContainerForm()
        {
            _self = this;

            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            AddForm(new SignInForm(), false);
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    break;
            }
        }

        public static void AddForm(Form child, bool resizable = true)
        {
            if (resizable)
            {
                _self.MinimumSize = Themes.WindowSize.ToSize();
                _self.MaximumSize = new Size(0, 0);
                _self.Size = Themes.WindowSize.ToSize();
                _self.MaximizeBox = true;
                _self.StartPosition = FormStartPosition.Manual;
                _self.Location = new Point(
                    (Screen.PrimaryScreen.WorkingArea.Width - _self.Width) / 2,
                    (Screen.PrimaryScreen.WorkingArea.Height - _self.Height) / 2);

                child.MinimumSize = Themes.ClientSize.ToSize();
                child.MaximumSize = new Size(0, 0);
                child.Size = Themes.ClientSize.ToSize();
            }
            else
            {
                _self.WindowState = FormWindowState.Normal;
                _self.MinimumSize = Themes.WindowSizeFixed.ToSize();
                _self.MaximumSize = Themes.WindowSizeFixed.ToSize();
                _self.Size = Themes.WindowSizeFixed.ToSize();
                _self.StartPosition = FormStartPosition.Manual;
                _self.MaximizeBox = false;

                child.MinimumSize = Themes.ClientSizeFixed.ToSize();
                child.MaximumSize = Themes.ClientSizeFixed.ToSize();
                child.Size = Themes.ClientSizeFixed.ToSize();
            }

            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;

            _self.Controls.Clear();
            _self.Controls.Add(child);
            _self.Tag = child;
            _self.Text = $@"{Resource_Localization.TitleApp} -- {child.Text}";
            _self.StartPosition = FormStartPosition.CenterScreen;

            child.BringToFront();
            child.Show();
        }
    }
}
