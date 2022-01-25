using System;
using System.Collections.Generic;
using System.Text;

namespace GitProjekt2
{
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Narozeni { get; set; }

        public int Vek()
        {
            DateTime dnes = DateTime.Now;
            return (dnes - Narozeni).ToString();
        }
    }
}
