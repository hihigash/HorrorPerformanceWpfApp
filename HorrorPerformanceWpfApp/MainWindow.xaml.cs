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
        var sw = Stopwatch.StartNew();
        InitializeComponent();
        var userManager = new UserManager(@"./Resources/DummyData.csv");
        UserDataGrid.ItemsSource = userManager.Users;
        NumberOfUsers.Text = $"平均年齢: {userManager.GetAverageAge()}";

        Thread.Sleep(2000); // デバッグ用

        sw.Stop();
        LoadTime.Text = $"起動時間 : {sw.Elapsed:hh\\:mm\\:ss\\.fff}";
    }
}
