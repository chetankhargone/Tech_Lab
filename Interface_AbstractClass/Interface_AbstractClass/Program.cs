using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILayer
{
    using Contracts;
    using ServiceLayer;
    using AbstractContainer;
        
    class Program
    {
        static void Main(string[] args)
        {
            // UI Layer
            ICustomer cust;
            cust = new GoldCustomer();
            cust.GetCustomer();

            cust = new SilverCustomer();
            cust.GetCustomer();

            cust = new NewCustomer();
            cust.GetCustomer();

           NewCalculator calc = new NewCalculator();
           Console.WriteLine(calc.Add(10, 10));
           Console.WriteLine(calc.Divide(10, 10));

        }
    }
}

namespace Contracts
{
    public interface ICustomer
    {
        void GetCustomer();
    }
}

namespace ServiceLayer
{
    using Contracts;

    public class GoldCustomer : ICustomer
    {
        public void GetCustomer()
        {
            Console.WriteLine("Hello Gold Customer");
        }
    }

    public class SilverCustomer : ICustomer
    {
        public void GetCustomer()
        {
            Console.WriteLine("Hello Silver Customer");
        }
    }

    public class NewCustomer : ICustomer
    {
        public void GetCustomer()
        {
            Console.WriteLine("Hello New Customer");
        }
    }
}

namespace AbstractContainer
{
    public abstract class Calculator
    {
        public int Add(int a, int b )
        {
            return (a + b);
        }

        public abstract int Divide(int a, int b);
    }

    public class NewCalculator : Calculator
    {
        public override int Divide(int a, int b)
        {
            if(b != 0)
            {
                return (a / b);
            }
            else
            {
                return 0;
            }
        }
    }
}