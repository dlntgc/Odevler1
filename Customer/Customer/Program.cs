namespace Customer
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CustomerDal myClass = new CustomerDal();
            Customer customer1 = new Customer();
            customer1.AdSoyad = "Dilan Tuğçe Özdemir";
            customer1.Email = "dlntgc";
            customer1.Sifre = "12345";
            customer1.Yas = 20;

            myClass.Add(customer1);

        }
    }

}
