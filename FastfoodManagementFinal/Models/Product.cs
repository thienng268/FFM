using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FastfoodManagementFinal.Models
{
    public class Product
    {
        public Product(int type_of_constructor)
        {

        }
        // load từ dưới database lên
        //public Product(string ProductId, string name, int price, string product_Type, int remaining_quantity, string avatar)
        //{
        //    this.ProductId = ProductId;
        //    Name = name;
        //    Price = price;
        //    Product_Type = product_Type;
        //    Remaining_quantity = remaining_quantity;
        //    Avatar = avatar;
        //}
        public Product()
        {

        }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Product_Type { get; set; }
        public int Remaining_quantity { get; set; }
        public string Avatar { get; set; }
    }
}
