using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SkillForge.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object? _currentView;

        [ObservableProperty]
        private string _themeButtonText = "🌙 Mode Gelap";

        public DashboardViewModel DashboardVM { get; } = new();
        public ProjectsViewModel ProjectsVM { get; } = new();
        public ReadinessViewModel ReadinessVM { get; } = new();
        public PipelineViewModel PipelineVM { get; } = new();

        public MainViewModel()
        {
            CurrentView = DashboardVM;
        }

        [RelayCommand]
        private void Navigate(string viewName)
        {
            CurrentView = viewName switch
            {
                "Dashboard" => DashboardVM,
                "Projects" => ProjectsVM,
                "Readiness" => ReadinessVM,
                "Pipeline" => PipelineVM,
                _ => DashboardVM
            };
        }

        [RelayCommand]
        private void ToggleTheme()
        {
            App.ToggleTheme();
            ThemeButtonText = App.IsDarkMode ? "☀️ Mode Terang" : "🌙 Mode Gelap";
        }
    }
}