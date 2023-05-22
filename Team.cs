using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Team
    {
        Coach coach;
        List<FootballPlayer> players;
        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count <11 && value.Count > 22)
                {
                    throw new ArgumentException("greshka");
                }

              players = value;
            }
        }

        public Coach CoachP { get { return coach; } set { value = coach ;} }

        public Team(Coach coach, List<FootballPlayer> team)
        {
            this.coach = coach;
            Players = team;
        }

        public double Average()
        {
            double sum = 0;
           

            foreach (var item in players)
            {
               sum += item.Age;
                
            }

            return sum / players.Count;
        }

    }
}
