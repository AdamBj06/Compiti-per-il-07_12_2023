using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Compiti_per_il_07_12_2023
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public List<Documento> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }
        public List<Utente> Utenti { get; set; }
        public Biblioteca(string nome)
        {
            Nome = nome;
            Documenti = new List<Documento>();
            Prestiti = new List<Prestito>();
            Utenti = new List<Utente>();
        }
        public List<Documento> SearchByCodice(string codice)
        {
            return Documenti.Where(d => d.Codice == codice).ToList();
        }
        public List<Documento> SearchByTitolo(string titolo)
        {
            return Documenti.Where(d => d.Titolo == titolo).ToList();
        }
        public List<Prestito> SearchPrestiti(string numero)
        {
            return Prestiti.Where(p => p.Numero == numero).ToList();
        }
        public List<Prestito> SearchPrestiti(string nome, string cognome)
        {
            return Prestiti.Where(p => p.Utente.Nome == nome && p.Utente.Cognome == cognome).ToList();
        }
    }
}
