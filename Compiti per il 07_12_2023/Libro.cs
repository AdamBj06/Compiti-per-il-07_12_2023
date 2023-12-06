using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    internal class Libro : Documento
    {
        public int NumeroPagine { get; set; }
        public Libro(string codice, string titolo, int anno, string settore, int numeroPagine) : base(codice, titolo, anno, settore)
        {
            NumeroPagine = numeroPagine;
        }
        public override string ToString()
        {
            return string.Format("{0}\n NumeroPagine: {1}", base.ToString(), NumeroPagine);
        }
    }
}
