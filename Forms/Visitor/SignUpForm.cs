using Bookshelf.Components.Base;
using Bookshelf.Database.Entities;
using Bookshelf.Database.Repositories;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bookshelf.Forms.Visitor
{
    public partial class SignUpForm : BaseForm
    {
        public SignUpForm()
        {
            InitializeComponent();

            WireUpSignUpForm();
        }

        private void WireUpSignUpForm()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void SignUpForm_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Text = $@"{Resource_Localization.TitleApp} -- {Text}";
        }

        private void SignUpForm_Click(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void lblSignUpTitle_Click(object sender, EventArgs e)
        {
            FocusOnTitle();
        }

        private void FocusOnTitle()
        {
            lblSignUpTitle.Select();
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            Text = Resource_Localization.TitleSignUp;
            lblSignUpTitle.Text = Resource_Localization.lblSignUpTitle;
            txtUsername.PlaceholderText = Resource_Localization.txtUsername;
            txtEmail.PlaceholderText = Resource_Localization.txtEmail;
            txtPassword.PlaceholderText = Resource_Localization.txtPassword;
            txtFirstName.PlaceholderText = Resource_Localization.txtFirstName;
            txtLastName.PlaceholderText = Resource_Localization.txtLastName;
            txtPhone.PlaceholderText = Resource_Localization.txtPhone;
            txtAddress.PlaceholderText = Resource_Localization.txtAddress;
            btnSignUp.Text = Resource_Localization.btnSignUp;
            lnkSignIn.Text = Resource_Localization.lnkSignIn;
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblSignUpTitle.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblSignUpTitle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtEmail.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtEmail.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEmail.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEmail.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtFirstName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtFirstName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtFirstName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtFirstName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtLastName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtLastName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtLastName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtLastName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPhone.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPhone.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPhone.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPhone.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtAddress.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtAddress.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAddress.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAddress.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnSignUp.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnSignUp.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    lnkSignIn.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkSignIn.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblSignUpTitle.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblSignUpTitle.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtEmail.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtEmail.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtEmail.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtEmail.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtFirstName.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtFirstName.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtFirstName.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtFirstName.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtLastName.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtLastName.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtLastName.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtLastName.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtPhone.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtPhone.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPhone.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPhone.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtAddress.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtAddress.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtAddress.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtAddress.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    btnSignUp.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnSignUp.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    lnkSignIn.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lnkSignIn.ForeColor = Themes.Colors.Dark.PrimaryVariant.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblSignUpTitle.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblSignUpTitle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    txtUsername.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUsername.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUsername.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtEmail.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtEmail.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEmail.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEmail.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPassword.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPassword.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPassword.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtFirstName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtFirstName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtFirstName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtFirstName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtLastName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtLastName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtLastName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtLastName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPhone.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPhone.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPhone.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPhone.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtAddress.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtAddress.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAddress.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAddress.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnSignUp.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnSignUp.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    lnkSignIn.BackColor = Themes.Colors.Light.Background.ToColor();
                    lnkSignIn.ForeColor = Themes.Colors.Light.PrimaryVariant.ToColor();
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.UnderlineColor = Themes.CurrentTheme switch
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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;

            if (username.IsNullOrEmpty())
                txtUsername.UnderlineColor = Themes.CurrentTheme switch
                {
                    Theme.Light => Themes.Colors.Light.Error.ToColor(),
                    Theme.Dark => Themes.Colors.Dark.Error.ToColor(),
                    _ => Themes.Colors.Light.Error.ToColor()
                };

            if (email.IsNullOrEmpty())
                txtEmail.UnderlineColor = Themes.CurrentTheme switch
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

            if (username.IsNullOrEmpty() || email.IsNullOrEmpty() || password.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var user = new UserEntity
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                    Address = address,
                    Role = Role.User
                };
                await UserRepository.CreateAsync(user);

                ContainerForm.AddForm(new SignInForm(), false);
                Close();
            }
            catch (SqlException exception) when (exception.Number == 2601)
            {
                Debug.WriteLine(exception.Message);
                // TODO: write localized error messages
                MessageBox.Show(exception.Message, "SQL exception (TODO: Localize)");
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

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContainerForm.AddForm(new SignInForm(), false);
            Close();
        }
    }
}