using System.Formats.Asn1;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValorantStatsAPP.ViewModels;

namespace ValorantStatsAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;
            //Loaded += MainWindow_Loaded;
        }

        //private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
            //await _viewModel.LoadMatchesAsync();
        //}

        private async void ButtonGetUuid_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtTag.Text))
            {
                await _viewModel.LoadMatchesAsync(txtName.Text, txtTag.Text);
                
            }
        }
    }
}