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

            var document = await OpenApiDocument.FromJsonAsync(wclient.DownloadString("https://app.amphoradata.com/swagger/v1/swagger.json"));

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
            var filePath = $"{directory}/client/AmphoraClient.cs";
            System.IO.File.Delete(filePath);
            Console.WriteLine($"Deleted {filePath}");
            System.IO.File.WriteAllText(filePath, code);
            Console.WriteLine($"Wrote {filePath}");
        }
    }
}
