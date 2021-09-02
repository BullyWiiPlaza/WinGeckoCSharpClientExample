using System;
using WinGecko;

namespace WinGeckoCSharpClientExample
{
    internal class Program
    {
        private const string WinGeckoServerFilePath = "your-WinGeckoServer.exe-file-path";

        private static void Main()
        {
            using (var winGeckoClient = WinGeckoClient.ConnectWinGeckoClient(WinGeckoServerFilePath))
            {
                var serverDetails = winGeckoClient.ReadServerDetails();
                Console.WriteLine(serverDetails.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
