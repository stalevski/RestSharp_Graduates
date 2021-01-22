using RestSharp_v1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.Contracts
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public Category()
        {
            id = RandomDataGenerator.RandomNumber();
            name = RandomDataGenerator.RandomStringOnlyLetters(10);
        }
    }
}
