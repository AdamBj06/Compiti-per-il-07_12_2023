using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public override string ToString()
        {
            return string.Format("Nome: {0}\nCognome: {1}", Nome, Cognome);
        }
    }
}
