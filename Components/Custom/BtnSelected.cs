using Bookshelf.Components.Base;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Custom
{
    public class BtnSelected : BaseButton
    {
        public BtnSelected()
        {
            WireUpBtnSelected();
        }

        private void WireUpBtnSelected()
        {
            Size = new Size(190, 50);
            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleLeft;

            // TODO: make name "selectedPanel" Color configurable
            Controls.Add(new BasePanel
            {
                Name = "selectedPanel",
                Visible = false,
                Width = 7,
                Height = Height,
                Location = new Point(0, Location.Y),
                BackColor = Themes.Colors.Light.Secondary.ToColor(),
                ForeColor = Themes.Colors.Light.Secondary.ToColor()
            });

            Resize += OnResize;
        }

        public static BtnSelected CurrentBtn { get; set; }

        public new ImageList ImageList = new()
        {
            ImageSize = new Size(32, 32),
            ColorDepth = ColorDepth.Depth32Bit
        };

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            CurrentBtn?.ResetState();
            CurrentBtn = this;
            SetState();
        }

        private void OnResize(object sender, EventArgs e)
        {
            if (Controls["selectedPanel"] == null) return;

            Controls["selectedPanel"].Height = Height;
            //SetState();
        }

        private void SetState()
        {
            if (DesignMode || Controls["selectedPanel"] == null) return;

            Controls["selectedPanel"].Visible = true;
            TextImageRelation = TextImageRelation.TextBeforeImage;
            ImageAlign = ContentAlignment.MiddleRight;
            TextAlign = ContentAlignment.MiddleRight;
        }

        private void ResetState()
        {
            if (DesignMode || Controls["selectedPanel"] == null) return;

            Controls["selectedPanel"].Visible = false;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        [DefaultValue(typeof(Size), "190, 50")]
        public new Size Size
        {
            get => base.Size;
            set => base.Size = value;
        }

        [DefaultValue(typeof(TextImageRelation), "4")]
        public new TextImageRelation TextImageRelation
        {
            get => base.TextImageRelation;
            set => base.TextImageRelation = value;
        }

        [DefaultValue(typeof(ContentAlignment), "16")]
        public new ContentAlignment ImageAlign
        {
            get => base.ImageAlign;
            set => base.ImageAlign = value;
        }

        [DefaultValue(typeof(ContentAlignment), "16")]
        public sealed override ContentAlignment TextAlign
        {
            get => base.TextAlign;
            set => base.TextAlign = value;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(string), "pnlMain")]
        public string ControlName { get; set; } = "pnlMain";
    }
}
