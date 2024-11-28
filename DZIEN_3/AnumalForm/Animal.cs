using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForms
{
    public enum AnimalType
    {
        Dog,
        Cat,
        Bird
    }
    public abstract class Animal : IAnimal
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AnimalType Type { get; }

        protected Animal(string name, int age, AnimalType type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public string MakeSound()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Type}: {Name},{Age} lat";
        }
    }
}
