using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    internal class Prestito
    {
        public string Numero { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
        public Prestito(string numero, DateTime dal, DateTime al, Utente utente, Documento documento)
        {
            Numero = numero;
            Dal = dal;
            Al = al;
            Utente = utente;
            Documento = documento;
            Documento.Stato = Stato.Prestito;
        }
        public override string ToString()
        {
            return string.Format("Numero: {0}\nDal: {1}\nAl: {2}\nStato: {3}\nUtente:\n{4}\nDocumento:\n{5}", Numero, Dal, Al, Documento.Stato, Utente.ToString(), Documento.ToString());
        }
    }
}
