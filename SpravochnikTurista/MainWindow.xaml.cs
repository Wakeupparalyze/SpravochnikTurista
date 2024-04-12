using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpravochnikTurista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthBtnClick(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "123" && PasswordBox.Text == "123")
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                MessageBox.Show("Вы вошли в аккаунт");
            }
            else { MessageBox.Show("Неверный логин или пароль"); }
            
        }
    }
}