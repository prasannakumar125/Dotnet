using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_in_oops.sealedclass.cs;

namespace Classes_in_oops.staticclass.cs
{
    static class teacher
    {
        static teacher()
        {
            Console.WriteLine("Static constructor1");
        }
        //Fields
        static int T_id;
        static string T_Name;
        static string T_Address;

        //properties
        static int ID { get; set; }
        static string NAME { get; set; }
        static string ADDRESS { get; set; }

        //Method
        static void GetdetailsofTeacher(int id, string Name, string Address)
        {
            ID = id;
            NAME = Name;
            ADDRESS = Address;

            T_id = id;
            T_Name = Name;
            T_Address = Address;

            //Console.Write("This is static method");
        }
    }
}