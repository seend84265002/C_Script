namespace Tic_Tac_Toe
{
    class Game
    {
        private int number =1;
        private PieceType CurrentPlayer = PieceType.CROSS;
        private Board board = new Board();
        private PieceType Winner = PieceType.NONE;
        public PieceType winner { get{ return Winner; } }
        public bool CanBePlaced(int x,int y)
        {
            return board.CanBePlaced(x,y);
        }
        public Piece PlaceAPiece(int x, int y)
        {
            if (number == 9)
                Winner = PieceType.TIE;

            Piece piece = board.PlaceAPiece(x, y, CurrentPlayer);

            if (piece != null)
            {
                //檢查是否勝利
                CheckWinner();
                //交換選手
                if (CurrentPlayer == PieceType.CROSS)
                {
                    CurrentPlayer = PieceType.CIRCLE;
                    number++;
                }
                else if (CurrentPlayer == PieceType.CIRCLE)
                {
                    CurrentPlayer = PieceType.CROSS;
                    number++;
                }
                return piece;
            }
            return null;

        }

        public void Reset()
        {
            number = 1;
            Winner = PieceType.NONE;
            board.Reset();
        }

        

        private void CheckWinner()
        {

            
            int centerX = board.lastPlaceNode.X;
            int centerY = board.lastPlaceNode.Y;
            for(int xDir = 1; xDir >= -1; xDir--)
            {
                for(int yDir = 1; yDir >= -1; yDir--)
                {
                    if (xDir == 0 && yDir == 0) 
                        continue;
                    
                    int count = 1;
                    while (count < 3)
                    {
                        int targetX = centerX + xDir*count;
                        int targetY = centerY + yDir*count;

                        if (targetX < 0 || targetX >= Board.NODE_Count ||
                            targetY < 0 || targetY >= Board.NODE_Count ||
                            board.GetPieceType(targetX, targetY) != CurrentPlayer)
                            break;

                        count++;
                    }
                    int count1 = 1;
                    while (count < 3)
                    {
                        int targetX = centerX - xDir * count1;
                        int targetY = centerY - yDir * count1;

                        if (targetX < 0 || targetX >= Board.NODE_Count ||
                            targetY < 0 || targetY >= Board.NODE_Count ||
                            board.GetPieceType(targetX, targetY) != CurrentPlayer)
                            break;

                        count1++;
                    }

                    if (count + count1 > 3)
                    {
                        Winner = CurrentPlayer; 
                    }
                       
                    
                }
            }
            

        }
    }
}
