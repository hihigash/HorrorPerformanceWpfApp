using System.Diagnostics;
using System.Windows;

namespace HorrorPerformanceWpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var sw = Stopwatch.StartNew();

        var mgrForAverage = new UserManager("Resources/DummyData.csv");
        NumberOfUsers.Text = $"平均年齢: {mgrForAverage.GetAverageAge()}";
        UserDataGrid.ItemsSource = mgrForAverage.Users;

        sw.Stop();
        LoadTime.Text = $"起動時間 : {sw.Elapsed:mm\\:ss\\.fff}";
    }
}
