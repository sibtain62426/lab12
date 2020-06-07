using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _project.Models
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }
    }

    public class Student
    {
        public string name;
        public int date;

        public Student(string name, int date)
        {
            this.name = name;
            this.date = date;
        }
    }

    public class  Std
    {
        public string regNum;
        public string name;
        public int age;

        public Std(string regNum, string name, int age)
        {
            this.regNum = regNum;
            this.name = name;
            this.age = age;
        }
    }
}