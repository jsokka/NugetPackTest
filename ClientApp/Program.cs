using System;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = DataLib.DataService.Test();
            //var test2 = DataLib.DataService.GetDataModel();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
