using System;

namespace LibreriaPersona
{
    public class Persona
    {
        public string nome { get; private set; }
        public string cognome { get; private set; }
        public DateTime datadinascita { get; private set; }
        public double altezza { get; private set; }

        public Persona(string nome, string cognome, DateTime datadinascita, double altezza)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.datadinascita = datadinascita;
            this.altezza = altezza;
        }
    }
}