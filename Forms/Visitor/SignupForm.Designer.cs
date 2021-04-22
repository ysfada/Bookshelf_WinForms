
using System.ComponentModel;
using Bookshelf.Components.Base;
using Bookshelf.Components.Custom;

namespace Bookshelf.Forms.Visitor
{
    partial class SignUpForm
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
            this.txtUsername = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtEmail = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPassword = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtFirstName = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtLastName = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtPhone = new Bookshelf.Components.Custom.TxtUnderline();
            this.txtAddress = new Bookshelf.Components.Custom.TxtUnderline();
            this.btnSignUp = new Bookshelf.Components.Base.BaseButton();
            this.lblSignUpTitle = new Bookshelf.Components.Base.BaseLabel();
            this.lnkSignIn = new Bookshelf.Components.Base.BaseLinkLabel();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.Location = new System.Drawing.Point(66, 90);
            this.txtUsername.MaxLength = 16;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(220, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmail.Location = new System.Drawing.Point(66, 137);
            this.txtEmail.MaxLength = 320;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(220, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.Location = new System.Drawing.Point(66, 184);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(220, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFirstName.Location = new System.Drawing.Point(66, 231);
            this.txtFirstName.MaxLength = 16;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "FirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 27);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLastName.Location = new System.Drawing.Point(66, 277);
            this.txtLastName.MaxLength = 16;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(220, 27);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPhone.Location = new System.Drawing.Point(66, 326);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.Size = new System.Drawing.Size(220, 27);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddress.Location = new System.Drawing.Point(66, 372);
            this.txtAddress.MaxLength = 128;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(220, 27);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.UnderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignUp.Location = new System.Drawing.Point(185, 417);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 35);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblSignUpTitle
            // 
            this.lblSignUpTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSignUpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSignUpTitle.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignUpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSignUpTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSignUpTitle.Name = "lblSignUpTitle";
            this.lblSignUpTitle.Size = new System.Drawing.Size(350, 60);
            this.lblSignUpTitle.TabIndex = 0;
            this.lblSignUpTitle.Text = "Sign Up";
            this.lblSignUpTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSignUpTitle.Click += new System.EventHandler(this.lblSignUpTitle_Click);
            // 
            // lnkSignIn
            // 
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnkSignIn.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lnkSignIn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkSignIn.Location = new System.Drawing.Point(66, 464);
            this.lnkSignIn.MaximumSize = new System.Drawing.Size(260, 0);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.Size = new System.Drawing.Size(132, 18);
            this.lnkSignIn.TabIndex = 9;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "Click here to sign in";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignIn_LinkClicked);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.lnkSignIn);
            this.Controls.Add(this.lblSignUpTitle);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(366, 539);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.TextChanged += new System.EventHandler(this.SignUpForm_TextChanged);
            this.Click += new System.EventHandler(this.SignUpForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TxtUnderline txtUsername;
        private TxtUnderline txtEmail;
        private TxtUnderline txtPassword;
        private TxtUnderline txtFirstName;
        private TxtUnderline txtLastName;
        private TxtUnderline txtPhone;
        private TxtUnderline txtAddress;
        private BaseButton btnSignUp;
        private BaseLabel lblSignUpTitle;
        private BaseLinkLabel lnkSignIn;
    }
}