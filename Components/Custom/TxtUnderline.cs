using Bookshelf.Components.Base;
using Bookshelf.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshelf.Components.Custom
{
    public class TxtUnderline : BaseTextBox
    {
        public TxtUnderline()
        {
            WireUpTxtUnderline();
        }

        private void WireUpTxtUnderline()
        {
            AutoSize = false;
            Size = new Size(100, 27);
            BorderStyle = BorderStyle.None;
            PlaceholderText = @"Placeholder";

            ShowUnderline = true;
            UnderlineHeight = 2;
            UnderlineLocation = new Point(0, 25);
            UnderlineColor = Themes.Colors.Light.OnBackground.ToColor();
            UnderlineFocusColor = Themes.Colors.Light.Secondary.ToColor();
            Controls.Add(new BasePanel
            {
                Name = "underlinePanel",
                Visible = ShowUnderline,
                Width = Width,
                Height = UnderlineHeight,
                Location = UnderlineLocation,
                BackColor = UnderlineColor,
                ForeColor = UnderlineColor
            });

            GotFocus += OnGotFocus;
            LostFocus += OnLostFocus;
            SizeChanged += OnSizeChanged;
            ShowUnderlineChangedEvent += OnShowUnderlineChangedEvent;
            UnderlineLocationChangedEvent += OnUnderlineLocationChangedEvent;
            UnderlineHeightChangedEvent += OnUnderlineHeightChangedEvent;
            UnderlineColorChangedEvent += OnUnderlineColorChangedEvent;
        }

        private void OnGotFocus(object sender, EventArgs e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].BackColor == UnderlineFocusColor) return;

            Controls["underlinePanel"].BackColor = UnderlineFocusColor;
        }

        private void OnLostFocus(object sender, EventArgs e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].BackColor == UnderlineColor) return;

            Controls["underlinePanel"].BackColor = UnderlineColor;
        }

        [DefaultValue(typeof(bool), "False")]
        public sealed override bool AutoSize
        {
            get => base.AutoSize;
            set => base.AutoSize = value;
        }

        [DefaultValue(typeof(Size), "100, 27")]
        public new Size Size
        {
            get => base.Size;
            set => base.Size = value;
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].Width == Width) return;

            Controls["underlinePanel"].Width = Width;
            UnderlineLocation = new Point(0, Height - UnderlineHeight);
        }

        [DefaultValue(typeof(BorderStyle), "0")]
        public new BorderStyle BorderStyle
        {
            get => base.BorderStyle;
            set => base.BorderStyle = value;
        }

        [DefaultValue(typeof(string), "Placeholder")]
        public sealed override string PlaceholderText
        {
            get => base.PlaceholderText;
            set => base.PlaceholderText = value;
        }

        private Color _underlineColor;

        private event EventHandler<Color> UnderlineColorChangedEvent;

        private void OnUnderlineColorChangedEvent(object sender, Color e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].BackColor == e) return;

            Controls["underlinePanel"].BackColor = e;
            Controls["underlinePanel"].ForeColor = e;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "0x000000")]
        public Color UnderlineColor
        {
            get => _underlineColor;
            set
            {
                if (_underlineColor == value) return;

                _underlineColor = value;
                UnderlineColorChangedEvent?.Invoke(this, value);
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "0x03DAC6")]
        public Color UnderlineFocusColor { get; set; }

        private bool _showUnderline;

        private event EventHandler<bool> ShowUnderlineChangedEvent;

        private void OnShowUnderlineChangedEvent(object sender, bool e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].Visible == e) return;

            Controls["underlinePanel"].Visible = e;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(bool), "True")]
        public bool ShowUnderline
        {
            get => _showUnderline;
            set
            {
                if (_showUnderline == value) return;

                _showUnderline = value;
                ShowUnderlineChangedEvent?.Invoke(this, value);
            }
        }

        private int _underlineHeight;

        private event EventHandler<int> UnderlineHeightChangedEvent;

        private void OnUnderlineHeightChangedEvent(object sender, int e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].Height == e) return;

            Controls["underlinePanel"].Height = e;
            UnderlineLocation = new Point(0, Height - e);
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(int), "2")]
        public int UnderlineHeight
        {
            get => _underlineHeight;
            set
            {
                if (_underlineHeight == value) return;

                _underlineHeight = value;
                UnderlineHeightChangedEvent?.Invoke(this, _underlineHeight);
            }
        }

        private Point _underlineLocation = new(0, 25);

        private event EventHandler<Point> UnderlineLocationChangedEvent;

        private void OnUnderlineLocationChangedEvent(object sender, Point e)
        {
            if (Controls["underlinePanel"] == null || Controls["underlinePanel"].Location == e) return;

            Controls["underlinePanel"].Location = e;
        }

        private Point UnderlineLocation
        {
            get => _underlineLocation;
            set
            {
                if (_underlineLocation == value) return;

                _underlineLocation = value;
                UnderlineLocationChangedEvent?.Invoke(this, value);
            }
        }
    }
}
