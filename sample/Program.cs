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

            // AUTHENTICATE

            var authClient = new AuthenticationClient(httpClient);
            var user = new LoginRequest
            {
                Username = "", // REPLACE THESE
                Password = ""
            };
            var startTime = DateTime.Now;
            var token = await authClient.RequestTokenAsync(user);
            var endTime = DateTime.Now;
            Console.WriteLine($"Acquiring token took {(endTime - startTime).TotalSeconds}");

            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            // Read your own user data.
            var userClient = new UsersClient(httpClient);
            var self = await userClient.ReadSelfAsync();
            Console.WriteLine($"Hello {self.FullName}");

            var amphoraClient = new AmphoraeClient(httpClient);
            // get my first 10 amphora
            var myAmphorae = await amphoraClient.ListAsync("self", "created", 0, 10);

            foreach (var a in myAmphorae)
            {
                Console.WriteLine($"'{a.Name}' costs ${a.Price}");
            }
        }
    }
}
