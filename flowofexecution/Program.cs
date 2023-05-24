using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace flowofexecution
{
    /*public class Mad
    {
        public static int x = 200;
        private Mad(int a) =>
        Console.WriteLine("Mad");
        public void hi()
        {
            Mad obj = new Mad(5);

        }

    }*/
    public class MainClass
{
    public static void Main()
    {

       // int a = 0;
       // Console.WriteLine("sdghc");
       // Organization organization = new Organization(65);
       // Console.WriteLine(organization.empname);
       // organization = null;

       // GC.SuppressFinalize(organization);
       //     GC.WaitForFullGCApproach();
       //     GC.Collect(4);

       // Console.WriteLine(GC.MaxGeneration);
       // Organization.orgname = 90;
       //// Mad.x = 30;
       // Console.WriteLine(a);
       // organization.print();
       //// Organization.orgname;
       // String str = Console.ReadLine();
       // Console.WriteLine(GC.CollectionCount(0));
       // Console.WriteLine(GC.CollectionCount(1));
       // Console.WriteLine(GC.CollectionCount(2));
       // int x = Convert.ToInt32(Console.ReadLine());
       // Console.WriteLine(x);
        Console.WriteLine(Organization.orgname);

    }
}
    public class Organization//:Mad
    {
        public static int orgname=190;
        public  void Print()
        {
            Console.WriteLine("jsbc");
        }
    static int empid = 10;
    static int empname;
    /*static Organization()
    {
        orgname = 10;
        Console.WriteLine("sjdfh");
    }
    /*public Organization()
    {
        empname = 0;
    }*/
    private Organization()
    {
        //empid = a;
    }
    static void print()
    {
        Console.WriteLine(empid + " " + empname);
    }
    /*~Organization()
    {
        Console.WriteLine("Hi Destroyer");
    }*/
}

}
