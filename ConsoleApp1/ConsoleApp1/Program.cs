using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new ConcreteSubject("XYZ");

            subject.AddRange(new List<Notifier>
            {
                new Observer("o1"),
                new Observer2("o2"),
                new Observer3("o3")
            });

            subject.SetState("XYZ");
            Console.ReadKey();
        }

        abstract class Notifier
        {
            public abstract void Display(string state);
        }

        abstract class Subject
        {
            public string subjectState;

            List<Notifier> notify = new List<Notifier>();

            public void AddRange(List<Notifier> n)
            {
                notify.AddRange(n);
            }

            public void Dettach(Notifier n)
            {
                notify.Remove(n);
            }

            protected virtual void Notify()
            {
                notify.ForEach(n => n.Display(this.subjectState));
            }

            public abstract void SetState(string state);
        }

        class ConcreteSubject : Subject
        {
            string name;
            public ConcreteSubject(string name)
            {
                SetState(name);
            }

            public override void SetState(string state)
            {
                if (this.subjectState != state)
                {
                    this.subjectState = state;
                    Notify();
                }
            }
        }

        class Observer : Notifier
        {
            string name;
            public Observer(string name)
            {
                this.name = name;
            }

            public override void Display(string state)
            {
                Console.WriteLine($"Observer3{state} Name {this.name}");
            }
        }

        class Observer2 : Notifier
        {
            string name;
            public Observer2(string name)
            {
                this.name = name;
            }

            public override void Display(string state)
            {
                Console.WriteLine($"Observer3{state} Name {this.name}");
            }
        }

        class Observer3 : Notifier
        {
            string name;
            public Observer3(string name)
            {
                this.name = name;
            }

            public override void Display(string state)
            {
                Console.WriteLine($"Observer3{state} Name {this.name}");
            }
        }
    }
}
