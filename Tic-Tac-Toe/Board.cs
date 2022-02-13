using System.Drawing;

namespace Tic_Tac_Toe
{
    class Board
    {
        public static readonly int NODE_Count = 3;
        private static readonly Point No_Match_Node = new Point(-1, -1);
        private static readonly int NODE_DIS = 200;
        private static readonly int R_DIS = 40;
        private static readonly int Off_DIS = 100;
        public Piece[,] pieces = new Piece[NODE_Count, NODE_Count];
        private Point LastPlaceNode = No_Match_Node;
        public Point lastPlaceNode { get { return LastPlaceNode; } }
        public bool CanBePlaced(int x,int y)
        {
            //找最近的節點
            Point nodeld = FindTheClosetNode(x, y);
            //如果位置錯誤
            if (nodeld == No_Match_Node) return false;

            if (pieces[nodeld.X, nodeld.Y] != null) return false;


            return true;
        }
        /// <summary>
        /// 經過運算判斷位址
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Point FindTheClosetNode(int x, int y)
        {
            int nodeldX = FindTheClosetNode(x);
            if (nodeldX == -1 || nodeldX >=NODE_Count)
                return No_Match_Node;
            int nodeldY = FindTheClosetNode(y);
            if (nodeldY == -1 || nodeldY >= NODE_Count)
                return No_Match_Node;
            return new Point(nodeldX, nodeldY);
        }
        /// <summary>
        /// 個別計算 X Y 位置落到哪
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        private int FindTheClosetNode(int pos)
        {
            if (pos <= Off_DIS - R_DIS) return -1;

            pos -= Off_DIS;

            int quotion = pos / NODE_DIS;
            int re = pos % NODE_DIS;

            if (re <= R_DIS)
            {
                return quotion;
            }
            else if (re >= NODE_DIS - R_DIS) 
                return quotion + 1;
            else
                return -1;
        }

        public Piece PlaceAPiece(int x,int y ,PieceType type)
        {
            //找最近的節點
            Point nodeld = FindTheClosetNode(x, y);
            //如果位置錯誤
            if (nodeld == No_Match_Node) return null;

            if (pieces[nodeld.X, nodeld.Y] != null) return null;

            Point formPos = ConvertToFormPosition(nodeld);

            if (type == PieceType.CIRCLE)
                pieces[nodeld.X, nodeld.Y] = new CirclePiece(formPos.X, formPos.Y);
            else if (type == PieceType.CROSS)
                pieces[nodeld.X, nodeld.Y] = new CrossPiece(formPos.X, formPos.Y);

            //紀錄最後位置
            LastPlaceNode = nodeld;
            return pieces[nodeld.X, nodeld.Y]; 
        }
        private Point ConvertToFormPosition(Point nodeld)
        {
            Point formPostion = new Point();
            formPostion.X = nodeld.X * NODE_DIS + Off_DIS;
            formPostion.Y = nodeld.Y * NODE_DIS + Off_DIS;
            return formPostion;
        }

        public PieceType GetPieceType (int nodeldX ,int nodeldY)
        {
            if (pieces[nodeldX, nodeldY] == null)
                return PieceType.NONE;
            else
                return pieces[nodeldX, nodeldY].GetPieceType();
        }
        public void Reset()
        {
            pieces = new Piece[NODE_Count, NODE_Count];
        }
    }
}
