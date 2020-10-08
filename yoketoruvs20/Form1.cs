using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 5;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int itemCount = ItemMax;
        int Count;
        int Playtime;
        int hsScore;

        const string PlayerText = "('ω')";
        const string EnemyText = "敵";
        const string ItemText = "＿人人人人人人人＿\n＞　   　アイテム　 　　＜\n￣^Ｙ^Ｙ^Ｙ^Ｙ^Ｙ^Ｙ^￣";

        static Random rand = new Random();

        enum State
        {
            None = -1,  //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear       //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 10;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vkey);

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if (i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = labelsource.Font;
                chrs[i].ForeColor = labelsource.ForeColor;
                Controls.Add(chrs[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc();
            }

            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if (((mp.X >= chrs[i].Left) &&
                     (mp.X < chrs[i].Right) &&
                     (mp.Y >= chrs[i].Top) &&
                     (mp.Y < chrs[i].Bottom)))
                {
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }

                    else
                    {
                        if (chrs[i].Visible = true)
                        {
                            chrs[i].Visible = false;
                            if (Count > 0)
                            {
                                Count = Count - 1;
                                countLabel.Text = "★:" + Count;
                                if (Count == 0)
                                {
                                    nextState = State.Clear;
                                }
                            }
                        }
                    }
                }
            }

            timeLabel.Text = "time " + Playtime--;
            if(Playtime<0)
            {
                nextState = State.Gameover;
            }
        }


        void initProc()
            {
                currentState = nextState;
                nextState = State.None;

                switch (currentState)
                {
                    case State.Title:
                        titleLabel.Visible = true;
                        startButton.Visible = true;
                        copyright.Visible = true;
                        hsLabel.Visible = true;
                        goLabel.Visible = false;
                        titleButton.Visible = false;
                        clearLabel.Visible = false;
                        countLabel.Text = "★:" + ItemMax;
                        Count = ItemMax;
                        Playtime = 100;
                    break;

                    case State.Game:
                        titleLabel.Visible = false;
                        startButton.Visible = false;
                        copyright.Visible = false;
                        hsLabel.Visible = false;

                        for (int i = EnemyIndex; i < ChrMax; i++)
                        {
                            chrs[i].Visible = true;
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                            vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                            vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        }

                        break;

                    case State.Gameover:
                        goLabel.Visible = true;
                        titleButton.Visible = true;
                        break;

                    case State.Clear:
                        clearLabel.Visible = true;
                        titleButton.Visible = true;
                        hsLabel.Visible = true;
                        if(hsScore<Playtime)
                        {
                            hsScore = Playtime;
                        }
                        hsLabel.Text = "HighScore " + hsScore;
                        break;
                }
            }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelsource_Click(object sender, EventArgs e)
        {

        }
    }
}
