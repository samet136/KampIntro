using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123456;
            customer1.Adi = "Abdülsamet";
            customer1.Soyadi = "BAYRAM";
            customer1.DogumTarihi = 1991;

            Customer customer2 = new Customer();
            customer2.Id = 123789;
            customer2.Adi = "Serhat";
            customer2.Soyadi = "ATEŞ";
            customer2.DogumTarihi = 1995;


            Customer customer3 = new Customer();
            customer3.Id = 456789;
            customer3.Adi="Filiz";
            customer3.Soyadi = "BAYRAKTAR";
            customer3.DogumTarihi = 1990;

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };
            foreach (var cstmr in customers)
            {
                Console.WriteLine(cstmr.Id);
                Console.WriteLine(cstmr.Adi);
                Console.WriteLine(cstmr.Soyadi);
                Console.WriteLine(cstmr.DogumTarihi);
                Console.WriteLine("-------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Delete(customer2);


            Console.ReadKey();
        }



        
    }
}
