using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gomoku_Demo_
{
    class WhitePiece : Piece
    {
        public WhitePiece(int x, int y) : base(x, y)
        {
            Image = Properties.Resources.white;
        }
        public WhitePiece(Point point) : base(point)
        {
            Image = Properties.Resources.white;
        }

        internal override PieceType GetPieceTyep()
        {
            return PieceType.WHITE;
        }
    }
}
