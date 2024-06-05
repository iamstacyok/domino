using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domino
{
    internal class Round
    {
        public List<Player> players;
        public Dictionary<Player, int> points = new Dictionary<Player, int>();
        public List<Domino> dominos = new List<Domino>();
        public List<Domino> dominosOnTable = new List<Domino>();
        public int currentPlayerIndex;

        public Round(List<Player> Players)
        {
            players = Players;
            points.Clear();
            dominos.Clear();
            dominosOnTable.Clear();

            GenerateDominos();
            GiveDominos();
            PlayersOrder();
        }

        public void GenerateDominos()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    Domino domino = new Domino(i, j);
                    dominos.Add(domino);
                }
            }
        }

        public void GiveDominos()
        {
            foreach (var player in players)
            {
                player.Dominos.Clear();
                Random random = new Random();
                for (int i = 0; i < 7; i++)
                {
                    int index = random.Next(dominos.Count);
                    player.Dominos.Add(dominos[index]);
                    dominos.RemoveAt(index);
                }
            }
        }

        public void GiveRandomDominoToCurrentPlayer()
        {
            if (dominos.Count == 0)
            {
                MessageBox.Show("Свободные домино закончились");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(dominos.Count);
            Domino randomDomino = dominos[randomIndex];
            Player currentPlayer = GetCurrentPlayer();
           
            dominos.RemoveAt(randomIndex);

            currentPlayer.Dominos.Add(randomDomino);
        }

        public Player FirstMove(List<Player> players)
        {
            Player playerWithOneOne = players.FirstOrDefault(player => player.Dominos.Any(d => d.leftSide == 1 && d.rightSide == 1));

            if (playerWithOneOne != null)
            {
                return playerWithOneOne;
            }

            Player playerWithSmallestDouble = null;
            Domino smallestDouble = null;

            foreach (var player in players)
            {
                foreach (var domino in player.Dominos)
                {
                    if (domino.leftSide == domino.rightSide)
                    {
                        if (smallestDouble == null || domino.leftSide < smallestDouble.leftSide)
                        {
                            smallestDouble = domino;
                            playerWithSmallestDouble = player;
                        }
                    }
                }
            }
            return playerWithSmallestDouble;
        }
        public Player GetCurrentPlayer()
        {
            return players[currentPlayerIndex];
        }
        public void NextPlayer(GameForm gameForm)
        {
            Player currentPlayer = GetCurrentPlayer();
            gameForm.GroupBoxEnabled(currentPlayer, false);
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }

        public void PlayersOrder()
        {
            Player firstPlayer = FirstMove(players);
            currentPlayerIndex = players.IndexOf(firstPlayer);
        }
        public void PlayRound(Game game, GameForm gameForm)
        {
            if (IsNotFishSituation())
            {
                Player currentPlayer = GetCurrentPlayer();
                gameForm.label1.Text = currentPlayer.Name;
                gameForm.GroupBoxEnabled(currentPlayer, true);
            }
            else
            {
                EndRound(game, gameForm);
                game.Eggs = GetEggs();
            }
        }

        public void EndRound(Game game, GameForm gameForm)
        {
            foreach (var player in players)
            {
                int round_points = 0;
                foreach (var domino in player.Dominos)
                {
                    round_points += domino.leftSide + domino.rightSide;
                }
                if (points.ContainsKey(player))
                {
                    points[player] += round_points;
                }
                else
                {
                    points[player] = round_points;
                }
                if (player != GetCurrentPlayer())
                {
                    points[player] += game.Eggs;
                    game.Eggs = 0;
                }
            }
            foreach (var player in players)
            {
                game.points[player] += points[player];
            }

            bool gameEnded = false;
            Player loser = players[0];
            foreach (var item in game.points)
            {
                if (item.Value >= 125)
                {
                    gameEnded = true;
                    loser = item.Key as Player;
                    break;
                }
            }

            if (gameEnded)
            {
                game.EndGame(loser, gameForm);
            }
            else
            {
                MessageBox.Show("Следующий раунд!");
                game.NewRound();
                gameForm.NewRound();
            }
        }

        public bool IsNotFishSituation()
        {
            if (dominosOnTable.Count == 0)
            {
                return true;
            }

            Domino lastDomino = dominosOnTable.Last();
            foreach (var player in players)
            {
                foreach(var domino in player.Dominos)
                {
                    if (domino.leftSide == lastDomino.rightSide || domino.rightSide == lastDomino.rightSide)
                    {
                        return true;
                    }
                }
            }
            foreach (var domino in dominos)
            {
                if (domino.leftSide == lastDomino.rightSide || domino.rightSide == lastDomino.rightSide)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetEggs()
        {
            bool flag;
            if (points == null || points.Count == 0)
            {
                flag = true;
            }
            var uniqueValues = points.Values.Distinct().ToList();

            flag = uniqueValues.Count == 1;

            if (flag)
            {
                return uniqueValues[0];
            }
            else return 0;
        }
    }
}
