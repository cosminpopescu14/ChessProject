using System;

namespace SolarWinds.MSP.Chess
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private Pawn[,] pieces;

        public ChessBoard ()
        {
            pieces = new Pawn[MaxBoardWidth, MaxBoardHeight];
        }

        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            throw new NotImplementedException("Need to implement ChessBoard.Add()");
        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            bool OnBoad(int X, int Y) => X <= MaxBoardWidth && Y <= MaxBoardHeight;
            bool PositiveCoords(int X, int Y) => xCoordinate >= 0 && yCoordinate >= 0;

            if (!(OnBoad(xCoordinate, yCoordinate) && PositiveCoords(xCoordinate, yCoordinate)))
            {
                return false;
            }
            return true;
        }
    }
}
