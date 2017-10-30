using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frustration
{
    class Game
    {
        static bool CheckCanMove(Player playerToCheck, int dice, BoardSpace[] board)
        {
            foreach (Token t in playerToCheck.Tokens)
            {
                int pos = t.GetBoardPosition();

                if (dice == 6 && pos == -1)
                {
                    return true;
                }
                if (pos > -1)
                {
                    int newBoardSpace = pos + dice;
                    if (newBoardSpace > 27)
                    {
                        newBoardSpace -= 27;
                    }
                    BoardSpace spaceToMove = (board[newBoardSpace]);
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

        static void DrawBoard(BoardSpace[] board)
        {
            Console.Clear();
            for (int i = 0; i < 28; i++)
            {
                board[i].DrawBoard();

            }

        }

          //  if (selectedToken.TotalPlacesMoved() + dice > 28)
                               
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
            DrawBoard(board);
            do
            {

                foreach (Player humanPlayer in players)
                {
                    int dice;
                    do
                    {
                        Console.WriteLine("");
                        Console.Write(humanPlayer.GetColour() + " - Enter dice number: ");

                        dice = int.Parse(Console.ReadLine());
                        Token selectedToken = new Token();
                        bool validChoice = false;

                        if (CheckCanMove(humanPlayer, dice, board) == true)
                        {
                            do
                            {
                                
                                Console.Write(humanPlayer.GetColour() + ": choose Token to move: ");
                                string tokenToMove = Console.ReadLine();


                                for (int i = 0; i < humanPlayer.Tokens.Count(); i++)
                                {
                                    Token currentToken = humanPlayer.Tokens[i];
                                    if (currentToken.GetLetter() == tokenToMove)
                                    {
                                        if (dice != 6 && currentToken.GetBoardPosition() == -1)
                                        {
                                            break;
                                        }
                                        selectedToken = humanPlayer.Tokens[i];
                                        validChoice = true;
                                        break;
                                    }

                                }
                                if (validChoice == false)
                                {
                                    Console.WriteLine("Error - Please select a valid token");
                                }

                            }
                            while (validChoice == false);


                            if (selectedToken.GetBoardPosition() == -1 && dice == 6) // when a player rolls a 6 and they choose a token at home.
                            {
                                selectedToken.setStartPosition();
                                int boardPos = selectedToken.GetBoardPosition();
                                board[boardPos].setPlayer(selectedToken);
                                DrawBoard(board);

                            }

                            else if (selectedToken.GetBoardPosition() > -1)  // if the token is on the board
                            {
                                int currentBoardPos = selectedToken.GetBoardPosition();
                                int newBoardPos = currentBoardPos + dice;
                                if (newBoardPos > 27)
                                {
                                    newBoardPos -= 28;
                                }

                                if (board[newBoardPos].IsSpaceTaken() == true && selectedToken.GetColour() != board[newBoardPos].getColour()) // If a different colour token occupies this space send it home
                                {
                                    string oldCol = board[newBoardPos].getColour();
                                    string newCol = selectedToken.GetColour();
                                    board[newBoardPos].LandOnOppenent();
                                    board[newBoardPos].setPlayer(selectedToken);
                                    selectedToken.moveToken(dice);
                                    board[currentBoardPos].SetAsEmpty();
                                    DrawBoard(board);
                                    Console.WriteLine(newCol + " sent a " + oldCol + " token home!");
                                }
                                else if (selectedToken.GetColour() == board[newBoardPos].getColour())
                                {

                                    Console.WriteLine("You cannot move this token if another one of your tokens occupys the space!");
                                    dice = 6;
                                }
                                else
                                {
                                    board[newBoardPos].setPlayer(selectedToken);
                                    selectedToken.moveToken(dice);
                                    board[currentBoardPos].SetAsEmpty();
                                    DrawBoard(board);
                                } 
                            }
                                                    
                        }

                        else
                        {
                            
                            Console.WriteLine("");
                            Console.WriteLine(humanPlayer.GetColour() + " cannot move");
                        }

                    } while (dice == 6);
                }
                } while (gameOver == false) ;

            }
    }
    }

