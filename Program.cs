using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler1 = new Dictionary<int, string>();
            ogrenciler1.Add(57,"Onur");
            ogrenciler1.Add(58,"Onur");
            ogrenciler1.Add(59,"Onur");
            Console.WriteLine(ogrenciler1.Count);

            MyDictionary<int, string> ogrenciler2 = new MyDictionary<int, string>();
            ogrenciler2.Add(34,"Mustafa");
            ogrenciler2.Add(35,"Mustafa");
            ogrenciler2.Add(36,"Mustafa");
            ogrenciler2.Add(37,"Mustafa");
            Console.WriteLine(ogrenciler2.Count);
        }
    }
}
