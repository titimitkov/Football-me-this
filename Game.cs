using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Game
    {

        private Team team1;
        private Team team2;

        public Team Team1 
        {
            get { return team1; }
            set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("greshka");
                }

                team1 = value;
            }
        }

        public Team Team2
        {
            get { return team2; }
            set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("greshka");
                }

                team2 = value;
            }
        }



        Referee referee;
        Referee assistantReferee1;
        Referee assistantReferee2;

        List<Goal> goals;
        GameResult result;

        Team winner;


        public Referee Referee { get { return referee; } set { value = referee; } }
        public Referee Referee1 { get { return assistantReferee1; } set { value = assistantReferee1; } }
        public Referee Referee2 { get { return assistantReferee2; } set { value = assistantReferee2; } }

        public List<Goal> Goals { get { return goals; } set { value = goals; } }

        public GameResult Result { get { return result; } set { result = value; } }
        public Team Winner { get { return winner; } set { winner = value; } }

        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee1, Referee assistantReferee2, List<Goal> goals, GameResult result, Team winner)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Referee1 = assistantReferee1;
            Referee2 = assistantReferee2;
            Goals = goals;
            Result = result;
            Winner = winner;
        }
    }

    public enum GameResult
    {
        Team1, Draw, Team2
    }
}
