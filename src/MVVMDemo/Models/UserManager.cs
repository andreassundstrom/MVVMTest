using System.Collections.ObjectModel;

namespace MVVMDemo.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> DatabaseUsers { get; set; } = new ObservableCollection<User>()
        {
            new User("Andreas", "andreas@test.se"),
            new User("Johanna", "johanna@test.se"),
            new User("Alfred", "alfred@test.se"),
            new User("Selma", "selma@test.se"),
        };

        public static ObservableCollection<User> GetUsers()
        {
            return DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            DatabaseUsers.Add(user);
        }
    }
}
