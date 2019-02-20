using System;
using ClassHierarchy.Enums;
using ClassHierarchy.Contracts;

namespace ClassHierarchy.Models
{
    public class Boy : Human, IBoy
    {
        public bool HasRelationship { get; set; }

        public Boy(string name, string job, decimal money, EyesType eyesType, bool hasRelationship) : 
            base(name, job, money, eyesType)
        {
            this.HasRelationship = hasRelationship;
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating...");
        }

        public void JustBeingBoy()
        {
            Console.WriteLine($"This boy is just being a boy...");
        }         

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping...");
        }

        public override void Walk()
        {
            Console.WriteLine($"{this.Name} is walking...");
        }

        public void PlayWithSomeone(Human human)
        {
            Console.WriteLine($"This boy {this.Name} is playing with {human.Name}");
        }
    }
}

