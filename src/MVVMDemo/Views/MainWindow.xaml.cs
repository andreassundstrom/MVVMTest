using System.Windows;
using MVVMDemo.Models;
using MVVMDemo.ViewModels;

namespace MVVMDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            if (obj is User user)
            {
                return user.Name is not null && user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}