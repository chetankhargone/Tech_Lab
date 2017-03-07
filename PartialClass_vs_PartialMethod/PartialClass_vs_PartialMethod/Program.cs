using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILayer
{
    using CustomerApp;

    class Program
    {
        static void Main(string[] args)
        {
            Customer custObj = new Customer();
            custObj.Id = 10;

            Console.WriteLine(custObj.Validation(custObj.Id));
            custObj.GetCustomer(custObj.Id);
            
        }
    }
}

#region What is Partial Class
/*
  Definition - A class that can be splitted into multiple physical files.
  Usage - /* Different Team having different copies of Customer  but when compiled they alll are mreged into a single class
  Benefit - Better Organization
*/
#endregion

#region What is Partial Method
    /*
    Defintion - A method marked with partial keyword is Partial method
    Usage - If you have a method whose implemenation is not yet defined & should be included in the class template only if it has implemenatiion else should be skipped.
    Rule -  1) A partial method can have only void as return type. 
            2) No access modifier allowed.
    */
#endregion

namespace CustomerApp
{
    //Team A
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
       
    }

    //Team B
    public partial class Customer
    {
        public bool Validation(int id)
        {
            if(id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Team C
    public partial class Customer
    {
        public string GetCustomer(int id)
        {
            if(id == 1)
            {
                return "Gold Customer";
            }
            else
            {
                return "Silver Customer";
            }
        }
    }

    //Team D
    public partial class Customer
    {
        partial void GetCustomerAge();
    }

}