using System;

namespace Chess.ChessModel
{
    public static class ChessFigureFactory
    {
        public static ChessFigure CreateFigure(ChessFigureTypes figureType, string currentCoord)
        {
            IMoveStrategy moveStrategy = null;

            switch (figureType)
            {
                case ChessFigureTypes.ROOK:
                    moveStrategy = new MoveStrategyRook();
                    break;
                case ChessFigureTypes.KNIGHT:
                    moveStrategy = new MoveStrategyKnight();
                    break;
                case ChessFigureTypes.BISHOP:
                    moveStrategy = new MoveStrategyBishop();
                    break;
                case ChessFigureTypes.PAWN:
                    moveStrategy = new MoveStrategyPawn();
                    break;
                case ChessFigureTypes.KING:
                    moveStrategy = new MoveStrategyKing();
                    break;
                case ChessFigureTypes.QUEEN:
                    moveStrategy = new MoveStrategyQueen();
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Chess figure with type {figureType} not found.");
            }

            return new ChessFigure(moveStrategy, currentCoord);
        }
    }
}
