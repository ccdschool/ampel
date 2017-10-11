using System;
using servicehost;

namespace ampel.console
{
    public class Program
    {
        public static void Main(string[] args) {
            using (var servicehoat = new ServiceHost()) {
                servicehoat.Start(new Uri("http://localhost:8080"));
                Console.WriteLine("Running... press enter to stop.");
                Console.ReadLine();
            }
        }
    }
}