using LoginService.Database;
using LoginService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Context context;

        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            List<User> users = context.Users.Where(u => u.Email == Email.Text).ToList();
            if (users.Count == 0) MessageBox.Show("Usuário não encontrado");
            else if (users[0].Password == Password.Password) MessageBox.Show("Login realizado com sucesso!");
            else MessageBox.Show("Dados incorretos. Tente novamente.");
        }
    }
}
