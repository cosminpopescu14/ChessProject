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
            bool OnBoad = IsOnBoad(xCoordinate, yCoordinate);//piece must be on the board
            bool PositiveCoords = HasPositiveCoords(xCoordinate, yCoordinate); //piece must has positive coords

            if (!(OnBoad && PositiveCoords))
            {
                return false;
            }
            return true;
        }

        private static bool HasPositiveCoords(int xCoordinate, int yCoordinate)
        {
            return xCoordinate >= 0 && yCoordinate >= 0;
        }

        private static bool IsOnBoad(int xCoordinate, int yCoordinate)
        {
            return xCoordinate <= MaxBoardWidth && yCoordinate <= MaxBoardHeight;
        }
    }
}
