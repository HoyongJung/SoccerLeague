using SoccerLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerLeague.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            //declare variables
            List<SoccerTeam> lstTeams = new List<SoccerTeam>();
            List<SoccerTeam> lstSorted;
            int iTeamRank = 0;

            //Load the data
            lstTeams.Add(new SoccerTeam("RSL", 35));
            //Load the data
            lstTeams.Add(new SoccerTeam("Colorado", 24));
            //Load the data
            lstTeams.Add(new SoccerTeam("FC Dallas", 42));
            //Load the data
            lstTeams.Add(new SoccerTeam("Sporting KC", 39));
            //Load the data
            lstTeams.Add(new SoccerTeam("San Jose", 16));
            //Load the data
            lstTeams.Add(new SoccerTeam("Houston", 27));
            //Load the data
            lstTeams.Add(new SoccerTeam("Seattle", 32));
            //Load the data
            lstTeams.Add(new SoccerTeam("Vancouver", 33));
            //Load the data
            lstTeams.Add(new SoccerTeam("Minnesota", 29));
            //Load the data
            lstTeams.Add(new SoccerTeam("Portland", 37));
            //Load the data
            lstTeams.Add(new SoccerTeam("LA Galaxy", 37));
            //Load the data
            lstTeams.Add(new SoccerTeam("LAFC", 39));


            //Sort the list
            lstSorted = lstTeams.OrderByDescending(x => x.points).ToList();

            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Ranking</th>";
            ViewBag.Output += "<th>Team Name</th>";
            ViewBag.Output += "<th>Points</th>";
            ViewBag.Output += "</tr>";

            //add the rest of the html table rows (using <tr> tag) and cells (using <td> tag) and a foreach statement
            //make sure you close the table html tag

            foreach (SoccerTeam oTeam in lstSorted)
            {
                iTeamRank++;
                ViewBag.Output += "<tr>";
                ViewBag.Output += "<td>" + iTeamRank + "</td>";
                ViewBag.Output += "<td>" + oTeam.name + "</td>";
                ViewBag.Output += "<td>" + oTeam.points + "</td>";
                ViewBag.Output += "</tr>";
            }

            ViewBag.Output += "</table>";

            return View();
        }
    }
}