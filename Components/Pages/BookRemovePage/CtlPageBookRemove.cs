using Bookshelf.Components.Base;
using Bookshelf.Database.Repositories;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Bookshelf.Components.Pages.BookRemovePage
{
    public partial class CtlPageBookRemove : BaseUserControl
    {
        public CtlPageBookRemove()
        {
            InitializeComponent();

            WireUpCtlPageBookRemove();
        }

        private void CtlPageBookRemove_Load(object sender, EventArgs e)
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

        private void WireUpCtlPageBookRemove()
        {
            Localization.LanguageChangedEvent += LocalizationOnLanguageChangedEvent;
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            LocalizationOnLanguageChangedEvent(this, Localization.CurrentLanguage);
            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void LocalizationOnLanguageChangedEvent(object sender, string e)
        {
            if (DesignMode) return;

            Text = Resource_Localization.btnPageBookRemove;
            if (ParentForm != null) ParentForm.Text = Text;

            txtBookSearch.PlaceholderText = Resource_Localization.txtBookSearch;
            btnBookSearch.Text = Resource_Localization.WordSearch;

            txtBookId.PlaceholderText = Resource_Localization.txtBookId;

            btnClear.Text = Resource_Localization.btnClear;

            btnRemove.Text = Resource_Localization.WordRemove;

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

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
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

                    btnClear.BackColor = Themes.Colors.Dark.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Dark.OnSecondary.ToColor();

                    btnRemove.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnRemove.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();
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

                    btnClear.BackColor = Themes.Colors.Light.Secondary.ToColor();
                    btnClear.ForeColor = Themes.Colors.Light.OnSecondary.ToColor();

                    btnRemove.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnRemove.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            _page = 1;
            _searchText = null;
            txtBookSearch.Clear();
            txtBookId.Clear();
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            var bookId = txtBookId.Text;

            if (bookId.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var editedBook = await BookRepository.DeleteAsync(Guid.Parse(bookId));

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