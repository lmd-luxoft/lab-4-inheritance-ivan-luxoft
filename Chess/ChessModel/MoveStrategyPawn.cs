namespace Chess.ChessModel
{
    internal class MoveStrategyPawn : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsSameVerticalLine(currentCoord, nextCoord)
                && IsMoveForwardByVerticalLine(currentCoord, nextCoord)
                && (IsMoveForwardForOneCell(currentCoord, nextCoord) || IsFirstMoveForTwoCells(currentCoord, nextCoord));
        }

        private bool IsSameVerticalLine(string currentCoord, string nextCoord)
        {
            return nextCoord[0] == currentCoord[0];
        }

        private bool IsMoveForwardByVerticalLine(string currentCoord, string nextCoord)
        {
            return nextCoord[1] > currentCoord[1];
        }

        private bool IsMoveForwardForOneCell(string currentCoord, string nextCoord)
        {
            return nextCoord[1] - currentCoord[1] == 1;
        }

        private bool IsFirstMoveForTwoCells(string currentCoord, string nextCoord)
        {
            return currentCoord[1] == '2' && nextCoord[1] == '4';
        }
    }
}
