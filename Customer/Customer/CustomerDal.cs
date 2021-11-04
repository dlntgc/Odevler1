using System;

namespace Customer
{
    partial class Program
    {
        class CustomerDal
        {
            public void Add(Customer customer)
            {
                if (customer.AdSoyad == "" && customer.Email == "" && customer.Sifre == "" && customer.Yas >= 18)
                {
                    Console.WriteLine("lütfen zorunlu alanları doldurunuz.");
                }
                else if (customer.Yas < 18)
                {
                    Console.WriteLine("uygulama sadece reşit birey kullanımına açıktır.");
                }


                Console.WriteLine(customer.AdSoyad + " adlı kullanıcı Sisteme dahil oldu");
            }

            public void Remove(Customer customer)
            {
                Console.WriteLine(customer.AdSoyad + " adlı kullanıcı Sistemden silindi");
            }

            public void Update(Customer customer)
            {
                Console.WriteLine(customer.AdSoyad + " adlı kullanıcı güncellendi");
            }

        }
    }

}
