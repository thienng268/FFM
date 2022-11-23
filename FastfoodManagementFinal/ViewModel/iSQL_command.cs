using FastfoodManagementFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastfoodManagementFinal.ViewModel
{
    public interface iSQL_command
    {
        //void Store_Account_Table();
        void Load_Account_Table(List<Account> accounts);
        //void Store_Bill_table();
        //void Store_Customer_table();
    }
}
