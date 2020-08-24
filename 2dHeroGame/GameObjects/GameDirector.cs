namespace _2dHeroGame
{
    public class GameDirector
    {
        public Board Board { get; set; }
        public ActionContext ActionContext { get; set; }
        public Cell CurrentCell { get; set; }
        public Cell NewCell { get; set; }

        public GameDirector()
        {

        }
        public GameDirector(Board board)
        {
            Board = board;
        }

        public Cell MovePlayer(Player player, Cell nextCell)
        {
            //check new cell 1 step away 
            NewCell = nextCell;
            return NewCell;
        }

        public ActionContext FindAction(Player player, Cell currentCell)
        {
            if (currentCell == null)
                return null;
            if (currentCell._ocupant is Enemy)
                ActionContext.SetAction(new EnemyAction());
            if (currentCell._ocupant is IKey)
                ActionContext.SetAction(new KeyAction());
            if (currentCell._ocupant is Treasure)
                ActionContext.SetAction(new BoxAction());

            return ActionContext;
        }

        public void MakeAction(Player player, Cell currentCell)
        {
            ActionContext.DoAction(player, currentCell._ocupant);
        }


    }
}
