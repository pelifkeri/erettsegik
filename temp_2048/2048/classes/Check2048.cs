using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.classes
{
    class CheckWinAndLose
    {
        public CheckWinAndLose()
        {

        }

        public static bool CheckIf2048Found(NumberButton[,] buttons)
        {
            foreach (var item in buttons)
            {
                if (item.Text == "2048")
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfTableIsFull(NumberButton[,] buttons)
        {
            foreach (var item in buttons)
            {
                if (item.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
