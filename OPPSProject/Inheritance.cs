using System;
using System.Collections.Generic;
using System.Text;

namespace OPPSProject
{
    //Base class
    class Person
    {
        //fields
        public string _name;
        public string _surname;
        public int _age;

        //methods
        public void PersonData(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
        public void PersonDataWriter()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
        }

    }
   
    class Student : Person  //Inheriting Person class using
    {
        //studend fields
        float _studentGrade;
        int _classYear;
        int _studentNumber;
        public void StudentData(float studentGrade, int classYear, int studentNumber)
        {
            _studentGrade = studentGrade;
            _classYear = classYear;
            _studentNumber = studentNumber;
        }
        public void StudentDataWriter()
        {
            //as seen bellow , sub class (student) can use super class data.
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Student Grade: " + _studentGrade);
            Console.WriteLine("Class Year: " + _classYear);
            Console.WriteLine("Student Number: " + _studentNumber);
        }
    }
    
    class Teacher : Person  //Inheriting Person class another using
    {
        //teacher fields
        int _teacherNumber;
        string _department;

        public void TeacherData( string department, int teacherNumber)
        {
            _teacherNumber = teacherNumber;
            _department = department;            
        }
        public void TeacherDataWriter()
        {
            //as seen bellow , sub class (teacher) can use super class data.
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Department: " + _department);
            Console.WriteLine("Teacher Number: " + _teacherNumber);
        }
    }
    class Inheritance 
    {
        public void Inherit()
        {
            var obj = new Student();
            obj.PersonData("Samiksha", "Chaudhari", 24);
            obj.StudentData(9, 4, 111);
            Console.WriteLine("Student Class Writer:\n--------------------");
            obj.StudentDataWriter();
            //Console.WriteLine("\nPerson Class Writer:\n--------------------");
            //obj.PersonDataWriter();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            var obj1 = new Teacher();
            obj1.PersonData("Tina", "Patil", 30);
            obj1.TeacherData("science", 222);
            Console.WriteLine("Teacher Class Writer:\n--------------------");
            obj1.TeacherDataWriter();       
        }
    }
   
}
