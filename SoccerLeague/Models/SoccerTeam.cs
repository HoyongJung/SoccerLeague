using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerLeague.Models
{
    public class SoccerTeam : Team
    {
        //empty constructor
        public SoccerTeam()
        {

        }
        //constructor with name and points
        public SoccerTeam(string teamName, int teamPoints)
        {
            base.name = teamName;
            this.points = teamPoints;
        }

        public int draw { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int differential { get; set; }
        public int points { get; set; }
    }
}