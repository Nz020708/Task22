using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    class Daughter:Mom
    {
        public int SchoolNo;
        public Daughter(string name, string surname,int age,int schoolno):base(name,surname,age)
        {
            SchoolNo = schoolno;
        }

        public override void Info()
        {
            Console.WriteLine($"Name: {Name}  Surname: {Surname} Age: {Age} School: N{SchoolNo}");
        }
    }
}
