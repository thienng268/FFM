using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FastfoodManagementFinal.ViewModel;

namespace FastfoodManagementFinal.ViewModel
{
    public class MainViewModel : BaseViewModel 
    {
        public bool Isloaded = false;
        // mọi thứ xử lý nằm trong này
        public MainViewModel()
        {
            if (!Isloaded)
            {
                Isloaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
