using System;

namespace _2dHeroGame
{
    public interface IAction
    {
        void Act(Player player, IOcupant ocupant);
    }
    public class EmptyAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is null )
                return;
            else
                throw new Exception("Not Treasure Object");
        }
    }
    public class BoxAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Treasure)
                ocupant.EditPlayer(player);
            else
                throw new Exception("Not Treasure Object");
        }
    }
    public class EnemyAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Enemy)
                ocupant.EditPlayer(player);
            else
                throw new Exception("Not Enemy Object");
        }
    }
    public class KeyAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Enemy)
                ocupant.EditPlayer(player);
            else
                throw new Exception("Not Key Object");
        }
    }

    public class ActionContext
    {
        private IAction Action;
        // The user will set the PaymentStrategy by 
        // calling this method at runtime
        public void SetAction(IAction action)
        {
            this.Action = action;
        }
        public void DoAction(Player player, IOcupant ocupant)
        {
            Action.Act(player, ocupant);
        }
    }

}
