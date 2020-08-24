namespace _2dHeroGame
{
    public class Cell
    {

        public IOcupant _ocupant { get; set; }
        public Player Player { get; set; }
        public Cell()
        {
            Player = null;
            //_ocupant = ocupant;
        }
        public Cell(IOcupant ocupant)
        {
            Player = null;
            _ocupant = ocupant;
        }
        public bool HasPlayer()
        {
            return Player != null ? true: false; 
        }

    }

    /// <summary>
    /// Abstract Strategy 
    /// </summary>
   

}
