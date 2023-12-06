using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_07_12_2023
{
    internal class Utente : Persona
    {
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { private get; set; }
        public Utente(string nome, string cognome, string telefono, string email, string password) : base(nome, cognome)
        {
            Telefono = telefono;
            Email = email;
            Password = password;
        }
        public override string ToString()
        {
            return string.Format(" Nome: {0}\n Cognome: {1}\nTelefono: {2}\nEmail: {3}\nPassword: {4}", Nome, Cognome, Telefono, Email, Password);
        }
    }
}
