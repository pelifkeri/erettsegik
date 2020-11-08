using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2048.classes
{
    class ColorizeButtons
    {
        public ColorizeButtons()
        {

        }

        public static void Colorize(NumberButton[,] buttons)
        {
            foreach (var item in buttons)
            {
                switch (item.Text)
                {

                    case "2":
                        item.BackColor = Color.Red;
                        break;
                    case "4":
                        item.BackColor = Color.Orange;
                        break;
                    case "8":
                        item.BackColor = Color.Yellow;
                        break;
                    case "16":
                        item.BackColor = Color.Green;
                        break;
                    case "32":
                        item.BackColor = Color.Aqua;
                        break;
                    case "64":
                        item.BackColor = Color.Brown;
                        break;
                    case "128":
                        item.BackColor = Color.Khaki;
                        break;
                    case "256":
                        item.BackColor = Color.Magenta;
                        break;
                    case "512":
                        item.BackColor = Color.Beige;
                        break;
                    case "1024":
                        item.BackColor = Color.SteelBlue;
                        break;
                    case "2048":
                        item.BackColor = Color.BurlyWood;
                        break;
                    default:
                        item.BackColor = default(Color);
                        break;
                }
            }
        }
    }
}
