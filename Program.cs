using System;

namespace Homework4odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string > sınıfListesi = new MyDictionary<int, string>();

           sınıfListesi.Add(1, "Zafer");
           sınıfListesi.Add(2, "Ayşe");
           sınıfListesi.Add(3, "Emre");
           sınıfListesi.Add(4, "Ahmet");
           sınıfListesi.Add(5, "Fatma");

            foreach (var number in sınıfListesi.Keys)
            {
                Console.WriteLine(number);
            }

            foreach (var name in sınıfListesi.Values)
            {
                Console.WriteLine(name);
            }


        }
    }
}
