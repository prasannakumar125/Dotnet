using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_oops
{
    public abstract class manager
    {
        //creating constriuctor 
        //implemented methods and unimplemented methods
        public manager()
        {
            Console.WriteLine("this is abstract constructor");
        }
        //creating properties
        public int Manager_id { get; set; }
        public string Managaer_name { get; set; }
        public string Manager_address { get; set; }

        //method
        public void Getmanager(int Managerid, string Managaername, string Manageraddress) //implemented method or non abstract method
        {
            this.Manager_id = Managerid;
            this.Managaer_name = Managaername;
            this.Manager_address = Manageraddress;

            Console.WriteLine("this is implemted method");
        }
        public abstract void Getmanagerdetails(int Managerid, string Managaername, string Manageraddress); //unimplemneted method or abstract mrthod

    }

    public class Employee : manager
    {
        public override void Getmanagerdetails(int Managerid, string Managaername, string Manageraddress)
        {
            Console.WriteLine("this is inherited child class method from abstrcat class");
        }
    }

}
