using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAndSyntaxTricksCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------
            //WITHOUT LINQ ------------------------------------------------------------

            //Check strings for equality:

            //Check strings for equality to int:

            //Check string for equality to a double:

            //Check string for equality to a float:

            //Check int for equality to a double:

            //Check int for equality to a float:

            //Reverse a string in C#:

            //Reverse an Integer in C#:

            //Loop over the values of a primitive array of integers (using a regular for loop):

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
                Console.Write(value + " ");
            }

            //Copy a List to another List: BY VALUES NOT BY REFERENCE
            List<Employee> emplist = GetExampleEmployees();
            List<Employee> copy = new List<Employee>(emplist);
            foreach(var e in copy)
            {
                Console.Write(e.FirstName + " ");
            }

            //Copy a primitive array to a List (by values and order):
            int[] primarray = new int[5] { 5, 6, 7, 8, 9 };
            List<int> primtolist = new List<int>(primarray);
            Console.WriteLine(String.Join(",", primtolist));
            //OR: 
            int[] primarray2 = { 1, 2, 3, 4, 5 };
            List<int> primtolist2 = primarray2.ToList();
            Console.WriteLine(String.Join(",", primtolist2));


            //Copy a List to a primitive array (by values and order):




            //--------------------------------------------------------------------------
            //WITH LINQ ----------------------------------------------------------------

            //Get the First element of a sequence: 
            List<double> doubles1 = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double first = doubles1.First();
            Console.WriteLine("first was equal to: " + first);

            //Get the Last element of a sequence: 
            List<double> doubles2 = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double last = doubles2.Last();
            Console.WriteLine("last was equal to: " + last);

            //Get a specific element of a sequence based on its location: 
            List<double> doubles3 = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double secondposition = doubles3.ElementAt(2);
            Console.WriteLine("secondposition was equal to: " + secondposition);

            //Get a Single element from a sequence, and return an exception if there is more than 1 element in that sequence.
            //(It is primarily used to convert a sequence to a Single.)  
            List<double> doubles4 = new List<double> { 3.0 };
            double single = doubles4.Single();
            Console.WriteLine("single was equal to: " + single);

            //Conditionally extract the first single element from a sequence, based on some predicate of true or false:
            //(Throw an exception if no element matching the predicate was found)
            List<double> doubles5 = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double firstpredicate = doubles5.First(val => val < 2.2);
            Console.WriteLine("firstpredicate was equal to: " + firstpredicate);

            //Conditionally extract the first single element from a sequence, based on some predicate of true or false:
            //(Throw an exception if no element matching the predicate was found)
            List<double> doubles6 = new List<double> { 2.0, 2.1, 2.2, 2.3 };
            double lastpredicate = doubles5.Last(val => val > 2.2);
            Console.WriteLine("lastpredicate was equal to: " + lastpredicate);

            //Check two primitive arrays for equality (all items the same and in same order):
            int[] firstarray = { 1, 2, 3, 4, 5 };
            int[] secondarray = { 1, 2, 3, 4, 5 };
            if (Enumerable.SequenceEqual(firstarray, secondarray))
            {
                Console.WriteLine("firstarray and secondarray were equal by value and order.");
            }
            else
            {
                Console.WriteLine("firstarray and secondarray were not equal by value and order.");
            }

            //Check two List for equality (all items the same and in same order):
            List<int> someints = new List<int>() { 5,6,7,8,9 } ;
            List<int> someints2 = new List<int>() { 5, 6, 7, 8, 10 };
            if(Enumerable.SequenceEqual(someints,someints2))
            {
                Console.WriteLine("someints was equal (by value and order) to someints2");
            }
            else
            {
                Console.WriteLine("someints was not equal (by value and order) to someints2");
            }

            //Check two Lists for equality, ORDER DOES NOT MATTER:
            List<int> x = new List<int>() { 3, 5, 3, 2, 7 };
            List<int> y = new List<int>() { 3, 5, 3, 7, 2 };
            bool isEqual = Enumerable.SequenceEqual(x.OrderBy(e => e), y.OrderBy(e => e));
            if (isEqual)
            {
                Console.WriteLine("Lists are Equal");
            }
            else
            {
                Console.WriteLine("Lists are not Equal");
            }

            //Find all elements of a List1 which are NOT in List2:

            //Find all elements of a List<int> greater than a conditional:

            //Find all Employees from a List with an Age greater than 55:


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
