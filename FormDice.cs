using RollingDiceGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollingDiceGame
{
    public partial class FormDice : Form
    {
        public FormDice()
        {
            InitializeComponent();
        }

        //Instaniate a random number 
        private readonly Random random = new Random();

        //Generates a random number in the range
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private void FormDice_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //this will allow me to close out 
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Close");
        }

        private void btnRoll1_Click(object sender, EventArgs e)
        {
            int number = RandomNumber(1, 7);
            if (number == 1)
                picDice.Image = Resources.Dice1;
            else if(number == 2)
                picDice.Image = Resources.Dice2;
            else if(number == 3)
                picDice.Image = Resources.Dice3;
            else if (number == 4)
                picDice.Image = Resources.Dice4;
            else if (number == 5)
                picDice.Image = Resources.Dice5;
            else 
                picDice.Image = Resources.Dice6;

            picDice.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
