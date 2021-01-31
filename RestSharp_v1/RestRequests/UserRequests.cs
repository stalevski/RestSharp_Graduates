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
    public static class UserRequests
    {
        private const string UserUrl = "/user";

        //Write the requests for the User model
        public static string PostArrayOfUsers(this StoreSpecification pss, User[] users)
        {
            var request = new RestRequest($"{UserUrl}/createWithArray", Method.POST, DataFormat.Json);
            request.AddJsonBody(users);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string PostListOfUsers(this StoreSpecification pss, List<User> users)
        {
            var request = new RestRequest($"{UserUrl}/createWithArray", Method.POST, DataFormat.Json);
            //Request endpoint is wrong, should be createUsersWithList
            request.AddJsonBody(users);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string GetUserByUsername(this StoreSpecification pss, string username)
        {
            var request = new RestRequest($"{UserUrl}/{username}", Method.GET);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string PutUser(this StoreSpecification pss, User user)
        {
            var request = new RestRequest($"{UserUrl}/{user.username}", Method.PUT, DataFormat.Json);
            request.AddJsonBody(user);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string DeleteUserByUsername(this StoreSpecification pss, string username)
        {
            var request = new RestRequest($"{UserUrl}/{username}", Method.DELETE);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string GetUserWhenLogin(this StoreSpecification pss, string username, string password)
        {
            var request = new RestRequest($"{UserUrl}/login?username={username}&password={password}", Method.GET);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string GetUserWhenLogout(this StoreSpecification pss)
        {
            var request = new RestRequest($"{UserUrl}/logout", Method.GET);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
        public static string PostUser(this StoreSpecification pss, User user)
        {
            var request = new RestRequest(UserUrl, Method.POST, DataFormat.Json);
            request.AddJsonBody(user);
            var response = pss.Client.Execute(request);

            return response.StatusCode.ToString();
        }
    }
}
