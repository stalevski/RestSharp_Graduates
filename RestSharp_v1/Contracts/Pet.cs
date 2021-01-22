using RestSharp_v1.Enums;
using RestSharp_v1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.Contracts
{
    public class Pet
    {
        public long id { get; set; }
        public Category category { get; set; }
        public String name { get; set; }
        public List<String> photoUrls { get; set; }
        public List<Tag> tags { get; set; }
        public string status { get; set; }

        public Pet()
        {
            id = RandomDataGenerator.RandomLongNumber();
            category = new Category();
            name = RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15));
            photoUrls = new List<String>();
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            photoUrls.Add(RandomDataGenerator.RandomStringOnlyLetters(RandomDataGenerator.RandomNumber(9, 15)));
            tags = new List<Tag>();
            tags.Add(new Tag());
            tags.Add(new Tag());
            status = PetStatus.available.ToString();
        }
    }
}
