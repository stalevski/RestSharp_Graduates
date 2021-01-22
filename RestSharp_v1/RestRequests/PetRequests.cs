using Newtonsoft.Json;
using RestSharp;
using RestSharp_v1.Contracts;
using RestSharp_v1.PetStoreSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp_v1.RestRequests
{
    public static class PetRequests
    {
        public const string PetUrl = "/pet";


        public static string PostPet(this StoreSpecification pss, Pet pet)
        {
            var request = new RestRequest(PetUrl, Method.POST, DataFormat.Json);
            //var request = new RestRequest("/pet", Method.POST);
            //var request = new RestRequest(yourUrlHere, Method.POST) 
            //{ RequestFormat = DataFormat.Json };
            //Different ways to build the request

            request.AddJsonBody(pet);

            //request.AddBody(pet);
            //request.AddXmlBody(pet);
            //AddBody should also work for this, XML body is how you add the body for an API that takes XML 
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }

        public static string PutPet(this StoreSpecification pss, Pet pet)
        {
            var request = new RestRequest(PetUrl, Method.PUT, DataFormat.Json);
            request.AddJsonBody(pet);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }

        public static string GetPetByStatus(this StoreSpecification pss, string status)
        {
            var request = new RestRequest($"{PetUrl}/findByStatus?status={status}", Method.GET);

            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }

        public static string GetPetById(this StoreSpecification pss, long id)
        {
            var request = new RestRequest($"{PetUrl}/{id}", Method.GET);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }

        public static string PostUpdatePetById(this StoreSpecification pss, Pet pet)
        {
            var request = new RestRequest($"{PetUrl}/{pet.id}", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(pet);
            //This was missing in the presentation, my bad :D
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }

        public static string DeletePetById(this StoreSpecification pss, long id)
        {
            var request = new RestRequest($"{PetUrl}/{id}", Method.DELETE);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
    }
}
