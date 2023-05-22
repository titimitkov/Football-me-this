using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public abstract class Person
    {
       string name;
       int age;

        public string Name { get { return name; } set { value = name; } }
        public int Age { get { return age; } set { value = age; } }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
           
        }
    }
}
