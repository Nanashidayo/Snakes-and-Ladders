using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Snake_Ladder.twoPs;

namespace Snake_Ladder
{
    public partial class FourPs : Form
    {
        // initial variables
        private Dictionary<int, Image> diceImages = new Dictionary<int, Image>();
        private Point[] Coords;
        private int TokenCords = 10;
        private int tileSize = 78;

        int p1_steps, p2_steps, p3_steps, p4_steps;
        int player_turn = 1;
        private int lastRoll;

        private Timer moveTimer;
        private int movingPlayer;
        private int targetStep;
        private int currentStep;
        private bool gameWon = false;

        //the form itself, 1 reference because it can be called from form4
        public FourPs()
        {
            InitializeComponent();
            LoadDiceImages();

            moveTimer = new Timer();
            moveTimer.Interval = 100;
            moveTimer.Tick += MovePieceStep;
        }

        //to load dice images
        private void LoadDiceImages()
        {
            for (int i = 1; i <= 6; i++)
            {
                diceImages[i] = Image.FromFile($"C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\{i}.png");
            }
        }

        //Stuffs to display once the form loads
        private void Form2_Load_1(object sender, EventArgs e)
        {
            Coordinates();
            int who = Dice.One_Four();
            player_turn = who;
            lblTurn.Text = (who == 1) ? "Momoi" :
                           (who == 2) ? "Midori" :
                           (who == 3) ? "Arisu" : "Yuzu";

            picBoxChar1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");
            picBoxChar2.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\midori.gif");
            picBoxChar3.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\arisu.gif");
            picBoxChar4.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\yuzu.gif");

            picBoxT1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");
            picBoxT2.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\midori.gif");
            picBoxT3.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\arisu.gif");
            picBoxT4.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\yuzu.gif");
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
                player_turn = (player % 4) + 1;
            }
            else if (player == 2)
            {
                p2_steps += lastRoll;
                p2_steps = Math.Min(p2_steps, 100);
                Move(2);
                Move_Player(2);
                Check_Winner();
                player_turn = (player % 4) + 1;
            }

            else if (player == 3)
            {
                p3_steps += lastRoll;
                p3_steps = Math.Min(p3_steps, 100);
                Move(3);
                Move_Player(3);
                Check_Winner();
                player_turn = (player % 4) + 1;
            }

            else if (player == 4)
            {
                p4_steps += lastRoll;
                p4_steps = Math.Min(p4_steps, 100);
                Move(4);
                Move_Player(4);
                Check_Winner();
                player_turn = (player % 4) + 1;
            }

            lblTurn.Text = (player_turn == 1) ? "Momoi" :
                           (player_turn == 2) ? "Midori.AI" :
                           (player_turn == 3) ? "Arisu.AI" : "Yuzu.AI";
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
            else if (player == 4)
            {
                currentStep = p4_steps - lastRoll;
                targetStep = p4_steps;
            }

            currentStep = Math.Max(currentStep, 0);
            moveTimer.Start();
        }

        //for moving pieces per tile... also disables after game
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
                else if (movingPlayer == 4)
                    picBoxT4.Location = Coords[Math.Max(0, currentStep - 1)];
            }
            else
            {
                moveTimer.Stop();
                Check_Winner();

                if (!gameWon) // Only enable the button if the game isn't over
                {
                    btnRoll.Enabled = true;
                }

                player_turn = (movingPlayer % 4) + 1;
                lblTurn.Text = (player_turn == 1) ? "Momoi" :
                               (player_turn == 2) ? "Midori" :
                               (player_turn == 3) ? "Arisu" : "Yuzu";

            }
        }

        //for ladders and snake... for ladders, token's current position plus tiles to between starting point and landing point, and for snakes, token's current position mius tiles to between starting point and landing point 

        private void Move(int player)
        {
            int oldPos = (player == 1) ? p1_steps :
                         (player == 2) ? p2_steps :
                         (player == 3) ? p3_steps : p4_steps;

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
            else if (player == 4)
            {
                switch (p4_steps)
                {
                    case 4: p4_steps += 10; break;
                    case 9: p4_steps += 22; break;
                    case 21: p4_steps += 21; break;
                    case 28: p4_steps += 56; break;
                    case 36: p4_steps += 8; break;
                    case 51: p4_steps += 16; break;
                    case 71: p4_steps += 20; break;
                    case 16: p4_steps -= 10; break;
                    case 56: p4_steps -= 3; break;
                    case 62: p4_steps -= 43; break;
                    case 87: p1_steps -= 64; break;
                    case 93: p4_steps -= 20; break;
                    case 98: p4_steps -= 20; break;
                }
            }

            if ((player == 1 && p1_steps != oldPos) ||
                (player == 2 && p2_steps != oldPos) ||
                (player == 3 && p3_steps != oldPos) ||
                (player == 4 && p4_steps != oldPos))
            {
                Move_Straight_Line(player, oldPos,
                    (player == 1) ? p1_steps :
                    (player == 2) ? p2_steps :
                    (player == 3) ? p3_steps : p4_steps);
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
            moveTimer.Stop(); // Ensure no overlapping timers

            straightMoveTimer.Tick += (sender, e) =>
            {
                if (stepCounter < steps)
                {
                    Point newPos = new Point(start.X + dx * stepCounter, start.Y + dy * stepCounter);

                    PictureBox movingToken = (player == 1) ? picBoxT1 :
                                             (player == 2) ? picBoxT2 :
                                             (player == 3) ? picBoxT3 : picBoxT4;

                    movingToken.Location = newPos;
                    movingToken.BringToFront(); //  Ensure the moving token is always on top

                    stepCounter++;
                }
                else
                {
                    straightMoveTimer.Stop();

                    PictureBox finalToken = (player == 1) ? picBoxT1 :
                                            (player == 2) ? picBoxT2 :
                                            (player == 3) ? picBoxT3 : picBoxT4;

                    finalToken.Location = end;
                    finalToken.BringToFront(); //  Ensure it remains on top at the end
                }
            };

            straightMoveTimer.Start();
        }

        //For checking the winner
        private void Check_Winner()
        {
            if (gameWon) return;
            if (p1_steps == 100) DeclareWinner("Momoi");
            else if (p2_steps == 100) DeclareWinner("Midori");
            else if (p3_steps == 100) DeclareWinner("Arisu");
            else if (p4_steps == 100) DeclareWinner("Yuzu");

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


        //for dice roll
        public static class Dice
        {
            private static Random random = new Random();
            public static int One_Four() => random.Next(1, 5);
            public static int Dice_Outcome() => random.Next(1, 7);
        }

        //to initiate rolling of dice
        private void btnRoll_Click_1(object sender, EventArgs e)
        {
            if (!gameWon) Main_Function(player_turn);
        }

        //exiting to intro page
        private void exit_Click_1(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }


        //acidents//
        private void lblName3_Click(object sender, EventArgs e){}

        private void pictureBox3_Click(object sender, EventArgs e){}

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblName2_Click(object sender, EventArgs e){}

        private void lblName1_Click(object sender, EventArgs e){}

        private void pictureBox6_Click(object sender, EventArgs e){}
    }
}
