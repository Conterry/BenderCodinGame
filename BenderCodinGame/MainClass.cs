using System;
using System.Collections.Generic;

namespace BenderCodinGame
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int L = int.Parse(inputs[0]);
            int C = int.Parse(inputs[1]);
            List<string> map = new List<string>();
            for (int i = 0; i < L; i++)
            {
                map.Add(Console.ReadLine());
                map[i].Split("");
            }

            Bender testLoopBender = FindBender(map, "@");
            int loopPosX = testLoopBender.positionX;
            int loopPosY = testLoopBender.positionY;
            int LoopCount = 0;


        }

        static void Game(List<string> map, Bender bender)
        {
            /*
            while (true)
            {
                switch (map[bender.positionY][bender.positionX])
                {
                }
            }*/
        }

        static Bender FindBender(List<string> map, string element)
        {
            for(int i = 0; i<map.Count; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == '@')
                    {
                        return new Bender(j, i);
                    }
                }
            }
            return null;
        }
    }
}
