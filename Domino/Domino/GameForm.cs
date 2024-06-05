using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domino
{
    internal partial class GameForm : Form
    {
        private Game game;
        private Round round;
        private Move move;
        public GameForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        public void DrawDominoInGroupBox(Domino domino, GroupBox groupBox, int x, int y)
        {
            PictureBox pictureBox = new PictureBox();
            string img_path = domino.img_path;
            pictureBox.Image = Image.FromFile(img_path);
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(30, 60);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = domino;
            pictureBox.Click += new EventHandler(PictureBox_Click);
            groupBox.Controls.Add(pictureBox);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ShowGroupBoxes();
            GiveNamesToGroupBox();
            DrawAllDominos();
        }

        public void NewRound()
        {
            gameTablePanel.Controls.Clear();
            bazarGroupBox.Controls.Clear();
            foreach (var item in game.points)
            {
                string groupBoxName = "player" + item.Key.Name + "GroupBox";
                Control groupBoxControl = Controls[groupBoxName];
                groupBoxControl.Controls.Clear();
                ControlHelper.SetControlText(groupBoxControl, item.Key.Name + ", " + item.Value + " оч.");
            }
            DrawAllDominos();
            currentDominoPosition = new Point(10, 10);
            currentDirection = "horizontal";
        }

        public void ShowGroupBoxes()
        {
            foreach (var item in game.points)
            {
                int ind = game.Players.IndexOf(item.Key) + 1;
                string groupBoxName = "player" + ind + "GroupBox";
                Control groupBoxControl = Controls[groupBoxName];
                ControlHelper.SetControlText(groupBoxControl, item.Key.Name+", "+item.Value+" оч.");
                ControlHelper.SetControlVisibility(groupBoxControl, true);
            }
        }

        public void GiveNamesToGroupBox()
        {
            for (int i = 1; i < game.Players.Count + 1; i++)
            {
                string playerGroupBoxName = "player" + i + "GroupBox";
                GroupBox playerGroupBox = Controls[playerGroupBoxName] as GroupBox;
                playerGroupBox.Name = "player" + game.Players[i - 1].Name + "GroupBox";
                EnablePictureBoxesInGroupBox(playerGroupBox, false);
            }
        }

        public void DrawAllDominos()
        {
            foreach (Player player in game.currentRound.players)
            {
                GroupBox playerGroupBox = Controls["player" + player.Name + "GroupBox"] as GroupBox;
                if (playerGroupBox != null)
                {
                    playerGroupBox.Controls.Clear();
                    for (int j = 0; j < player.Dominos.Count; j++)
                    {
                        Domino domino = player.Dominos[j];
                        int x = j * 45;
                        int y = 20;
                        DrawDominoInGroupBox(domino, playerGroupBox, x, y);
                    }
                }
            }

            if (game.currentRound.dominos.Count > 0)
            {
                bazarGroupBox.Controls.Clear();
                for (int i = 0; i < game.currentRound.dominos.Count; i++)
                {
                    int x = (i % 4) * 50 + 10;
                    int y = (i / 4) * 70 + 20;
                    DrawDominoInGroupBox(game.currentRound.dominos[i], bazarGroupBox, x, y);
                }
                takeDominoButton.Visible = true;
                EnablePictureBoxesInGroupBox(bazarGroupBox, false);
            }
            else
            {
                bazarGroupBox.Controls.Clear();
            }
            game.currentRound.PlayRound(game, this);
        }

        private Point currentDominoPosition = new Point(10, 10);
        private string currentDirection = "horizontal";
        private void AddDominoToGameTablePanel(Domino domino, bool Rotate)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(domino.img_path);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = domino;

            if (currentDirection == "horizontal")
            {
                if (currentDominoPosition.X + pictureBox.Width > gameTablePanel.Width)
                {
                    currentDirection = "vertical";
                }
            }
            else if (currentDirection == "vertical")
            {
                if (currentDominoPosition.Y + pictureBox.Height > gameTablePanel.Height)
                {
                    currentDominoPosition.X -= pictureBox.Width-30;
                    currentDominoPosition.Y -= pictureBox.Height-20;
                    currentDirection = "left";
                }
            }
            else if (currentDirection == "left")
            {
                if (currentDominoPosition.X - pictureBox.Width < 0)
                {
                    currentDirection = "verticalUp";
                }
            }

            pictureBox.Location = currentDominoPosition;

            if (currentDirection == "horizontal")
            {
                pictureBox.Size = new Size(60, 30);
                currentDominoPosition.X += pictureBox.Width;
                if (Rotate) pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                else pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (currentDirection == "vertical")
            {
                pictureBox.Size = new Size(30, 60);
                currentDominoPosition.Y += pictureBox.Height;
                if (Rotate) pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (currentDirection == "left")
            {
                pictureBox.Size = new Size(60, 30);
                currentDominoPosition.X -= pictureBox.Width;
                if (Rotate) pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                else pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (currentDirection == "verticalUp")
            {
                pictureBox.Size = new Size(30, 60);
                currentDominoPosition.Y -= pictureBox.Height+25;
                if (Rotate) pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            gameTablePanel.Controls.Add(pictureBox);
        }

        public void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                Domino clickedDomino = clickedPictureBox.Tag as Domino;
                if (clickedDomino != null)
                {
                    Player currentPlayer = game.currentRound.GetCurrentPlayer();
                    Move move = new Move(currentPlayer, clickedDomino);
                    if (move.CanPlaceDomino(game.currentRound))
                    {
                        bool Rotate = move.DominoRotate(game.currentRound);
                        move.ChooseDomino(game.currentRound);
                        AddDominoToGameTablePanel(clickedDomino, Rotate);
                        DrawAllDominos();
                        move.EndPlayerTurn(game.currentRound, game, this);
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете выложить эту кость!");
                    }
                }
            }
        }

        public void GroupBoxEnabled(Player currentPlayer, bool Enable)
        {
            string currentGroupBoxName = "player" + currentPlayer.Name + "GroupBox";
            GroupBox currentGroupBox = Controls[currentGroupBoxName] as GroupBox;
            if (currentGroupBox != null)
            {
                currentGroupBox.Enabled = Enable;
                EnablePictureBoxesInGroupBox(currentGroupBox, Enable);
            }
        }
        public void EnablePictureBoxesInGroupBox(GroupBox groupBox, bool Enable)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Enabled = Enable;
                }
            }
        }

        private void takeDominoButton_Click(object sender, EventArgs e)
        {
            game.currentRound.GiveRandomDominoToCurrentPlayer();
            DrawAllDominos();
        }

        private void skipmoveButton_Click(object sender, EventArgs e)
        {
            game.currentRound.NextPlayer(this);
            game.currentRound.PlayRound(game, this);
        }
    }
}
