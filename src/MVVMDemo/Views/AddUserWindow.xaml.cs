using System.Windows;
using MVVMDemo.ViewModels;

namespace MVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
            DataContext = new AddUserViewModel();
        }
    }
}
