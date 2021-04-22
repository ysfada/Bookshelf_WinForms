
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Components.Pages.BookGivePage
{
    partial class CtlPageBookGive
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
        /// the contents of this method with the code Giveor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer = new Bookshelf.Components.Base.BasePanel();
            this.pnlBookOrder = new Bookshelf.Components.Base.BasePanel();
            this.radbBookAZ = new System.Windows.Forms.RadioButton();
            this.radbBookZA = new System.Windows.Forms.RadioButton();
            this.pnlUserOrder = new Bookshelf.Components.Base.BasePanel();
            this.radbUserAZ = new System.Windows.Forms.RadioButton();
            this.radbUserZA = new System.Windows.Forms.RadioButton();
            this.btnClear = new Bookshelf.Components.Base.BaseButton();
            this.lblDueDate = new Bookshelf.Components.Base.BaseLabel();
            this.lblDays = new Bookshelf.Components.Base.BaseLabel();
            this.cboDays = new Bookshelf.Components.Base.BaseComboBox();
            this.btnBookSearch = new Bookshelf.Components.Base.BaseButton();
            this.btnGiveBook = new Bookshelf.Components.Base.BaseButton();
            this.btnUserSearch = new Bookshelf.Components.Base.BaseButton();
            this.txtBookSearch = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtDueDate = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtBookId = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtUserId = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtUserSearch = new Bookshelf.Components.Custom.TxtUnderline();
            this.ctlDataGridView = new Bookshelf.Components.Custom.CtlDataGridView();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBookOrder.SuspendLayout();
            this.pnlUserOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
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
            this.pnlContainer.Controls.Add(this.pnlUserOrder);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.lblDueDate);
            this.pnlContainer.Controls.Add(this.lblDays);
            this.pnlContainer.Controls.Add(this.cboDays);
            this.pnlContainer.Controls.Add(this.btnBookSearch);
            this.pnlContainer.Controls.Add(this.btnGiveBook);
            this.pnlContainer.Controls.Add(this.btnUserSearch);
            this.pnlContainer.Controls.Add(this.txtBookSearch);
            this.pnlContainer.Controls.Add(this.txtDueDate);
            this.pnlContainer.Controls.Add(this.txtBookId);
            this.pnlContainer.Controls.Add(this.txtUserId);
            this.pnlContainer.Controls.Add(this.txtUserSearch);
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
            this.pnlBookOrder.Location = new System.Drawing.Point(40, 194);
            this.pnlBookOrder.Name = "pnlBookOrder";
            this.pnlBookOrder.Size = new System.Drawing.Size(106, 40);
            this.pnlBookOrder.TabIndex = 4;
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
            // pnlUserOrder
            // 
            this.pnlUserOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlUserOrder.Controls.Add(this.radbUserAZ);
            this.pnlUserOrder.Controls.Add(this.radbUserZA);
            this.pnlUserOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUserOrder.Location = new System.Drawing.Point(40, 87);
            this.pnlUserOrder.Name = "pnlUserOrder";
            this.pnlUserOrder.Size = new System.Drawing.Size(106, 40);
            this.pnlUserOrder.TabIndex = 1;
            // 
            // radbUserAZ
            // 
            this.radbUserAZ.AutoSize = true;
            this.radbUserAZ.Checked = true;
            this.radbUserAZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.radbUserAZ.Location = new System.Drawing.Point(0, 0);
            this.radbUserAZ.Margin = new System.Windows.Forms.Padding(0);
            this.radbUserAZ.Name = "radbUserAZ";
            this.radbUserAZ.Size = new System.Drawing.Size(53, 40);
            this.radbUserAZ.TabIndex = 0;
            this.radbUserAZ.TabStop = true;
            this.radbUserAZ.Text = "A-Z";
            this.radbUserAZ.UseVisualStyleBackColor = true;
            // 
            // radbUserZA
            // 
            this.radbUserZA.AutoSize = true;
            this.radbUserZA.Dock = System.Windows.Forms.DockStyle.Right;
            this.radbUserZA.Location = new System.Drawing.Point(53, 0);
            this.radbUserZA.Margin = new System.Windows.Forms.Padding(0);
            this.radbUserZA.Name = "radbUserZA";
            this.radbUserZA.Size = new System.Drawing.Size(53, 40);
            this.radbUserZA.TabIndex = 1;
            this.radbUserZA.Text = "Z-A";
            this.radbUserZA.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(40, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDueDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDueDate.Location = new System.Drawing.Point(40, 395);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(72, 19);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due date";
            this.lblDueDate.Click += new System.EventHandler(this.lblDueDate_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDays.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDays.Location = new System.Drawing.Point(40, 348);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(43, 19);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Days";
            this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // cboDays
            // 
            this.cboDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboDays.FormattingEnabled = true;
            this.cboDays.Items.AddRange(new object[] {
            "1",
            "7",
            "10",
            "15",
            "30",
            "45"});
            this.cboDays.Location = new System.Drawing.Point(130, 348);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(130, 27);
            this.cboDays.TabIndex = 9;
            this.cboDays.SelectedIndexChanged += new System.EventHandler(this.cboDays_SelectedIndexChanged);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBookSearch.Location = new System.Drawing.Point(160, 194);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(100, 40);
            this.btnBookSearch.TabIndex = 5;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnGiveBook
            // 
            this.btnGiveBook.FlatAppearance.BorderSize = 0;
            this.btnGiveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGiveBook.Location = new System.Drawing.Point(160, 442);
            this.btnGiveBook.Name = "btnGiveBook";
            this.btnGiveBook.Size = new System.Drawing.Size(100, 40);
            this.btnGiveBook.TabIndex = 13;
            this.btnGiveBook.Text = "Give";
            this.btnGiveBook.UseVisualStyleBackColor = false;
            this.btnGiveBook.Click += new System.EventHandler(this.btnGiveBook_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.FlatAppearance.BorderSize = 0;
            this.btnUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserSearch.Location = new System.Drawing.Point(160, 87);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(100, 40);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookSearch.Location = new System.Drawing.Point(40, 147);
            this.txtBookSearch.MaxLength = 64;
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.PlaceholderText = "Book id, book name, author";
            this.txtBookSearch.Size = new System.Drawing.Size(220, 27);
            this.txtBookSearch.TabIndex = 3;
            this.txtBookSearch.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookSearch_KeyDown);
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDueDate.Location = new System.Drawing.Point(160, 395);
            this.txtDueDate.MaxLength = 9;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.PlaceholderText = "";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(100, 27);
            this.txtDueDate.TabIndex = 11;
            this.txtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDueDate.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookId_KeyDown);
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookId.Location = new System.Drawing.Point(40, 301);
            this.txtBookId.MaxLength = 64;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.PlaceholderText = "Book id";
            this.txtBookId.Size = new System.Drawing.Size(220, 27);
            this.txtBookId.TabIndex = 7;
            this.txtBookId.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBookId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookId_KeyDown);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserId.Location = new System.Drawing.Point(40, 254);
            this.txtUserId.MaxLength = 64;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PlaceholderText = "User id";
            this.txtUserId.Size = new System.Drawing.Size(220, 27);
            this.txtUserId.TabIndex = 6;
            this.txtUserId.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserSearch.Location = new System.Drawing.Point(40, 40);
            this.txtUserSearch.MaxLength = 320;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.PlaceholderText = "User id, username, email";
            this.txtUserSearch.Size = new System.Drawing.Size(220, 27);
            this.txtUserSearch.TabIndex = 0;
            this.txtUserSearch.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserSearch_KeyDown);
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
            // CtlPageBookGive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CtlPageBookGive";
            this.Load += new System.EventHandler(this.CtlPageBookGive_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlBookOrder.ResumeLayout(false);
            this.pnlBookOrder.PerformLayout();
            this.pnlUserOrder.ResumeLayout(false);
            this.pnlUserOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Custom.CtlDataGridView ctlDataGridView;
        private Base.BasePanel pnlContainer;
        private BaseButton btnBookSearch;
        private BaseButton btnUserSearch;
        private TxtUnderline txtBookSearch;
        private TxtUnderline txtUserSearch;
        private BaseButton btnGiveBook;
        private TxtUnderline txtBookId;
        private TxtUnderline txtUserId;
        private BaseLabel lblDays;
        private BaseComboBox cboDays;
        private BaseLabel lblDueDate;
        private TxtUnderline txtDueDate;
        private BaseButton btnClear;
        private System.Windows.Forms.RadioButton radbBookZA;
        private System.Windows.Forms.RadioButton radbUserZA;
        private System.Windows.Forms.RadioButton radbBookAZ;
        private System.Windows.Forms.RadioButton radbUserAZ;
        private BasePanel pnlBookOrder;
        private BasePanel pnlUserOrder;
    }
}
