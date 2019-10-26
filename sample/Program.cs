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


            var userClient = new UsersClient(httpClient);
            Console.WriteLine("Reading self...");
            var self = await userClient.ReadSelfAsync();

            Console.WriteLine($"Hello {self.FullName}");
        }
    }
}
