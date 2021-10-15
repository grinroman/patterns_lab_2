using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_lab_1
{
    public abstract class Action
    {
        public abstract void  Run();
    }

    public class Human : Action
    {
        public int Age { get; set; }
        public Human()
        {
            this.Age = new Random().Next(14, 70);
        }

        public Human Clone()
        {
            Human temp = new Human() { Age = this.Age };
            return temp;
        }

        public override void Run()
        {
           Console.WriteLine("we just crowling!");
        }

    }

    public class Avatar : Action
    {
        Human human;
        public Avatar(Human human)
        {
            this.human = human;
        }
        public int AvatarAge { get { return human.Age; } }
        public override void Run()
        {
            human.Run();
            Console.WriteLine("So cool to run!");
        }
    }
}
