using ClassHierarchy.Enums;

namespace ClassHierarchy.Models
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Money { get; set; }
        public EyesType EyesType { get; set; }


        public Human(string name, string job, decimal money, EyesType eyesType)
        {
            this.Name = name;
            this.Job = job;
            this.Money = money;
            this.EyesType = EyesType;
        }

        abstract public void Eat();
        abstract public void Sleep();
        abstract public void Walk();
    }
}
