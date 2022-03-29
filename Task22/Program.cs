using System;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Mom mom = new Mom("Jane", "Dark", 35);
            mom.Info();
            Mom daughter = new Daughter("Anna", "Dark", 15, 345);
            daughter.Info();
        }
    }
}
