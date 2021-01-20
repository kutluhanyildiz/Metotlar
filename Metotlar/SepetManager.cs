using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //syntax 
        //naming convention
        public void Ekle(Product product)
        {
            
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.Name);

        }

        public void Ekle2(string productName, string Description, double Price, int stockAvailable)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + productName);
        }
    }
}
