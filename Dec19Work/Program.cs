using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19Work
{
    internal class Program
    {
        public static string Msg()
        {
            string s = "Good moring";
            Console.WriteLine(s);
            return s;
        }
        static void Main(string[] args)
        {
            Customer.CustomerDetails();//no parameters
            Customer c = new Customer();
            c.CustomerDetails(12, "amit", "Hyd", 12345);//4 parameter
            c.Display();
            // string s = Msg();
            //  Console.WriteLine(  s);
            //string s1 =  Msg();
            Console.ReadLine();
            //// string str = Console.ReadLine();
            //// Stack s = new Stack();
        }
    }
}
