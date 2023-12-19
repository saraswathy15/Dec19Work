using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19Work
{
    public class Customer
    {//method overloading
        int cusId, ContactNo;
        string cuName, Address;// are accessibe to any method in class 
        public static void CustomerDetails() { Console.WriteLine("no parameter"); }
        public void CustomerDetails(int id, string name, string addr)
        {
            this.cusId = id;
            this.cuName = name;
            this.Address = addr;
            int x = 10;//local
            while (x < 10) { }

        }
        public void CustomerDetails(int id) { this.cusId = id; }
        public void CustomerDetails(int id, string name, string addr, int no)
        {
            this.cusId = id; this.Address = addr; this.ContactNo = no;
            this.cuName = name;
        }
        public void Display()
        {
            //  int num1 = Console.ReadLine();
            Console.WriteLine("{0} \t{1}\t{2}\t{3}", this.cusId, this.cuName, this.Address, this.ContactNo);
            int x = 10 * 20;// 30 is ans , we get 200
        }
    }
}
