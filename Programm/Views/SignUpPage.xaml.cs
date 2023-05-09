using Programm.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
            Loaded += SignUpPage_Loaded;
        }

        private void SignUpPage_Loaded(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Height = 800;
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new CheltipoEntities2())
            {
                string username = usernameBox.Text;
                string password = passwordBox.Password;
                string date = dataBox.Text;


                context.User.Add(new User
                {
                    login = username,
                    password = password,
                    sessionData = date,
                    idUserType = "User"
                });
                //context.UserType.Add(new UserType
                //{

                //    idUserType = "User"
                //});
                
                int result = context.SaveChanges();

                

                if (result > 0)
                {
                    MessageBox.Show("Вы успешно зарегистрированы!");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так. Попробуйте еще раз.");
                }
            }
        }


        private void BtnToSignIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInPage());
        }
    }
}
