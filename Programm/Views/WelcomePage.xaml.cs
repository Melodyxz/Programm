using Programm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        private readonly CheltipoEntities2 dbContext = AppData.db;

        public WelcomePage()
        {
            InitializeComponent();
            var user = AppData.db.User.FirstOrDefault(u => u.login.Equals(AppData.currentUser.login));
            datata.Text = user.sessionData;
            userer.Text = user.login;


        }
        private void WelcomePage_Loaded(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Height = 833;
            Window.GetWindow(this).Width = 1182;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new SignInPage());
        }
    }

}
