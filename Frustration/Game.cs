using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frustration
{
    static class Game
    {
        static bool CheckCanMove(Player playerToCheck, int dice, BoardSpace[] board)
        {
            foreach (Token t in playerToCheck.Tokens)
            {
                int pos = t.GetBoardPosition();

                if (dice == 6 && pos == 0)
                {
                    return true;
                }
                if (pos > 0)
                {
                    BoardSpace spaceToMove = (board[pos + dice]);
                    if (spaceToMove.IsSpaceTaken() && t.GetColour() != spaceToMove.getColour())
                    {
                        return true;
                    }
                    else if (spaceToMove.IsSpaceTaken() == false)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

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

            players.Add(blue);
            players.Add(red);

            do
            {
                foreach (Player humanPlayer in players)
                {
                    Console.Write("enter dice number: ");

                    int dice = int.Parse(Console.ReadLine());
                    Token selectedToken = new Token();
                    bool validChoice = false;

                    if (CheckCanMove(humanPlayer, dice, board) == true)
                    {
                        do
                        {

                            Console.WriteLine(humanPlayer.GetColour() + ": choose Token to move");
                            string tokenToMove = Console.ReadLine();


                            for (int i = 0; i < humanPlayer.Tokens.Count(); i++)
                            {
                                if (humanPlayer.Tokens[i].GetLetter() == tokenToMove)
                                {
                                    selectedToken = humanPlayer.Tokens[i];
                                    validChoice = true;
                                }

                            }


                        }
                        while (validChoice == false);


                        if (selectedToken.GetBoardPosition() == 0 && dice == 6)
                        {
                            selectedToken.setStartPosition();
                            int boardPos = selectedToken.GetBoardPosition();
                            board[boardPos].setPlayer(selectedToken);

                        }

                        else
                        {
                            int currentBoardPos = selectedToken.GetBoardPosition();
                            board[currentBoardPos].SetAsEmpty();
                            selectedToken.moveToken(dice);
                            int newBoardPos = currentBoardPos + dice;

                            board[newBoardPos].setPlayer(selectedToken);
                        }

                        Console.Clear();
                        for (int i = 0; i < 28; i++)
                        {
                            board[i].DrawBoard();

                        }

                    }
                    else { Console.WriteLine("cannot move"); }

                    }

                } while (gameOver == false) ;

            }
    }
    }
