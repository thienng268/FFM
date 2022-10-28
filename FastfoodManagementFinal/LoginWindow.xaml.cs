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
using System.Windows.Shapes;

namespace FastfoodManagementFinal
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public LoginWindow()
        {
            InitializeComponent();

        }

        private void ForgotPass_Click(object sender, RoutedEventArgs e)
        {
            ForgotPass Forgotpass = new ForgotPass();
            this.Hide();
            Forgotpass.ShowDialog();
            this.Show();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp Signup = new SignUp();
            this.Hide();
            Signup.ShowDialog();
            this.Show();
        }
    }
}
