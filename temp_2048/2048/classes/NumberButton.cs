using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048.classes
{
    class NumberButton : Button
    {
        public NumberButton()
        {
            this.Text = "";
            this.Width = 100;
            this.Height = 100;
            this.FlatStyle = FlatStyle.Flat;
        }

        public static void Spawn(NumberButton[,] buttons)
        {
            //színezzük őket előre, mert ha nyerünk, előbb feljön a mbox, és csak utána színeződik
            ColorizeButtons.Colorize(buttons);

            if (CheckWinAndLose.CheckIf2048Found(buttons))
                MessageBox.Show("easy gg");

            Random rand = new Random();
            bool notCreated = true;
            int counter = 0;

            while (notCreated && counter < 16)
            {
                counter = 0;
                foreach (var item in buttons)
                {
                    if (item.Text == "")
                        break;
                    else
                        counter++;
                }

                int randX = rand.Next(0, 4), randY = rand.Next(0, 4);

                if (buttons[randX, randY].Text == "")
                {
                    buttons[randX, randY].Text = "2";
                    notCreated = false;
                }
            }

            ColorizeButtons.Colorize(buttons);

            if (CheckWinAndLose.CheckIfTableIsFull(buttons))
                MessageBox.Show("Game Over");
        }
    }
}
