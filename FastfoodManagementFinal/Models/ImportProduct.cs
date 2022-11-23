﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastfoodManagementFinal.Models
{
    public class ImportProduct
    {
        public ImportProduct()
        { }
        public string ImportProductName { get; set; }
        public string ImportID { get; set; } // lấy từ import
        public int ImportProductPrice { get; set; }
        public string ProductType { get; set; }
        public int ImportQuantity { get; set; }

    }
}
