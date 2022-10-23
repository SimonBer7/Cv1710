using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni2210
{
    internal class Slovo
    {

        private List<string> cesky = new List<string>();
        private List<string> anglicky = new List<string>();


        public List<string> Cesky
        {
            get { return cesky; }
            set { cesky = value; }
        }


        public List<string> Anglicky
        {
            get { return anglicky; }
            set { anglicky = value; }
        }


        public Slovo(List<string> czech, List<string> english)
        {
            Cesky = czech;
            Anglicky = english;
          
        }


        public override string ToString()
        {
            string vypis = "";

            foreach(string c in cesky)
            {
                vypis += c + ", ";
            }

            foreach(string c in anglicky)
            {
                vypis += c + ", ";
            }

            return vypis;
        }





    }
}
