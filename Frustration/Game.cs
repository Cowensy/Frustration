using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frustration
{
    static class Game
    {
       
        static void Main(string[] args)
        {

            bool gameOver = false;
            BoardSpace[] board = new BoardSpace[28];


            for (int i = 0; i < 28; i++)
            {
                board[i] = new BoardSpace();


            }
            board[0].SetStartSpace("blue");
            board[7].SetStartSpace("red");
            board[14].SetStartSpace("yellow");
            board[21].SetStartSpace("green");
            
            Player blue = new Player("blue");
            Player red = new Player("red");
            

            List<Player> players = new List<Player>();

            players.Add(red);
            players.Add(blue);

            do
            {
                foreach (Player humanPlayer in players)
                {
                    Console.Write("enter dice number: ");
                    
                    int dice = int.Parse(Console.ReadLine());
                    if (dice == 6 & humanPlayer.GetTokenNo() == 4)
                    {
                        board[0].setPlayer(humanPlayer.GetTokenFromHome()); 
                    }
                    
                    Console.Clear();
                    for (int i = 0; i < 28; i++)
                    {
                        board[i].DrawBoard();

                    }


               
                }

                } while (gameOver == false);
            
    }
    }
    }
