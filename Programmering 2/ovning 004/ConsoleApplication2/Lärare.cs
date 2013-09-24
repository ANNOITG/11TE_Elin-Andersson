using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Lärare : Person
    {
        public Lärare()
        {

        }

        public Lärare(string namn, string adress, string pnr, string telenr)
        {
            setNamn(namn);
            setAdress(adress);
            setPnr(pnr);
            setTeleNr(telenr);

        }
                                                           
    }
}
