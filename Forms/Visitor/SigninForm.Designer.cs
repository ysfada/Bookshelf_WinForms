
using System.ComponentModel;
using Bookshelf.Components;
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Forms.Visitor
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnSignIn = new Bookshelf.Components.Base.BaseButton();
            this.txtUsername = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPassword = new Bookshelf.Components.Custom.TxtUnderline();
            this.lblSignInTitle = new Bookshelf.Components.Base.BaseLabel();
            this.lnkSignUp = new Bookshelf.Components.Base.BaseLinkLabel();
            this.lnkVisitor = new Bookshelf.Components.Base.BaseLinkLabel();
            this.cboLanguage = new Bookshelf.Components.CboLanguage();
            this.cboTheme = new Bookshelf.Components.CboTheme();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignIn.Location = new System.Drawing.Point(185, 242);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 35);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.Location = new System.Drawing.Point(65, 120);
            this.txtUsername.MaxLength = 16;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(220, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.Location = new System.Drawing.Point(65, 177);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(220, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblSignInTitle
            // 
            this.lblSignInTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSignInTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignInTitle.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignInTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignInTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSignInTitle.Name = "lblSignInTitle";
            this.lblSignInTitle.Size = new System.Drawing.Size(350, 60);
            this.lblSignInTitle.TabIndex = 0;
            this.lblSignInTitle.Text = "Sign In";
            this.lblSignInTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSignInTitle.Click += new System.EventHandler(this.lblSignInTitle_Click);
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnkSignUp.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lnkSignUp.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkSignUp.Location = new System.Drawing.Point(45, 327);
            this.lnkSignUp.MaximumSize = new System.Drawing.Size(260, 0);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(233, 18);
            this.lnkSignUp.TabIndex = 4;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Click here to create a new account";
            this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);
            // 
            // lnkVisitor
            // 
            this.lnkVisitor.AutoSize = true;
            this.lnkVisitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnkVisitor.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lnkVisitor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkVisitor.Location = new System.Drawing.Point(45, 365);
            this.lnkVisitor.MaximumSize = new System.Drawing.Size(260, 0);
            this.lnkVisitor.Name = "lnkVisitor";
            this.lnkVisitor.Size = new System.Drawing.Size(223, 36);
            this.lnkVisitor.TabIndex = 5;
            this.lnkVisitor.TabStop = true;
            this.lnkVisitor.Text = "Click here to continue without an account";
            this.lnkVisitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVisitor_LinkClicked);
            // 
            // cboLanguage
            // 
            this.cboLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(9, 464);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(80, 27);
            this.cboLanguage.TabIndex = 6;
            // 
            // cboTheme
            // 
            this.cboTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(261, 464);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(80, 27);
            this.cboTheme.TabIndex = 7;
            // 
            // SignInForm
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lnkVisitor);
            this.Controls.Add(this.lnkSignUp);
            this.Controls.Add(this.lblSignInTitle);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(366, 539);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.TextChanged += new System.EventHandler(this.SignInForm_TextChanged);
            this.Click += new System.EventHandler(this.SignInForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TxtUnderline txtUsername;
        private TxtUnderline txtPassword;
        private BaseButton btnSignIn;
        private BaseLabel lblSignInTitle;
        private BaseLinkLabel lnkSignUp;
        private BaseLinkLabel lnkVisitor;
        private CboLanguage cboLanguage;
        private CboTheme cboTheme;
    }
}