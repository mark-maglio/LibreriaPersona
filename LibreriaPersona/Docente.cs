using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaPersona
{
    public class Docente : Lavoratore
    {
        private string nome;
        private string cognome;
        public string materia { get; private set; }
        private DateTime dataDiNascita;
        private double altezza;
        private int stipendio;

        public Docente(string nome, string cognome, DateTime dataDiNascita, double altezza, int stipendio, string materia) : base(nome, cognome, dataDiNascita, altezza, stipendio)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.altezza = altezza;
            this.stipendio = stipendio;
            this.materia = materia;
        }
    }