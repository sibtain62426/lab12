using _project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18_05_2020_1.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public ActionResult Index()
        {
            return View();
        }

        public string LinqFun()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            var str = "";
            foreach (int num in numQuery)
            {
                str += num + "<br>";
            }
            return str;
        }

        public string findPerson()
        {
            Person[] personInfo = new Person[4];
            personInfo[0] = new Person("Saad", 27);
            personInfo[1] = new Person("Usama", 22);
            personInfo[2] = new Person("Isa", 44);
            personInfo[3] = new Person("sIBTAIN", 31);

            var result = from per in personInfo
                         where per.Age > 20
                         orderby per.Age
                         select per;

            string str = "";

            foreach(Person per in result)
            {
                str += per.Name + "<br>";
            }

            return str;
        }

        //Walk through task
        public string StudentDict()
        {
            Dictionary<int, Student> dict = new Dictionary<int, Student>();
            dict.Add(1, new Student("Ali", 1999));
            dict.Add(2, new Student("AKbar", 1998));
            dict.Add(3, new Student("AHmed", 1997));
            dict.Add(4, new Student("Hassan", 1996));

            string result = "<HTML><Body><Talbe>";
            foreach(var d in dict)
            {
                result += "<tr><td>" + ((Student)d.Value).name + "</td></tr><br>";
            }
            result += "</Talbe></Body></HTML>";
            return result;
        }

        public string task01()
        {
            int[] arr = new int[9] { 2, 2, 4, 1, 3, 2, 5, 6, 7 };

            IEnumerable<int> once = arr.Distinct<int>();
            
            string result = "Displaying all elements once only: " + string.Join("<br>", once);

            return result;
        }

        public string selectStudent()
        {
            Std[] studentInfo = new Std[3];
            studentInfo[0] = new Std("BCS173001", "Asad", 20);
            studentInfo[1] = new Std("BCS173002", "Asad", 20);
            studentInfo[2] = new Std("BCS173003", "Asad", 44);

            var result = studentInfo.OrderBy(s => s.name).ThenBy(s => s.age);


            string str = "";

            foreach (Std stu in result)
            {
                str += stu.regNum+ "<br>" + stu.name + "<br>" + stu.age + "<br><br>";
            }

            return str;
        }

        public string highestMarks()
        {
            double[] marks = new double[5] { 1.3, 4, 3.5, 2.2, 3.9 };

            double maxValue = marks.Max();

            string str = "";
            str = "Highest gpa is " + maxValue;
            return str;
        }

        public string task04()
        {
            List<int> intList = new List<int>() { 7, 10, 48, 52, 68, 25 };
            List<string> stringList = new List<string>() { null, "Two","Three","2","Five","MVC"};
            List<int> emptyList = new List<int>();
            

            int res = (from l in intList select l).FirstOrDefault();
            string res2 = (from l in stringList select l).FirstOrDefault();
            int res3 = (from l in emptyList select l).FirstOrDefault();
            int res4 = (from l in intList select l).SingleOrDefault();
            string res5 = (from l in stringList select l).SingleOrDefault();
            int res6 = (from l in emptyList select l).SingleOrDefault();

            string result = res + "<br>" + res2 + "<br>" + res3 + "<br>" +res4 + "<br>" + res5 + "<br>" + res6;
            
            return result;
        }
    }
}