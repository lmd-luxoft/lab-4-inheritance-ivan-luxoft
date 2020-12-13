using System;

namespace Chess.ChessModel
{
    public class ChessFigure
    {
        private string currentCoord;
        private IMoveStrategy moveStrategy;

        public ChessFigure(IMoveStrategy moveStrategy, string currentCoord)
        {
            if (!IsCoordValid(currentCoord))
                throw new ArgumentOutOfRangeException(
                    $"Coordinate \"{currentCoord}\" out of range",
                    nameof(currentCoord));

            this.currentCoord = currentCoord;
            this.moveStrategy = moveStrategy;
        }

        internal bool Move(string nextCoord)
        {
            if (!IsCoordValid(nextCoord))
                return false;

            if (!IsCellChanged(nextCoord))
                return false;

            return moveStrategy.CanMove(this.currentCoord, nextCoord);
        }

        private bool IsCellChanged(string nextCoord)
        {
            return string.Compare(this.currentCoord, nextCoord, true) != 0;
        }

        private bool IsCoordValid(string coord)
        {
            return coord.Length == 2 && coord[0] >= 'A' && coord[0] <= 'H' && coord[1] >= '1' && coord[1] <= '8';
        }
    }
}