using System;

namespace Chess.ChessModel
{
    public class ChessFigure
    {
        private string currentCoord;
        private IMoveStrategy moveStrategy;

        public ChessFigure(IMoveStrategy moveStrategy, string currentCoord)
        {
            this.currentCoord = currentCoord;
            this.moveStrategy = moveStrategy;
        }

        internal bool Move(string nextCoord)
        {
            if (!IsCoordValid(nextCoord))
                return false;

            return moveStrategy.CanMove(this.currentCoord, nextCoord);
        }

        private bool IsCoordValid(string coord)
        {
            return coord.Length == 2 && coord[0] >= 'A' && coord[0] <= 'H' && coord[1] >= '1' && coord[1] <= '8';
        }
    }
}