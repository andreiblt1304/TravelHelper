using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_BaltariuAndrei
{
    class TipCladire
    {
        public
            string nume;
            int nrCamere;
            int nrCamereOc;

        void arataNrCamLibere()
        {
            Console.WriteLine(nrCamere - nrCamereOc);
        }
    }
}
