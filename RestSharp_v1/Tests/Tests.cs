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
        User[] users= new User[3];
        List<User> userList = new List<User>();
        StoreSpecification pss;
        string RequestStatus = null;

        [SetUp]
        public void Init()
        {
            users[0] = new User();
            users[1] = new User();
            users[2] = new User();
            userList.Add(users[0]);
            userList.Add(users[1]);
            userList.Add(users[2]);
            pss = new StoreSpecification();
        }

        [Test]
        public void PostArrayOfUsersTest()
        {
            RequestStatus = pss.PostArrayOfUsers(users);
            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void PostListOfUsersTest()
        {
            RequestStatus = pss.PostListOfUsers(userList);
            Assert.AreEqual(RequestStatus, "OK", "Post status was not OK");
        }

        [Test]
        public void GetUserByUsernameTest()
        {
            RequestStatus = pss.PostUser(users[0]);
            RequestStatus = pss.GetUserByUsername(users[0].username);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void PutUserByUsernameTest()
        {
            RequestStatus = pss.PutUser(users[0]);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void DeleteUserByUsernameTest()
        {
            RequestStatus = pss.PostUser(users[0]);
            RequestStatus = pss.DeleteUserByUsername(users[0].username);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void GetUserByLoginTest()
        {
            RequestStatus = pss.PostUser(users[0]);
            RequestStatus = pss.GetUserWhenLogin(users[0].username, users[0].password);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void GetUserByLogoutTest()
        {
            RequestStatus = pss.PostUser(users[0]);
            RequestStatus = pss.GetUserWhenLogout();
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [Test]
        public void PostUserTest()
        {
            RequestStatus = pss.PostUser(users[0]);
            Assert.AreEqual(RequestStatus, "OK", "Not OK");
        }

        [TearDown]
        public void Cleanup()
        {
            pss.Client = null;
        }
    }
}
