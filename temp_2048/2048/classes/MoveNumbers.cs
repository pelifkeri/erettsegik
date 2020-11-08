using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace _2048.classes
{
    class MoveNumbers
    {
        public MoveNumbers()
        {

        }

        public static void MoveUp(NumberButton[,] buttons)
        {
            for (int index = 0; index < 3; index++)
            {
                for (int sor = 0; sor < 4; sor++)
                {
                    //ha felfele mozgatásnál lyuk van két szám között
                    for (int oszlop = 0; oszlop < 3; oszlop++)
                    {
                        if (buttons[oszlop, sor].Text == "" && (buttons[oszlop + 1, sor].Text) != "")
                        {
                            buttons[oszlop, sor].Text = buttons[oszlop + 1, sor].Text;
                            buttons[oszlop + 1, sor].Text = "";
                        }
                    }
                }
            }
            for (int oszlop = 0; oszlop < 3; oszlop++)
            {
                for (int sor = 0; sor < 4; sor++)
                {
                    //ha egymás alatt két egyforma van
                    if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor].Text == buttons[oszlop + 1, sor].Text))
                    {
                        buttons[oszlop, sor].Text = (Int32.Parse(buttons[oszlop, sor].Text) * 2).ToString();
                        buttons[oszlop + 1, sor].Text = "";
                    }
                }
            }
            NumberButton.Spawn(buttons);
        }

        public static void MoveDown(NumberButton[,] buttons)
        {
            for (int index = 3; index > -1; index--)
            {
                for (int sor = 3; sor > -1; sor--)
                {
                    //ha lefele mozgatásnál lyuk van két szám között
                    for (int oszlop = 3; oszlop > 0; oszlop--)
                    {
                        if (buttons[oszlop, sor].Text == "" && (buttons[oszlop - 1, sor].Text) != "")
                        {
                            buttons[oszlop, sor].Text = buttons[oszlop - 1, sor].Text;
                            buttons[oszlop - 1, sor].Text = "";                            
                        }
                    }
                }
            }
            for (int oszlop = 3; oszlop > 0; oszlop--)
            {
                for (int sor = 3; sor > -1; sor--)
                {
                    //ha egymás alatt két egyforma van
                    if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor].Text == buttons[oszlop - 1, sor].Text))
                    {
                        buttons[oszlop, sor].Text = (Int32.Parse(buttons[oszlop, sor].Text) * 2).ToString();
                        buttons[oszlop - 1, sor].Text = "";
                    }
                }
            }
            NumberButton.Spawn(buttons);
        }

        public static void MoveRight(NumberButton[,] buttons)
        {
                for (int oszlop = 0; oszlop < 4; oszlop++)
                {
                    //ha jobbra mozgatásnál lyuk van
                    for (int sor = 0; sor < 3; sor++)
                    {
                        if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor+1].Text) == "")
                        {
                            buttons[oszlop, sor+1].Text = buttons[oszlop, sor].Text;
                            buttons[oszlop, sor].Text = "";
                        }
                    }
            }
            for (int oszlop = 0; oszlop < 4; oszlop++)
            {
                for (int sor = 0; sor < 3; sor++)
                {
                    //ha egymás mellett két egyforma van
                    if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor].Text == buttons[oszlop, sor + 1].Text))
                    {
                        buttons[oszlop, sor + 1].Text = (Int32.Parse(buttons[oszlop, sor].Text) * 2).ToString();
                        buttons[oszlop, sor].Text = "";
                    }
                }
            }
            NumberButton.Spawn(buttons);
        }

        public static void MoveLeft(NumberButton[,] buttons)
        {
            for (int index = 3; index > -1; index--)
            {
                for (int sor = 3; sor > 0; sor--)
                {
                    //ha balra mozgatásnál lyuk van két szám között
                    for (int oszlop = 3; oszlop > -1; oszlop--)
                    {
                        if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor-1].Text) == "")
                        {
                            buttons[oszlop, sor-1].Text = buttons[oszlop, sor].Text;
                            buttons[oszlop, sor].Text = "";
                        }
                    }
                }
            }
            for (int oszlop = 3; oszlop > -1; oszlop--)
            {
                for (int sor = 3; sor > 0; sor--)
                {
                    //ha egymás mellett két egyforma van
                    if (buttons[oszlop, sor].Text != "" && (buttons[oszlop, sor].Text == buttons[oszlop, sor-1].Text))
                    {
                        buttons[oszlop, sor-1].Text = (Int32.Parse(buttons[oszlop, sor].Text) * 2).ToString();
                        buttons[oszlop, sor].Text = "";
                    }
                }
            }
            NumberButton.Spawn(buttons);
        }



    }
}
