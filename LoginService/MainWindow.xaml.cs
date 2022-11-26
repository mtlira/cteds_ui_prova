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
            var typedEmail = (TextBox) this.FindName("Email");
            //context.Users.Where(u => u.Email == ).ToList();
        }
    }
}
