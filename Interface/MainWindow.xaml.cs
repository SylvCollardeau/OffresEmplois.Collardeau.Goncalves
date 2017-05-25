
using System.Windows;
using Interface.VueModel;

namespace Interface
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ListOffresVueModel();
        }
    }
}
