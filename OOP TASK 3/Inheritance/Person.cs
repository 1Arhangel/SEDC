using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public int IdNumber { get; set; }


        public string Sell (Seller seller, Customer customer, Product product)
        {
            return "The seller name is "+seller.Name + " " + "the customer name is "+customer.Name+ " " + customer.LastName +" "+"and he bought " + product.Name;
        }

        public string Sell(Baker baker, Customer customer, Product product)
        {
            return "The Baker Name is "+baker.Name +", "+ "the customer name is "+customer.Name +", "+ customer.LastName + " " +"and he bought " + product.Name;
        }

        public string Sell(string sellerName, string CustomerFullName, string ProductName)
        {
            return "The seller name is " + sellerName + " " + "the customer name is " + CustomerFullName+" "+"and he bought " + ProductName;
        }
    }

}
