using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> makyajMalzemeleri = new MyDictionary<int,string>();
            makyajMalzemeleri.Add(40, "Highlighter");
            makyajMalzemeleri.Add(100, "Fondöten");
            makyajMalzemeleri.Add(60, "Maskara");
            Console.WriteLine("Makyaj Malzemelerim :" + makyajMalzemeleri.Count);
        }
    }
}
