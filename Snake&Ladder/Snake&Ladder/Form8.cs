﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Ladder
{
    public partial class AI3Ps : Form
    {
        // initial variables
        private Dictionary<int, Image> diceImages = new Dictionary<int, Image>();
        private Point[] Coords;
        private int TokenCords = 10;
        private int tileSize = 78;

        int p1_steps, p2_steps, p3_steps;
        int player_turn = 1;
        private int lastRoll;

        private Timer aiTurnTimer;
        private Timer moveTimer;
        private int movingPlayer;
        private int targetStep;
        private int currentStep;
        private bool gameWon = false;

        //the initializer of everything ones the form loads, 1 reference because it can be called from form4
        public AI3Ps()
        {
            InitializeComponent();
            LoadDiceImages();

            moveTimer = new Timer();
            moveTimer.Interval = 100;
            moveTimer.Tick += MovePieceStep;
        }

        //Stuffs to display once the form loads, it sets the board to its starting positions
        private void Form8_Load(object sender, EventArgs e)
        {
            Coordinates();
            player_turn = Dice.One_Three();

            lblTurn.Text = (player_turn == 1) ? "Momoi" :
                           (player_turn == 2) ? "Midori.AI" : "Arisu.AI";

            picBoxChar1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");

            picBoxT1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");

            if (player_turn != 1)
            {
                AI_Turn();
            }
            else
            {
                btnRoll.Enabled = true; 
            }
        }

        //to load dice images
        private void LoadDiceImages()
        {
            for (int i = 1; i <= 6; i++)
            {
                diceImages[i] = Image.FromFile($"C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\{i}.png");
            }
        }



        //Placements of pieces or tokens on the board
        private void Coordinates()
        {
            Coords = new Point[TokenCords * TokenCords];
            int pieceWidth = 60;
            int pieceHeight = 1;

            for (int row = 0; row < TokenCords; row++)
            {
                for (int col = 0; col < TokenCords; col++)
                {
                    int x = (row % 2 == 0) ? col * tileSize : (TokenCords - 1 - col) * tileSize;
                    int y = (TokenCords - 1 - row) * tileSize;
                    int tileNumber = row * TokenCords + col;
                    int centerX = x + (tileSize - pieceWidth) / 2;
                    int centerY = y + (tileSize - pieceHeight) / 2;
                    Coords[tileNumber] = new Point(centerX, centerY);
                }
            }
        }

        //main game logic... where each steps is calculated
        private void Main_Function(int player)
        {
            lastRoll = Dice.Dice_Outcome(); // Store the dice roll

            if (diceImages.ContainsKey(lastRoll))
            {
                picBoxDie.Image = diceImages[lastRoll];
            }

            if (player == 1)
            {
                p1_steps += lastRoll;
                p1_steps = Math.Min(p1_steps, 100);
                Move(1);
                Move_Player(1);
                Check_Winner();
                player_turn = (player % 3) + 1;
            }
            else if (player == 2)
            {
                p2_steps += lastRoll;
                p2_steps = Math.Min(p2_steps, 100);
                Move(2);
                Move_Player(2);
                Check_Winner();
                player_turn = (player % 3) + 1;
            }

            else if (player == 3)
            {
                p3_steps += lastRoll;
                p3_steps = Math.Min(p3_steps, 100);
                Move(3);
                Move_Player(3);
                Check_Winner();
                player_turn = (player % 3) + 1;
            }

            lblTurn.Text = (player_turn == 1) ? "Momoi" :
                           (player_turn == 2) ? "Midori.AI" : "Arisu.AI";
        }

        //for animation when moving and disabling the button "roll" when a token is moving... this also prevents out of bounds
        private void Move_Player(int player)
        {
            btnRoll.Enabled = false;

            movingPlayer = player;

            if (player == 1)
            {
                currentStep = p1_steps - lastRoll;
                targetStep = p1_steps;
            }
            else if (player == 2)
            {
                currentStep = p2_steps - lastRoll;
                targetStep = p2_steps;
            }
            else if (player == 3)
            {
                currentStep = p3_steps - lastRoll;
                targetStep = p3_steps;
            }
            currentStep = Math.Max(currentStep, 0);
            moveTimer.Start();
        }

        //for moving pieces per tile... also disables roll button after game
        private void MovePieceStep(object sender, EventArgs e)
        {
            if (currentStep < targetStep) // Moving forward
            {
                currentStep++;

                if (movingPlayer == 1)
                    picBoxT1.Location = Coords[Math.Max(0, currentStep - 1)];
                else if (movingPlayer == 2)
                    picBoxT2.Location = Coords[Math.Max(0, currentStep - 1)];
                else if (movingPlayer == 3)
                    picBoxT3.Location = Coords[Math.Max(0, currentStep - 1)];
            }
            else
            {
                moveTimer.Stop();
                Check_Winner();

                if (!gameWon && player_turn == 1)
                {
                    btnRoll.Enabled = true; // Enable roll for player when it's their turn
                }

            }
        }

        //for ladders and snake... for ladders, token's current position plus tiles to between starting point and landing point, and for snakes, token's current position mius tiles to between starting point and landing point 

        private void Move(int player)
        {
            int oldPos = (player == 1) ? p1_steps :
                         (player == 2) ? p2_steps : p3_steps;

            if (player == 1)
            {
                switch (p1_steps)
                {
                    case 4: p1_steps += 10; break;
                    case 9: p1_steps += 22; break;
                    case 21: p1_steps += 21; break;
                    case 28: p1_steps += 56; break;
                    case 36: p1_steps += 8; break;
                    case 51: p1_steps += 16; break;
                    case 71: p1_steps += 20; break;
                    case 16: p1_steps -= 10; break;
                    case 56: p1_steps -= 3; break;
                    case 62: p1_steps -= 43; break;
                    case 87: p1_steps -= 64; break;
                    case 93: p1_steps -= 20; break;
                    case 98: p1_steps -= 20; break;
                }
            }
            else if (player == 2)
            {
                switch (p2_steps)
                {
                    case 4: p2_steps += 10; break;
                    case 9: p2_steps += 22; break;
                    case 21: p2_steps += 21; break;
                    case 28: p2_steps += 56; break;
                    case 36: p2_steps += 8; break;
                    case 51: p2_steps += 16; break;
                    case 71: p2_steps += 20; break;
                    case 16: p2_steps -= 10; break;
                    case 56: p2_steps -= 3; break;
                    case 62: p2_steps -= 43; break;
                    case 87: p1_steps -= 64; break;
                    case 93: p2_steps -= 20; break;
                    case 98: p2_steps -= 20; break;
                }
            }
            else if (player == 3)
            {
                switch (p3_steps)
                {
                    case 4: p3_steps += 10; break;
                    case 9: p3_steps += 22; break;
                    case 21: p3_steps += 21; break;
                    case 28: p3_steps += 56; break;
                    case 36: p3_steps += 8; break;
                    case 51: p3_steps += 16; break;
                    case 71: p3_steps += 20; break;
                    case 16: p3_steps -= 10; break;
                    case 56: p3_steps -= 3; break;
                    case 62: p3_steps -= 43; break;
                    case 87: p1_steps -= 64; break;
                    case 93: p3_steps -= 20; break;
                    case 98: p3_steps -= 20; break;
                }
            }

            if ((player == 1 && p1_steps != oldPos) ||
                (player == 2 && p2_steps != oldPos) ||
                (player == 3 && p3_steps != oldPos))
            {
                Move_Straight_Line(player, oldPos,
                    (player == 1) ? p1_steps :
                    (player == 2) ? p2_steps : p3_steps);
            }

        }

        // for the said anination in ladders and snakes
        private void Move_Straight_Line(int player, int from, int to)
        {
            Point start = Coords[Math.Max(0, from - 1)];
            Point end = Coords[Math.Max(0, to - 1)];

            int steps = Math.Max(10, Math.Abs(end.X - start.X) / 10);
            int dx = (end.X - start.X) / steps;
            int dy = (end.Y - start.Y) / steps;

            int stepCounter = 0;

            Timer straightMoveTimer = new Timer();
            straightMoveTimer.Interval = 50;
            moveTimer.Stop();

            straightMoveTimer.Tick += (sender, e) =>
            {
                if (stepCounter < steps)
                {
                    Point newPos = new Point(start.X + dx * stepCounter, start.Y + dy * stepCounter);

                    PictureBox movingToken = (player == 1) ? picBoxT1 :
                                             (player == 2) ? picBoxT2 : picBoxT3;

                    movingToken.Location = newPos;
                    movingToken.BringToFront();

                    stepCounter++;
                }
                else
                {
                    straightMoveTimer.Stop();

                    PictureBox finalToken = (player == 1) ? picBoxT1 :
                                            (player == 2) ? picBoxT2 : picBoxT3;

                    finalToken.Location = end;
                    finalToken.BringToFront();
                }
            };

            straightMoveTimer.Start();
        }

        //For checking the winner
        private void Check_Winner()
        {
            if (gameWon) return;
            if (p1_steps == 100) DeclareWinner("Momoi");
            else if (p2_steps == 100) DeclareWinner("Midori.AI");
            else if (p3_steps == 100) DeclareWinner("Arisu.AI");

        }

        //declares the winner
        private void DeclareWinner(string playerName)
        {
            gameWon = true;
            MessageBox.Show($"{playerName} Wins!");
            btnRoll.Enabled = false;
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }

        

        //for dice roll, one for who comes first, the other is for moving
        public static class Dice
        {
            private static Random random = new Random();
            public static int One_Three() => random.Next(1, 2);
            public static int Dice_Outcome() => random.Next(1, 7);
        }

        //exiting to intro page
        private void exit_Click_1(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }

        //to initiate rolling of dice
        private void btnRoll_Click_1(object sender, EventArgs e)
        {
            if (!gameWon && player_turn == 1) // Only allow Player 1 (Momoi) to roll
            {
                Main_Function(player_turn);

                if (!gameWon)
                {
                    if (player_turn != 1) // If it's an AI's turn, let AI roll automatically
                    {
                        Task.Delay(1000).ContinueWith(t => Invoke(new Action(AI_Turn)));
                    }
                    else
                    {
                        btnRoll.Enabled = true; // Enable button for player if it's their turn
                    }
                }
            }
        }

        //Manages AI player turns
        private async void AI_Turn()
        {
            if (!gameWon && player_turn != 1)
            {
                btnRoll.Enabled = false;
                await Task.Delay(500);

                Main_Function(player_turn);

                if (!gameWon)
                {
                    if (player_turn == 1)
                    {
                        btnRoll.Enabled = true;
                    }
                    else
                    {
                        await Task.Delay(1000).ContinueWith(t => Invoke(new Action(AI_Turn)));
                    }
                }
            }
        }


    }
}



