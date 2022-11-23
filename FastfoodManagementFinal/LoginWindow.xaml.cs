using FastfoodManagementFinal.Models;
using FastfoodManagementFinal.ViewModel;
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
using System.Windows.Shapes;

namespace FastfoodManagementFinal
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window,iSQL_command
    {
        public LoginWindow()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=FastFood;Integrated Security=True");

        //public void Store_Account_Table() 
        //{

        //}
        public void Load_Account_Table(List<Account> accounts)
        {
            con.Open();
            string sql = "exec Select_all_from_Account_proc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                accounts.Add(new Account());
            }
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

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            //con.Open();
            //SqlCommand command = new SqlCommand("exec Login_check '" + txtEmail.Text + "','" + txtPass.Text + "'", con);
            //command.ExecuteNonQuery();
            //SqlDataReader read_line = command.ExecuteReader();
            //if (read_line.Read())
            //{
            //    string user_name = read_line.GetString(0);
            //    string pass = read_line.GetString(1);
            //    MessageBox.Show(user_name + pass);
            //}
            //con.Close();
            //MessageBox.Show("dang ky thanh cong");
        }
    }
}
