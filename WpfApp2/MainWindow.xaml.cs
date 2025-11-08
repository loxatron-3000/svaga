using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using var db = new AppDbContext();
            UsersListView.ItemsSource = db.Users.ToList();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new UserEditDialog();
            if (dialog.ShowDialog() == true)
            {
                using var db = new AppDbContext();
                db.Users.Add(dialog.User);
                db.SaveChanges();
                LoadUsers();
            }
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersListView.SelectedItem is User user)
            {
                using var db = new AppDbContext();
                db.Users.Remove(user);
                db.SaveChanges();
                LoadUsers();
            }
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersListView.SelectedItem is User user)
            {
                var dialog = new UserEditDialog(user);
                if (dialog.ShowDialog() == true)
                {
                    using var db = new AppDbContext();
                    db.Users.Update(dialog.User);
                    db.SaveChanges();
                    LoadUsers();
                }
            }
        }
    }
}