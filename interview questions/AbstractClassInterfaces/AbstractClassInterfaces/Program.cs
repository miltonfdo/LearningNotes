using System;

namespace AbstractClassInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c = new WalkInCustomer();
            c.Enquiry();
            ICustomer c1 = new PlatiniumCustomer();
            c1.Enquiry();
            Console.WriteLine("Hello World!");
        }
    }
    public interface ICustomer// 1. planning 
    {
     
        decimal Discount();
    }
    public interface IEnquiry// 1. planning 
    {
        string name { get; set; }
        void Enquiry();
    }
    ////public abstract class IEnquiry
    //{
    //    public abstract string name { get; set; }
    //    public abstract void Enquiry();
    //}
    public abstract class Customer 
    {
        public abstract decimal Discount();
    }
    //public abstract  class Customer : ICustomer
    //{
    //    public  string name { get; set; }
    //    public  void Enquiry()
    //    {
    //        Console.WriteLine("Explain him product");
    //    }
    //    public abstract decimal Discount();
    //} // 2. Define common logic
    public class WalkInCustomer : IEnquiry, ICustomer
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal Discount()
        {
            throw new NotImplementedException();
        }

        public void Enquiry()
        {
            throw new NotImplementedException();
        }
    } // 3. Full classes

    public class PlatiniumCustomer : Customer
    {
        public override string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal Discount()
        {
            throw new NotImplementedException();
        }

        public override void Enquiry()
        {
            throw new NotImplementedException();
        }
    }

    public class Lead : IEnquiry
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Enquiry()
        {
            throw new NotImplementedException();
        }
    }
}
