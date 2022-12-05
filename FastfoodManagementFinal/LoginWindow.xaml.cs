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
            int j = 0;
            while (reader.Read() == true)
            {
                accounts.Add(new Account());
                accounts[j].StaffID = reader.GetString(0);
                accounts[j].Avatar = reader.GetString(1);
                accounts[j].AccessRight = reader.GetString(2);
                accounts[j].Username = reader.GetString(3);
                accounts[j].Pass = reader.GetString(4);
                accounts[j].Name = reader.GetString(5);
                accounts[j].Sex = reader.GetString(6);
                accounts[j].DateOfBirth = reader.GetDateTime(7);
                accounts[j].Phone_Number = reader.GetString(8);
                accounts[j].Email = reader.GetString(9);
                j++;
            }
            con.Close();
        }
        public void Load_Product_Table(List<Product> x)
        {
            con.Open();
            string sql = "exec Select_all_Product_proc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            int j = 0;
            while (reader.Read() == true)
            {
                x.Add(new Product());
                x[j].ProductId = reader.GetString(0);
                x[j].Name = reader.GetString(1);
                x[j].Product_Type = reader.GetString(2);
                x[j].Price = reader.GetInt32(3);
                x[j].Remaining_quantity = reader.GetInt32(4);
                x[j].description = reader.GetString(5);
                x[j].Avatar = reader.GetString(6);
                j++;
            }
        }
        private bool check_login(string username, string password)
        {
            con.Open();
            string sql = "exec select_all_account_where_username_password_proc '"+username+"','"+password+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                if (username == reader.GetString(3) && password == reader.GetString(4))
                    return true;
                else
                    return false;
            }
            return false;
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
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
            
            
            
            
            
            
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

            //List<Account> accounts = new List<Account>();
            //Load_Account_Table(accounts);
            //MessageBox.Show(accounts[0].Name);
            //MessageBox.Show(accounts[0].Sex);
            //MessageBox.Show(accounts[0].DateOfBirth.ToString());

            //bool b = check_login(txtEmail.Text, txtPass.Text);
            //MessageBox.Show(b.ToString());


            //List<Product> accounts = new List<Product>();
            //Load_Product_Table(accounts);
            //MessageBox.Show(accounts[0].Name);
            //MessageBox.Show(accounts[0].Price.ToString());
            //MessageBox.Show(accounts[0].Avatar.ToString());


        }
    }
}
