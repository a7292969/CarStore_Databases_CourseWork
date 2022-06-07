using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Position
    {
        public int playerId;
        public Match match;
        public String position;

        public Position(int playerId, Match match, String position)
        {
            this.playerId = playerId;
            this.match= match;
            this.position = position;
        }

        public override string ToString()
        {
            return position + ": " + match.ToString();
        }
    }
}
