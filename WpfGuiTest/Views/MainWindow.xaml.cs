using System.Windows;

using WpfGuiTest.ViewModel;

namespace WpfGuiTest.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Konstruktor des MainWindows
        /// </summary>
        public MainWindow()
        {
            // GUI builden
            InitializeComponent();

            // DataContext festlegen
            DataContext = new TestViewModel();
        }

        /// <summary>
        /// Settings Flyout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click( object sender, RoutedEventArgs e ) => SettingsFlyout.IsOpen = !SettingsFlyout.IsOpen;
    }
}