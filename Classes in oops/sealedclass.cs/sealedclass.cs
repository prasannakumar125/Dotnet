using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_oops.sealedclass.cs
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("this is sealed class");

        }
        //properties
        public int car_id { get; set; }
        public string car_name { get; set; }
        public string car_address { get; set; }

        //method
        public void Getcardetails(int carid, string carname, string caraddress)
        {
            car_id = carid;
            car_name = carname;
            car_address = caraddress;

        }
    }
}
