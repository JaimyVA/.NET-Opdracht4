using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    public delegate void delegate1(string task);
    internal class TeDoen
    {
        public int Id;
        public DateTime tijdstip;
        public string Titel;
        public string informatie;
        public override string ToString()
        {
            return base.ToString();
        }

        public event delegate1 ToonMij;

    }
}
