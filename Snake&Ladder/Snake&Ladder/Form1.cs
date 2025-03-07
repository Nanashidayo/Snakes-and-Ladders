using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Ladder
{
    public partial class twoPs : Form
    {
        //Initial values

        private Dictionary<int, Image> diceImages = new Dictionary<int, Image>();
        private Point[] Coords;
        private int TokenCords = 10;
        private int tileSize = 78;

        int p1_steps;
        int p2_steps;
        int player_turn = 1;
        private int lastRoll;

        private Timer moveTimer;
        private int movingPlayer;
        private int targetStep;
        private int currentStep;
        private bool gameWon = false;


        //the form itself, 1 reference because it can be called from form4
        public twoPs()
        {
            InitializeComponent();
            LoadDiceImages();

            moveTimer = new Timer();
            moveTimer.Interval = 100; // Adjust speed (lower = faster)
            moveTimer.Tick += MovePieceStep;
            picBoxT1.BackColor = Color.Transparent;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Coordinates();
            int who = Dice.One_Two();
            player_turn = who;
            lblTurn.Text = (who == 1) ? "Momoi" : "Midori";

            picBoxChar1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");
            picBoxChar2.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\midori.gif");
            

            picBoxT1.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\momoi.gif");
            picBoxT2.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\midori.gif");
            
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
            lastRoll = Dice.Dice_Outcome();

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
                player_turn = 2;
            }
            else
            {
                p2_steps += lastRoll;
                p2_steps = Math.Min(p2_steps, 100);
                Move(2);
                Move_Player(2);
                Check_Winner();
                player_turn = 1;
            }

            lblTurn.Text = (player_turn == 1) ? "Momoi" : "Midori";
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
            else
            {
                currentStep = p2_steps - lastRoll;
                targetStep = p2_steps;
            }

            currentStep = Math.Max(currentStep, 0); 
            moveTimer.Start();
        }

        //for moving pieces per tile... also disables after game
        private void MovePieceStep(object sender, EventArgs e)
        {
            if (currentStep < targetStep) 
            {
                currentStep++;

                if (movingPlayer == 1)
                    picBoxT1.Location = Coords[Math.Max(0, currentStep - 1)];
                else
                    picBoxT2.Location = Coords[Math.Max(0, currentStep - 1)];
            }
            else
            {
                moveTimer.Stop();
                Check_Winner();

                if (!gameWon) 
                {
                    btnRoll.Enabled = true;
                }

                player_turn = (movingPlayer == 1) ? 2 : 1;
                lblTurn.Text = (player_turn == 1) ? "Momoi" : "Midori";
            }
        }



        //for ladders and snake... for ladders, token's current position plus tiles to between starting point and landing point, and for snakes, token's current position mius tiles to between starting point and landing point 
        private void Move(int player)
        {
            int oldPos = (player == 1) ? p1_steps : p2_steps;

            if (player == 1)
            {
                switch (p1_steps)
                {
                    case 4: p1_steps += 10; break;//
                    case 9: p1_steps += 22; break;//
                    case 21: p1_steps += 21; break;//
                    case 28: p1_steps += 56; break;//
                    case 36: p1_steps += 8; break;//
                    case 51: p1_steps += 16; break;//
                    case 71: p1_steps += 20; break;//

                    case 16: p1_steps -= 10; break;//
                    case 56: p1_steps -= 3; break;//
                    case 62: p1_steps -= 43; break;//
                    case 87: p1_steps -= 64; break;//
                    case 93: p1_steps -= 20; break;//
                    case 98: p1_steps -= 20; break;//
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

            //  use for smooth animation on ladders/snakes
            if ((player == 1 && p1_steps != oldPos) || (player == 2 && p2_steps != oldPos))
            {
                Move_Straight_Line(player, oldPos, (player == 1) ? p1_steps : p2_steps);
            }
        }

        // for the said anination in ladders and snakes
        private void Move_Straight_Line(int player, int from, int to)
        {
            Point start = Coords[Math.Max(0, from - 1)];
            Point end = Coords[Math.Max(0, to - 1)];

            int steps = 20; // Number of animation frames
            int dx = (end.X - start.X) / steps;
            int dy = (end.Y - start.Y) / steps;

            int stepCounter = 0;

            Timer straightMoveTimer = new Timer();
            straightMoveTimer.Interval = 50; // Adjust animation speed
            straightMoveTimer.Tick += (sender, e) =>
            {
                if (stepCounter < steps)
                {
                    Point newPos = new Point(start.X + dx * stepCounter, start.Y + dy * stepCounter);

                    if (player == 1)
                        picBoxT1.Location = newPos;
                    else
                        picBoxT2.Location = newPos;

                    stepCounter++;
                }
                else
                {
                    straightMoveTimer.Stop();
                    if (player == 1)
                        picBoxT1.Location = end;
                    else
                        picBoxT2.Location = end;
                }
            };

            straightMoveTimer.Start();
        }

        // fow checking winners
        private void Check_Winner()
        {
            if (gameWon) return;

            if (p1_steps == 100)
            {
                gameWon = true;
                MessageBox.Show("Momoi Wins!");
                btnRoll.Enabled = false; // Disable dice rolling
                Intro intro = new Intro();
                this.Hide();
                intro.ShowDialog();
            }
            else if (p2_steps == 100)
            {
                gameWon = true;
                MessageBox.Show("Midori Wins!");
                btnRoll.Enabled = false; // Disable dice rolling
                Intro intro = new Intro();
                this.Hide();
                intro.ShowDialog();
            }
        }


        // for dice rolls
        public static class Dice
        {
            private static Random random = new Random();
            public static int One_Two()
            {
                return random.Next(1, 3);
            }

            public static int Dice_Outcome()
            {
                return random.Next(1, 7);
            }
        }

        //exit to intro page
        private void exit_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }

        //to start rolling the dice
        private void btnRoll_Click(object sender, EventArgs e)
        {

            if (gameWon) return;
            Main_Function(player_turn);
        

        }

        /////////////////////accidents happen

        private void pictureBox3_Click(object sender, EventArgs e) 
        { }
        private void label1_Click(object sender, EventArgs e) 
        { }
        private void pictureBox2_Click(object sender, EventArgs e) 
        { }

        private void picBoxT2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
