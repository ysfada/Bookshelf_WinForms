
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Components.Pages.BookEditPage
{
    partial class CtlPageBookEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer = new Bookshelf.Components.Base.BasePanel();
            this.pnlBookOrder = new Bookshelf.Components.Base.BasePanel();
            this.radbBookAZ = new System.Windows.Forms.RadioButton();
            this.radbBookZA = new System.Windows.Forms.RadioButton();
            this.btnClear = new Bookshelf.Components.Base.BaseButton();
            this.lblGenre = new Bookshelf.Components.Base.BaseLabel();
            this.btnBookSearch = new Bookshelf.Components.Base.BaseButton();
            this.btnEdit = new Bookshelf.Components.Base.BaseButton();
            this.cboGenre = new Bookshelf.Components.Base.BaseComboBox();
            this.txtAuthor = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtEdition = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPublishedAt = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPages = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtBookSearch = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtBookId = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtBookName = new Bookshelf.Components.Custom.TxtUnderline();
            this.ctlDataGridView = new Bookshelf.Components.Custom.CtlDataGridView();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBookOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.pnlContainer, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.ctlDataGridView, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(700, 460);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContainer.Controls.Add(this.pnlBookOrder);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.lblGenre);
            this.pnlContainer.Controls.Add(this.btnBookSearch);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.cboGenre);
            this.pnlContainer.Controls.Add(this.txtAuthor);
            this.pnlContainer.Controls.Add(this.txtEdition);
            this.pnlContainer.Controls.Add(this.txtPublishedAt);
            this.pnlContainer.Controls.Add(this.txtPages);
            this.pnlContainer.Controls.Add(this.txtBookSearch);
            this.pnlContainer.Controls.Add(this.txtBookId);
            this.pnlContainer.Controls.Add(this.txtBookName);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlContainer.Location = new System.Drawing.Point(400, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(300, 460);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Click += new System.EventHandler(this.pnlContainer_Click);
            // 
            // pnlBookOrder
            // 
            this.pnlBookOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBookOrder.Controls.Add(this.radbBookAZ);
            this.pnlBookOrder.Controls.Add(this.radbBookZA);
            this.pnlBookOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBookOrder.Location = new System.Drawing.Point(40, 86);
            this.pnlBookOrder.Name = "pnlBookOrder";
            this.pnlBookOrder.Size = new System.Drawing.Size(106, 40);
            this.pnlBookOrder.TabIndex = 1;
            // 
            // radbBookAZ
            // 
            this.radbBookAZ.AutoSize = true;
            this.radbBookAZ.Checked = true;
            this.radbBookAZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.radbBookAZ.Location = new System.Drawing.Point(0, 0);
            this.radbBookAZ.Margin = new System.Windows.Forms.Padding(0);
            this.radbBookAZ.Name = "radbBookAZ";
            this.radbBookAZ.Size = new System.Drawing.Size(53, 40);
            this.radbBookAZ.TabIndex = 0;
            this.radbBookAZ.TabStop = true;
            this.radbBookAZ.Text = "A-Z";
            this.radbBookAZ.UseVisualStyleBackColor = true;
            // 
            // radbBookZA
            // 
            this.radbBookZA.AutoSize = true;
            this.radbBookZA.Dock = System.Windows.Forms.DockStyle.Right;
            this.radbBookZA.Location = new System.Drawing.Point(53, 0);
            this.radbBookZA.Margin = new System.Windows.Forms.Padding(0);
            this.radbBookZA.Name = "radbBookZA";
            this.radbBookZA.Size = new System.Drawing.Size(53, 40);
            this.radbBookZA.TabIndex = 1;
            this.radbBookZA.Text = "Z-A";
            this.radbBookZA.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(40, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGenre.Location = new System.Drawing.Point(40, 428);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 19);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBookSearch.Location = new System.Drawing.Point(160, 86);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(100, 40);
            this.btnBookSearch.TabIndex = 2;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(160, 475);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(130, 428);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(130, 27);
            this.cboGenre.TabIndex = 10;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAuthor.Location = new System.Drawing.Point(40, 381);
            this.txtAuthor.MaxLength = 32;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.Size = new System.Drawing.Size(220, 27);
            this.txtAuthor.TabIndex = 8;
            this.txtAuthor.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtEdition
            // 
            this.txtEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEdition.Location = new System.Drawing.Point(40, 334);
            this.txtEdition.MaxLength = 3;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.PlaceholderText = "Edition";
            this.txtEdition.Size = new System.Drawing.Size(220, 27);
            this.txtEdition.TabIndex = 7;
            this.txtEdition.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdition_KeyPress);
            // 
            // txtPublishedAt
            // 
            this.txtPublishedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPublishedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPublishedAt.Location = new System.Drawing.Point(40, 287);
            this.txtPublishedAt.MaxLength = 4;
            this.txtPublishedAt.Name = "txtPublishedAt";
            this.txtPublishedAt.PlaceholderText = "Published at";
            this.txtPublishedAt.Size = new System.Drawing.Size(220, 27);
            this.txtPublishedAt.TabIndex = 6;
            this.txtPublishedAt.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPublishedAt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublishedAt_KeyPress);
            // 
            // txtPages
            // 
            this.txtPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPages.Location = new System.Drawing.Point(40, 240);
            this.txtPages.MaxLength = 5;
            this.txtPages.Name = "txtPages";
            this.txtPages.PlaceholderText = "Pages";
            this.txtPages.Size = new System.Drawing.Size(220, 27);
            this.txtPages.TabIndex = 5;
            this.txtPages.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPages_KeyPress);
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookSearch.Location = new System.Drawing.Point(40, 40);
            this.txtBookSearch.MaxLength = 64;
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.PlaceholderText = "Book id, book name, author";
            this.txtBookSearch.Size = new System.Drawing.Size(220, 27);
            this.txtBookSearch.TabIndex = 0;
            this.txtBookSearch.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookSearch_KeyDown);
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookId.Location = new System.Drawing.Point(40, 146);
            this.txtBookId.MaxLength = 64;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.PlaceholderText = "Book id";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(220, 27);
            this.txtBookId.TabIndex = 3;
            this.txtBookId.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookName.Location = new System.Drawing.Point(40, 193);
            this.txtBookName.MaxLength = 32;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PlaceholderText = "Book name";
            this.txtBookName.Size = new System.Drawing.Size(220, 27);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // ctlDataGridView
            // 
            this.ctlDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctlDataGridView.Location = new System.Drawing.Point(5, 0);
            this.ctlDataGridView.Name = "ctlDataGridView";
            this.ctlDataGridView.Size = new System.Drawing.Size(395, 460);
            this.ctlDataGridView.TabIndex = 1;
            this.ctlDataGridView.OnPreviousPage += new System.EventHandler<System.EventArgs>(this.ctlDataGridView_OnPreviousPage);
            this.ctlDataGridView.OnNextPage += new System.EventHandler<System.EventArgs>(this.ctlDataGridView_OnNextPage);
            this.ctlDataGridView.OnRowEnter += new System.EventHandler<System.EventArgs>(this.ctlDataGridView_OnRowEnter);
            // 
            // CtlPageBookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CtlPageBookEdit";
            this.Load += new System.EventHandler(this.CtlPageBookEdit_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlBookOrder.ResumeLayout(false);
            this.pnlBookOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Custom.CtlDataGridView ctlDataGridView;
        private Base.BasePanel pnlContainer;
        private TxtUnderline txtBookName;
        private TxtUnderline txtPages;
        private TxtUnderline txtPublishedAt;
        private TxtUnderline txtEdition;
        private TxtUnderline txtAuthor;
        private BaseButton btnEdit;
        private BaseComboBox cboGenre;
        private BaseLabel lblGenre;
        private BaseButton btnClear;
        private TxtUnderline txtBookId;
        private BaseButton btnBookSearch;
        private TxtUnderline txtBookSearch;
        private BasePanel pnlBookOrder;
        private System.Windows.Forms.RadioButton radbBookAZ;
        private System.Windows.Forms.RadioButton radbBookZA;
    }
}
