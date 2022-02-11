using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gomoku_Demo_
{
    class BlackPiece : Piece
    {
        public BlackPiece(int x, int y) : base(x, y)
        {
            Image = Properties.Resources.black;
        }
        public BlackPiece(Point point) : base(point)
        {
            Image = Properties.Resources.black;
        }
        internal override PieceType GetPieceTyep()
        {
            return PieceType.BLACK;
        }
    }
}
