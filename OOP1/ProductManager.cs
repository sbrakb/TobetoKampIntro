using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            product.ProductName = "zahaha";
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            product.ProductName = "zahaha2";
            Console.WriteLine(product.ProductName + " güncellendi");
        }




        public int Test(int sayi) 
        {
             return sayi = sayi + 1;
        }
    }
}
