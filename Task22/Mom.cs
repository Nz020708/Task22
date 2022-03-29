using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    class Mom
    {
        public string Name;
        public string Surname;
        public int Age;
        public Mom(string name,string surname)
        {
            Name = name;
            Surname = surname;
           
        }
        public Mom(string name, string surname, int age):this(name,surname)
        {
            
            Age = age;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Name: {Name}  Surname: {Surname} Age: {Age}");
        }
    }
}
