using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AmphoraData.Client;

namespace sample
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting sample");
            
            // AUTHENTICATE

            var authClient = new AuthenticationClient(httpClient);
            var user = new TokenRequest
            {
                Username = "", // REPLACE THESE
                Password = ""
            };
            var token = await authClient.RequestTokenAsync(user);
            Console.WriteLine("Got a token");

            httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Bearer", token);

            // WORK WITH USERS

            var userClient = new UsersClient(httpClient);
            var self = await userClient.ReadSelfAsync();
            Console.WriteLine($"Hello {self.FullName}");

            // SEARCH FOR AMPHORAE
            var search = new SearchClient(httpClient);
            var myAmphorae = await search.SearchAmphoraeByCreatorAsync(self.UserName);
            Console.WriteLine($"You own {myAmphorae.Count} Amphorae");

            foreach(var a in myAmphorae)
            {
                Console.WriteLine($"'{a.Name}' costs ${a.Price}"); 
            }
        }
    }
}
