using _2048.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2048
{
    public partial class StartForm : Form
    {

        #region Variables
        NumberButton[,] buttons;
        #endregion

        public StartForm()
        {
            KeyPreview = true;

            InitializeComponent();
            CreateButtons();
            NumberButton.Spawn(buttons);
        }

        private void CreateButtons()
        {
            buttons = new NumberButton[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j] = new NumberButton();
                    buttons[i, j].Left = 100 * j;
                    buttons[i, j].Top = 100 * i;
                    buttons[i, j].Enabled = false;
                    //buttons[i, j].Text = "i= " + i + ", j= " + j;
                    this.Controls.Add(buttons[i,j]);
                }
            }

            #region test button colors
            //buttons[0, 0].Text = "2";
            //buttons[0, 1].Text = "4";
            //buttons[0, 2].Text = "8";
            //buttons[0, 3].Text = "16";
            //buttons[1, 0].Text = "32";
            //buttons[1, 1].Text = "64";
            //buttons[1, 2].Text = "128";
            //buttons[1, 3].Text = "256";
            //buttons[2, 0].Text = "512";
            //buttons[2, 1].Text = "1024";
            //buttons[2, 2].Text = "2048";
            #endregion

        }

        private void StartForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
                MoveNumbers.MoveUp(buttons);

            else if (e.KeyData == Keys.Down)
                MoveNumbers.MoveDown(buttons);

            else if (e.KeyData == Keys.Left)
                MoveNumbers.MoveLeft(buttons);

            else if (e.KeyData == Keys.Right)
                MoveNumbers.MoveRight(buttons);
        }
    }
}
