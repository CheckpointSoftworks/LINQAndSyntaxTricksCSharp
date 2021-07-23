using System;
using System.Collections.Generic;

namespace LINQAndSyntaxTricksCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------
            //WITHOUT LINQ ------------------------------------------------------------

            //Reverse a string in C#:

            //Reverse an Integer in C#:

            //Check strings for equality:

            //Check strings for equality to int:

            //Check string for equality to a double:

            //Check string for equality to a float:

            //Loop over the values of a primitive array of integers using a for loop:

            //Loop over the values of a List<int> using a foreach loop:

            //Loop over the characters of a string using a foreach loop:

            //Loop over the values of any generic List using a foreach loop:
            Employee e1 = new Employee("Thomas", "Train", 29);
            Employee e2 = new Employee("Cynthia", "Wallace", 47);
            Employee e3 = new Employee("Michael", "Phelps", 35);
            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            foreach (var e in employees)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + " " + e.Age);
            }

            //Copy an array to another array: BY VALUES NOT BY REFERENCE
            int[] source = new int[5] { 1, 2, 3, 4, 5 };
            int[] target = new int[5];
            Array.Copy(source, target, 5);
            foreach (int value in target)
            {
                Console.WriteLine(value);
            }

            //Copy a List to another List: BY VALUES NOT BY REFERENCE
            List<Employee> emplist = GetExampleEmployees();
            List<Employee> copy = new List<Employee>(emplist);
            foreach(var e in copy)
            {
                Console.WriteLine(e.FirstName);
            }




            //--------------------------------------------------------------------------
            //WITH LINQ ----------------------------------------------------------------

            //Check two primitive arrays for equality (all items the same and in same order);

            //Check two List for equality (all items the same and in same order):

            //Find all elements of a List1 which are NOT in List2:

            //Find all elements of a List<int> greater than a condition:

            //Find all Employees with an Age greater than 55:

            //Find all Employees with an Age between 13 to 19:

            //Find all Employees with a LastName less than 'M' (disregard case)

            //Find all Employees with a LastName greater than 'M' (disregard case)


        }
        public class Employee
        {
            private string _FirstName;
            private string _LastName;
            private int _Age;
            public Employee(string FirstName, string LastName, int Age)
            {
                this._FirstName = FirstName;
                this._LastName = LastName;
                this._Age = Age;
            }
            public string FirstName { get { return _FirstName; } set { this._FirstName = FirstName; } }
            public string LastName { get { return _LastName; } set { this._LastName = LastName; } }
            public int Age { get { return this._Age; } set { this._Age = Age; } }
        }

        public static List<Employee> GetExampleEmployees ()
        {
            List<Employee> res = new List<Employee>()
            {
                new Employee("Ian","Weber",29),
                new Employee("Frank","Reynolds",60),
                new Employee("Tabitha","Collins",34),
                new Employee("David","Bennet",37),
                new Employee("Seth","Mendoza",39),
                new Employee("Mary","Brown",50),
                new Employee("Mabel","Bilodeau",26),
                new Employee("Samantha","Heap",79),
                new Employee("Michelle","Ortiz",46),
                new Employee("Debra","Limon",45),
                new Employee("Genia","Hamilton",58),
            };

            return res; 
        }
    }
}
