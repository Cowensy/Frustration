using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frustration
{
    class Token 
    {
        enum StartSpace
        {
            blue = 1,
            red = 8, 
            green = 15,
            yellow = 22,
        };

        public Token(string let, string col)
        {
            colour = col;
            letter = let;
        }
        public Token()
        {

        }
        private string colour;
        private string letter;
       private int boardPosition;
        private int placesMoved;

        public void setStartPosition()
        {
            if (colour == "blue")
            {
                boardPosition = (int)StartSpace.blue;
                
            }
            else if (colour == "red")
            {
                boardPosition = (int)StartSpace.red;
            }
            else if (colour == "green")
            {
                boardPosition = (int)StartSpace.green;
            }
           else if (colour == "yellow")
            {
                boardPosition = (int)StartSpace.yellow;
            }
        }

        public int GetBoardPosition()
        {
            return boardPosition;
        }
        
        public void moveToken(int num)
        {
            boardPosition = +num;
            placesMoved = +num;
            if (boardPosition < 28 )
            {
                boardPosition = 1;
            }
        }

        public string GetLetter()
        {
            return letter;
        }

        public string GetColour()
        {
            return colour;
        }


    }
}
