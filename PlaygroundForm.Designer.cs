
using System.ComponentModel;
using Bookshelf.Components.Base;

namespace Bookshelf
{
    partial class PlaygroundForm
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
            this.btnTogglePie = new BaseButton();
            this.pnlPie = new BasePanel();
            this.lblTitle = new BaseLabel();
            this.lblP6 = new BaseLabel();
            this.lblP5 = new BaseLabel();
            this.lblP4 = new BaseLabel();
            this.lblP3 = new BaseLabel();
            this.lblP2 = new BaseLabel();
            this.lblP1 = new BaseLabel();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTogglePie
            // 
            this.btnTogglePie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTogglePie.FlatAppearance.BorderSize = 0;
            this.btnTogglePie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTogglePie.Location = new System.Drawing.Point(400, 50);
            this.btnTogglePie.Name = "btnTogglePie";
            this.btnTogglePie.Size = new System.Drawing.Size(100, 40);
            this.btnTogglePie.TabIndex = 0;
            this.btnTogglePie.Text = "Toggle Pie";
            this.btnTogglePie.UseVisualStyleBackColor = false;
            this.btnTogglePie.Click += new System.EventHandler(this.btnTogglePie_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlPie.Controls.Add(this.lblTitle);
            this.pnlPie.Controls.Add(this.lblP6);
            this.pnlPie.Controls.Add(this.lblP5);
            this.pnlPie.Controls.Add(this.lblP4);
            this.pnlPie.Controls.Add(this.lblP3);
            this.pnlPie.Controls.Add(this.lblP2);
            this.pnlPie.Controls.Add(this.lblP1);
            this.pnlPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlPie.Location = new System.Drawing.Point(350, 150);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(300, 225);
            this.pnlPie.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(37, 204);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "fibonacci sequence";
            // 
            // lblP6
            // 
            this.lblP6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP6.AutoSize = true;
            this.lblP6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP6.Location = new System.Drawing.Point(220, 141);
            this.lblP6.Name = "lblP6";
            this.lblP6.Size = new System.Drawing.Size(24, 17);
            this.lblP6.TabIndex = 0;
            this.lblP6.Text = "p6";
            // 
            // lblP5
            // 
            this.lblP5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP5.AutoSize = true;
            this.lblP5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP5.Location = new System.Drawing.Point(220, 121);
            this.lblP5.Name = "lblP5";
            this.lblP5.Size = new System.Drawing.Size(24, 17);
            this.lblP5.TabIndex = 0;
            this.lblP5.Text = "p5";
            // 
            // lblP4
            // 
            this.lblP4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP4.AutoSize = true;
            this.lblP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP4.Location = new System.Drawing.Point(220, 101);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(24, 17);
            this.lblP4.TabIndex = 0;
            this.lblP4.Text = "p4";
            // 
            // lblP3
            // 
            this.lblP3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP3.AutoSize = true;
            this.lblP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP3.Location = new System.Drawing.Point(220, 81);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(24, 17);
            this.lblP3.TabIndex = 0;
            this.lblP3.Text = "p3";
            // 
            // lblP2
            // 
            this.lblP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP2.AutoSize = true;
            this.lblP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP2.Location = new System.Drawing.Point(220, 61);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(24, 17);
            this.lblP2.TabIndex = 0;
            this.lblP2.Text = "p2";
            // 
            // lblP1
            // 
            this.lblP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblP1.AutoSize = true;
            this.lblP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblP1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblP1.Location = new System.Drawing.Point(220, 41);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(24, 17);
            this.lblP1.TabIndex = 0;
            this.lblP1.Text = "p1";
            // 
            // PlaygroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.btnTogglePie);
            this.Name = "PlaygroundForm";
            this.Text = "PlaygroundForm";
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseButton btnTogglePie;
        private BasePanel pnlPie;
        private BaseLabel lblP1;
        private BaseLabel lblP6;
        private BaseLabel lblP5;
        private BaseLabel lblP4;
        private BaseLabel lblP3;
        private BaseLabel lblP2;
        private BaseLabel lblTitle;
    }
}