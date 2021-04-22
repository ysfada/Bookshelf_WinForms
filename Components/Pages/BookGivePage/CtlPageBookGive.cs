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

namespace Bookshelf.Components.Pages.BookGivePage
{
    public partial class CtlPageBookGive : BaseUserControl
    {
        public CtlPageBookGive()
        {
            InitializeComponent();

            WireUpCtlPageBookGive();
        }

        private void CtlPageBookGive_Load(object sender, EventArgs e)
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

        private void WireUpCtlPageBookGive()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            cboDays.SelectedIndex = 2;
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageBookGive;
            if (ParentForm != null) ParentForm.Text = Text;

            txtUserSearch.PlaceholderText = Resource_Localization.txtUserSearch;
            btnUserSearch.Text = Resource_Localization.WordSearch;

            txtBookSearch.PlaceholderText = Resource_Localization.txtBookSearch;
            btnBookSearch.Text = Resource_Localization.WordSearch;

            txtUserId.PlaceholderText = Resource_Localization.txtUserId;
            txtBookId.PlaceholderText = Resource_Localization.txtBookId;

            lblDays.Text = Resource_Localization.lblDays;

            lblDueDate.Text = Resource_Localization.lblDueDate;

            btnClear.Text = Resource_Localization.btnClear;

            btnGiveBook.Text = Resource_Localization.btnGiveBook;

            LocalizeDataGridView();
        }

