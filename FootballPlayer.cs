using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public abstract class FootballPlayer : Person
    {

        int number;
        int height;

        public int Height { get { return height; } set { value = height; } }
        public int Number { get { return number; } set { value = number; } }
        protected FootballPlayer(string name, int age, int number, int height) : base(name, age)
        {
            Height = height;
            Number = number;
        }
    }
}
