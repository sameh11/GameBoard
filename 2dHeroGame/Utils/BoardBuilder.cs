//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace _2dHeroGame
{
    public class BoardBuilder : GameDirectorBuilder
    {
        public BoardBuilder(GameDirector gameDirector) : base(gameDirector){}

        public BoardBuilder AddCellToBoard(Cell[,] cells)
        {
            GameDirector.Board.Cells = cells;
            return this;
        }
        public BoardBuilder AddPlayerToBoard(Player player)
        {
            GameDirector.Board.Player = player;
            return this;
        }
    }


}
