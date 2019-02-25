using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicTacToe
{
    public class PlayGround
    {
        private IList<Point> player1Points = new List<Point>();
        private IList<Point> player2Points = new List<Point>();

        public int GroundSize { get; }
        public int SeriesLength { get; }

        public PlayGround() : this(3, 3) { }

        public PlayGround(int groundSize, int seriesLength)
        {
            GroundSize = groundSize;
            SeriesLength = seriesLength;
        }

        public void AddPlayer1Point(Point point)
        {
            if (Player1PointsCount + Player2PointsCount < GroundSize * GroundSize)
            {
                player1Points.Add(point);
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void AddPlayer2Point(Point point)
        {
            if (Player1PointsCount + Player2PointsCount < GroundSize * GroundSize)
            {
                player2Points.Add(point);
            }
            else
            {
                throw new OverflowException();
            }
        }

        public IList<Point> GetPlayer1Points()
        {
            return player1Points;
        }

        public IList<Point> GetPlayer2Points()
        {
            return player2Points;
        }

        public int Player1PointsCount
        {
            get
            {
                return player1Points.Count;
            }
        }

        public int Player2PointsCount
        {
            get
            {
                return player2Points.Count;
            }
        }
    }
}
