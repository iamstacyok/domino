using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    internal class Move
    {
        public Player player;
        public Domino domino;

        public Move(Player Player, Domino Domino)
        {
            player = Player;
            domino = Domino;
        }

        public void ChooseDomino(Round round)
        {
            player.Dominos.Remove(domino);
            round.dominosOnTable.Add(domino);      
        }
        public bool CanPlaceDomino(Round round)
        {
            if (round.dominosOnTable.Count == 0)
            {
                return true;
            }

            Domino lastDomino = round.dominosOnTable.Last();
            return domino.leftSide == lastDomino.rightSide || domino.rightSide == lastDomino.rightSide;

        }

        public bool DominoRotate(Round round)
        {
            if (round.dominosOnTable.Count == 0 ) return false;

            Domino lastDomino = round.dominosOnTable.Last();
            if (domino.rightSide == lastDomino.rightSide) 
            {
                domino.Flip();
                return true;
            }
            return domino.leftSide != lastDomino.rightSide;
        }

        public void EndPlayerTurn(Round round, Game game, GameForm gameForm)
        {
            if (player.Dominos.Count == 0)
            {
                round.EndRound(game, gameForm);
                player = null;
                domino = null;
            }
            else
            {
                round.NextPlayer(gameForm);
                round.PlayRound(game, gameForm);
            }
        }
    }
}
