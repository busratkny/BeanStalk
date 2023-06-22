using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeanStalk
{
    internal class Maze
    {
        public string[,] Grid;
        private int Rows;
        private int Cols;

        public Maze(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }
        public void Draw()
        {
                for (int y = 0; y < Rows; y++)
                {
                    for (int x = 0; x < Cols; x++)
                    {
                        string element = Grid[y, x];
                        Console.SetCursorPosition(x,y);
                        if(element == "X")
                        {
                        Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                          Console.ForegroundColor= ConsoleColor.White;
                        }
                        Console.WriteLine(element);
                    }
                }
        }
        public string GetElementAt(int x, int y)
        {
            return Grid[y,x];
        }

       
        public bool isBoolWalkable(int x,int y)
        {
            if(x <0 || y < 0 || x>=Cols|| y >= Rows)
            {
                return false;
            }
            return Grid[y,x]==" " || Grid[y,x]== "X" || Grid[y,x]=="S" || Grid[y,x]=="B" || Grid[y, x] == "F" || Grid[y, x] == "W";
        }
           
        

        
    }
}
