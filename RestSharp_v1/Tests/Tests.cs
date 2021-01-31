using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp_v1.Contracts;
using RestSharp_v1.RestRequests;
using RestSharp_v1.PetStoreSpecification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp_v1.Helpers;

namespace RestSharp_v1.Tests
{
    [TestFixture]
    public class Tests
    {
        Pet pet;
        User user;
        User user2;
        List<User> usersList;
        User[] usersArray;
        StoreSpecification pss;

        // These can be put in all the tests separately, but because they are used in more than 1 test its better to initialize them here

        [SetUp]
        public void Init()
        {
            pet = new Pet();
            user = new User();
            user2 = new User();
            usersList = new List<User>();
            usersArray = new User[5];
            pss = new StoreSpecification();

            // These can be put in all the tests separately, but because they are used in more than 1 test its better to initialize them here
        }

        //Write the missing "tests" and assert the status code from the requests. If you want to experiment you can try asserting something else
        [Test]
        public void PostPetTest()
        {
            //Pet pet = new Pet();
            //StoreSpecification pss = new StoreSpecification();


            string RequestStatus = pss.PostPet(pet);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(pet));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(pet));

            //This is just to see if there is a difference between TestContext.WriteLine and Console.WriteLine
            //They both show up in the same test output window and there is no difference
            //Probably there was a difference in older version of Visual Studio

            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void PutPetTest()
        {

        }

        [Test]
        public void GetPetByStatusTest()
        {

        }

        [Test]
        public void GetPetByIdTest()
        {

        }

        [Test]
        public void UpdatePetByIdTest()
        {

        }

        [Test]
        public void DeletePetByIdTest()
        {

        }

        //////////////// User Tests /////////////////////////


        [Test]
        public void PostUserTest()
        {

            string RequestStatus = pss.PostUser(user);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void PostCreateWithListTest()
        {

            string RequestStatus = pss.PostCreateWithList(usersList);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(usersList));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(usersList));

            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void PostCreateWithArrayTest()
        {

            string RequestStatus = pss.PostCreateWithArray(usersArray);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(usersArray));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(usersArray));

            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void GetUserTest()
        {

            string RequestStatus = pss.GetUser("kzxkSElBLan"); //if it were user.username - the new random generated user would not be found.

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Get status was not OK");
        }

        [Test]
        public void PutUserTest()
        {

            string RequestStatus = pss.PutUser(user);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Put status was not OK");
        }


        [Test]
        public void DeleteUserTest()
        {
            string RequestStatus = pss.DeleteUser("kzxkSElBLan"); //if it were user.username - the new random generated user would not be found.

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Delete status was not OK");
        }

        [Test]
        public void GetUserLoginTest()
        {

            string RequestStatus = pss.GetUserLogin("NhCRMDXpj", "mWnHNZxTNXwpKp"); //if it were user.username - the new random generated user would not be found.

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Login status was not OK");
        }

        [Test]
        public void GetUserLogoutTest()
        {

            string RequestStatus = pss.GetUserLogout(); 

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(user));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(user));

            Assert.AreEqual(RequestStatus, "OK", "Logout status was not OK");
        }

        [TearDown]
        public void Cleanup()
        {
            pss.Client = null;

            // I don't this this is necessary
        }
    }
}
