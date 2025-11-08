using System.Windows;

namespace WpfApp2
{
    public partial class UserEditDialog : Window
    {
        public User User { get; set; }

        public UserEditDialog(User user = null)
        {
            InitializeComponent();
            User = user ?? new User();
            DataContext = User;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}