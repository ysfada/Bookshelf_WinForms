using Bookshelf.Components.Base;
using Bookshelf.Database.Entities;
using Bookshelf.Database.Repositories;
using Bookshelf.Forms.Admin;
using Bookshelf.Forms.Staff;
using Bookshelf.Forms.User;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bookshelf.Forms.Visitor
{
    public partial class SignInForm : BaseForm
    {
        public SignInForm()
        {
            InitializeComponent();

            WireUpSignInForm();
        }

        private void WireUpSignInForm()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void SignInForm_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Text = $@"{Resource_Localization.TitleApp} -- {Text}";
        }

        private void SignInForm_Click(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void lblSignInTitle_Click(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void FocusOnTitle()
        {
            lblSignInTitle.Select();
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.TitleSignIn;
            lblSignInTitle.Text = Resource_Localization.lblSignInTitle;
            txtUsername.PlaceholderText = Resource_Localization.txtUsername;
            txtPassword.PlaceholderText = Resource_Localization.txtPassword;
            btnSignIn.Text = Resource_Localization.btnSignIn;
            lnkSignUp.Text = Resource_Localization.lnkSignUp;
            lnkVisitor.Text = Resource_Localization.lnkVisitor;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblSignInTitle.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblSignInTitle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnSignIn.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnSignIn.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    lnkSignUp.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkSignUp.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();

                    lnkVisitor.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkVisitor.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblSignInTitle.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblSignInTitle.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    btnSignIn.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnSignIn.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    lnkSignUp.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lnkSignUp.ForeColor = Themes.Colors.Dark.PrimaryVariant.ToColor();

                    lnkVisitor.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lnkVisitor.ForeColor = Themes.Colors.Dark.PrimaryVariant.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboLanguage.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboLanguage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    cboTheme.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboTheme.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblSignInTitle.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblSignInTitle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnSignIn.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnSignIn.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    lnkSignUp.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkSignUp.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();

                    lnkVisitor.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkVisitor.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();
                    break;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.UnderlineColor = Themes.CurrentTheme switch
            {
                Theme.Light => Themes.Colors.Light.OnBackground.ToColor(),
                Theme.Dark => Themes.Colors.Dark.OnBackground.ToColor(),
                _ => Themes.Colors.Light.OnBackground.ToColor()
            };
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UnderlineColor = Themes.CurrentTheme switch
            {
                Theme.Light => Themes.Colors.Light.OnBackground.ToColor(),
                Theme.Dark => Themes.Colors.Dark.OnBackground.ToColor(),
                _ => Themes.Colors.Light.OnBackground.ToColor()
            };
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (username.IsNullOrEmpty())
                txtUsername.UnderlineColor = Themes.CurrentTheme switch
                {
                    Theme.Light => Themes.Colors.Light.Error.ToColor(),
                    Theme.Dark => Themes.Colors.Dark.Error.ToColor(),
                    _ => Themes.Colors.Light.Error.ToColor()
                };

            if (password.IsNullOrEmpty())
                txtPassword.UnderlineColor = Themes.CurrentTheme switch
                {
                    Theme.Light => Themes.Colors.Light.Error.ToColor(),
                    Theme.Dark => Themes.Colors.Dark.Error.ToColor(),
                    _ => Themes.Colors.Light.Error.ToColor()
                };

            if (username.IsNullOrEmpty() || password.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var where = new Dictionary<string, string>()
                {
                    {"Username", username}
                };
                //var user = UserRepository.Find(where, true);
                var user = await UserRepository.FindAsync(where, true);

                if (user == null || !(await Hash.CompareAsync(password, user.Password)))
                {
                    MessageBox.Show(Resource_Localization.ErrorIncorrectCredentials);
                    return;
                }

                Store.CurrentUser = user;

                BaseForm yetkiForm = user.Role switch
                {
                    Role.Admin => new AdminForm(),
                    Role.Staff => new StaffForm(),
                    Role.User => new UserForm(),
                    Role.Visitor => new VisitorForm(),
                    _ => new VisitorForm()
                };
                ContainerForm.AddForm(yetkiForm);
                Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                MessageBox.Show(Resource_Localization.ErrorUnknown);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContainerForm.AddForm(new SignUpForm(), false);
            Close();
        }

        private void lnkVisitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContainerForm.AddForm(new VisitorForm());
            Close();
        }
    }
}
