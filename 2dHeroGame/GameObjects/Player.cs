using System.Collections.Generic;

namespace _2dHeroGame
{
    public class Player
    {
        public int Health { get; set; }
        public int Weapon { get; set; }

        public List<IKey> Keys { get; set; }
        public Player()
        {
            Keys = new List<IKey>();
            Health = 100;
            Weapon = 100; 
        }
    }


}
