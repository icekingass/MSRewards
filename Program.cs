using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            Thread.Sleep(10000);
            for (int i = 0; i < 40; i++)
            {
                var query = new string(
                Enumerable.Repeat(chars, 3)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

                string search_query = query;
                int delay = 1000;

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.bing.com/search?q={search_query}") { CreateNoWindow = true });
                Thread.Sleep(delay);
            }
        }
    }
}