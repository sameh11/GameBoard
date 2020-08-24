namespace _2dHeroGame
{
    public class Board
    {
        
        public Cell[,] Cells { get; set; }
        public Player Player { get; set; }
        public Board()
        {
            Cells = new Cell[,] { };
            Player = new Player();
        }
        public Board(Cell[,] cells)
        {
            Cells = cells;
            Player = new Player();
        }
    }

    /// <summary>
    /// Abstract Strategy 
    /// </summary>
   

}
