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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=FastFood;Integrated Security=True");
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            con.Open();
            SqlCommand command = new SqlCommand("exec sign_up '" + txtĐK_TK.Text + "','" + txtĐK_Pass.Text + "','" + txtĐK_Name.Text + "','" + txtĐK_Sex.Text + "','" + txtĐK_Date.Text + "','" + txtĐK_Phone.Text + "','" + txtĐK_Email.Text + "','" + txtĐK_Address.Text + "','" + x + "'",con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("dang ky thanh cong");
        }
    }
}
