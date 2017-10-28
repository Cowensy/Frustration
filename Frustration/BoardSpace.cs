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
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), startSpaceColour, true);
               
                if (isTaken == true)
                {
                   
                    Console.Write("[");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), currentPlayer.GetColour(), true);
                    
                    Console.Write(currentPlayer.GetLetter());
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), startSpaceColour, true);
                    Console.Write("]");
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else
                {
                    
                    Console.Write("[");

                    Console.ResetColor();
                    Console.Write("  ");
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), startSpaceColour, true);
                    Console.Write("]");
                    Console.ResetColor();
                    Console.Write(" ");
                }
            }                        
            else
            {
                if (isTaken == true)
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), currentPlayer.GetColour(), true);
                    Console.Write("[ " + currentPlayer.GetLetter() + " ]");
                    Console.Write(" ");
                    Console.ResetColor();
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
