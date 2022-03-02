using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunSatis
{
    public interface ICustomerCheckService
    {
        bool CustomerInfoCheck(Customer customer);
    }
}
