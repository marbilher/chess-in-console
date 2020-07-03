using System;
namespace BoardModel
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] cellGrid { get; set; }

        public Board (int s)
        {
            Size = s;

            cellGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    cellGrid[i, j] = new Cell(i, j);
                }
            }

        }

        public void MarkNextLegalMoves( Cell currentCell, string chessPiece)
        {
            //Clear all previous legal moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    cellGrid[i, j].LegalNextMove = false;
                    cellGrid[i, j].CurrentlyOccupied = false;
                }
            }

            //Find all legal moves and mark cells as legal

            switch (chessPiece)
            {
                case "King":
                    break;

                case "Queen":
                    break;

                case "Bishop":
                    break;

                case "Rook":
                    break;

                case "Knight":
                    cellGrid[currentCell.RowNumber + 2, currentCell.RowNumber + 1].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber + 2, currentCell.RowNumber - 1].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber - 2, currentCell.RowNumber + 1].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber - 2, currentCell.RowNumber - 1].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber + 1, currentCell.RowNumber - 2].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber + 1, currentCell.RowNumber + 2].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber - 1, currentCell.RowNumber - 2].LegalNextMove = true;
                    cellGrid[currentCell.RowNumber - 1, currentCell.RowNumber + 2].LegalNextMove = true;


                    break;

                case "Pawn":
                    break;

                default:

                    break;

            }
        }
    }
}
