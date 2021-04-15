using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerable
{
    class Params : IEnumerable<int>
    {
        private int a, b, c;


        public Params(int a,int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Person 
    {
        private string FirstName, MiddleName, LastName;
            
        public  Person(string FirstName, string MiddleName, string LastName)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
        }

        public IEnumerable<string> Names()
        {
            yield return FirstName;
            yield return MiddleName;
            yield return LastName;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            var a = new Params(1, 2, 3);
            foreach(var x in a)
            {
                Console.WriteLine(x);
            }

            var p = new Person("Seetharaman", "Balaraman", "Krishana");
            foreach(var name in p.Names())
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Hello World!");

        }
    }
}
