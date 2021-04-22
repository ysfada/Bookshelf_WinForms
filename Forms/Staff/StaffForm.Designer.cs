
using Bookshelf.Components;
using Bookshelf.Components.Base;
using Bookshelf.Components.Pages.BookAddPage;
using Bookshelf.Components.Pages.BookEditPage;
using Bookshelf.Components.Pages.BookGivePage;
using Bookshelf.Components.Pages.BookRemovePage;
using Bookshelf.Components.Pages.BookSearchPage;
using Bookshelf.Components.Pages.BookTakePage;
using Bookshelf.Components.Pages.HomePage;
using Bookshelf.Components.Pages.UserSearchPage;

namespace Bookshelf.Forms.Staff
{
    partial class StaffForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.pnlNavigation = new Bookshelf.Components.Base.BasePanel();
            this.btnPageUserEdit = new Bookshelf.Components.Pages.UserEditPage.BtnPageUserEdit();
            this.btnPageUserSearch = new Bookshelf.Components.Pages.UserSearchPage.BtnPageUserSearch();
            this.btnPageBookEdit = new Bookshelf.Components.Pages.BookEditPage.BtnPageBookEdit();
            this.btnPageBookRemove = new Bookshelf.Components.Pages.BookRemovePage.BtnPageBookRemove();
            this.btnPageBookAdd = new Bookshelf.Components.Pages.BookAddPage.BtnPageBookAdd();
            this.btnPageBookSearch = new Bookshelf.Components.Pages.BookSearchPage.BtnPageBookSearch();
            this.btnPageBookTake = new Bookshelf.Components.Pages.BookTakePage.BtnPageBookTake();
            this.btnPageBookGive = new Bookshelf.Components.Pages.BookGivePage.BtnPageBookGive();
            this.btnPageHome = new Bookshelf.Components.Pages.HomePage.BtnPageHome();
            this.ctlHeader = new Bookshelf.Components.CtlHeader();
            this.pnlMain = new Bookshelf.Components.Base.BasePanel();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.AutoScroll = true;
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNavigation.Controls.Add(this.btnPageUserEdit);
            this.pnlNavigation.Controls.Add(this.btnPageUserSearch);
            this.pnlNavigation.Controls.Add(this.btnPageBookEdit);
            this.pnlNavigation.Controls.Add(this.btnPageBookRemove);
            this.pnlNavigation.Controls.Add(this.btnPageBookAdd);
            this.pnlNavigation.Controls.Add(this.btnPageBookSearch);
            this.pnlNavigation.Controls.Add(this.btnPageBookTake);
            this.pnlNavigation.Controls.Add(this.btnPageBookGive);
            this.pnlNavigation.Controls.Add(this.btnPageHome);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 500);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnPageUserEdit
            // 
            this.btnPageUserEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageUserEdit.FlatAppearance.BorderSize = 0;
            this.btnPageUserEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageUserEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnPageUserEdit.Image")));
            this.btnPageUserEdit.Location = new System.Drawing.Point(5, 431);
            this.btnPageUserEdit.Name = "btnPageUserEdit";
            this.btnPageUserEdit.Size = new System.Drawing.Size(190, 50);
            this.btnPageUserEdit.TabIndex = 8;
            this.btnPageUserEdit.Text = "Edit user";
            this.btnPageUserEdit.UseVisualStyleBackColor = false;
            // 
            // btnPageUserSearch
            // 
            this.btnPageUserSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageUserSearch.FlatAppearance.BorderSize = 0;
            this.btnPageUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageUserSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPageUserSearch.Image")));
            this.btnPageUserSearch.Location = new System.Drawing.Point(5, 380);
            this.btnPageUserSearch.Name = "btnPageUserSearch";
            this.btnPageUserSearch.Size = new System.Drawing.Size(190, 50);
            this.btnPageUserSearch.TabIndex = 7;
            this.btnPageUserSearch.UseVisualStyleBackColor = false;
            // 
            // btnPageBookEdit
            // 
            this.btnPageBookEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookEdit.FlatAppearance.BorderSize = 0;
            this.btnPageBookEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookEdit.Image")));
            this.btnPageBookEdit.Location = new System.Drawing.Point(5, 329);
            this.btnPageBookEdit.Name = "btnPageBookEdit";
            this.btnPageBookEdit.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookEdit.TabIndex = 6;
            this.btnPageBookEdit.UseVisualStyleBackColor = false;
            // 
            // btnPageBookRemove
            // 
            this.btnPageBookRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookRemove.FlatAppearance.BorderSize = 0;
            this.btnPageBookRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookRemove.Image")));
            this.btnPageBookRemove.Location = new System.Drawing.Point(5, 278);
            this.btnPageBookRemove.Name = "btnPageBookRemove";
            this.btnPageBookRemove.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookRemove.TabIndex = 5;
            this.btnPageBookRemove.UseVisualStyleBackColor = false;
            // 
            // btnPageBookAdd
            // 
            this.btnPageBookAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookAdd.FlatAppearance.BorderSize = 0;
            this.btnPageBookAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookAdd.Image")));
            this.btnPageBookAdd.Location = new System.Drawing.Point(5, 227);
            this.btnPageBookAdd.Name = "btnPageBookAdd";
            this.btnPageBookAdd.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookAdd.TabIndex = 4;
            this.btnPageBookAdd.UseVisualStyleBackColor = false;
            // 
            // btnPageBookSearch
            // 
            this.btnPageBookSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookSearch.FlatAppearance.BorderSize = 0;
            this.btnPageBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookSearch.Image")));
            this.btnPageBookSearch.Location = new System.Drawing.Point(5, 176);
            this.btnPageBookSearch.Name = "btnPageBookSearch";
            this.btnPageBookSearch.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookSearch.TabIndex = 3;
            this.btnPageBookSearch.UseVisualStyleBackColor = false;
            // 
            // btnPageBookTake
            // 
            this.btnPageBookTake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookTake.FlatAppearance.BorderSize = 0;
            this.btnPageBookTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookTake.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookTake.Image")));
            this.btnPageBookTake.Location = new System.Drawing.Point(5, 125);
            this.btnPageBookTake.Name = "btnPageBookTake";
            this.btnPageBookTake.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookTake.TabIndex = 2;
            this.btnPageBookTake.UseVisualStyleBackColor = false;
            // 
            // btnPageBookGive
            // 
            this.btnPageBookGive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookGive.FlatAppearance.BorderSize = 0;
            this.btnPageBookGive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookGive.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookGive.Image")));
            this.btnPageBookGive.Location = new System.Drawing.Point(5, 74);
            this.btnPageBookGive.Name = "btnPageBookGive";
            this.btnPageBookGive.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookGive.TabIndex = 1;
            this.btnPageBookGive.UseVisualStyleBackColor = false;
            // 
            // btnPageHome
            // 
            this.btnPageHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageHome.FlatAppearance.BorderSize = 0;
            this.btnPageHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageHome.Image = ((System.Drawing.Image)(resources.GetObject("btnPageHome.Image")));
            this.btnPageHome.Location = new System.Drawing.Point(5, 23);
            this.btnPageHome.Name = "btnPageHome";
            this.btnPageHome.Size = new System.Drawing.Size(190, 50);
            this.btnPageHome.TabIndex = 0;
            this.btnPageHome.UseVisualStyleBackColor = false;
            // 
            // ctlHeader
            // 
            this.ctlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ctlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctlHeader.Location = new System.Drawing.Point(200, 0);
            this.ctlHeader.Name = "ctlHeader";
            this.ctlHeader.Size = new System.Drawing.Size(700, 40);
            this.ctlHeader.TabIndex = 12;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlMain.Location = new System.Drawing.Point(200, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(700, 460);
            this.pnlMain.TabIndex = 13;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ctlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "StaffForm";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.TextChanged += new System.EventHandler(this.StaffForm_TextChanged);
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BasePanel pnlNavigation;
        private CtlHeader ctlHeader;
        private BasePanel pnlMain;
        private BtnPageUserSearch btnPageUserSearch;
        private BtnPageBookEdit btnPageBookEdit;
        private BtnPageBookRemove btnPageBookRemove;
        private BtnPageBookAdd btnPageBookAdd;
        private BtnPageBookSearch btnPageBookSearch;
        private BtnPageBookTake btnPageBookTake;
        private BtnPageBookGive btnPageBookGive;
        private BtnPageHome btnPageHome;
        private Components.Pages.UserEditPage.BtnPageUserEdit btnPageUserEdit;
    }
}