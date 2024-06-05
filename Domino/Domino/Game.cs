using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domino
{
    internal class Game
    {
        public List<Player> Players = new List<Player>();
        public Dictionary<Player, int> points = new Dictionary<Player, int>();
        public Round currentRound;
        public int Eggs = 0;
        public Game()
        {
            Players.Clear();
        }
        public void CreatePlayer(string name)
        {
            Player player = new Player(name);
            Players.Add(player);
        }
        public void NewGame()
        {
            foreach (Player player in Players)
            {
                points[player] = 0;
            }
        }
        public void NewRound()
        {
            currentRound = new Round(Players);
        }

        public void EndGame(Player loser, GameForm gameForm)
        {
            MessageBox.Show("Игра закончена! Проигравший игрок: "+loser.Name+" " + points[loser]+" очков.");
            gameForm.Close();
        }

    }
}
