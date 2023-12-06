using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    internal class Dvd : Documento
    {
        public int Durata { get; set; }
        public Dvd(string codice, string titolo, int anno, string settore, int durata) : base(codice, titolo, anno, settore)
        {
            Durata = durata;
        }
        public override string ToString()
        {
            return string.Format("{0}\nDurata: {1}", base.ToString(), Durata);
        }
    }
}
