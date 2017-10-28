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
            
        }

        public Player()
        {
            Tokens.Add(a);
            Tokens.Add(b);
            Tokens.Add(c);
            Tokens.Add(d);
        }

        private int tokensAtHome = 4;
        private string colour;
        private Token a = new Token(colour);
        private Token b = new Token();
        private Token c = new Token();
        private Token d = new Token();

        public List<Token> Tokens = new List<Token>();
        

        public Token GetToken()
        {
            foreach (Token t in Tokens)
            {
                if (t.getBoardPosition() == null )
                {
                    t.setBoardPosition(1);
                    return t;
                    break;
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
