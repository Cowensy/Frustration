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
            blue = 0,
            red = 7, 
            green = 14,
            yellow = 21,
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
        private int boardPosition = -1;
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
        public int TotalPlacesMoved()
        {
            return placesMoved;
        }

        public void moveToken(int num)
        {
            boardPosition +=num;
            placesMoved += num;
            if (boardPosition > 27 )
            {
                boardPosition -= 28;
            }
        }

        public void SendHome()
        {
            boardPosition = -1;
            placesMoved = 0;
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
