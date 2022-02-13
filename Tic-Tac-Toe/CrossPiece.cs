namespace Tic_Tac_Toe
{
    class CrossPiece : Piece
    {
        public CrossPiece (int x,int y ) :base(x, y)
        {
            //圖案位置
            Image = Properties.Resources.Cross;
        }
        public override PieceType GetPieceType()
        {
            return PieceType.CROSS;
        }
    }
}
