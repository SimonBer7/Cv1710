using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2210
{

    public enum Jazyk
    {
        CZ,
        EN
    }


    internal class Slovnicek
    {

        private List<Slovo> slovnik = new List<Slovo>();


        public List<Slovo> Slovnik
        {
            get { return slovnik; }
            set { slovnik = value; }
        }

        public Slovnicek()
        {

        }


        public void AddSlovo(Slovo s)
        {
            slovnik.Add(s);
        }


        public List<string> HledejVeSlovniku(string hledaneSlovo, Jazyk jazyk)
        {

            List<string> vyslednySlova = new List<string>();

            foreach (Slovo s in slovnik)
            {

                if (jazyk.Equals(Jazyk.CZ))
                {
                    foreach (string ceskeSlovo in s.Cesky)
                    {
                        if (ceskeSlovo == hledaneSlovo)
                        {
                            vyslednySlova = s.Anglicky;
                        }
                    }


                }
                else
                {
                    foreach (string anglickeSlovo in s.Anglicky)
                    {
                        if (anglickeSlovo == hledaneSlovo)
                        {
                            vyslednySlova = s.Cesky;
                        }
                    }

                }

            }
                return vyslednySlova;
        }



    }
}
