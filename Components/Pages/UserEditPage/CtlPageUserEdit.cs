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

namespace Bookshelf.Components.Pages.UserEditPage
{
    public partial class CtlPageUserEdit : BaseUserControl
    {
        public CtlPageUserEdit()
        {
            InitializeComponent();

            WireUpCtlPageUserEdit();
        }

        private void CtlPageUserEdit_Load(object sender, EventArgs e)
        {
            if (_searchText.IsNullOrEmpty())
            {
                ctlDataGridView.DisableBtnPreviousPage();
                ctlDataGridView.DisableBtnNextPage();
            }

            pnlContainer.Focus();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            pnlContainer.Focus();
        }

        private void WireUpCtlPageUserEdit()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            if (Store.CurrentUser.Role != Role.Admin) txtPassword.ReadOnly = true;

            cboRole.SelectedIndex = (int) Role.User;
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageUserEdit;
            if (ParentForm != null) ParentForm.Text = Text;

            txtUserSearch.PlaceholderText = Resource_Localization.txtUserSearch;
            btnUserSearch.Text = Resource_Localization.btnPageUserSearch;

            txtUserId.PlaceholderText = Resource_Localization.txtUserId;
            txtUsername.PlaceholderText = Resource_Localization.txtUsername;
            txtEmail.PlaceholderText = Resource_Localization.txtEmail;
            txtPassword.PlaceholderText = Resource_Localization.txtPassword;
            txtFirstName.PlaceholderText = Resource_Localization.txtFirstName;
            txtLastName.PlaceholderText = Resource_Localization.txtLastName;
            txtPhone.PlaceholderText = Resource_Localization.txtPhone;
            txtAddress.PlaceholderText = Resource_Localization.txtAddress;
            lblRole.Text = Resource_Localization.lblRole;

            btnClear.Text = Resource_Localization.btnClear;
            btnEdit.Text = Resource_Localization.WordEdit;

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

                    txtUserSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlUserOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlUserOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnUserSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnUserSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

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

                    btnEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    txtUserSearch.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtUserSearch.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserSearch.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserSearch.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    pnlUserOrder.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlUserOrder.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnUserSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnUserSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

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

                    btnEdit.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnEdit.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    txtUserSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlUserOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlUserOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnUserSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnUserSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

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

                    btnEdit.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnEdit.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
            }
        }

        private void ctlDataGridView_OnRowEnter(object sender, EventArgs e)
        {
            var table = (DataGridView) ctlDataGridView.Controls["dataGridView"];
            if (table.SelectedCells.Count <= 0) return;

            var selectedRowIndex = table.SelectedCells[0].RowIndex;
            var selectedRow = table.Rows[selectedRowIndex];

            txtUserId.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtUsername.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtEmail.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtFirstName.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtLastName.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtPhone.Text = Convert.ToString(selectedRow.Cells[5].Value);
            txtAddress.Text = Convert.ToString(selectedRow.Cells[6].Value);
            cboRole.SelectedIndex = (int) selectedRow.Cells[7].Tag;
        }

        private short _page = 1;
        private string _searchText;

        private async void ctlDataGridView_OnPreviousPage(object sender, EventArgs e)
        {
            ctlDataGridView.EnableBtnNextPage();

            if (_page < 2)
            {
                ctlDataGridView.DisableBtnPreviousPage();
                return;
            }

            _page--;

            if (_searchText.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var users = await UserRepository.SearchAsync(_searchText, radbUserAZ.Checked, _page,
                    ctlDataGridView.PageLimit());

                ctlDataGridView.PopulateDataGridView(users, true);

                LocalizeDataGridView();
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

        private async void ctlDataGridView_OnNextPage(object sender, EventArgs e)
        {
            if (_searchText.IsNullOrEmpty()) return;

            _page++;
            ctlDataGridView.EnableBtnPreviousPage();

            try
            {
                Cursor = Cursors.WaitCursor;

                var users = await UserRepository.SearchAsync(_searchText, radbUserAZ.Checked, _page,
                    ctlDataGridView.PageLimit());

                if (users.Count < 1)
                {
                    _page--;
                    ctlDataGridView.DisableBtnNextPage();
                    return;
                }

                ctlDataGridView.PopulateDataGridView(users, true);

                LocalizeDataGridView();
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

        private void txtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnUserSearch_Click(this, new EventArgs());
        }

        private async void btnUserSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtUserSearch.Text;
            _searchText = searchText;
            _page = 1;

            if (searchText.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var users = await UserRepository.SearchAsync(searchText, radbUserAZ.Checked, 1,
                    ctlDataGridView.PageLimit());

                if (users.Count > 0)
                {
                    ctlDataGridView.EnableBtnPreviousPage();
                    ctlDataGridView.EnableBtnNextPage();

                    ctlDataGridView.PopulateDataGridView(users, true);
                }
                else
                {
                    ctlDataGridView.ClearRows();
                }

                LocalizeDataGridView();
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
            _page = 1;
            _searchText = null;
            txtUserId.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboRole.SelectedIndex = (int) Role.User;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var userId = txtUserId.Text;
            var username = txtUsername.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var phone = txtPhone.Text;
            var address = txtAddress.Text;
            var role = (Role) cboRole.SelectedIndex;

            if (userId.IsNullOrEmpty() || username.IsNullOrEmpty() || email.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var user = new UserEntity
                {
                    Id = Guid.Parse(userId),
                    Username = username,
                    Email = email,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                    Address = address,
                    Role = role
                };

                var editedUser = await UserRepository.EditAsync(user);

                ctlDataGridView.PopulateDataGridView(editedUser, true);

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