using System.Windows;

namespace HorrorPerformanceWpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly UserManager _userManager;

    public MainWindow()
    {
        InitializeComponent();
        _userManager = new UserManager(@"./Resources/DummyData.csv");
        UserDataGrid.ItemsSource = _userManager.Users;
        NumberOfUsers.Text = $"平均年齢: {_userManager.GetAverageAge()}";

        Thread.Sleep(2000); // デバッグ用
    }
}
