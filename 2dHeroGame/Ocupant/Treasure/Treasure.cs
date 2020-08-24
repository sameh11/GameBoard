namespace _2dHeroGame
{
    abstract class Treasure : IOcupant
    {
        public abstract void EditPlayer(Player player);
    }

    class GoldBox : Treasure
    {
        public IKey key = new GoldKey();
        public int Health = 50;
        public int Weapon = 10;

        public override void EditPlayer(Player player)
        {
            Health+= player.Health; 
        }

    }
    class SilverBox : Treasure
    {
        public IKey key = new SilverKey();
        public int Health = 10;
        public int Weapon = 40;
        public override void EditPlayer(Player player)
        {
            Health += player.Health;
            Weapon += player.Weapon;
        }
    }
    class BronzeBox : Treasure
    {
        public IKey key = new BronzKey();
        public int Health = 20;
        public override void EditPlayer(Player player)
        {
            Health += player.Health;
        }
    }
}
