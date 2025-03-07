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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        //to start the game and go to game mode chooose
        private void btnSTART_Click(object sender, EventArgs e)
        {
            chooseGame chooseGame = new chooseGame();
            this.Hide();
            chooseGame.ShowDialog();
        }

        //closes the form/game
        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
