using System;
using ClassHierarchy.Enums;
using ClassHierarchy.Contracts;

namespace ClassHierarchy.Models
{
    public class Man : Human, IMan
    {
        public Man(string name, string job, decimal money, EyesType eyesType) : base(name, job, money, eyesType)
        {
        }

        public void BeingMan()
        {
            Console.WriteLine($"This man is just being man...");
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping...");
        }

        public override void Walk()
        {
            Console.WriteLine($"{this.Name} is walking...");
        }
    }
}
