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
    }
}
