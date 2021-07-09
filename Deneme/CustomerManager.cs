using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Hesabı Eklendi : " + customer.Adi + " " + customer.Soyadi);

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Hesabı Silindi : "+customer.Adi+" "+customer.Soyadi);
        }
    }
}
