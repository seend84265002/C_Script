﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku_Demo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //表單背景圖片
            BackgroundImage = Properties.Resources.board;
            ////掛上表單事件連結
            //Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            //設定表單長寬為棋盤圖檔的長寬
            Height = Properties.Resources.board.Height;
            Width = Properties.Resources.board.Width;
            //設定表單出現在螢幕的正中央
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = Game.PlaceAPiece(e.X, e.Y);
            if (piece != null)//如果可以下棋子
            {
                Controls.Add(piece);
                //檢查是否有人獲勝
                if (Game.Winner == PieceType.BLACK)
                {
                    MessageBox.Show("黑子獲勝！");
                }
                else if (Game.Winner == PieceType.WHITE)
                {
                    MessageBox.Show("白子獲勝！");
                }
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //可見果然不必再用new做個執行個體才行(重構小山老師菩薩的)
            if (Game.CanBePlaced(e.X, e.Y))
                Cursor = Cursors.Hand;//可以下棋子則游標呈手形
            else
                Cursor = Cursors.Default;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //當對表單（視窗）按下Esc鍵時，關閉表單
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
