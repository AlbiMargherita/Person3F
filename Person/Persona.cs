using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        private int _anni;
        public int anni
        {
            set
            {
                if (value < 0) value = 1;               //valore di default 
                _anni = value;
            }

            get { return _anni; }
        }

        private int _codicefiscale;
        public string codicefiscale { get { return nome + cognome + anni; } }


        public Persona (string nome, string cognome, int anni)                        //costruttore Persona
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }


        public string describe ()                     //funzione di descrizione 
        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "Anni: " + anni + "\r\n";

            return output;
        }

    }
}
