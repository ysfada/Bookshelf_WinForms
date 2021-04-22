﻿using Bookshelf.Components.Base;
using Bookshelf.Database.Repositories;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Bookshelf.Components.Pages.UserSearchPage
{
    public partial class CtlPageUserSearch : BaseUserControl
    {
        public CtlPageUserSearch()
        {
            InitializeComponent();

            WireUpCtlPageUserSearch();
        }

        private void CtlPageUserSearch_Load(object sender, EventArgs e)
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

        private void WireUpCtlPageUserSearch()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageUserSearch;
            if (ParentForm != null) ParentForm.Text = Text;

            txtUserSearch.PlaceholderText = Resource_Localization.txtUserSearch;
            btnUserSearch.Text = Resource_Localization.WordSearch;

            btnClear.Text = Resource_Localization.btnClear;

            LocalizeDataGridView();
        }

        private void LocalizeDataGridView()
        {
            var dataGridView = ((DataGridView) ctlDataGridView.Controls["dataGridView"]);

            if (dataGridView.Columns.Count <= 0) return;

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

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

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

                    btnClear.BackColor = Themes.Colors.Dark.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Dark.OnSecondary.ToColor();

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

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    break;
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            _page = 1;
            _searchText = null;
            txtUserSearch.Clear();
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
    }
}