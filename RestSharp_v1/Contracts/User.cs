using RestSharp_v1.Enums;
using RestSharp_v1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.Contracts
{
    public class User
    {
        public long id { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public int userStatus { get; set; }
    public User()
        {
            id = RandomDataGenerator.RandomLongNumber();
            username = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            firstName = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            lastName = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            email = RandomDataGenerator.RandomEmailAddress();
            password = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            phone = RandomDataGenerator.RandomStringOnlyNumbers(RandomDataGenerator.RandomNumber(9, 15));
            userStatus = 1;
        }
    }
}
