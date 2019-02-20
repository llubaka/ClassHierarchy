using System;
using ClassHierarchy.Enums;
using ClassHierarchy.Contracts;

namespace ClassHierarchy.Models
{
    public class Woman : Human , IWoman
    {
        public Woman(string name, string job, decimal money, EyesType eyesType) : base(name, job, money, eyesType)
        {
        }

        public void BeingWoman()
        {
            Console.WriteLine($"This woman is just being a woman!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping!");
        }

        public override void Walk()
        {
            Console.WriteLine($"{this.Name} is walking!");
        }
    }
}
