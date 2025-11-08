using System.Collections.ObjectModel;
using System.Linq;

namespace WpfApp2
{
    public class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsersFromDatabase();
        }

        private void LoadUsersFromDatabase()
        {
            using (var context = new AppDbContext())
            {

                context.Database.EnsureCreated();

                var users = context.Users.ToList();
                foreach (var user in users)
                {
                    Users.Add(user);
                }
            }
        }
    }
}