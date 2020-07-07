using System;
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
            var apiVersion = "0"; // use this for backwards compatibility

            // AUTHENTICATE

            var authClient = new AuthenticationClient(httpClient);
            var user = new LoginRequest
            {
                Username = "", // REPLACE THESE
                Password = ""
            };
            var startTime = DateTime.Now;
            var token = await authClient.RequestTokenAsync(apiVersion, user);
            var endTime = DateTime.Now;
            Console.WriteLine($"Acquiring token took {(endTime - startTime).TotalSeconds}");

            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            // WORK WITH USERS

            var userClient = new UsersClient(httpClient);
            var self = await userClient.ReadSelfAsync(apiVersion);
            Console.WriteLine($"Hello {self.FullName}");

            // SEARCH FOR AMPHORAE
            var amphoraClient = new AmphoraeClient(httpClient);
            var myAmphorae = await amphoraClient.ListAsync("self", "created", "0");
            Console.WriteLine($"You've created {myAmphorae.Count} Amphorae");

            foreach (var a in myAmphorae)
            {
                Console.WriteLine($"'{a.Name}' costs ${a.Price}");
            }
        }
    }
}
