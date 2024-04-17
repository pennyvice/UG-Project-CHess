﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Logics
{
    public  class King : Piece
    {
        public override PieceType Type => PieceType.King;
        public override Player Color { get; }

        public King(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            King copy = new King(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}
