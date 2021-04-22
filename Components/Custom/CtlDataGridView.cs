using Bookshelf.Components.Base;
using Bookshelf.Database.Entities;
using Bookshelf.Properties;
using Bookshelf.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bookshelf.Components.Custom
{
    public partial class CtlDataGridView : BaseUserControl
    {
        public CtlDataGridView()
        {
            InitializeComponent();

            WireUpCtlDataGridView();
        }

        private void WireUpCtlDataGridView()
        {
            Themes.ThemeChangedEvent += ThemesOnThemeChangedEvent;

            btnPreviousPage.Text = string.Empty;
            btnPreviousPage.ImageList.Images.Add(Resources.PreviousLight);
            btnPreviousPage.ImageList.Images.Add(Resources.PreviousDark);
            btnPreviousPage.BackColor = Themes.Colors.Light.Background.ToColor();
            btnPreviousPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
            btnPreviousPage.Image = btnPreviousPage.ImageList.Images[0];

            btnNextPage.Text = string.Empty;
            btnNextPage.ImageList.Images.Add(Resources.NextLight);
            btnNextPage.ImageList.Images.Add(Resources.NextDark);
            btnNextPage.BackColor = Themes.Colors.Light.Background.ToColor();
            btnNextPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
            btnNextPage.Image = btnNextPage.ImageList.Images[0];

            cboLimit.SelectedIndex = 1;

            ThemesOnThemeChangedEvent(this, Themes.CurrentTheme);
        }

        private void ThemesOnThemeChangedEvent(object sender, Theme e)
        {
            switch (e)
            {
                case Theme.Light:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    dataGridView.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.BackgroundColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.DefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.DefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlPagination.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlPagination.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnPreviousPage.BackColor = Themes.Colors.Light.Background.ToColor();
                    btnPreviousPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    btnPreviousPage.Image = btnPreviousPage.ImageList.Images[0];

                    btnNextPage.BackColor = Themes.Colors.Light.Background.ToColor();
                    btnNextPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    btnNextPage.Image = btnNextPage.ImageList.Images[0];
                    break;
                case Theme.Dark:
                    BackColor = Themes.Colors.Dark.Background.ToColor();
                    ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    dataGridView.BackColor = Themes.Colors.Dark.Background.ToColor();
                    dataGridView.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    dataGridView.BackgroundColor = Themes.Colors.Dark.Background.ToColor();
                    dataGridView.DefaultCellStyle.BackColor = Themes.Colors.Dark.Background.ToColor();
                    dataGridView.DefaultCellStyle.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Themes.Colors.Dark.Background.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.BackColor = Themes.Colors.Dark.Background.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    pnlPagination.BackColor = Themes.Colors.Dark.Background.ToColor();
                    pnlPagination.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();

                    btnPreviousPage.BackColor = Themes.Colors.Dark.Background.ToColor();
                    btnPreviousPage.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    btnPreviousPage.Image = btnPreviousPage.ImageList.Images[1];

                    btnNextPage.BackColor = Themes.Colors.Dark.Background.ToColor();
                    btnNextPage.ForeColor = Themes.Colors.Dark.OnBackground.ToColor();
                    btnNextPage.Image = btnNextPage.ImageList.Images[1];
                    break;
                default:
                    BackColor = Themes.Colors.Light.Background.ToColor();
                    ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    dataGridView.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.BackgroundColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.DefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.DefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.BackColor = Themes.Colors.Light.Background.ToColor();
                    dataGridView.RowHeadersDefaultCellStyle.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    pnlPagination.BackColor = Themes.Colors.Light.Background.ToColor();
                    pnlPagination.ForeColor = Themes.Colors.Light.OnBackground.ToColor();

                    btnPreviousPage.BackColor = Themes.Colors.Light.Background.ToColor();
                    btnPreviousPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    btnPreviousPage.Image = btnPreviousPage.ImageList.Images[0];

                    btnNextPage.BackColor = Themes.Colors.Light.Background.ToColor();
                    btnNextPage.ForeColor = Themes.Colors.Light.OnBackground.ToColor();
                    btnNextPage.Image = btnNextPage.ImageList.Images[0];
                    break;
            }
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using var b = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
        }

        public void HideEmptyColumns()
        {
            for (var i = 0; i < dataGridView.ColumnCount; i++)
            {
                var i1 = i;
                var column = dataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[i1].Value);
                dataGridView.Columns[i].Visible = !column.All(el =>
                    el == null ||
                    el.ToString().IsNullOrEmpty() ||
                    (DateTime.TryParse(el.ToString(), out _) && DateTime.Parse((el.ToString().IsNullOrEmpty() ? el.ToString() : DateTime.MinValue.ToString(CultureInfo.CurrentCulture)) ?? string.Empty) == DateTime.MinValue));
            }
        }

        public void RemoveEmptyColumns()
        {
            var removeColumns = new List<string>();
            for (var i = 0; i < dataGridView.ColumnCount; i++)
            {
                var i1 = i;
                var column = dataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[i1].Value);
                if (column.All(el =>
                    el == null ||
                    el.ToString().IsNullOrEmpty() ||
                    (DateTime.TryParse(el.ToString(), out _) && DateTime.Parse((el.ToString().IsNullOrEmpty() ? el.ToString() : DateTime.MinValue.ToString(CultureInfo.CurrentCulture)) ?? string.Empty) == DateTime.MinValue)))
                    removeColumns.Add(dataGridView.Columns[i].Name);
            }

            removeColumns.ForEach(column => dataGridView.Columns.Remove(column));
        }

        public void RemoveColumn(string columnName)
        {
            dataGridView.Columns.Remove(columnName);
        }

        public void DisableBtnPreviousPage()
        {
            btnPreviousPage.Enabled = false;
        }

        public void EnableBtnPreviousPage()
        {
            btnPreviousPage.Enabled = true;
        }

        public void DisableBtnNextPage()
        {
            btnNextPage.Enabled = false;
        }

        public void EnableBtnNextPage()
        {
            btnNextPage.Enabled = true;
        }

        public int PageLimit()
        {
            return Convert.ToInt32(cboLimit.SelectedItem);
        }

        public void ClearColumns()
        {
            dataGridView.Columns.Clear();
        }

        public void ClearRows()
        {
            dataGridView.Rows.Clear();
        }

        public void PopulateDataGridView(object data, bool clearRows = false, bool clearColumns = false)
        {
            if (clearRows) ClearRows();

            switch (data)
            {
                case UserEntity user:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtUserId);
                        dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        dataGridView.Columns.Add("Email", Resource_Localization.txtEmail);
                        dataGridView.Columns.Add("FirstName", Resource_Localization.txtFirstName);
                        dataGridView.Columns.Add("LastName", Resource_Localization.txtLastName);
                        dataGridView.Columns.Add("Phone", Resource_Localization.txtPhone);
                        dataGridView.Columns.Add("Address", Resource_Localization.txtAddress);
                        dataGridView.Columns.Add("Role", Resource_Localization.lblRole);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtUserId);
                        if (!dataGridView.Columns.Contains("Username")) dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        if (!dataGridView.Columns.Contains("Email")) dataGridView.Columns.Add("Email", Resource_Localization.txtEmail);
                        if (!dataGridView.Columns.Contains("FirstName")) dataGridView.Columns.Add("FirstName", Resource_Localization.txtFirstName);
                        if (!dataGridView.Columns.Contains("LastName")) dataGridView.Columns.Add("LastName", Resource_Localization.txtLastName);
                        if (!dataGridView.Columns.Contains("Phone")) dataGridView.Columns.Add("Phone", Resource_Localization.txtPhone);
                        if (!dataGridView.Columns.Contains("Address")) dataGridView.Columns.Add("Address", Resource_Localization.txtAddress);
                        if (!dataGridView.Columns.Contains("Role")) dataGridView.Columns.Add("Role", Resource_Localization.lblRole);
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Email"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["FirstName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["LastName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Phone"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Address"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Role"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Email"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["FirstName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["LastName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Phone"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Address"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Role"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    var userRow = new DataGridViewRow();
                    userRow.CreateCells(dataGridView);
                    userRow.Cells[0].Value = user.Id;
                    userRow.Cells[1].Value = user.Username;
                    userRow.Cells[2].Value = user.Email;
                    userRow.Cells[3].Value = user.FirstName;
                    userRow.Cells[4].Value = user.LastName;
                    userRow.Cells[5].Value = user.Phone;
                    userRow.Cells[6].Value = user.Address;
                    userRow.Cells[7].Value = user.Role.ToString();
                    userRow.Cells[7].Tag = user.Role;
                    dataGridView.Rows.Add(userRow);

                    break;
                case List<UserEntity> users:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtUserId);
                        dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        dataGridView.Columns.Add("Email", Resource_Localization.txtEmail);
                        dataGridView.Columns.Add("FirstName", Resource_Localization.txtFirstName);
                        dataGridView.Columns.Add("LastName", Resource_Localization.txtLastName);
                        dataGridView.Columns.Add("Phone", Resource_Localization.txtPhone);
                        dataGridView.Columns.Add("Address", Resource_Localization.txtAddress);
                        dataGridView.Columns.Add("Role", Resource_Localization.lblRole);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtUserId);
                        if (!dataGridView.Columns.Contains("Username")) dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        if (!dataGridView.Columns.Contains("Email")) dataGridView.Columns.Add("Email", Resource_Localization.txtEmail);
                        if (!dataGridView.Columns.Contains("FirstName")) dataGridView.Columns.Add("FirstName", Resource_Localization.txtFirstName);
                        if (!dataGridView.Columns.Contains("LastName")) dataGridView.Columns.Add("LastName", Resource_Localization.txtLastName);
                        if (!dataGridView.Columns.Contains("Phone")) dataGridView.Columns.Add("Phone", Resource_Localization.txtPhone);
                        if (!dataGridView.Columns.Contains("Address")) dataGridView.Columns.Add("Address", Resource_Localization.txtAddress);
                        if (!dataGridView.Columns.Contains("Role")) dataGridView.Columns.Add("Role", Resource_Localization.lblRole);
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Email"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["FirstName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["LastName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Phone"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Address"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Role"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Email"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["FirstName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["LastName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Phone"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Address"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Role"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    users.ForEach(user =>
                    {
                        var usersRow = new DataGridViewRow();
                        usersRow.CreateCells(dataGridView);
                        usersRow.Cells[0].Value = user.Id;
                        usersRow.Cells[1].Value = user.Username;
                        usersRow.Cells[2].Value = user.Email;
                        usersRow.Cells[3].Value = user.FirstName;
                        usersRow.Cells[4].Value = user.LastName;
                        usersRow.Cells[5].Value = user.Phone;
                        usersRow.Cells[6].Value = user.Address;
                        usersRow.Cells[7].Value = user.Role.ToString();
                        usersRow.Cells[7].Tag = user.Role;
                        dataGridView.Rows.Add(usersRow);
                    });

                    break;
                case BookEntity book:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtBookId);
                        dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        dataGridView.Columns.Add("Pages", Resource_Localization.txtPages);
                        dataGridView.Columns.Add("PublishedAt", Resource_Localization.txtPublishedAt);
                        dataGridView.Columns.Add("Edition", Resource_Localization.txtEdition);
                        dataGridView.Columns.Add("Author", Resource_Localization.txtAuthor);
                        dataGridView.Columns.Add("Genre", Resource_Localization.lblGenre);
                        //dataGridView.Columns.Add("Borrowed", Resource_Localization.lblBorrowed);
                        var borrowedColumn = new DataGridViewCheckBoxColumn
                        {
                            Name = "Borrowed",
                            HeaderText = Resource_Localization.lblBorrowed
                        };
                        dataGridView.Columns.Add(borrowedColumn);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtBookId);
                        if (!dataGridView.Columns.Contains("BookName")) dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        if (!dataGridView.Columns.Contains("Pages")) dataGridView.Columns.Add("Pages", Resource_Localization.txtPages);
                        if (!dataGridView.Columns.Contains("PublishedAt")) dataGridView.Columns.Add("PublishedAt", Resource_Localization.txtPublishedAt);
                        if (!dataGridView.Columns.Contains("Edition")) dataGridView.Columns.Add("Edition", Resource_Localization.txtEdition);
                        if (!dataGridView.Columns.Contains("Author")) dataGridView.Columns.Add("Author", Resource_Localization.txtAuthor);
                        if (!dataGridView.Columns.Contains("Genre")) dataGridView.Columns.Add("Genre", Resource_Localization.lblGenre);
                        //if (!dataGridView.Columns.Contains("Borrowed")) dataGridView.Columns.Add("Borrowed", Resource_Localization.lblBorrowed);
                        if (!dataGridView.Columns.Contains("Borrowed"))
                        {
                            var borrowedColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Borrowed",
                                HeaderText = Resource_Localization.lblBorrowed
                            };
                            dataGridView.Columns.Add(borrowedColumn);
                        }
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Pages"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["PublishedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Edition"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Author"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Genre"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //dataGridView.Columns["Borrowed"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Pages"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["PublishedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Edition"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Author"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Genre"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //dataGridView.Columns["Borrowed"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                    var bookRow = new DataGridViewRow();
                    bookRow.CreateCells(dataGridView);
                    bookRow.Cells[0].Value = book.Id;
                    bookRow.Cells[1].Value = book.BookName;
                    bookRow.Cells[2].Value = book.Pages;
                    bookRow.Cells[3].Value = book.PublishedAt;
                    bookRow.Cells[4].Value = book.Edition;
                    bookRow.Cells[5].Value = book.Author;
                    bookRow.Cells[6].Value = book.Genre.ToString();
                    bookRow.Cells[6].Tag = book.Genre;
                    bookRow.Cells[7].Value = book.Borrowed;
                    dataGridView.Rows.Add(bookRow);

                    break;
                case List<BookEntity> books:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtBookId);
                        dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        dataGridView.Columns.Add("Pages", Resource_Localization.txtPages);
                        dataGridView.Columns.Add("PublishedAt", Resource_Localization.txtPublishedAt);
                        dataGridView.Columns.Add("Edition", Resource_Localization.txtEdition);
                        dataGridView.Columns.Add("Author", Resource_Localization.txtAuthor);
                        dataGridView.Columns.Add("Genre", Resource_Localization.lblGenre);
                        //dataGridView.Columns.Add("Borrowed", Resource_Localization.lblBorrowed);
                        var borrowedColumn = new DataGridViewCheckBoxColumn
                        {
                            Name = "Borrowed",
                            HeaderText = Resource_Localization.lblBorrowed
                        };
                        dataGridView.Columns.Add(borrowedColumn);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtBookId);
                        if (!dataGridView.Columns.Contains("BookName")) dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        if (!dataGridView.Columns.Contains("Pages")) dataGridView.Columns.Add("Pages", Resource_Localization.txtPages);
                        if (!dataGridView.Columns.Contains("PublishedAt")) dataGridView.Columns.Add("PublishedAt", Resource_Localization.txtPublishedAt);
                        if (!dataGridView.Columns.Contains("Edition")) dataGridView.Columns.Add("Edition", Resource_Localization.txtEdition);
                        if (!dataGridView.Columns.Contains("Author")) dataGridView.Columns.Add("Author", Resource_Localization.txtAuthor);
                        if (!dataGridView.Columns.Contains("Genre")) dataGridView.Columns.Add("Genre", Resource_Localization.lblGenre);
                        //if (!dataGridView.Columns.Contains("Borrowed")) dataGridView.Columns.Add("Borrowed", Resource_Localization.lblBorrowed);
                        if (!dataGridView.Columns.Contains("Borrowed"))
                        {
                            var borrowedColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Borrowed",
                                HeaderText = Resource_Localization.lblBorrowed
                            };
                            dataGridView.Columns.Add(borrowedColumn);
                        }
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Pages"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["PublishedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Edition"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Author"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Genre"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //dataGridView.Columns["Borrowed"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Pages"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["PublishedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Edition"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["Author"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Genre"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //dataGridView.Columns["Borrowed"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                    books.ForEach(book =>
                    {
                        var booksRow = new DataGridViewRow();
                        booksRow.CreateCells(dataGridView);
                        booksRow.Cells[0].Value = book.Id;
                        booksRow.Cells[1].Value = book.BookName;
                        booksRow.Cells[2].Value = book.Pages;
                        booksRow.Cells[3].Value = book.PublishedAt;
                        booksRow.Cells[4].Value = book.Edition;
                        booksRow.Cells[5].Value = book.Author;
                        booksRow.Cells[6].Value = book.Genre.ToString();
                        booksRow.Cells[6].Tag = book.Genre;
                        booksRow.Cells[7].Value = book.Borrowed;
                        dataGridView.Rows.Add(booksRow);
                    });
                    break;
                case BookIssueEntity bookIssue:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtBookIssueId);
                        dataGridView.Columns.Add("UserId", Resource_Localization.txtUserId);
                        dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        dataGridView.Columns.Add("BookId", Resource_Localization.txtBookId);
                        dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        dataGridView.Columns.Add("IssuerId", Resource_Localization.txtIssuerId);
                        dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtIssuerUsername);
                        dataGridView.Columns.Add("ReceiverId", Resource_Localization.txtReceiverId);
                        dataGridView.Columns.Add("ReceiverUsername", Resource_Localization.txtReceiverUsername);
                        dataGridView.Columns.Add("IssuedAt", Resource_Localization.lblIssuedAt);
                        dataGridView.Columns.Add("DueDate", Resource_Localization.lblDueDate);
                        dataGridView.Columns.Add("ReturnedAt", Resource_Localization.lblReturnedAt);
                        //dataGridView.Columns.Add("Returned", Resource_Localization.lblReturned);
                        var borrowedColumn = new DataGridViewCheckBoxColumn
                        {
                            Name = "Returned",
                            HeaderText = Resource_Localization.lblReturned
                        };
                        dataGridView.Columns.Add(borrowedColumn);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtBookIssueId);
                        if (!dataGridView.Columns.Contains("UserId")) dataGridView.Columns.Add("UserId", Resource_Localization.txtUserId);
                        if (!dataGridView.Columns.Contains("Username")) dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        if (!dataGridView.Columns.Contains("BookId")) dataGridView.Columns.Add("BookId", Resource_Localization.txtBookId);
                        if (!dataGridView.Columns.Contains("BookName")) dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        if (!dataGridView.Columns.Contains("IssuerId")) dataGridView.Columns.Add("IssuerId", Resource_Localization.txtIssuerId);
                        if (!dataGridView.Columns.Contains("IssuerUsername")) dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtIssuerUsername);
                        if (!dataGridView.Columns.Contains("ReceiverId")) dataGridView.Columns.Add("IssuerId", Resource_Localization.txtReceiverId);
                        if (!dataGridView.Columns.Contains("ReceiverUsername")) dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtReceiverUsername);
                        if (!dataGridView.Columns.Contains("IssuedAt")) dataGridView.Columns.Add("IssuedAt", Resource_Localization.lblIssuedAt);
                        if (!dataGridView.Columns.Contains("DueDate")) dataGridView.Columns.Add("DueDate", Resource_Localization.lblDueDate);
                        if (!dataGridView.Columns.Contains("ReturnedAt")) dataGridView.Columns.Add("ReturnedAt", Resource_Localization.lblReturnedAt);
                        //if (!dataGridView.Columns.Contains("Returned")) dataGridView.Columns.Add("Returned", Resource_Localization.lblReturned);
                        if (!dataGridView.Columns.Contains("Returned"))
                        {
                            var borrowedColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Returned",
                                HeaderText = Resource_Localization.lblReturned
                            };
                            dataGridView.Columns.Add(borrowedColumn);
                        }
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["UserId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerUsername"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverUsername"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["DueDate"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["ReturnedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dataGridView.Columns["Returned"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["UserId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerUsername"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverUsername"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["DueDate"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["ReturnedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dataGridView.Columns["Returned"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                    var bookIssueRow = new DataGridViewRow();
                    bookIssueRow.CreateCells(dataGridView);
                    bookIssueRow.Cells[0].Value = bookIssue.Id;
                    bookIssueRow.Cells[1].Value = bookIssue.UserId;
                    bookIssueRow.Cells[2].Value = bookIssue.User.Username;
                    bookIssueRow.Cells[3].Value = bookIssue.BookId;
                    bookIssueRow.Cells[4].Value = bookIssue.Book.BookName;
                    bookIssueRow.Cells[5].Value = bookIssue.IssuerId;
                    bookIssueRow.Cells[6].Value = bookIssue.Issuer.Username;
                    bookIssueRow.Cells[7].Value = bookIssue.ReceiverId == Guid.Empty ? string.Empty : bookIssue.ReceiverId;
                    bookIssueRow.Cells[8].Value = bookIssue.Receiver.Username;
                    bookIssueRow.Cells[9].Value = bookIssue.IssuedAt;
                    bookIssueRow.Cells[10].Value = bookIssue.DueDate;
                    bookIssueRow.Cells[11].Value = bookIssue.ReturnedAt == DateTime.MinValue ? string.Empty : bookIssue.ReturnedAt;
                    bookIssueRow.Cells[12].Value = bookIssue.Returned;
                    dataGridView.Rows.Add(bookIssueRow);
                    break;
                case List<BookIssueEntity> bookIssues:
                    if (clearColumns)
                    {
                        ClearColumns();

                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        dataGridView.Columns.Add("Id", Resource_Localization.txtBookIssueId);
                        dataGridView.Columns.Add("UserId", Resource_Localization.txtUserId);
                        dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        dataGridView.Columns.Add("BookId", Resource_Localization.txtBookId);
                        dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        dataGridView.Columns.Add("IssuerId", Resource_Localization.txtIssuerId);
                        dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtIssuerUsername);
                        dataGridView.Columns.Add("ReceiverId", Resource_Localization.txtReceiverId);
                        dataGridView.Columns.Add("ReceiverUsername", Resource_Localization.txtReceiverUsername);
                        dataGridView.Columns.Add("IssuedAt", Resource_Localization.lblIssuedAt);
                        dataGridView.Columns.Add("DueDate", Resource_Localization.lblDueDate);
                        dataGridView.Columns.Add("ReturnedAt", Resource_Localization.lblReturnedAt);
                        //dataGridView.Columns.Add("Returned", Resource_Localization.lblReturned);
                        var borrowedColumn = new DataGridViewCheckBoxColumn
                        {
                            Name = "Returned",
                            HeaderText = Resource_Localization.lblReturned
                        };
                        dataGridView.Columns.Add(borrowedColumn);
                    }
                    else
                    {
                        //var idColumn = new DataGridViewTextBoxColumn
                        //{
                        //    Name = "Id",
                        //    HeaderText = "Id"
                        //};
                        //dataGridView.Columns.Add(idColumn);

                        if (!dataGridView.Columns.Contains("Id")) dataGridView.Columns.Add("Id", Resource_Localization.txtBookIssueId);
                        if (!dataGridView.Columns.Contains("UserId")) dataGridView.Columns.Add("UserId", Resource_Localization.txtUserId);
                        if (!dataGridView.Columns.Contains("Username")) dataGridView.Columns.Add("Username", Resource_Localization.txtUsername);
                        if (!dataGridView.Columns.Contains("BookId")) dataGridView.Columns.Add("BookId", Resource_Localization.txtBookId);
                        if (!dataGridView.Columns.Contains("BookName")) dataGridView.Columns.Add("BookName", Resource_Localization.txtBookName);
                        if (!dataGridView.Columns.Contains("IssuerId")) dataGridView.Columns.Add("IssuerId", Resource_Localization.txtIssuerId);
                        if (!dataGridView.Columns.Contains("IssuerUsername")) dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtIssuerUsername);
                        if (!dataGridView.Columns.Contains("ReceiverId")) dataGridView.Columns.Add("IssuerId", Resource_Localization.txtReceiverId);
                        if (!dataGridView.Columns.Contains("ReceiverUsername")) dataGridView.Columns.Add("IssuerUsername", Resource_Localization.txtReceiverUsername);
                        if (!dataGridView.Columns.Contains("IssuedAt")) dataGridView.Columns.Add("IssuedAt", Resource_Localization.lblIssuedAt);
                        if (!dataGridView.Columns.Contains("DueDate")) dataGridView.Columns.Add("DueDate", Resource_Localization.lblDueDate);
                        if (!dataGridView.Columns.Contains("ReturnedAt")) dataGridView.Columns.Add("ReturnedAt", Resource_Localization.lblReturnedAt);
                        //if (!dataGridView.Columns.Contains("Returned")) dataGridView.Columns.Add("Returned", Resource_Localization.lblReturned);
                        if (!dataGridView.Columns.Contains("Returned"))
                        {
                            var borrowedColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Returned",
                                HeaderText = Resource_Localization.lblReturned
                            };
                            dataGridView.Columns.Add(borrowedColumn);
                        }
                    }

                    dataGridView.Columns["Id"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["UserId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerUsername"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverId"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverUsername"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["DueDate"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["ReturnedAt"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dataGridView.Columns["Returned"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dataGridView.Columns["Id"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["UserId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["Username"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["BookName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuerUsername"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverId"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["ReceiverUsername"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView.Columns["IssuedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["DueDate"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["ReturnedAt"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //dataGridView.Columns["Returned"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                    bookIssues.ForEach(bookIssue =>
                    {
                        var bookIssuesRow = new DataGridViewRow();
                        bookIssuesRow.CreateCells(dataGridView);
                        bookIssuesRow.Cells[0].Value = bookIssue.Id;
                        bookIssuesRow.Cells[1].Value = bookIssue.UserId;
                        bookIssuesRow.Cells[2].Value = bookIssue.User.Username;
                        bookIssuesRow.Cells[3].Value = bookIssue.BookId;
                        bookIssuesRow.Cells[4].Value = bookIssue.Book.BookName;
                        bookIssuesRow.Cells[5].Value = bookIssue.IssuerId;
                        bookIssuesRow.Cells[6].Value = bookIssue.Issuer.Username;
                        bookIssuesRow.Cells[7].Value = bookIssue.ReceiverId == Guid.Empty ? string.Empty : bookIssue.ReceiverId;
                        bookIssuesRow.Cells[8].Value = bookIssue.Receiver.Username;
                        bookIssuesRow.Cells[9].Value = bookIssue.IssuedAt;
                        bookIssuesRow.Cells[10].Value = bookIssue.DueDate;
                        bookIssuesRow.Cells[11].Value = bookIssue.ReturnedAt == DateTime.MinValue ? string.Empty : bookIssue.ReturnedAt;
                        bookIssuesRow.Cells[12].Value = bookIssue.Returned;
                        dataGridView.Rows.Add(bookIssuesRow);
                    });
                    break;
            }

            dataGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(column => column.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        [DefaultValue(typeof(Size), "400, 460")]
        public new Size Size
        {
            get => base.Size;
            set => base.Size = value;
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[e.ColumnIndex],
                dataGridView.SortOrder == SortOrder.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending);
        }

        [Browsable(true)]
        [Category("Custom"), Description("Runs when previousPage button is clicked.")]
        public event EventHandler<EventArgs> OnPreviousPage;

        [Browsable(true)]
        [Category("Custom"), Description("Runs when nextPage button is clicked.")]
        public event EventHandler<EventArgs> OnNextPage;

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            OnPreviousPage?.Invoke(sender, e);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            OnNextPage?.Invoke(sender, e);
        }

        [Browsable(true)]
        [Category("Custom"), Description("Runs when RowEnter event fired on dataGridPanel.")]
        public event EventHandler<EventArgs> OnRowEnter;

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            OnRowEnter?.Invoke(sender, e);
        }
    }
}
