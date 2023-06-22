using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanStalk
{
    internal class ItemsF:IItem
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;

        public ItemsF(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerMarker = "F";
            PlayerColor = ConsoleColor.Cyan;
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

