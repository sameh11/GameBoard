//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace _2dHeroGame
{
    public class GameDirectorBuilder
    {
        public GameDirector GameDirector { get; set; }

        public GameDirectorBuilder()
        {
            GameDirector = new GameDirector();
        }

        public GameDirectorBuilder(GameDirector gameDirector)
        {
            GameDirector = gameDirector;
        }

        public BoardBuilder newBoard()
        {
            return new BoardBuilder(GameDirector);
        }


    }


}
