using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frustration
{
    class Token 
    {
        private string colour;
       private int boardPosition;

        public void setBoardPosition(int position)
        {
            boardPosition = position;
        }

        public int getBoardPosition()
        {
            return boardPosition;
        }

        public Token(string col)
        {

        }
    }
}
