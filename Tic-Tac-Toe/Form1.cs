using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private Game game = new Game();
        
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = game.PlaceAPiece(e.X, e.Y);
            
            if (piece != null)
            {
                Controls.Add(piece);


                if(game.winner == PieceType.CIRCLE)
                {
                    MessageBox.Show("圈圈 獲勝");
                    Controls.Clear();
                    game.Reset();
                    

                }
                else if(game.winner == PieceType.CROSS)
                {
                    MessageBox.Show("叉叉 獲勝");
                    Controls.Clear();
                    game.Reset();
                    
                }
                else if (game.winner == PieceType.TIE)
                {
                    MessageBox.Show("平手 重開遊戲");
                    Controls.Clear();
                    game.Reset();
                    
                }


            }

            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (game.CanBePlaced(e.X, e.Y))
            {
                Cursor=Cursors.Hand;
                
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
