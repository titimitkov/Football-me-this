using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Goal
    {
        int minute;
        FootballPlayer player;

        public int Minute { get { return minute; } set { value = minute; } }
        public FootballPlayer Player { get { return player; } set { value = Player; } }

        public Goal(int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
