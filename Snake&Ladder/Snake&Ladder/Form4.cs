using System;
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
    public partial class chooseGame : Form
    {

        public chooseGame()
        {
            InitializeComponent();
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            picBoxBG.Image = Image.FromFile("C:\\Code\\Snake&Ladder\\Snake&Ladder\\meeps\\bgbg.gif");
        }

        //exiting to intro page
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            this.Hide();
            intro.ShowDialog();
        }

        //to go to a game mode for 2 Players
        private void Game2P_Click(object sender, EventArgs e)
        {
            twoPs twoPs = new twoPs();
            this.Hide();
            twoPs.ShowDialog();

        } 
        
        //go to a game mode for 3 Players
        private void Game3P_Click(object sender, EventArgs e)
        {
            threePs threePs = new threePs();
            this.Hide();
            threePs.ShowDialog();
        }

        //to go to a game mode for 4 Players
        private void Game4P_Click(object sender, EventArgs e)
        {
            FourPs fourPs = new FourPs();
            this.Hide();
            fourPs.ShowDialog();
        }

        //to go to a game mode for 1 Player vs 1 AI
        private void AI2Ps_Click(object sender, EventArgs e)
        {
            AI2Ps AI2Ps = new AI2Ps();
            this.Hide();
            AI2Ps.ShowDialog();
        }
        
        //to go to a game mode for 1 Player vs 2 AI
        private void AI3Ps_Click(object sender, EventArgs e)
        {
            AI3Ps AI3Ps = new AI3Ps();
            this.Hide();
            AI3Ps.ShowDialog();
        }
        //to go to a game mode for 1 Player vs 3 AI
        private void AI4Ps_Click(object sender, EventArgs e)
        {
            AI4Ps AI4Ps = new AI4Ps();
            this.Hide();
            AI4Ps.ShowDialog();
        }
        
        

        //accidents//
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
