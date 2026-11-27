using System;
using System.Collections.Generic;
using System.Text;


namespace BussinessLayer.model
{
    public class Speler
    {
        private string Naam {  get; set; }
        private int Leeftijd { get; set; }

        public override string ToString()
        {
            return Naam;
        }
        public Speler(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

    }
}
