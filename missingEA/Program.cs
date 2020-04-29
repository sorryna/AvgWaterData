using System;
using System.IO;

namespace missingEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var connect = new CheckMissingEA();
            // var test = connect.testGet();
            // var listEA = connect.missingEA();
            // System.IO.File.WriteAllLines(@"D:\MissingEA.json",listEA);
            // var listArea = connect.missingArea();
            // System.IO.File.WriteAllLines(@"D:\MissingArea.json",listArea);
            var manage = new ManageEA();
            manage.EA();
        }
    }
}
