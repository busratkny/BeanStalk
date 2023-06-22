using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BeanStalk
{
    internal class Game
    {
        Maze maze;
        Player player;
        ItemsS ıtems;
        ItemsB ıtemsB;
        ItemsF ıtemsF;
        ItemsW ıtemsW;

        public void Start()
        {
            string[,] grid =
            {
              {"","","","#","#","#","#","","","","","","","","",""},
              {"","","#","#"," "," ","#","","","","","","","","",""},
              {"","","#"," "," "," ","#","","","","","","","","",""},
              {"#","#","#"," "," "," ","#","#","","","","","","","",""},
              {"#"," "," "," "," "," "," ","#","","","","","","","",""},
              {"#"," ","#"," ","#","#"," ","#","","","","#","#","#","#","#"},
              {"#"," ","#"," ","#","#"," ","#","#","#","#","#"," "," "," ","#"},
              {"#"," "," "," "," "," "," "," "," "," "," "," "," ","X"," ","#"},
              {"#","#","#"," ","#","#","#"," ","#","","#","#"," "," "," ","#"},
              {"","","#"," "," "," "," "," ","#","#","#","#","#","#","#","#"},
              {"","","#","#","#","#","#","#","#","","","","","","",""},
            };
            maze = new Maze(grid);

            player = new Player(9, 8);
            ıtems = new ItemsS(3, 7);
            ıtemsB= new ItemsB(3, 4);
            ıtemsF= new ItemsF(5, 4);
            ıtemsW=new ItemsW(5, 3);

            RunGameLoop();
            Console.ReadKey(true);

        }

        private void DisplayIntro()
        {
            Console.WriteLine("Welcome to the Beanstalk");
            Console.WriteLine("Use the arrow keys to push items onto the planting spot marked with an 'X' ");
            Console.WriteLine("Items must be pushed into the planting spot in the following order: ");
            Console.WriteLine("Shovel     (S) : To dig the hole\n" +
                              "Bean       (B) : Plant the magic bean\n" +
                              "Fertilizer (F) : Give the bean some food\n" +
                              "Water      (W) : Now it will grow");


            Console.WriteLine("A boulder does nothing but get in the way.Luckily you can push it round");
            Console.WriteLine("Press any key to start");
            Console.ReadKey(true);
        }
        private void DisplayOutro()
        {
            Console.Clear();
            Console.WriteLine("Congratulations!!You have successfully passed the level...");
            Console.WriteLine("Press any enter to exit");
            Console.ReadKey(true);
        }
        private void DrawFrame()
        {
            Console.Clear();
            maze.Draw();
            player.Draw();
            ıtems.Draw();
            ıtemsB.Draw();
            ıtemsF.Draw();
            ıtemsW.Draw();  

        }
        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (maze.isBoolWalkable(player.X, player.Y - 1))
                    {
                        player.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (maze.isBoolWalkable(player.X, player.Y + 1))
                    {
                        player.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze.isBoolWalkable(player.X - 1, player.Y))
                    {
                        player.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (maze.isBoolWalkable(player.X + 1, player.Y))
                    {
                        player.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void HandlePlayerInputS()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (maze.isBoolWalkable(ıtems.X, ıtems.Y - 1))
                    {
                        ıtems.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (maze.isBoolWalkable(ıtems.X, ıtems.Y + 1))
                    {
                        ıtems.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze.isBoolWalkable(ıtems.X - 1, ıtems.Y))
                    {
                        ıtems.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (maze.isBoolWalkable(ıtems.X + 1, ıtems.Y))
                    {
                        ıtems.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }
        private void HandlePlayerInputB()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (maze.isBoolWalkable(ıtemsB.X, ıtemsB.Y - 1))
                    {
                        ıtemsB.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (maze.isBoolWalkable(ıtemsB.X, ıtemsB.Y + 1))
                    {
                        ıtemsB.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze.isBoolWalkable(ıtemsB.X - 1, ıtemsB.Y))
                    {
                        ıtemsB.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (maze.isBoolWalkable(ıtemsB.X + 1, ıtemsB.Y))
                    {
                        ıtemsB.X += 1;
                    }
                    break;
                default:
                    break;
            }

        }
        private void HandlePlayerInputF()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (maze.isBoolWalkable(ıtemsF.X, ıtemsF.Y - 1))
                    {
                        ıtemsF.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (maze.isBoolWalkable(ıtemsF.X, ıtemsF.Y + 1))
                    {
                        ıtemsF.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze.isBoolWalkable(ıtemsF.X - 1, ıtemsF.Y))
                    {
                        ıtemsF.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (maze.isBoolWalkable(ıtemsF.X + 1, ıtemsF.Y))
                    {
                        ıtemsF.X += 1;
                    }
                    break;
                default:
                    break;
            }

        }
        private void HandlePlayerInputW()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (maze.isBoolWalkable(ıtemsW.X, ıtemsW.Y - 1))
                    {
                        ıtemsW.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (maze.isBoolWalkable(ıtemsW.X, ıtemsW.Y + 1))
                    {
                        ıtemsW.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (maze.isBoolWalkable(ıtemsW.X - 1, ıtemsW.Y))
                    {
                        ıtemsW.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (maze.isBoolWalkable(ıtemsW.X + 1, ıtemsW.Y))
                    {
                        ıtemsW.X += 1;
                    }
                    break;
                default:
                    break;
            }

        }


        
        private void RunGameLoop()
        {
            DisplayIntro();
            while (true)
            {
                DrawFrame();
                HandlePlayerInput();
               
                if ((player.X == ıtems.X) & player.Y == ıtems.Y)
                {
                    if(ıtems.X!=13 || ıtems.Y!=7) 
                    {
                        HandlePlayerInputS();
                    }
                    
                }
                if ((player.X == ıtemsB.X) & player.Y == ıtemsB.Y)
                {
                    if(ıtemsB.X!=13 || ıtemsB.Y!=7)
                    {
                        HandlePlayerInputB();
                    }  

                }
                if ((player.X == ıtemsF.X) & player.Y == ıtemsF.Y)
                {
                    if(ıtemsF.X!=13 || ıtemsF.Y != 7)
                    {
                        HandlePlayerInputF();
                    }
                }
                if ((player.X == ıtemsW.X) & player.Y == ıtemsW.Y)
                {
                    if(ıtemsW.X!=13 || ıtemsW.Y != 7)
                    {
                        HandlePlayerInputW();
                    }                   
                }
                if(ıtems.X==13 & ıtemsB.X==13 & ıtemsF.X==13 & ıtemsW.X==13)
                {
                    break;
                }
                
            }
            
            DisplayOutro();
        }

    }   
        
}

