using System.Drawing;

namespace MunicipalServices
{
    /// <summary>
    /// Shared colour palette and fonts so every form in the application looks consistent.
    /// </summary>
    internal static class UiTheme
    {
        public static readonly Color Primary = Color.FromArgb(0, 90, 156);
        public static readonly Color PrimaryDark = Color.FromArgb(0, 64, 112);
        public static readonly Color Accent = Color.FromArgb(0, 153, 76);
        public static readonly Color Background = Color.FromArgb(245, 247, 250);
        public static readonly Color TextLight = Color.White;
        public static readonly Color TextDark = Color.FromArgb(33, 37, 41);
        public static readonly Color Disabled = Color.FromArgb(189, 195, 199);

        public static readonly Font TitleFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static readonly Font HeadingFont = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font BodyFont = new Font("Segoe UI", 10F);
    }
}
