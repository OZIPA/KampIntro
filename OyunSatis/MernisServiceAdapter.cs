using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunSatis
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CustomerInfoCheck(Customer customer)
        {
            var mernisClient= new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse= mernisClient.TCKimlikNoDogrulaAsync(customer.TcNo, customer.FirstName, customer.LastName, customer.YearOfBirth);
            
            return tcKimlikDogrulamaServisResponse.Result.Body.TCKimlikNoDogrulaResult;
            





        }   
    }
}
