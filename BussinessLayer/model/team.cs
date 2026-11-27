using BussinessLayer.model;
using System;
using System.Collections.Generic;
using System.Text;


namespace BussinessLayer
{
    public class Team
    {
        private string TeamNaam {  get; set; }
        private int MaxSpeler {  get; set; }
        private List<Speler> Spelers = new List<Speler>();

        public override string ToString()
        {
            return TeamNaam;
        }
        public Team(string teamnaam, int maxspeler)
        {
            this.TeamNaam = teamnaam;
            this.MaxSpeler = maxspeler;
        }

        public void LidIndelen(Speler speler)
        {
            Spelers.Add(speler);
        }
        public List<Speler> SpelersOphalen()
        {
            return Spelers;
        }
        


    }
}
