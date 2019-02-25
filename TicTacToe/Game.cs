using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicTacToe
{
    public class Game
    {
        private string player1;
        private string player2;
        private string player;
        private PlayGround playGround = new PlayGround();

        public string Player
        {
            get
            {
                return player;
            }
        }

        public Game() : this("x", "o") { }

        public Game(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            player = player1;
        }

        public void AddPoint(Point point)
        {
            if (Player == player1)
            {
                playGround.AddPlayer1Point(point);
            }
            else if (Player == player2)
            {
                playGround.AddPlayer2Point(point);
            }
        }

        public ISet<Point> GetWinSeries()
        {
            IList<Point> points = GetPlayerPoints();
            ISet<Point> winSeries = null;
            if (playGround.Player1PointsCount 
                + playGround.Player2PointsCount < 2 * playGround.SeriesLength - 1)
            {
                return winSeries;
            }
            return winSeries;
        }

        private IList<Point> GetPlayerPoints()
        {
            return (Player == player1) ? playGround.GetPlayer1Points() 
                : playGround.GetPlayer2Points();
        }

        public void ChangePlayer()
        {
            if (Player == player1)
            {
                player = player2;
            }
            else if (Player == player2)
            {
                player = player1;
            }
        }
    }
}
