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

                points[j] = calc(line);
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

                points[j] = calc(line);
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
                
            points[0] = calc(line);
            points[1] = calc(line2);

            return points;
        }

        private static int calc(int[] line)
        {
            int t_points = 0;
            Array.Sort(line);

            if (onePair(line)) t_points = 1;
            if (twoPairs(line)) t_points = 3;

            if (straight3(line) && !(straight4(line) || straight5(line))) t_points += 1;
            if (straight4(line) && !straight5(line)) t_points += 3;
            if (straight5(line)) t_points = 6;

            if (tripple(line)) t_points = 4;
            if (fullHouse(line)) t_points = 5;
            if (poker(line)) t_points = 4;

            return t_points;
        }

        private static bool onePair(int[] line)
        {
            for (int i = 0; i < 4; i++)
            {
                if (isPair(line[i], line[i + 1]))
                    return true;
            }
            return false;
        }

        private static bool twoPairs(int[] line)
        {
            int pairs = 0;
            int before = 0;

            for (int i = 0; i < 4; i++)
            {
                if (isPair(line[i], line[i + 1]))
                {
                    if (before != line[i])
                        pairs++;
                }

                before = line[i];
            }

            return (pairs == 2);
        }

        private static bool tripple(int[] line)
        {
            int before = 0;
            for (int i = 0; i < 4; i++)
            {
                if (isPair(line[i], line[i + 1]))
                {
                    if (before == line[i])
                        return true;
                }

                before = line[i];
            }

            return false;
        }

        private static bool fullHouse(int[] line) { return (tripple(line) && isPairNotTripple(line)); }
        private static bool poker(int[] line) { return (line[0] == line[4] || line[1] == line[4]); }
        private static bool straight3(int[] line) { return (number_straight(line) == 3); }
        private static bool straight4(int[] line) { return (number_straight(line) == 4); }
        private static bool straight5(int[] line) { return (number_straight(line) == 5); }


        private static bool isPair(int a, int b)
        {
            return (a == b && a != 0);
        }

        private static bool isPairNotTripple(int[] line)
        {
            if(line[0] == line[1] && line[1] != line[2])
                return true;
            if(line[3] == line[4] && line[2] != line[3])
                return true;

            return false;
        }

        private static int number_straight(int[] line)
        {
            int inline = 1;
            for (int i = 0; i < 4; i++)
            {
                if (line[i] == line[i + 1] - 1)
                {
                    inline++;
                }
                else if (inline != 1) break;
                else inline = 1;
            }

            return ((inline < 3) ? 0 : inline);
        }
    }
}
