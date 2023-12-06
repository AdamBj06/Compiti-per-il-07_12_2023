using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    enum Stato { Disponibile, Prestito }
    internal class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public Stato Stato { get; set; }
        public Scaffale Scaffale { get; set; }
        public List<Autore> Autori { get; set; }
        public Documento(string codice, string titolo, int anno, string settore)
        {
            Codice = codice;
            Titolo = titolo;
            Settore = settore;
            Anno = anno;
            Autori = new List<Autore>();
            Stato = Stato.Disponibile;
        }
        public override string ToString()
        {
            return string.Format(" Codice: {0}\n Titolo: {1}\n Settore: {2}\n Anno: {3}\n Stato: {4}\n Scaffale numero: {5}", Codice, Titolo, Settore, Anno, Stato, Scaffale.Numero);
        }
        public void ImpostaInPrestito()
        {
            Stato = Stato.Prestito;
        }
        public void ImpostaDisponibile()
        {
            Stato = Stato.Disponibile;
        }
    }
}
