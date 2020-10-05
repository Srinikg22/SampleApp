using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new ConcreateSubject("ABC");

            subject.AddRange(new List<Observer>{
               new MilkObserver("o1"),
               new MilkObserver_2("o2"),
               new MilkObserver_3("o3"),
               new MilkObserver_4("o4")
            });

            subject.SetState("XYZ");

            Console.ReadLine();
        }
    }

    abstract class Observer
    {
        public abstract void Update(string state);
    }

    abstract class Subject 
    {
        public string SubjectState;

        List<Observer> observers = new List<Observer>();

        public virtual void AddRange(List<Observer> o)
        {
            observers.AddRange(o);
        }

        public abstract void SetState(string state);


        public virtual void Notify()
        {
            observers.ForEach(o => o.Update(this.SubjectState));
        }
    }

    class ConcreateSubject : Subject
    {
        public string Message;
        public ConcreateSubject(string state)
        {
            SetState(state);
        }

        public override void SetState(string state)
        {
            if (this.SubjectState != state)
            {
                this.SubjectState = state;
                Notify();
            }
        }
    }

    class MilkObserver : Observer
    {
        string Name;
        public MilkObserver(string state)
        {
            this.Name = state;
        }

        public override void Update(string state)
        {
            Console.WriteLine($"Observer{state} state {this.Name}");
        }
    }

    class MilkObserver_2 : Observer
    {
        string Name;
        public MilkObserver_2(string state)
        {
            this.Name = state;
        }

        public override void Update(string state)
        {
            Console.WriteLine($"Observer{state} state {this.Name}");
        }
    }

    class MilkObserver_3 : Observer
    {
        string Name;
        public MilkObserver_3(string state)
        {
            this.Name = state;
        }

        public override void Update(string state)
        {
            Console.WriteLine($"Observer{state} State {this.Name}");
        }
    }

    class MilkObserver_4 : Observer
    {
        string Name;
        public MilkObserver_4(string state)
        {
            this.Name = state;
        }

        public override void Update(string state)
        {
            Console.WriteLine($"Observer{state} State {this.Name}");
        }
    }
}
