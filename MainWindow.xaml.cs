using OpusOneEmulator.Controls;

using System.Windows;

namespace OpusOneEmulator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new PlannerDaily();
        }
        private void DailyButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new PlannerDaily();
        }
        private void WeeklyButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new PlannerWeekly();
        }
        private void MonthlyButton_Click( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("Monthly planner - Coming soon!");
        }
        private void TasksButton_Click( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("Tasks view - Coming soon!");
        }
        private void NotesButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new NotesPane();
        }
        private void GoalsButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new GoalsPane();
        }
        private void WeatherButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new WeatherPane();
        }
        private void MeetingsButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new MeetingPlanner();
        }
        private void SettingsButton_Click( object sender, RoutedEventArgs e )
        {
            MainContent.Content = new SettingsPane();
        }
    }
}