
using Bookshelf.Components.Base;

namespace Bookshelf.Components.Pages.HomePage
{
    partial class CtlPageHome
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
            this.lblTitle = new Bookshelf.Components.Base.BaseLabel();
            this.baseLabel1 = new Bookshelf.Components.Base.BaseLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(305, 220);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home Page";
            // 
            // baseLabel1
            // 
            this.baseLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseLabel1.AutoSize = true;
            this.baseLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.baseLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseLabel1.Location = new System.Drawing.Point(310, 239);
            this.baseLabel1.Name = "baseLabel1";
            this.baseLabel1.Size = new System.Drawing.Size(80, 19);
            this.baseLabel1.TabIndex = 0;
            this.baseLabel1.Text = "Ana Sayfa";
            // 
            // CtlPageHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseLabel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "CtlPageHome";
            this.Text = "Wellcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Base.BaseLabel lblTitle;
        private BaseLabel baseLabel1;
    }
}
