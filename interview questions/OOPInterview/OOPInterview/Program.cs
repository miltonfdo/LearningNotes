using System;

namespace OOPInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1 + 2;
            var o1 = new SomeClass(10);
            var o2 = new SomeClass(20);
            var o3 = o1 + o2;
            Console.WriteLine("Hello World!");
        }
    }
    public class SomeClass
    {

        private int someValue;
        public SomeClass(int val)
        {
            someValue = val;
        }

        public static SomeClass operator +(SomeClass arg1, SomeClass arg2)
        {
            return new SomeClass(arg1.someValue + arg2.someValue);
        }
    }
    public class Employee
    {
        public string name { get; set; }
        public string address { get; set; }
        public virtual void Validate()
        {
            CheckName();
            CheckAddress();
        }
        private void CheckName()
        {

        }
        private void CheckAddress()
        {

        }
    }
    public class Manager : Employee
    {
        public void Management()
        {

        }
        public override void Validate()
        {
           // our own logic
        }
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict , int num1)
        {
            // our own logic
        }
    }
    public class Supervisor : Employee
    {
        public void Management()
        {

        }
        public override void Validate()
        {
            // our own logic
        }
        public void Validate(bool strict)
        {
            // our own logic
        }
        public void Validate(bool strict, int num1)
        {
            // our own logic
        }
    }
    
}
