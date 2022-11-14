using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Gav");
            Dog dog = new Dog("Bim");
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
