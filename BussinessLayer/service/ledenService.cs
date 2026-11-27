
using BussinessLayer.model;
using System.Collections.Generic;

namespace BussinessLayer.service
{
    public class ledenService
    {
        
        Jumpers jumpers = new Jumpers();


        public void addTeams()
        {
            jumpers.addTeam(new Team("U10", 11));
            jumpers.addTeam(new Team("U12", 11));
            jumpers.addTeam(new Team("U14", 11));
            jumpers.addTeam(new Team("U16", 11));
            jumpers.addTeam(new Team("U18", 11));
        }

        public void addSpeler(Team team, string naam, int leeftijd)
        {
            team.LidIndelen(new Speler(naam, leeftijd));
        }

        public List<Team> showTeams()
        {
            return jumpers.showTeams();
        }


    }
}
