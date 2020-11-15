using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaPersona
{
    public class Studente : Persona
    {
        private string nome;
        private string cognome;
        public string classe { get; private set; }
        private DateTime dataDiNascita;
        private double altezza;

        public Studente(string nome, string cognome, DateTime dataDiNascita, double altezza, string classe) : base(nome, cognome, dataDiNascita, altezza)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.altezza = altezza;
            this.classe = classe;
        }

    }
}