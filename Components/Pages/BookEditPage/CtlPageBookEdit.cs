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

namespace Bookshelf.Components.Pages.BookEditPage
{
    public partial class CtlPageBookEdit : BaseUserControl
    {
        public CtlPageBookEdit()
        {
            InitializeComponent();

            WireUpCtlPageBookEdit();
        }

        private void CtlPageBookEdit_Load(object sender, EventArgs e)
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

        private void WireUpCtlPageBookEdit()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);

            cboGenre.SelectedIndex = (int) Genre.Other;
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageBookEdit;
            if (ParentForm != null) ParentForm.Text = Text;

            txtBookSearch.PlaceholderText = Resource_Localization.txtBookSearch;
            btnBookSearch.Text = Resource_Localization.WordSearch;

            txtBookId.PlaceholderText = Resource_Localization.txtBookId;
            txtBookName.PlaceholderText = Resource_Localization.txtBookName;
            txtPages.PlaceholderText = Resource_Localization.txtPages;
            txtPublishedAt.PlaceholderText = Resource_Localization.txtPublishedAt;
            txtEdition.PlaceholderText = Resource_Localization.txtEdition;
            txtAuthor.PlaceholderText = Resource_Localization.txtAuthor;
            lblGenre.Text = Resource_Localization.lblGenre;

            btnClear.Text = Resource_Localization.btnClear;

            btnEdit.Text = Resource_Localization.WordEdit;

            var cboGenreSelectedIndex = cboGenre.SelectedIndex;
            cboGenre.Items.Clear();
            foreach (var genre in Enum.GetNames(typeof(Genre)))
                cboGenre.Items.Add(Resource_Localization.ResourceManager.GetString(
                    $"Genre{genre}",
                    CultureInfo.GetCultureInfo(Localization.CurrentLanguage))!);
            cboGenre.SelectedIndex = cboGenreSelectedIndex;

            LocalizeDataGridView();
        }

        private void LocalizeDataGridView()
        {
            var dataGridView = ((DataGridView) ctlDataGridView.Controls["dataGridView"]);

            if (dataGridView.Columns.Count <= 0) return;

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

                    txtBookSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtBookName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPages.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPages.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPages.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPages.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPublishedAt.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPublishedAt.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPublishedAt.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPublishedAt.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtEdition.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtEdition.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEdition.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEdition.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtAuthor.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtAuthor.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAuthor.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAuthor.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    lblGenre.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblGenre.ForeColor = Color.Gray;

                    cboGenre.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboGenre.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

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

                    txtBookSearch.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtBookName.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtBookName.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookName.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtBookName.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtPages.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtPages.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPages.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPages.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtPublishedAt.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtPublishedAt.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPublishedAt.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtPublishedAt.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtEdition.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtEdition.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtEdition.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtEdition.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    txtAuthor.BackColor = Themes.Colors.Dark.Background.ToColor();
                    txtAuthor.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtAuthor.UnderlineColor = Themes.Colors.Dark.OnBackground.ToColor();
                    txtAuthor.UnderlineFocusColor = Themes.Colors.Dark.Secondary.ToColor();

                    lblGenre.BackColor = Themes.Colors.Dark.Background.ToColor();
                    lblGenre.ForeColor = Color.Gray;

                    cboGenre.BackColor = Themes.Colors.Dark.Background.ToColor();
                    cboGenre.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

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

                    txtBookSearch.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookSearch.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookSearch.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    pnlBookOrder.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlBookOrder.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnBookSearch.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnBookSearch.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();

                    txtBookId.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookId.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookId.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtBookName.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtBookName.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookName.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtBookName.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPages.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPages.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPages.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPages.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtPublishedAt.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtPublishedAt.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPublishedAt.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtPublishedAt.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtEdition.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtEdition.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEdition.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtEdition.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    txtAuthor.BackColor = Themes.Colors.Light.Background.ToColor();
                    txtAuthor.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAuthor.UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
                    txtAuthor.UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();

                    lblGenre.BackColor = Themes.Colors.Light.Background.ToColor();
                    lblGenre.ForeColor = Color.Gray;

                    cboGenre.BackColor = Themes.Colors.Light.Background.ToColor();
                    cboGenre.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

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

            txtBookId.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtBookName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtPages.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtPublishedAt.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtEdition.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtAuthor.Text = Convert.ToString(selectedRow.Cells[5].Value);
            cboGenre.SelectedIndex = (int) selectedRow.Cells[6].Tag;
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

                var books = await BookRepository.SearchAsync(_searchText, radbBookAZ.Checked, _page,
                    ctlDataGridView.PageLimit());

                ctlDataGridView.PopulateDataGridView(books, true);

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

                var books = await BookRepository.SearchAsync(_searchText, radbBookAZ.Checked, _page,
                    ctlDataGridView.PageLimit());

                if (books.Count < 1)
                {
                    _page--;
                    ctlDataGridView.DisableBtnNextPage();
                    return;
                }

                ctlDataGridView.PopulateDataGridView(books, true);

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

        private void txtBookSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnBookSearch_Click(this, new EventArgs());
        }

        private async void btnBookSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtBookSearch.Text;
            _searchText = searchText;
            _page = 1;

            if (searchText.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var books = await BookRepository.SearchAsync(searchText, radbBookAZ.Checked, 1,
                    ctlDataGridView.PageLimit());

                if (books.Count > 0)
                {
                    ctlDataGridView.EnableBtnPreviousPage();
                    ctlDataGridView.EnableBtnNextPage();

                    ctlDataGridView.PopulateDataGridView(books, true);
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

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validator.IsDigit(e.KeyChar);
        }

        private void txtPublishedAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validator.IsDigit(e.KeyChar);
        }

        private void txtEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validator.IsDigit(e.KeyChar);
        }

        private void lblGenre_Click(object sender, EventArgs e)
        {
            cboGenre.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _page = 1;
            _searchText = null;
            txtBookSearch.Clear();
            txtBookId.Clear();
            txtBookName.Clear();
            txtPages.Clear();
            txtPublishedAt.Clear();
            txtEdition.Clear();
            txtAuthor.Clear();
            cboGenre.SelectedIndex = (int) Genre.Other;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var bookId = txtBookId.Text;
            var bookName = txtBookName.Text;
            var pages = txtPages.Text;
            var publishedAt = txtPublishedAt.Text;
            var edition = txtEdition.Text;
            var author = txtAuthor.Text;
            var genre = (Genre) cboGenre.SelectedIndex;

            if (bookId.IsNullOrEmpty() || bookName.IsNullOrEmpty() || author.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var book = new BookEntity
                {
                    Id = Guid.Parse(bookId),
                    BookName = bookName,
                    Pages = pages,
                    PublishedAt = publishedAt,
                    Edition = edition,
                    Author = author,
                    Genre = genre
                };

                var editedBook = await BookRepository.EditAsync(book);

                ctlDataGridView.PopulateDataGridView(editedBook, true);

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