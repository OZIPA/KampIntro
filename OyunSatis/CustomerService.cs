using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunSatis
{
    public class CustomerService

    {

        ICustomerCheckService _customerCheckService;
        public CustomerService(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Save(Customer customer)
        {
           // MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();


            if (_customerCheckService.CustomerInfoCheck(customer)==true)
            {
                Console.WriteLine(customer.FirstName + " isimli musteri kaydedildi");
            }
            else
            {
                Console.WriteLine("Kullanici Bilgiler Hatali!");
            }
        }


        public void Update(Customer customer)
        {
            Console.WriteLine("musteri bilgileri guncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("musteri kaydi silindi");
        }


    }
}


      
 