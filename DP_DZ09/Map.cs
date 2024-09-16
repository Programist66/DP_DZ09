using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DZ09
{

    public class Map
    {
        private char[][] map;
        private int x = 6;
        private int y = 6;
        public Map() 
        {
            map = new char[x][];
            for (int i = 0; i < y; i++)
            {
                map[i] = new char[y];
            }
        }

        public void GenerateMap(Func<char[][]> mapGenerator) 
        {
            map = mapGenerator();
        }        

        public void Print() 
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(map[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
