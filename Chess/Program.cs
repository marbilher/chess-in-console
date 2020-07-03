using System;
using BoardModel;

namespace Chess
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            //show empty board
            printBoard(myBoard);

            //ask user for x and y coords
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;
            //calculate all legal moves for that piece
            myBoard.MarkNextLegalMoves(currentCell, "Knight");

            // print the board
            printBoard(myBoard);

            //wait for key press before ending program
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            //get x and y from user, return cell location
            Console.WriteLine("Enter the current row number:");
            int currentRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current column number:");
            int currentColumn = int.Parse(Console.ReadLine());

            return myBoard.cellGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard)
        {
            //print the chess board to console
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.cellGrid[i, j];

                    if(c.CurrentlyOccupied)
                    {
                        Console.Write('X');
                    } else if (c.LegalNextMove){
                        Console.Write('+');
                    } else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================");
        }
    }
}
