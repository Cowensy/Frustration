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
            Tokens.Add(a);
            Tokens.Add(b);
            Tokens.Add(c);
            Tokens.Add(d);

        }

        public Player()
        {
            
        }

        private int tokensAtHome = 4;
        private static string colour;
        private Token a = new Token("a", colour);
        private Token b = new Token("b" ,colour);
        private Token c = new Token("c", colour);
        private Token d = new Token("d" ,colour);

        public List<Token> Tokens = new List<Token>();
        

        public Token GetTokenFromHome()
        {
            foreach (Token t in Tokens)
            {
                if (t.getBoardPosition() == 0 )
                {
                    t.setBoardPosition();
                    return t;
                    
                }
                return t;

            }
            return a;
        }
        public int GetTokenNo()
        {
            return tokensAtHome;
        }

        public void moveToken(int num)
        {
            
        }


    }
}
