using System;
using WinGecko;

namespace WinGeckoCSharpClientExample
{
    internal class Program
    {
        private const string WinGeckoServerFilePath = "your-WinGeckoServer.exe-file-path";

        private static int Main()
        {
            int returnValue;
            try
            {
                Console.WriteLine("Connecting to WinGecko server...");
                using (var winGeckoClient = WinGeckoClient.ConnectWinGeckoClient(WinGeckoServerFilePath, true))
                {
                    var serverDetails = winGeckoClient.ReadServerDetails();
                    Console.WriteLine(serverDetails.ToString());
                }

                returnValue = 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                returnValue = -1;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            return returnValue;
        }
    }
}
