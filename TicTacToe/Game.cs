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
            int floor = (int)(lastPoint.Y - playGround.SeriesLength);
            int ceil = (int)(lastPoint.Y + playGround.SeriesLength + 1);
            ISet<Point> winSeries = new HashSet<Point>();

            for (int j = floor; j < ceil; j++)
            {
                Point point = new Point(lastPoint.X, j);
                if (points.Contains(point))
                {
                    winSeries.Add(point);
                }
            }

            return winSeries;
        }

        private ISet<Point> GetHorizontal(IList<Point> points)
        {
            int floor = (int)(lastPoint.X - playGround.SeriesLength);
            int ceil = (int)(lastPoint.X + playGround.SeriesLength + 1);
            ISet<Point> winSeries = new HashSet<Point>();

            for (int i = floor; i < ceil; i++)
            {
                Point point = new Point(i, lastPoint.Y);
                if (points.Contains(point))
                {
                    winSeries.Add(point);
                }
            }

            return winSeries;
        }

        private ISet<Point> GetMajorDiag(IList<Point> points)
        {
            ISet<Point> winSeries = new HashSet<Point>();

            for (int i = 0; i < 2 * playGround.SeriesLength + 1; i++)
            {
                Point point = new Point(lastPoint.X - playGround.SeriesLength + i, 
                    lastPoint.Y - playGround.SeriesLength + i);
                if (points.Contains(point))
                {
                    winSeries.Add(point);
                }
            }

            return winSeries;
        }

        private ISet<Point> GetMinorDiag(IList<Point> points)
        {
            ISet<Point> winSeries = new HashSet<Point>();

            for (int i = 0; i < 2 * playGround.SeriesLength + 1; i++)
            {
                Point point = new Point(lastPoint.X + playGround.SeriesLength - i,
                    lastPoint.Y - playGround.SeriesLength + i);
                if (points.Contains(point))
                {
                    winSeries.Add(point);
                }
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
                Player = player2;
            }
            else if (Player == player2)
            {
                Player = player1;
            }
        }
    }
}
