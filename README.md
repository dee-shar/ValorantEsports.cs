# ValorantEsports.cs
Web-API for [vlresports.vercel.app](https://vlresports.vercel.app/) a user-friendly tool that allows you to extract data from the website vlr.gg

## Example
```cs
using ValorantEsportsApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new ValorantEsports();
            string teams = await api.GetTeams();
            Console.WriteLine(teams);
        }
    }
}
```