        private void LocalizeDataGridView()
        {
            var dataGridView = ((DataGridView) ctlDataGridView.Controls["dataGridView"]);

            if (dataGridView.Columns.Count <= 0) return;

            switch (_searchedFor)
            {
                case SearchedFor.User:
                    dataGridView.Columns[0].HeaderText = Resource_Localization.txtUserId;
                    dataGridView.Columns[1].HeaderText = Resource_Localization.txtUsername;
                    dataGridView.Columns[2].HeaderText = Resource_Localization.txtEmail;
                    dataGridView.Columns[3].HeaderText = Resource_Localization.txtFirstName;
                    dataGridView.Columns[4].HeaderText = Resource_Localization.txtLastName;
                    dataGridView.Columns[5].HeaderText = Resource_Localization.txtPhone;
                    dataGridView.Columns[6].HeaderText = Resource_Localization.txtAddress;
                    dataGridView.Columns[7].HeaderText = Resource_Localization.lblRole;

                    if (dataGridView.Rows.Count <= 0) return;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                        row.Cells[7].Value = Resource_Localization.ResourceManager.GetString(
                            $"Role{row.Cells[7].Tag}",
                            CultureInfo.GetCultureInfo(Localization.CurrentLanguage));
                    break;
                case SearchedFor.Book:
                    dataGridView.Columns[0].HeaderText = Resource_Localization.txtBookId;
                    dataGridView.Columns[1].HeaderText = Resource_Localization.txtBookName;
                    dataGridView.Columns[2].HeaderText = Resource_Localization.txtPages;
                    dataGridView.Columns[3].HeaderText = Resource_Localization.txtPublishedAt;
                    dataGridView.Columns[4].HeaderText = Resource_Localization.txtEdition;
                    dataGridView.Columns[5].HeaderText = Resource_Localization.txtAuthor;
                    dataGridView.Columns[6].HeaderText = Resource_Localization.lblGenre;
                    dataGridView.Columns[7].HeaderText = Resource_Localization.lblBorrowed;

                    if (dataGridView.Rows.Count <= 0) return;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                        row.Cells[6].Value = Resource_Localization.ResourceManager.GetString(
                            $"Genre{row.Cells[6].Tag}",
                            CultureInfo.GetCultureInfo(Localization.CurrentLanguage));
                    break;
                case SearchedFor.BookIssue:
                    dataGridView.Columns[0].HeaderText = Resource_Localization.txtBookIssueId;
                    dataGridView.Columns[1].HeaderText = Resource_Localization.txtUserId;
                    dataGridView.Columns[2].HeaderText = Resource_Localization.txtUsername;
                    dataGridView.Columns[3].HeaderText = Resource_Localization.txtBookId;
                    dataGridView.Columns[4].HeaderText = Resource_Localization.txtBookName;
                    dataGridView.Columns[5].HeaderText = Resource_Localization.txtIssuerId;
                    dataGridView.Columns[6].HeaderText = Resource_Localization.txtIssuerUsername;
                    dataGridView.Columns[7].HeaderText = Resource_Localization.txtReceiverId;
                    dataGridView.Columns[8].HeaderText = Resource_Localization.txtReceiverUsername;
                    dataGridView.Columns[9].HeaderText = Resource_Localization.lblIssuedAt;
                    dataGridView.Columns[10].HeaderText = Resource_Localization.lblDueDate;
                    dataGridView.Columns[11].HeaderText = Resource_Localization.lblReturnedAt;
                    dataGridView.Columns[12].HeaderText = Resource_Localization.lblReturned;
                    break;
            }
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

                    txtBookSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    lblDays.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblDays.ForeColor = Color.Gray;
                    cboDays.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboDays.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblDueDate.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblDueDate.ForeColor = Color.Gray;

                    txtDueDate.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtDueDate.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtDueDate.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtDueDate.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnGiveBook.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnGiveBook.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
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

                    txtBookSearch.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    lblDays.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblDays.ForeColor = Color.Gray;
                    cboDays.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboDays.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    lblDueDate.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblDueDate.ForeColor = Color.Gray;

                    txtDueDate.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtDueDate.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtDueDate.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtDueDate.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    btnClear.BackColor = Themes.Colors.Dark.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Dark.OnSecondary.ToColor();

                    btnGiveBook.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnGiveBook.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();
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

                    txtBookSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtUserId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtUserId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtUserId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    lblDays.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblDays.ForeColor = Color.Gray;
                    cboDays.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboDays.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    lblDueDate.BackColor = Themes.Colors.Light.Primary.ToColor();
                    lblDueDate.ForeColor = Color.Gray;

                    txtDueDate.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtDueDate.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtDueDate.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtDueDate.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnGiveBook.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnGiveBook.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
            }
        }

        private SearchedFor _searchedFor = SearchedFor.None;

        private void ctlDataGridView_OnRowEnter(object sender, EventArgs e)
        {
            var table = (DataGridView) ctlDataGridView.Controls["dataGridView"];
            if (table.SelectedCells.Count <= 0) return;

            var selectedRowIndex = table.SelectedCells[0].RowIndex;
            var selectedRow = table.Rows[selectedRowIndex];

            switch (_searchedFor)
            {
                case SearchedFor.User:
                    txtUserId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                    break;
                case SearchedFor.Book:
                    txtBookId.Text = Convert.ToString(selectedRow.Cells[0].Value);
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

            switch (_searchedFor)
            {
                case SearchedFor.User:
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        var users = await UserRepository.SearchAsync(_searchText, radbUserAZ.Checked, _page,
                            ctlDataGridView.PageLimit());

                        ctlDataGridView.PopulateDataGridView(users, true);
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

                    break;
                case SearchedFor.Book:
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        var books = await BookRepository.SearchAsync(_searchText, radbBookAZ.Checked, _page,
                            ctlDataGridView.PageLimit(), false, true);

                        ctlDataGridView.PopulateDataGridView(books, true);
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

                    break;
                case SearchedFor.BookIssue:
                    break;
                case SearchedFor.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            LocalizeDataGridView();
        }

        private async void ctlDataGridView_OnNextPage(object sender, EventArgs e)
        {
            if (_searchText.IsNullOrEmpty()) return;

            _page++;
            ctlDataGridView.EnableBtnPreviousPage();

            switch (_searchedFor)
            {
                case SearchedFor.User:
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

                    break;
                case SearchedFor.Book:
                    try
                    {
                        Cursor = Cursors.WaitCursor;

                        var books = await BookRepository.SearchAsync(_searchText, radbBookAZ.Checked, _page,
                            ctlDataGridView.PageLimit(), false, true);

                        if (books.Count < 1)
                        {
                            _page--;
                            ctlDataGridView.DisableBtnNextPage();
                            return;
                        }

                        ctlDataGridView.PopulateDataGridView(books, true);
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

                    break;
                case SearchedFor.BookIssue:
                    break;
                case SearchedFor.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            LocalizeDataGridView();
        }

        private void txtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnUserSearch_Click(this, new EventArgs());
        }

        private void txtBookSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnBookSearch_Click(this, new EventArgs());
        }

        private async void btnUserSearch_Click(object sender, EventArgs e)
        {
            _searchedFor = SearchedFor.User;

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

                    ctlDataGridView.PopulateDataGridView(users, true, true);
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

        private async void btnBookSearch_Click(object sender, EventArgs e)
        {
            _searchedFor = SearchedFor.Book;

            var searchText = txtBookSearch.Text;
            _searchText = searchText;
            _page = 1;

            if (searchText.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var books = await BookRepository.SearchAsync(searchText, radbBookAZ.Checked, 1,
                    ctlDataGridView.PageLimit(), false, true);

                if (books.Count > 0)
                {
                    ctlDataGridView.EnableBtnPreviousPage();
                    ctlDataGridView.EnableBtnNextPage();

                    ctlDataGridView.PopulateDataGridView(books, true, true);
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

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGiveBook_Click(this, new EventArgs());
        }

        private void txtBookId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGiveBook_Click(this, new EventArgs());
        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            cboDays.Focus();
        }

        private void cboDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDueDate.Text = DateTime.Now.AddDays(int.Parse((string) cboDays.SelectedItem)).ToString("d");
        }

        private void lblDueDate_Click(object sender, EventArgs e)
        {
            txtDueDate.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _page = 1;
            _searchText = null;
            txtUserSearch.Clear();
            txtBookSearch.Clear();
            txtUserId.Clear();
            txtBookId.Clear();
            cboDays.SelectedIndex = 2;
        }

        private async void btnGiveBook_Click(object sender, EventArgs e)
        {
            _searchedFor = SearchedFor.BookIssue;

            var userId = txtUserId.Text;
            var bookId = txtBookId.Text;
            //var days = int.Parse((string) cboDays.SelectedItem);
            var dueDate = txtDueDate.Text;

            if (userId.IsNullOrEmpty() || bookId.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var bookIssue = new BookIssueEntity()
                {
                    Id = Guid.Parse(bookId),
                    UserId = Guid.Parse(userId),
                    BookId = Guid.Parse(bookId),
                    IssuerId = Store.CurrentUser.Id,
                    DueDate = DateTime.Parse(dueDate)
                };

                var createdBookIssue = await BookIssueRepository.GiveBookAsync(bookIssue);

                ctlDataGridView.PopulateDataGridView(createdBookIssue, true, true);

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

    internal enum SearchedFor
    {
        None,
        User,
        Book,
        BookIssue
    }
}