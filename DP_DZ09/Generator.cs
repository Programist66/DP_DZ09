using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DZ09
{
    public class Generator
    {
        static char water = '~';
        static char grass = '.';
        static char mountain = '^';
        static char forest = '&';
        static Random random = new Random();

        static int x = 6;
        static int y = 6;


        public static char[][] PlainGenerate() 
        {
            char[][] map;          
            map = new char[x][];
            for (int i = 0; i < y; i++)
            {
                map[i] = new char[y];
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    map[i][j] = grass;
                }
            }
            return map;
        }
        public static char[][] MountainousGenerate() 
        {
            char[][] map;            
            map = new char[x][];
            for (int i = 0; i < y; i++)
            {
                map[i] = new char[y];
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    map[i][j] = random.Next(2) == 0 ? mountain : forest;
                }
            }
            return map;
        }

        public static char[][] ArchipelagoGenerate() 
        {
            char[][] map;
            map = new char[x][];
            for (int i = 0; i < y; i++)
            {
                map[i] = new char[y];
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    map[i][j] = water;
                }
            }
            for (int i = 0; i < random.Next(4, 11); i++)
            {
                map[random.Next(y)][random.Next(x)] = grass;
            }
            return map;
        }

        public static char[][] PlainWithRiverGenerate() 
        {
            char[][] map;
            map = new char[x][];
            int currentRiverX = random.Next(1,x-1);
            for (int i = 0; i < y; i++)
            {
                map[i] = new char[y];
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    map[i][j] = random.Next(10) == 0 ? forest : grass;
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == currentRiverX)
                    {
                        map[i][j] = water;
                        currentRiverX = random.Next(currentRiverX > 0 ? currentRiverX - 1 : currentRiverX, currentRiverX < 5 ? currentRiverX + 2 : currentRiverX);
                    }
                }
            }

            return map;
        }
    }
}
