using Bookshelf.Components.Base;
using Bookshelf.Database.Entities;
using Bookshelf.Database.Repositories;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bookshelf.Components.Pages.UserAddPage
{
    public partial class CtlPageUserAdd : BaseUserControl
    {
        public CtlPageUserAdd()
        {
            InitializeComponent();

            WireUpCtlPageUserAdd();
        }

        private void CtlPageUserAdd_Load(object sender, EventArgs e)
        {
            pnlContainer.Focus();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            pnlContainer.Focus();
        }

        private void WireUpCtlPageUserAdd()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            cboRole.SelectedIndex = (int) Role.User;
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageUserAdd;
            if (ParentForm != null) ParentForm.Text = Text;

            txtUsername.PlaceholderText = Resource_Localization.txtUsername;
            txtEmail.PlaceholderText = Resource_Localization.txtEmail;
            txtPassword.PlaceholderText = Resource_Localization.txtPassword;
            txtFirstName.PlaceholderText = Resource_Localization.txtFirstName;
            txtLastName.PlaceholderText = Resource_Localization.txtLastName;
            txtPhone.PlaceholderText = Resource_Localization.txtPhone;
            txtAddress.PlaceholderText = Resource_Localization.txtAddress;
            lblRole.Text = Resource_Localization.lblRole;

            btnClear.Text = Resource_Localization.btnClear;
            btnAdd.Text = Resource_Localization.WordAdd;

            var cboRoleSelectedIndex = cboRole.SelectedIndex;
            cboRole.Items.Clear();
            foreach (var role in Enum.GetNames(typeof(Role)))
                cboRole.Items.Add(Resource_Localization.ResourceManager.GetString(
                    $"Role{role}",
                    CultureInfo.GetCultureInfo(Localization.CurrentLanguage))!);
            cboRole.SelectedIndex = cboRoleSelectedIndex;

            LocalizeDataGridView();
        }

        private void LocalizeDataGridView()
        {
            var dataGridView = ((DataGridView) ctlDataGridView.Controls["dataGridView"]);

            if (dataGridView.Rows.Count <= 0) return;

            dataGridView.Columns[0].HeaderText = Resource_Localization.txtUserId;
            dataGridView.Columns[1].HeaderText = Resource_Localization.txtUsername;
            dataGridView.Columns[2].HeaderText = Resource_Localization.txtEmail;
            dataGridView.Columns[3].HeaderText = Resource_Localization.txtFirstName;
            dataGridView.Columns[4].HeaderText = Resource_Localization.txtLastName;
            dataGridView.Columns[5].HeaderText = Resource_Localization.txtPhone;
            dataGridView.Columns[6].HeaderText = Resource_Localization.txtAddress;
            dataGridView.Columns[7].HeaderText = Resource_Localization.lblRole;

            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells[7].Value = Resource_Localization.ResourceManager.GetString(
                    $"Role{row.Cells[7].Tag}",
                    CultureInfo.GetCultureInfo(Localization.CurrentLanguage));
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

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

                    lblRole.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblRole.ForeColor = Color.Gray;

                    cboRole.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboRole.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

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

                    lblRole.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblRole.ForeColor = Color.Gray;

                    cboRole.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboRole.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnClear.BackColor = Themes.Colors.Dark.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Dark.OnSecondary.ToColor();

                    btnAdd.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

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

                    lblRole.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblRole.ForeColor = Color.Gray;

                    cboRole.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboRole.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {
            cboRole.Focus();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Store.CurrentUser.Role != Role.Admin) cboRole.SelectedIndex = (int) Role.User;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboRole.SelectedIndex = (int) Role.User;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;
            var role = (Role) cboRole.SelectedIndex;

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
                    Role = role
                };

                var createdUser = await UserRepository.CreateAsync(user);

                ctlDataGridView.PopulateDataGridView(createdUser);

                LocalizeDataGridView();

                btnClear.PerformClick();
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
    }
}