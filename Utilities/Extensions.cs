using Bookshelf.Database.Entities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bookshelf.Utilities
{
    internal static class Extensions
    {
        internal static void AddForm(this Form self, Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Size = self.Size;
            form.Dock = DockStyle.Fill;

            self.Controls.Clear();
            self.Controls.Add(form);
            self.Text = form.Text;
            self.StartPosition = FormStartPosition.CenterScreen;

            form.BringToFront();
            form.Show();
        }

        internal static void AddControl(this Control.ControlCollection self, Control control)
        {
            control.Size = self.Owner.Size;
            control.Dock = DockStyle.Fill;

            self.Clear();
            self.Add(control);

            self.Owner.Text = control.Text;

            control.BringToFront();
            control.Show();
        }

        internal static void AddControlTo(this Control self, string name, Control control)
        {
            var targetCtlControl = self.Controls[name];

            control.Size = targetCtlControl.Size;
            control.Dock = DockStyle.Fill;

            targetCtlControl.Controls.Clear();
            targetCtlControl.Controls.Add(control);

            self.Controls.Owner.Text = control.Text;

            control.BringToFront();
            control.Show();
        }

        internal static Color ToColor(this int rgb)
        {
            return Color.FromArgb(
                (rgb & 0xff0000) >> 16,
                (rgb & 0xff00) >> 8,
                rgb & 0xff);
        }

        internal static Color ToColor(this string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        internal static Size ToSize(this string size)
        {
            var list = size.Split(",").Select(s => Convert.ToInt32(s)).ToList();
            return new Size(list[0], list[1]);
        }

        internal static Font ToFont(this string font)
        {
            var split = font.Split(",");
            return new Font(split[0], float.Parse(split[1]));
        }

        internal static Role ToRole(this string role)
        {
            return (Role) Enum.Parse(typeof(Role), role);
        }

        internal static Genre ToGenre(this string genre)
        {
            return (Genre) Enum.Parse(typeof(Genre), genre);
        }

        internal static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Gets the value of the specified column as a string.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="colIndex"></param>
        /// <returns>The value of the specified column if column is not null or string.Empty.</returns>
        internal static string GetStringSafe(this SqlDataReader reader, int colIndex)
        {
            return !reader.IsDBNull(colIndex) ? reader.GetString(colIndex) : string.Empty;
        }

        /// <summary>
        /// Gets the value of the specified column as a System.DateTime object.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="colIndex"></param>
        /// <returns>The value of the specified column if column is not null or DateTime.MinValue.</returns>
        internal static DateTime GetDateTimeSafe(this SqlDataReader reader, int colIndex)
        {
            return !reader.IsDBNull(colIndex) ? reader.GetDateTime(colIndex) : DateTime.MinValue;
        }

        /// <summary>
        /// Gets the value of the specified column as a globally unique identifier (GUID).
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="colIndex"></param>
        /// <returns>The value of the specified column if column is not null or Guid.Empty.</returns>
        internal static Guid GetGuidSafe(this SqlDataReader reader, int colIndex)
        {
            return !reader.IsDBNull(colIndex) ? reader.GetGuid(colIndex) : Guid.Empty;
        }
    }
}