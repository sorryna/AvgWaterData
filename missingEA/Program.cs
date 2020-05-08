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
            //var listEA = connect.missingEA();
            //System.IO.File.WriteAllLines(@"D:\MissingEA.json", listEA);
            var (listArea, MsArea) = connect.missingArea();
            System.IO.File.WriteAllLines(@"D:\MissingArea.json", listArea);
            var manage = new ManageEA();
            //manage.EA();
            //manage.Area();
            manage.MsArea(MsArea);
        }
    }
}
