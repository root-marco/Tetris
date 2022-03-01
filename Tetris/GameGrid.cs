﻿namespace Tetris
{
    internal class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int rows, int columns]
        {
            get => grid[rows, columns];
            set => grid[rows, columns] = value;
        }

        public GameGrid(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            grid = new int[rows, columns];
        }

        public bool IsInside(int rows, int columns)
        {
            return rows >= 0 && rows < this.Rows &&
                columns >= 0 && columns < this.Columns;
        }

        public bool IsEmpty(int rows, int columns)
        {
            return IsInside(rows, columns) &&
                grid[rows, columns] == 0;
        }
    }
}
