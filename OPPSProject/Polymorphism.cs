using System;

namespace OPPSProject
{
    //base class
    public class Shape
    {
        protected int length;
        protected int breadth;
        public Shape()
        {
        }
        public Shape(int x, int y) //example of method overloading
        {
            length = x;
            breadth = y;
        }
        public virtual void Draw() // virtual used to override the base class member in its derived class 
        {
            Console.WriteLine("Drawing a SHAPE at " + length + " " + breadth);
        }
    }
    public class Square : Shape //inherit shape class
    {      
        public Square(int x, int y) 
        {
            length = x;
            breadth = y;
        }
        public override void Draw() //override keyword to override the base class method
        {
            Console.WriteLine("Drawing a SQUARE at " + length + " " + breadth);
        }
    }
    public class trangle : Shape //inherit shape class
    {       
        public trangle(int x, int y) : base(x, y) //used to access members of the base class from within a derived class
        {
        }
        public void Filltrangle()
        {
            Console.WriteLine("Filling trangle at " + length + " " + breadth);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a trangle at " + length + " " + breadth);
        }
    }
    public class trangleNonOverride : Shape //inherit shape class
    {        
        public trangleNonOverride(int x, int y) : base(x, y)
        {
        }
        public new void Draw() //Using the "new" keyword, we can hide the base class member.
        {
            Console.WriteLine("Drawing a trangle at " + length + " " + breadth);
        }
    }
    class Polymorphism
    {
        public void Poly()
        {
            Shape sh = new Shape(100, 100);
            sh.Draw();
            Square sq = new Square(200, 200);
            sq.Draw();
            trangle ci = new trangle(300, 300);
            ci.Draw();
            //can creat all below object in one Shape array in Polymorphism
            Console.WriteLine("\nPolymorphism:\n------------------");
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(100, 100);
            shapes[1] = new Square(200, 200);
            shapes[2] = new trangle(300, 300);
            foreach (Shape shape in shapes)
            shape.Draw();
            //non override method call base method.
            Console.WriteLine("\nNon Override Class:\n------------------");
            Shape Non = new trangleNonOverride(250, 250);
            Non.Draw();
            //Up-casting:
            Console.WriteLine("\nUp Casting:\n------------------");
            Shape shp = new trangle(320, 320);
            shp.Draw();
            //Down-casting:
            Console.WriteLine("\nDown Casting:\n------------------");
            //Circle c=shp; this is illegal, we have to define shape is Trangle.
            trangle c = (trangle)shp;
            c.Filltrangle();
            //shp is shape,if we call draw, Trangle call draw because we defined shape as Trangle.
            //But shp don't know am i Trangle, so we have to define shape is Trangle.
            ((trangle)shp).Filltrangle();
        }
    }
}
