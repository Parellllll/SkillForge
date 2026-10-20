using System.Windows;
using System.Windows.Media;

namespace SkillForge
{
    public partial class App : Application
    {
        public static bool IsDarkMode { get; private set; } = false;

        public static void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;

            var res = Current.Resources;

            if (IsDarkMode)
            {
                // Palet Warna Dark Mode (Slate / Midnight)
                res["AppBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#090D16"));
                res["CardBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#131C2E"));
                res["InnerCardBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1E293B"));
                res["BorderBrushColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#334155"));
                res["TextPrimaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));
                res["TextSecondaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#94A3B8"));
            }
            else
            {
                // Palet Warna Light Mode
                res["AppBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F1F5F9"));
                res["CardBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                res["InnerCardBgBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8FAFC"));
                res["BorderBrushColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E2E8F0"));
                res["TextPrimaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0F172A"));
                res["TextSecondaryBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64748B"));
            }
        }
    }
}