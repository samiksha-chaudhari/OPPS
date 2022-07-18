using System;
using System.Collections.Generic;
using System.Text;

namespace OPPSProject
{
    //Abstract class have regular and abstract method
    public abstract class Persons
    {
        public void CanWalk()
        {
            Console.WriteLine("Yes, I can walk");
        }
        public abstract void CanSpeakLanguages(); //Abstract method not have body
    }

    public class American : Persons // Derived class Inherit from Person
    {
        public American()
        {
            Console.WriteLine("American Class:");
        }

        public override void CanSpeakLanguages() //override keyword to override the base class method
        {
            Console.WriteLine("I can speak English");
        }
    }

    public class Indian : Persons
    {
        public Indian()
        {
            Console.WriteLine("Indian Class:");
        }
        public override void CanSpeakLanguages()
        {
            Console.WriteLine("I can speak Hindi, Marathi and English");
        }
    }

    public class Chinese : Persons
    {
        public Chinese()
        {
            Console.WriteLine("Chinese Class:");
        }
        public override void CanSpeakLanguages()
        {
            Console.WriteLine("I can speak Mandolin");
        }
    }
    class Abstraction
    {
        public void abst()
        {
            Persons person = new American();
            person.CanWalk();
            person.CanSpeakLanguages();

            Indian person1 = new Indian();
            person1.CanWalk();
            person1.CanSpeakLanguages();

            person = new Chinese();
            person.CanWalk();
            person.CanSpeakLanguages();
        }
    }
}
