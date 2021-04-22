
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Components.Pages.UserEditPage
{
    partial class CtlPageUserEdit
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
            this.pnlUserOrder = new Bookshelf.Components.Base.BasePanel();
            this.radbUserAZ = new System.Windows.Forms.RadioButton();
            this.radbUserZA = new System.Windows.Forms.RadioButton();
            this.lblRole = new Bookshelf.Components.Base.BaseLabel();
            this.cboRole = new Bookshelf.Components.Base.BaseComboBox();
            this.txtAddress = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPhone = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtLastName = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtFirstName = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPassword = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtEmail = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtUserId = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtUsername = new Bookshelf.Components.Custom.TxtUnderline();
            this.btnClear = new Bookshelf.Components.Base.BaseButton();
            this.btnUserSearch = new Bookshelf.Components.Base.BaseButton();
            this.btnEdit = new Bookshelf.Components.Base.BaseButton();
            this.txtUserSearch = new Bookshelf.Components.Custom.TxtUnderline();
            this.ctlDataGridView = new Bookshelf.Components.Custom.CtlDataGridView();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlUserOrder.SuspendLayout();
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
            this.pnlContainer.Controls.Add(this.pnlUserOrder);
            this.pnlContainer.Controls.Add(this.lblRole);
            this.pnlContainer.Controls.Add(this.cboRole);
            this.pnlContainer.Controls.Add(this.txtAddress);
            this.pnlContainer.Controls.Add(this.txtPhone);
            this.pnlContainer.Controls.Add(this.txtLastName);
            this.pnlContainer.Controls.Add(this.txtFirstName);
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.txtUserId);
            this.pnlContainer.Controls.Add(this.txtUsername);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.btnUserSearch);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.txtUserSearch);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlContainer.Location = new System.Drawing.Point(400, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(300, 460);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Click += new System.EventHandler(this.pnlContainer_Click);
            // 
            // pnlUserOrder
            // 
            this.pnlUserOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlUserOrder.Controls.Add(this.radbUserAZ);
            this.pnlUserOrder.Controls.Add(this.radbUserZA);
            this.pnlUserOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUserOrder.Location = new System.Drawing.Point(40, 86);
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
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRole.Location = new System.Drawing.Point(40, 522);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 19);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(130, 522);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(130, 27);
            this.cboRole.TabIndex = 12;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddress.Location = new System.Drawing.Point(40, 475);
            this.txtAddress.MaxLength = 128;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(220, 27);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPhone.Location = new System.Drawing.Point(40, 428);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.Size = new System.Drawing.Size(220, 27);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLastName.Location = new System.Drawing.Point(40, 381);
            this.txtLastName.MaxLength = 32;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last name";
            this.txtLastName.Size = new System.Drawing.Size(220, 27);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFirstName.Location = new System.Drawing.Point(40, 334);
            this.txtFirstName.MaxLength = 32;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First name";
            this.txtFirstName.Size = new System.Drawing.Size(220, 27);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 287);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(220, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 240);
            this.txtEmail.MaxLength = 320;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(220, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserId.Location = new System.Drawing.Point(40, 146);
            this.txtUserId.MaxLength = 64;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PlaceholderText = "User id";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(220, 27);
            this.txtUserId.TabIndex = 3;
            this.txtUserId.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.Location = new System.Drawing.Point(40, 193);
            this.txtUsername.MaxLength = 32;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(220, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(35, 569);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.FlatAppearance.BorderSize = 0;
            this.btnUserSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserSearch.Location = new System.Drawing.Point(160, 86);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(100, 40);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(160, 569);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // CtlPageUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CtlPageUserEdit";
            this.Load += new System.EventHandler(this.CtlPageUserEdit_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlUserOrder.ResumeLayout(false);
            this.pnlUserOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Custom.CtlDataGridView ctlDataGridView;
        private Base.BasePanel pnlContainer;
        private BaseButton btnEdit;
        private BaseButton btnClear;
        private BaseButton btnUserSearch;
        private TxtUnderline txtUserSearch;
        private BaseLabel lblRole;
        private BaseComboBox cboRole;
        private TxtUnderline txtAddress;
        private TxtUnderline txtPhone;
        private TxtUnderline txtLastName;
        private TxtUnderline txtFirstName;
        private TxtUnderline txtPassword;
        private TxtUnderline txtEmail;
        private TxtUnderline txtUsername;
        private TxtUnderline txtUserId;
        private BasePanel pnlUserOrder;
        private System.Windows.Forms.RadioButton radbUserAZ;
        private System.Windows.Forms.RadioButton radbUserZA;
    }
}
