
using ClassHierarchy.Contracts;
using ClassHierarchy.Enums;
using ClassHierarchy.Models;
using System;
using System.Collections.Generic;

namespace ClassHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            Human man = new Man("Lyubomir", "Software Engineer", 5325m, EyesType.Green);
            Human woman = new Woman("Anjelina", "Miqch na kenefi", 999999m, EyesType.Red);
            Human boy = new Boy("Young manqk", "School", -10m, EyesType.Black, false);
            Human girl = new Girl("Manqchkata", "Waitress", 1003, EyesType.Silver, true);

            List<Human> humans = new List<Human>();
            humans.Add(man);
            humans.Add(woman);
            humans.Add(boy);
            humans.Add(girl);

            DoSomethingWithHumans(humans);
            Console.WriteLine();

            DoSomethingWithMan(man as IMan);
            Console.WriteLine();

            DoSomethingWithWoman(woman as IWoman);
            Console.WriteLine();

            DoSomethingWithMan(boy as IBoy);
            Console.WriteLine();
             
            DoSomethingWithWoman(girl as IGirl);
            Console.WriteLine();

            List<IChild> childs = new List<IChild>();
            childs.Add(boy as IChild);
            childs.Add(girl as IChild);

            DoSomethingWithChilds(childs, woman);

            Console.ReadLine();
        }

        private static void DoSomethingWithChilds(IEnumerable<IChild> childs, Human human)
        {
            foreach (var child in childs)
            {
                child.PlayWithSomeone(human);
            }
        }

        private static void DoSomethingWithWoman(IGirl girl)
        {
            girl.JustBeingGirl();
        }

        private static void DoSomethingWithMan(IBoy boy)
        {
            boy.JustBeingBoy();
        }

        private static void DoSomethingWithWoman(IWoman woman)
        {
            woman.BeingWoman();
        }

        private static void DoSomethingWithMan(IMan man)
        {
            man.BeingMan();
        }

        private static void DoSomethingWithHumans(IEnumerable<Human> humans)
        {
            foreach (var human in humans)
            {
                human.Sleep();
                human.Eat();
                human.Walk();
            }
        }
    }
}
