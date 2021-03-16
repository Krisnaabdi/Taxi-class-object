using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_TAXI
{
    class Taxi
    {
        //propertis
        public string NamaPengemudi { get; set; }
        public bool SedangBertugas { get; set; }
        public int NomorPenumpang { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("NamaPengemudi : {0}", NamaPengemudi);
            if (SedangBertugas == true)
            {
                Console.WriteLine("OnDuty : yes", SedangBertugas);
            }
            else
            {
                Console.WriteLine("OnDuty : no", SedangBertugas);
            }
            Console.WriteLine("NomorPenumPang : {0}", NomorPenumpang);
        }
           
            
        

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Udin sedang menjemput penumpang\n", NamaPengemudi);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Udin selesei mengantar penumpang\n", NamaPengemudi);
        }
    }
}
