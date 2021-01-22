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
        StoreSpecification pss;

        // These can be put in all the tests separately, but because they are used in more than 1 test its better to initialize them here

        [SetUp]
        public void Init()
        {
            pet = new Pet();
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


        [TearDown]
        public void Cleanup()
        {
            pss.Client = null;

            // I don't this this is necessary
        }
    }
}
