using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Fighter
    {
        public static int Lung(Whale user, Whale target)
        {
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        }
        public static int Execute(Whale user, Whale target)
        {
            double percent = (target.Health / 10);
            if (percent == 0.4) { target.Health -= target.Health; return target.Health; }
            else { target.Health -= (user.Offense + 1); return target.Health;  }
        }
    }
}
