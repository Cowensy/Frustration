using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frustration
{
    class BoardSpace
    {
        public BoardSpace()
        {

        }

        private string startSpaceColour;
       private string playerColour;
        private bool isTaken = false;
        private bool startSpace = false;

        public void DrawBoard()
        {
            if (startSpace == true)
            {
                if (startSpaceColour == "blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (startSpaceColour == "red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (startSpaceColour == "yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (startSpaceColour == "green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                if (isTaken == true)
                {
                    Console.Write("[ * ]");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("[  ]");
                    Console.ResetColor();
                    Console.Write(" ");
                }
            }                        
            else
            {
                if (isTaken == true)
                {
                    Console.Write("[ * ]");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("[  ]");
                    Console.Write(" ");
                }
            }                                           
        }

        
        Token currentPlayer;

       

        public void SetAsTaken(string colour)
        {
            isTaken = true;
            playerColour = colour;
        }

        public void SetAsEmpty()
        {
            isTaken = false;
        }

        public bool IsSpaceTaken()
        {
            return isTaken;
        }

        public void SetStartSpace(string colour)
        {
            startSpace = true;
            startSpaceColour = colour;
        }

        public void setPlayer(Token playerOnSpace)
        {
            currentPlayer = playerOnSpace;
            isTaken = true;
        }
    }
}
