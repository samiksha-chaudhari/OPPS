using System;

namespace OPPSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("------------------------OOPS CONCEPTS-----------------------");
                Console.WriteLine("1.Inheritance  2.Polymorphism  3.Abstraction  4.Interface 5.Constructors 6.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Inheritance _inhert = new Inheritance();//creating object
                        _inhert.Inherit(); //calling start method
                        break;

                    case 2:
                        Polymorphism _poly = new Polymorphism();//creating object
                        _poly.Poly(); //calling start method
                        break;
                                            
                    case 3:
                        Abstraction _abst = new Abstraction();//creating object
                        _abst.abst(); //calling start method
                        break;

                    case 4:
                        Interface _interf = new Interface();//creating object
                        _interf.Interf(); //calling start method
                        break;

                    case 5:
                        Constructors _con = new Constructors();//creating object
                        _con.Constrc(); //calling start method
                        break;

                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
                }
            }
        }
    }
}
