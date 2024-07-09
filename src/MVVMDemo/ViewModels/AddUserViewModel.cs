using System.Windows.Input;
using MVVMDemo.Commands;
using MVVMDemo.Models;

namespace MVVMDemo.ViewModels
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User(Name ?? "", Email ?? ""));
        }

        private bool CanAddUser(object obj)
        {
            return true; // !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email);
        }
    }
}
