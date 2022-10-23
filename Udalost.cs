using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2210
{

    public enum Typ
    {
        SYSTEMOVA,
        HARDWAROVA,
        APLIKACNI,
        JINY

    }

    public enum Uroven
    {
        INFORMACE,
        VAROVANI,
        CHYBA,
        JINY

    }

    internal class Udalost
    {



        private Typ typ;
        private Uroven uroven;
        private String popis;

        public Typ T
        {
            get { return typ; }
            set 
            {
                if(value == Typ.JINY)
                {
                    throw new Exception("Typ nesmi byt Jiny!");
                }
                typ = value; 
            }
        }

        public Uroven U
        {
            get { return uroven; }
            set 
            {
                if (value == Uroven.JINY)
                {
                    throw new Exception("Uroven nesmi byt Jiny!");
                }
                uroven = value;
            }
        }

        public String Popis
        {
            get { return popis; }
            set { popis = value; }
        }

        public Udalost(Typ typ, Uroven uroven, string popis)
        {
            this.typ = typ;
            this.uroven = uroven;
            this.popis = popis;
        }




        public override string ToString()
        {
            return "Udalost typu: " + typ + ", uroven: " + uroven + ", popis: " + popis;
        }





    }
}