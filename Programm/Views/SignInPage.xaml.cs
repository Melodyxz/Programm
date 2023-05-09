using Programm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Programm.Views
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.login.Equals(TxbLogin.Text) && u.password.Equals(TxbPassword.Password));
            
            
            if (CurrentUser != null)
            {
                UserType userType = AppData.db.UserType.FirstOrDefault(w => w.idUserType == CurrentUser.idUserType);
                if (userType.idUserType.Equals("Admin"))
                {

                   NavigationService.Navigate(new DataPage());
                } else
                {
                    AppData.currentUser = CurrentUser;
                    NavigationService.Navigate(new WelcomePage());
                }
            }   else
            {
                MessageBox.Show("Данного пользователя не существует","Ошибка");
            }
        }
        private void BtnToSignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage());

        }

        private void TxbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
