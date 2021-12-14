using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_in_oops.sealedclass.cs;

namespace Classes_in_oops
{
    class Program
    {
        static void Main(string[] args)
        {
            soap soap = new soap(); //Partial class
            Car car = new Car();//sealed class
            soap.getdetailsofsoap(1, "lirirl", "london");
            Employee employee = new Employee();
            employee.Getmanager(5, "gggg", "hhhhh");
            Console.WriteLine("mgrid:" + employee.Manager_id);
            Console.WriteLine("mgrname:" + employee.Managaer_name);
            Console.WriteLine("mgraddress:" + employee.Manager_address);
            employee.Getmanagerdetails(1, "narasi", "banagalore");
            Console.ReadLine();
            
            //teacher tt = new teacher();
        //    teacher.GetdetailsofTeacher(1, "Prasanna", "Banaglore");

        //    Console.WriteLine("Teacher id:" + teacher.T_id);
        //    Console.WriteLine("Teacher Name:" + teacher.T_Name);
        //    Console.WriteLine("Teacher Address :" + teacher.T_Address);
        //    Console.WriteLine("ID:" + teacher.ID);
        //    Console.WriteLine("NAME:" + teacher.NAME);
        //    Console.WriteLine("ADDRESS :" + ADDRESS);
        //    Console.ReadLine();
        }
    }
}
