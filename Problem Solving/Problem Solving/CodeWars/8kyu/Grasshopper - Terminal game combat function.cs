using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Grasshopper___Terminal_game_combat_function
    {
        public static float Combat(float health, float damage) => ((health - damage) > 0) ? health - damage : 0;    
    }
}
