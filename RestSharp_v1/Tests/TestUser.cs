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
    public class TestUser
    {
        User user;
        User[] users;
        List<User> users_list;
        StoreSpecification pss;
        string RequestStatus;

        

        [SetUp]
        public void Init()
        {
            user = new User();
            pss = new StoreSpecification();
            users = new User[3];
            users_list = new List<User>();           
        }


        //Write the missing "tests" and assert the status code from the requests. If you want to experiment you can try asserting something else
        [Test]
        public void PostUserArray()
        {
            //user user = new user();
            //StoreSpecification pss = new StoreSpecification();
            User user1 = new User();
            User user2 = new User();
            User[] users = { user1, user2, };
            

            string RequestStatus = pss.PostUserArray(users);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(users));
            TestContext.WriteLine("\n");

            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(users));
           
            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }


        [Test]
        public void PostUserList()
        {
            //user user = new user();
            //StoreSpecification pss = new StoreSpecification();

            string RequestStatus = pss.PostUserList(users_list);

            TestContext.WriteLine("TestContext.WriteLine\n");
            TestContext.WriteLine(JsonConvert.SerializeObject(users_list));
            TestContext.WriteLine("\n");
            Console.WriteLine("Console.WriteLine\n");
            Console.WriteLine(JsonConvert.SerializeObject(users_list));

            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }


        [Test]
        public void GetUserByUsername()
        {
            RequestStatus = pss.PostUser(user);
            RequestStatus = pss.GetUserByUsername(user.username);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void PutUserTest()
        {
            //RequestStatus = pss.PostUser(user);
            RequestStatus = pss.PutUser(user);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void DeleteUserByIdTest()
        {
            RequestStatus = pss.PostUser(user);
            RequestStatus = pss.DeleteUserByUsername(user.username);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void GetUserByLogin()
        {
            RequestStatus = pss.PostUser(user);
            RequestStatus = pss.GetUserLogin(user.username, user.password);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void GetUserLogiut()
        {
            RequestStatus = pss.PostUser(user);
            RequestStatus = pss.GetUserLogout();
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

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

        [TearDown]
        public void Cleanup()
        {
            pss.Client = null;           
        }
    }
}