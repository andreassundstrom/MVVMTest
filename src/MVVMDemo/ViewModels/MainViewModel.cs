using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMDemo.Commands;
using MVVMDemo.Models;
using MVVMDemo.Views;

namespace MVVMDemo.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.Show();
        }
    }
}
