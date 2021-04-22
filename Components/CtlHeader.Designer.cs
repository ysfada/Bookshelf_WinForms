
using Bookshelf.Components.Base;

namespace Bookshelf.Components
{
    partial class CtlHeader
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlHeader));
			this.cboLanguage = new Bookshelf.Components.CboLanguage();
			this.cboTheme = new Bookshelf.Components.CboTheme();
			this.btnSignOut = new Bookshelf.Components.BtnSignOut();
			this.lblCurrentUser = new Bookshelf.Components.Base.BaseLabel();
			this.lblClock = new Bookshelf.Components.Base.BaseLabel();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// cboLanguage
			// 
			this.cboLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cboLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.cboLanguage.FormattingEnabled = true;
			this.cboLanguage.Location = new System.Drawing.Point(5, 7);
			this.cboLanguage.Name = "cboLanguage";
			this.cboLanguage.Size = new System.Drawing.Size(80, 27);
			this.cboLanguage.TabIndex = 0;
			// 
			// cboTheme
			// 
			this.cboTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cboTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.cboTheme.FormattingEnabled = true;
			this.cboTheme.Location = new System.Drawing.Point(85, 7);
			this.cboTheme.Name = "cboTheme";
			this.cboTheme.Size = new System.Drawing.Size(80, 27);
			this.cboTheme.TabIndex = 1;
			// 
			// btnSignOut
			// 
			this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSignOut.FlatAppearance.BorderSize = 0;
			this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
			this.btnSignOut.Location = new System.Drawing.Point(655, 0);
			this.btnSignOut.Name = "btnSignOut";
			this.btnSignOut.Size = new System.Drawing.Size(40, 40);
			this.btnSignOut.TabIndex = 4;
			this.btnSignOut.UseVisualStyleBackColor = false;
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblCurrentUser.Location = new System.Drawing.Point(490, 0);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(165, 40);
			this.lblCurrentUser.TabIndex = 3;
			this.lblCurrentUser.Text = "Visitor";
			this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblClock
			// 
			this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblClock.Location = new System.Drawing.Point(165, 0);
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(75, 40);
			this.lblClock.TabIndex = 2;
			this.lblClock.Text = "23:59:59";
			this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// CtlHeader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblClock);
			this.Controls.Add(this.lblCurrentUser);
			this.Controls.Add(this.btnSignOut);
			this.Controls.Add(this.cboTheme);
			this.Controls.Add(this.cboLanguage);
			this.Name = "CtlHeader";
			this.Size = new System.Drawing.Size(700, 40);
			this.ResumeLayout(false);

        }

        #endregion

        private CboLanguage cboLanguage;
        private CboTheme cboTheme;
        private BtnSignOut btnSignOut;
        private Base.BaseLabel lblCurrentUser;
        private Base.BaseLabel lblClock;
        private System.Windows.Forms.Timer timer;
    }
}
