using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    abstract class Piece : PictureBox
    {
        private static readonly int IMAGE_W = 80; 
        public Piece (int x ,int y)
        {
            //設定圖片背景顏色，位置，尺寸
            BackColor = Color.Transparent;
            Location = new Point(x - IMAGE_W/2, y- IMAGE_W / 2);
            Size = new Size(IMAGE_W, IMAGE_W);

        }
        public abstract PieceType GetPieceType();
        

        
    }
}
