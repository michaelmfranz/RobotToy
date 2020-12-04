
using System;
using System.Collections.Generic;

namespace RobotToy
{
    public class RobotToy
    {

        /// <summary>
        /// ctor
        /// </summary>
        public RobotToy()
        {
            Report = new List<String>();
            IsPlaced = false;
        }

        public IList<String> Report;


        public bool IsPlaced { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        public int Orientation { get; set; }

        private const int UpperLimit = 5;
        
        private const int LowerLimit = 0;

        private const int North = 0;

        private const int South = 180;

        private const int East = 90;

        private const int West = 270;

        /// <summary>
        /// Convert numric to string representation
        /// </summary>
        /// <returns></returns>
        public string GetOrientation()
        {
            if (Orientation == North) return "North";
            if (Orientation == South) return "South";
            if (Orientation == East) return "East";
            if (Orientation == West) return "West";
            return "";
        }

        public enum CommandType
        {
            PLACE = 1,
            MOVE = 2
        }
        /// <summary>
        /// Place command
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="orientation"></param>
        public void Place(string x, string y, int orientation)
        {
            if (!int.TryParse(x, out int resultX)) return;
            if (!int.TryParse(y, out int resultY)) return;
   

            Locator(CommandType.PLACE, resultX, resultY, orientation);
            Report.Add(this.ToString());

            return;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="orientation"></param>
        private void Locator(CommandType cmd, int? x, int? y, int orientation = 0)
        {

            if (cmd == CommandType.PLACE)
            {
                if (x >= LowerLimit && x <= UpperLimit && y >= LowerLimit && y <= UpperLimit)
                {
                    X = x;
                    Y = y;
                }

                Orientation = orientation;
            }
            else if (cmd == CommandType.MOVE)
            {
                if (X == LowerLimit && x < 0) return;
                if (X == UpperLimit && x > 0) return;

                if (Y == LowerLimit && y < 0) return;
                if (Y == UpperLimit && y > 0) return;

                X = X + x;
                Y = Y + y;
            }
            return;
        }
        /// <summary>
        /// Move command
        /// </summary>
        public void Move()
        {
            switch (Orientation)
            {
                case North:
                   Locator(CommandType.MOVE, x: 0, y: 1);
                    break;
                case South:
                     Locator(CommandType.MOVE, x: 0, y: -1);
                    break;
                case East:
                     Locator(CommandType.MOVE, x: 1, y: 0);
                    break;
                case West:
                    Locator(CommandType.MOVE, x: -1, y: 0);
                    break;
                default:

                    break;
            }
            Report.Add(this.ToString());
            return;
        }
        /// <summary>
        /// Rotate Left
        /// </summary>
        public void Left()
        {
            Orientation = Orientation - 90;
            if (Orientation < 0) Orientation = West;
            Report.Add(this.ToString());
            return;
        }

        /// <summary>
        /// Rotate Right
        /// </summary>
        public void Right()
        {
            Orientation = Orientation + 90;
            if (Orientation == 360) Orientation = North;
            Report.Add(this.ToString());
            return;
        }

        /// <summary>
        /// Report string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (X.HasValue && Y.HasValue)
            {
                return $"X Location:{X}, Y Location:{Y}, Orientation:{GetOrientation()}";
            }
            else
            {
                return $"No valid location on table";
            }
        }

    }
}
