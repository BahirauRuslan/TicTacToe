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
        private Point lastPoint;
        private PlayGround playGround = new PlayGround();

        public string Player { get; private set; }

        public Game() : this("x", "o") { }

        public Game(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            Player = player1;
        }

        public void AddPoint(Point point)
        {
            if (Player == player1)
            {
                playGround.AddPlayer1Point(point);
                lastPoint = point;
            }
            else if (Player == player2)
            {
                playGround.AddPlayer2Point(point);
                lastPoint = point;
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
            else if (GetVertical(points).Count >= playGround.SeriesLength)
            {
                winSeries = GetVertical(points);
            }
            else if (GetHorizontal(points).Count >= playGround.SeriesLength)
            {
                winSeries = GetHorizontal(points);
            }
            else if (GetMajorDiag(points).Count >= playGround.SeriesLength)
            {
                winSeries = GetMajorDiag(points);
            }
            else if (GetMinorDiag(points).Count >= playGround.SeriesLength)
            {
                winSeries = GetMinorDiag(points);
            }

            return winSeries;
        }

        private ISet<Point> GetVertical(IList<Point> points)
        {
            throw new NotImplementedException();
        }

        private ISet<Point> GetHorizontal(IList<Point> points)
        {
            throw new NotImplementedException();
        }

        private ISet<Point> GetMajorDiag(IList<Point> points)
        {
            throw new NotImplementedException();
        }

        private ISet<Point> GetMinorDiag(IList<Point> points)
        {
            throw new NotImplementedException();
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
                Player = player2;
            }
            else if (Player == player2)
            {
                Player = player1;
            }
        }
    }
}
