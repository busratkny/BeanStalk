using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanStalk
{
    internal class ItemsS:IItem
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;

        public ItemsS(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "S";
            PlayerColor = ConsoleColor.Blue;
        }
        public void Draw()
        {
            Console.ForegroundColor = PlayerColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(PlayerMarker);
            Console.ResetColor();
        }
       


    }
}
