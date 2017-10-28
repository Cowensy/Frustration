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

        public Token(string col)
        {
            colour = col;
        }
        public Token()
        {

        }
        private string colour;
       private int boardPosition;

        public void setBoardPosition()
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

        public int getBoardPosition()
        {
            return boardPosition;
        }

        
    }
}
