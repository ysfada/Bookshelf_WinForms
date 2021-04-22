
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Components.Pages.BookAddPage
{
    partial class CtlPageBookAdd
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
            this.btnClear = new Bookshelf.Components.Base.BaseButton();
            this.lblGenre = new Bookshelf.Components.Base.BaseLabel();
            this.btnAdd = new Bookshelf.Components.Base.BaseButton();
            this.cboGenre = new Bookshelf.Components.Base.BaseComboBox();
            this.txtAuthor = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtEdition = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPublishedAt = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPages = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtBookName = new Bookshelf.Components.Custom.TxtUnderline();
            this.ctlDataGridView = new Bookshelf.Components.Custom.CtlDataGridView();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlContainer.SuspendLayout();
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
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.lblGenre);
            this.pnlContainer.Controls.Add(this.btnAdd);
            this.pnlContainer.Controls.Add(this.cboGenre);
            this.pnlContainer.Controls.Add(this.txtAuthor);
            this.pnlContainer.Controls.Add(this.txtEdition);
            this.pnlContainer.Controls.Add(this.txtPublishedAt);
            this.pnlContainer.Controls.Add(this.txtPages);
            this.pnlContainer.Controls.Add(this.txtBookName);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlContainer.Location = new System.Drawing.Point(400, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(300, 460);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Click += new System.EventHandler(this.pnlContainer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(40, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGenre.Location = new System.Drawing.Point(40, 275);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 19);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(160, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(130, 275);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(130, 27);
            this.cboGenre.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAuthor.Location = new System.Drawing.Point(40, 228);
            this.txtAuthor.MaxLength = 32;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.Size = new System.Drawing.Size(220, 27);
            this.txtAuthor.TabIndex = 4;
            this.txtAuthor.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtEdition
            // 
            this.txtEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEdition.Location = new System.Drawing.Point(40, 181);
            this.txtEdition.MaxLength = 3;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.PlaceholderText = "Edition";
            this.txtEdition.Size = new System.Drawing.Size(220, 27);
            this.txtEdition.TabIndex = 3;
            this.txtEdition.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdition_KeyPress);
            // 
            // txtPublishedAt
            // 
            this.txtPublishedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPublishedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPublishedAt.Location = new System.Drawing.Point(40, 134);
            this.txtPublishedAt.MaxLength = 4;
            this.txtPublishedAt.Name = "txtPublishedAt";
            this.txtPublishedAt.PlaceholderText = "Published at";
            this.txtPublishedAt.Size = new System.Drawing.Size(220, 27);
            this.txtPublishedAt.TabIndex = 2;
            this.txtPublishedAt.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPublishedAt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublishedAt_KeyPress);
            // 
            // txtPages
            // 
            this.txtPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPages.Location = new System.Drawing.Point(40, 87);
            this.txtPages.MaxLength = 5;
            this.txtPages.Name = "txtPages";
            this.txtPages.PlaceholderText = "Pages";
            this.txtPages.Size = new System.Drawing.Size(220, 27);
            this.txtPages.TabIndex = 1;
            this.txtPages.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPages_KeyPress);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookName.Location = new System.Drawing.Point(40, 40);
            this.txtBookName.MaxLength = 32;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PlaceholderText = "Book name";
            this.txtBookName.Size = new System.Drawing.Size(220, 27);
            this.txtBookName.TabIndex = 0;
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
            // 
            // CtlPageBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CtlPageBookAdd";
            this.Load += new System.EventHandler(this.CtlPageBookAdd_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
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
        private BaseButton btnAdd;
        private BaseComboBox cboGenre;
        private BaseLabel lblGenre;
        private BaseButton btnClear;
    }
}
