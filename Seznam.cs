using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2210
{
    internal class Seznam
    {

        private List<Udalost> list;

        public List<Udalost> List
        {
            get { return list; }
            set { list = value; }
        }

        public Seznam()
        {
            list = new List<Udalost>();
        }

        public void Add(Udalost u)
        {
            list.Add(u);
        }


        public Seznam Filtr(Typ? t, Uroven? u)
        {
            Seznam seznam = new Seznam();

            foreach(Udalost ud in list)
            {
                if (ud.T == t && ud.U == u)
                {
                    seznam.Add(ud);
                }
                else
                {
                    if (Typ.JINY == t && ud.U == u)
                    {
                        seznam.Add(ud);
                    }
                    else
                    {
                        if (ud.T == t && Uroven.JINY == u)
                        {
                            seznam.Add(ud);
                        }
                    }
                }        
            }
            return seznam;
        }


        public override string ToString()
        {
            string vypis = "";
            foreach(Udalost ud in list)
            {
                vypis += ud.ToString()+"\n";
            }


            return vypis;
        }






    }
}
