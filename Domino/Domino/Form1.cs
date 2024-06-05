using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Domino
{
    internal partial class StartForm : Form
    {
        private Game game;
        public StartForm(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text != "")
            {
                if(game.Players.Count < 4)
                {
                    var i = game.Players.Count+1;
                    string playerTextBoxName = "player"+i.ToString()+"Textbox";
                    string labelName = "player"+i.ToString()+"Label";

                    string name = nameTextBox.Text.ToString();
                    game.CreatePlayer(name);

                    nameTextBox.Text = "";

                    Control textBoxControl = Controls[playerTextBoxName];
                    Control labelControl = Controls[playerTextBoxName];

                    ControlHelper.SetControlText(textBoxControl, name);
                    ControlHelper.SetControlVisibility(labelControl, true);
                }
                else
                {
                    MessageBox.Show("Максимум игроков: 4");
                }
            }
            else
            {
                MessageBox.Show("Введите имя игрока!");
            }
            if (game.Players.Count > 1) startGameButton.Enabled = true;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            game.NewGame();
            game.NewRound();
            GameForm gameForm = new GameForm(game);
            gameForm.ShowDialog();
        }
    }
}
