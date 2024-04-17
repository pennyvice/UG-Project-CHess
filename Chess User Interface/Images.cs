﻿
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Chess_Logics;

namespace Chess_User_Interface
{
    public static class Images

    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSource = new()
        {
            {PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            {PieceType.Bishop, LoadImage("Assets/BishopW.png") },
            {PieceType.Rook, LoadImage("Assets/RookW.png") },
            {PieceType.Knight, LoadImage("Assets/KnightW.png")},
            {PieceType.King, LoadImage("Assets/KingW.png")},
            {PieceType.Queen, LoadImage("Assets/QueenW.png") }
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSource = new()
        {
            {PieceType.Pawn, LoadImage("Assets/PawnB.png") },
            {PieceType.Bishop, LoadImage("Assets/BishopB.png") },
            {PieceType.Rook, LoadImage("Assets/RookB.png") },
            {PieceType.Knight, LoadImage("Assets/KnightB.png")},
            {PieceType.King, LoadImage("Assets/KingB.png")},
            {PieceType.Queen, LoadImage("Assets/QueenB.png") }
        };

        private static ImageSource LoadImage(string filepath)
        {
            return new BitmapImage(new Uri(filepath,UriKind.Relative));
        }

        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSource[type],
                Player.Black => blackSource[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if(piece == null) return null;

            return GetImage(piece.Color, piece.Type);
        }
    }
}
