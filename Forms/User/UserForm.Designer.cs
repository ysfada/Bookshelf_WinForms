
using Bookshelf.Components;
using Bookshelf.Components.Base;
using Bookshelf.Components.Pages.BookSearchPage;
using Bookshelf.Components.Pages.HomePage;

namespace Bookshelf.Forms.User
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pnlNavigation = new BasePanel();
            this.btnPageBookSearch = new BtnPageBookSearch();
            this.btnPageHome = new BtnPageHome();
            this.ctlHeader = new CtlHeader();
            this.pnlMain = new BasePanel();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNavigation.Controls.Add(this.btnPageBookSearch);
            this.pnlNavigation.Controls.Add(this.btnPageHome);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 500);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnPageBookSearch
            // 
            this.btnPageBookSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageBookSearch.FlatAppearance.BorderSize = 0;
            this.btnPageBookSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPageBookSearch.Image")));
            this.btnPageBookSearch.Location = new System.Drawing.Point(5, 250);
            this.btnPageBookSearch.Name = "btnPageBookSearch";
            this.btnPageBookSearch.Size = new System.Drawing.Size(190, 50);
            this.btnPageBookSearch.TabIndex = 3;
            this.btnPageBookSearch.UseVisualStyleBackColor = false;
            // 
            // btnPageHome
            // 
            this.btnPageHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPageHome.FlatAppearance.BorderSize = 0;
            this.btnPageHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPageHome.Image = ((System.Drawing.Image)(resources.GetObject("btnPageHome.Image")));
            this.btnPageHome.Location = new System.Drawing.Point(5, 199);
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ctlHeader);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.TextChanged += new System.EventHandler(this.UserForm_TextChanged);
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BasePanel pnlNavigation;
        private CtlHeader ctlHeader;
        private BasePanel pnlMain;
        private BtnPageBookSearch btnPageBookSearch;
        private BtnPageHome btnPageHome;
    }
}