using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frustration
{
    class Player
    {
        public Player(string col)
        {
            colour = col;
            Token a = new Token("a", colour);
         Token b = new Token("b", colour);
         Token c = new Token("c", colour);
         Token d = new Token("d", colour);
        
            Tokens.Add(a);
            Tokens.Add(b);
            Tokens.Add(c);
            Tokens.Add(d);

        }

        public Player()
        {
            
        }

        private int tokensAtHome = 4;
        private string colour;
        

        public List<Token> Tokens = new List<Token>();
        

        public Token GetTokenFromHome()
        {
            foreach (Token t in Tokens)
            {
                if (t.GetBoardPosition() == 0 )
                {
                    t.setStartPosition();
                    return t;
                    
                }
                return null;

            }
            return null;
        }
        public int GetTokenNo()
        {
            return tokensAtHome;
        }

        public void moveToken(int num)
        {
            
        }

        public string GetColour()
        {
            return colour;
        }
    }
}
