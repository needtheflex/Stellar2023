using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace StellarMVVM_2024.Views;

public partial class setting_goals_archive_screen : UserControl
{
    public setting_goals_archive_screen()
    {
        InitializeComponent();
    }
    private void returnPrevious(object sender, PointerReleasedEventArgs e)
    {
        MainWindow.changeView(new archive_screen());
    }
}