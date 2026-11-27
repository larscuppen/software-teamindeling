
using System.Collections.Generic;

namespace BussinessLayer.model
{
    public class Jumpers
    {
        private List<Team> Teams = new List<Team>();

        public void addTeam(Team team)
        {
            Teams.Add(team);
        }
        public List<Team> showTeams()
        {
            return Teams;
        }
    }
}
