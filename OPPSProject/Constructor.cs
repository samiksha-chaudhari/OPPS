using System;
using System.Collections.Generic;
using System.Text;

namespace OPPSProject
{
    class DefaultConstructor
    {
        //when object of that class created, Constructor would be invoked
        public DefaultConstructor()
        {
            Console.WriteLine("Constructor is running");
        }

    }
    class ParameterizedConstructor
    {
        //when class created, if constructor no have paramater, this methods run.
        public ParameterizedConstructor()
        {
            Console.WriteLine("Non Parameterized Constructor is running");
        }
        //when class created, if constructor have int i paramater, this methods run.
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine("Parameterized Constructor is running, You are parameter : " + i);
        }
    }
    class CopyConstructor
    {
        private string _data;
        private int _number;

        //if class paramater has come, this constructor copy object which come
        public CopyConstructor(CopyConstructor obj)
        {
            _data = obj._data;
            _number = obj._number;
        }
        //first creat this class, paramater value add
        public CopyConstructor(string data, int number)
        {
            _data = data;
            _number = number;
        }
        public void DataWriter()
        {
            Console.WriteLine("Data: " + _data + " Number: " + _number);
        }

    }
    class PrivateConstructor
    {
        private PrivateConstructor()
        {

        }
        public void Method()
        {
            Console.WriteLine("Method is running");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method is running");
        }
    }
    class StaticConstructor
    {
        //It is invoked before the first instance constructor is run.
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor is running");
        }

        //Instance constructor
        public StaticConstructor(int x)
        {
            Console.WriteLine("Instance Constructor is running, you are data: " + x);
        }
    }
    class Constructors
    {
        public void Constrc()
        {
            //Default Constructor

            Console.WriteLine("Default Constructor\n-----------------------\n");
            var obj1 = new DefaultConstructor();
            //Parameterized Constructor

            Console.WriteLine("\nParameterized Constructor\n-----------------------\n");
            var obj2 = new ParameterizedConstructor();
            obj2 = new ParameterizedConstructor(5);
            //Copy Constructor

            Console.WriteLine("\nCopy Constructor\n-----------------------\n");
            var obj3 = new CopyConstructor("My Data", 1);
            obj3 = new CopyConstructor(obj3);
            obj3.DataWriter();
            //Private Constructor

            Console.WriteLine("\nPrivate Constructor\n-----------------------\n");
            //var obj4=new PrivateConstructors(); - this command line is illegal
            //PrivateConstructors method is private so this can't access to PrivateConstructors
            //In this class or another class, only can access static class or another 
            //public constructor in which called class
            PrivateConstructor.StaticMethod();

            //Static Constructor

            Console.WriteLine("\nStatic Constructor\n-----------------------\n");

            var obj4 = new StaticConstructor(4);


        }
    }
}
