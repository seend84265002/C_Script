namespace Tic_Tac_Toe
{
    class CirclePiece :Piece
    {
        public CirclePiece(int x,int y) :base(x, y)
        {
            //圖案位置
            Image = Properties.Resources.Circle;
        }
        public override PieceType GetPieceType()
        {
            return PieceType.CIRCLE;
        }
    }
}
