namespace Tetris
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
    }
}
