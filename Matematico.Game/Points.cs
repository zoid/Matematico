using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.Game
{
    static class Points
    {
        public static int Missing(int[,] board)
        {
            int mis = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (board[i, j] == 0)
                        mis++;
                }
            }

            return mis;
        }


        public static int[] Lines(int[,] board)
        {
            int[] points = new int[5];
            int[] line = new int[5];

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    line[i] = board[i, j];
                }

                points[j] = Calculate(line);
            }

            return points;
        }

        public static int[] Columns(int[,] board)
        {
            int[] points = new int[5];
            int[] line = new int[5];

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    line[i] = board[j, i];
                }

                points[j] = Calculate(line);
            }

            return points;
        }

        public static int[] Diagonals(int[,] board)
        {
            int[] points = new int[2];
            int[] line = new int[5];
            int[] line2 = new int[5];
            
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                        line[i] = board[i, i];
                        line2[i] = board[i, 4 - i];
                }
            }
                
            points[0] = Calculate(line);
            points[1] = Calculate(line2);

            return points;
        }


        private static int Calculate(int[] line)
        {
            return PairPoints(line) + StraightPoints(line);
        }

        private static int PairPoints(int[] line)
        {
            int[] arr = line.GroupBy(p => p).Where(g => g.Count() > 1).Select(g => g.Count()).ToArray();

            int points = arr.Sum() + arr.Length - 2;

            if (points == 3) points = 4;
            else if (points == 4) points = 3;

            if (points < 0) points = 0;
            return points;
        }

        private static int StraightPoints(int[] line)
        {
            int lenght;
            
            int.TryParse(line.OrderBy(x => x)
                             .Zip(line.Skip(1).OrderBy(x => x), (x, y) => y - x)
                             .GroupBy(x => x)
                             .Select((count, item) => new { count = count.Count(), item = count.Key })
                             .Where(x => x.item == 1)
                             .Select(x => x.count)
                             .FirstOrDefault()
                             .ToString(), out lenght);

            switch (lenght)
            {
                case 2: return 1;
                case 3: return 3;
                case 4: return 6;
            }

            return 0;
        }
    }
}
