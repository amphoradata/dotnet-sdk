using System;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            System.Net.WebClient wclient = new System.Net.WebClient();

            var document = await OpenApiDocument.FromJsonAsync(wclient.DownloadString("https://beta.amphoradata.com/swagger/v1/swagger.json"));

            wclient.Dispose();

            var settings = new CSharpClientGeneratorSettings
            {
                //ClassName = "AmphoraClient",
                CSharpGeneratorSettings =
                {
                    Namespace = "AmphoraData.Client",
                }
            };

            var generator = new CSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();
            var directory = System.IO.Directory.GetCurrentDirectory();
            System.IO.File.WriteAllText($"{directory}/client/AmphoraClient.cs", code);
            Console.WriteLine("Done");
        }
    }
}
