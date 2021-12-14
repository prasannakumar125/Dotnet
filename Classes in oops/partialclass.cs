using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_oops
{
    public partial class soap
    {
        public soap()
        {

        }
        //properties
        public int soapid { get; set; }
        public string soapname { get; set; }
        public string soapaddress { get; set; }

        public void getdetailsofsoap(int soap_id, string soap_name, string soap_address)
        {
            Console.WriteLine("this is partial class");
        }


    }

}
