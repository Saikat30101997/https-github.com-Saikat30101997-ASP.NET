using System;
using Microsoft.Extensions.Hosting;

namespace forconsoletoweb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IHostBuilder CreateDefaultBuilder(string[] args)
        {
            Host.CreateDefaultBuilder(args);
        }
    }
}
