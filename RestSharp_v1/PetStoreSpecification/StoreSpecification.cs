using RestSharp;
using RestSharp_v1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.PetStoreSpecification
{
    public class StoreSpecification
    {
        public RestClient Client { get; set; }

        public StoreSpecification()
        {
            Client = new RestClient();
            Client.BaseUrl = new Uri("https://petstore.swagger.io/v2");
        }
    }
}
