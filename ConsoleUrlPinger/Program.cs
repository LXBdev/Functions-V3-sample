using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleUrlPinger
{
    class Program
    {
        async static Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            while (true)
            {
                var resp = await client.GetAsync("https://functestabee.azurewebsites.net/api/HttpTrigger1?code=q9ft5bUe30ev/DJfAYpM2f/NgxaNpYwkgB6VR1d3Qo8JKDf7SNimuQ==");
                var content = await resp.Content.ReadAsStringAsync();
                Console.WriteLine($"{DateTimeOffset.Now.ToString("o")} {resp.StatusCode} - {(content.Length > 0 ? content.Substring(0,10) : string.Empty)}");
                await Task.Delay(100);
            }
        }
    }
}
