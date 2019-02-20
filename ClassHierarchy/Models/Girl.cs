using System;
using ClassHierarchy.Enums;
using ClassHierarchy.Contracts;

namespace ClassHierarchy.Models
{
    public class Girl : Human , IGirl
    {
        public bool HasRelationship { get; set; }

        public Girl(string name, string job, decimal money, EyesType eyesType, bool hasRelationship) : 
            base(name, job, money, eyesType)
        {
            this.HasRelationship = hasRelationship;
        }               

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating!");
        }

        public void JustBeingGirl()
        {
            Console.WriteLine("This girl is just being a girl!");
        }         

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping!");
        }

        public override void Walk()
        {
            Console.WriteLine($"{this.Name} is walking!");
        }

        public void PlayWithSomeone(Human human)
        {
            Console.WriteLine($"This girl {this.Name} is playing with {human.Name}");
        }
    }
}
