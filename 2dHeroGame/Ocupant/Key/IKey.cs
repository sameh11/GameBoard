namespace _2dHeroGame
{
    public interface IKey
    {

    }

    public class SilverKey : IKey, IOcupant
    {

        public void EditPlayer(Player player)
        {
            player.Keys.Add(this); 
        }
    }

    public class GoldKey : IKey, IOcupant
    {
        public void EditPlayer(Player player)
        {
            player.Keys.Add(this);
        }
    }

    public class BronzKey : IKey, IOcupant
    {
        public void EditPlayer(Player player)
        {
            player.Keys.Add(this);
        }
    }
}