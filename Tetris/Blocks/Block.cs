namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Position offset;

        public Block ()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }
    }
}
