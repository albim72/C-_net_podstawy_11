using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForms
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age, AnimalType.Dog)
        {
        }
        public override string MakeSound()
        {
            return "Hau, hau!";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age, AnimalType.Cat)
        {
        }
        public override string MakeSound()
        {
            return "Miau, Miau!";
        }
    }

    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age, AnimalType.Bird)
        {
        }
        public override string MakeSound()
        {
            return "Ćwir, Ćwir!";
        }
    }

}
