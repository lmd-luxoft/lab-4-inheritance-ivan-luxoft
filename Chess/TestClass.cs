// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Chess.ChessModel;
using System;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void RookShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.ROOK, "E2");
            Assert.AreEqual(true, figure.Move("C2"));
        }
        [Test]
        public void RookShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.ROOK, "E2");
            Assert.AreEqual(false, figure.Move("C5"));
        }
        [Test]
        public void KnightShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.KNIGHT, "B1");
            Assert.AreEqual(true, figure.Move("C3"));
        }
        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.KNIGHT, "B1");
            Assert.AreEqual(false, figure.Move("C5"));
        }
        [Test]
        public void BishopShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.BISHOP, "C1");
            Assert.AreEqual(true, figure.Move("E3"));
        }
        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.BISHOP, "C1");
            Assert.AreEqual(false, figure.Move("C3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.PAWN, "E2");
            Assert.AreEqual(true, figure.Move("E3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.PAWN, "E2");
            Assert.AreEqual(true, figure.Move("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.PAWN, "E4");
            Assert.AreEqual(true, figure.Move("E5"));
        }
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.PAWN, "E2");
            Assert.AreEqual(false, figure.Move("C5"));
        }
        [Test]
        public void KingShouldBeCorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.KING, "E1");
            Assert.AreEqual(true, figure.Move("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.KING, "E1");
            Assert.AreEqual(false, figure.Move("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.QUEEN, "D1");
            Assert.AreEqual(true, figure.Move("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.QUEEN, "D1");
            Assert.AreEqual(true, figure.Move("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.QUEEN, "D1");
            Assert.AreEqual(false, figure.Move("E3"));
        }
        [Test]
        public void CreateFigureWithUncorrectCurrentCoordShouldThrowException()
        {
            var coord = "D9";
            TestDelegate createFigure = () => ChessFigureFactory.CreateFigure(ChessFigureTypes.QUEEN, coord);
            Assert.Throws<ArgumentOutOfRangeException>(createFigure, $"Coordinate \"{coord}\" out of range");
        }
        [Test]
        public void MoveWithSameCoordinateShouldReturnError()
        {
            var coord = "D8";
            ChessFigure figure = ChessFigureFactory.CreateFigure(ChessFigureTypes.PAWN, coord);
            Assert.AreEqual(false, figure.Move(coord));
        }
    }
}
