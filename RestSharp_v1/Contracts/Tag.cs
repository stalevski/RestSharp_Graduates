using RestSharp_v1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.Contracts
{
    public class Tag
    {
        public long id { get; set; }
        public String name { get; set; }

        public Tag()
        {
            id = RandomDataGenerator.RandomLongNumber();
            name = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
        }
    }
}
