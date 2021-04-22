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

namespace Bookshelf.Components.Pages.BookAddPage
{
    public partial class CtlPageBookAdd : BaseUserControl
    {
        public CtlPageBookAdd()
        {
            InitializeComponent();

            WireUpCtlPageBookAdd();
        }

        private void CtlPageBookAdd_Load(object sender, EventArgs e)
        {
            pnlContainer.Focus();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            pnlContainer.Focus();
        }

        private void WireUpCtlPageBookAdd()
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

            Text = Resource_Localization.btnPageBookAdd;
            if (ParentForm != null) ParentForm.Text = Text;

            txtBookName.PlaceholderText = Resource_Localization.txtBookName;
            txtPages.PlaceholderText = Resource_Localization.txtPages;
            txtPublishedAt.PlaceholderText = Resource_Localization.txtPublishedAt;
            txtEdition.PlaceholderText = Resource_Localization.txtEdition;
            txtAuthor.PlaceholderText = Resource_Localization.txtAuthor;
            lblGenre.Text = Resource_Localization.lblGenre;
            btnClear.Text = Resource_Localization.btnClear;
            btnAdd.Text = Resource_Localization.WordAdd;

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

            if (dataGridView.Rows.Count <= 0) return;

            dataGridView.Columns[0].HeaderText = Resource_Localization.txtBookId;
            dataGridView.Columns[1].HeaderText = Resource_Localization.txtBookName;
            dataGridView.Columns[2].HeaderText = Resource_Localization.txtPages;
            dataGridView.Columns[3].HeaderText = Resource_Localization.txtPublishedAt;
            dataGridView.Columns[4].HeaderText = Resource_Localization.txtEdition;
            dataGridView.Columns[5].HeaderText = Resource_Localization.txtAuthor;
            dataGridView.Columns[6].HeaderText = Resource_Localization.lblGenre;
            dataGridView.Columns[7].HeaderText = Resource_Localization.lblBorrowed;

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

                    btnAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

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

                    btnAdd.BackColor = Themes.Colors.Dark.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Dark.OnPrimary.ToColor();
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlContainer.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlContainer.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

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

                    btnAdd.BackColor = Themes.Colors.Light.Primary.ToColor();
                    btnAdd.ForeColor = Themes.Colors.Light.OnPrimary.ToColor();
                    break;
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
            txtBookName.Clear();
            txtPages.Clear();
            txtPublishedAt.Clear();
            txtEdition.Clear();
            txtAuthor.Clear();
            cboGenre.SelectedIndex = (int) Genre.Other;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var bookName = txtBookName.Text;
            var pages = txtPages.Text;
            var publishedAt = txtPublishedAt.Text;
            var edition = txtEdition.Text;
            var author = txtAuthor.Text;
            var genre = (Genre) cboGenre.SelectedIndex;

            if (bookName.IsNullOrEmpty() || author.IsNullOrEmpty()) return;

            try
            {
                Cursor = Cursors.WaitCursor;

                var book = new BookEntity
                {
                    BookName = bookName,
                    Pages = pages,
                    PublishedAt = publishedAt,
                    Edition = edition,
                    Author = author,
                    Genre = genre
                };

                var createdBook = await BookRepository.CreateAsync(book);

                ctlDataGridView.PopulateDataGridView(createdBook);

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