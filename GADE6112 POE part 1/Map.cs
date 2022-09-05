﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_part_1
{
    internal class Map
    {
        static private int width;
        static private int height;
        private int [,] map = new int [width,height];
        private string[] enemy = new string[5]; //Come back and check if correct later
        Random randomGen = new Random();

        Map Hero = new Map();
        public Map(/*Create()*/) // Calling Create() to be coded later to loop through and create hero and enemies on the map
        {
            int horizontal,vertical,enemyNum;

            int minWidth = 4; // playable tiles must be 4
            int maxWidth = 9;
            int minHeight = 7;//playable tiles must be 7
            int maxHeight = 9;
            int minEnemy = 3;
            int maxEnemy = 6;
            horizontal = randomGen.Next(minWidth, maxWidth);//TOADD IF ISSUES: +1 because random gens stop 1 number before max. Eg if range is 0-9 then it will only calc between 0-8
            vertical = randomGen.Next(minHeight, maxHeight);
            Tile[,] map = new Tile[horizontal - 1, vertical - 1]; //one less than the map border for playable map. For borders to be done.
            enemyNum = randomGen.Next(minEnemy, maxEnemy);
            //Create();
            Character [] enemy = new Character [enemyNum];
            for (int i = 0; i < enemy.Length; i++)
            {
               // enemy[i] = Create(); Method to be coded later and hopefully work.
            }
            //UpdateVision();
            for (int i = 0; i < enemy.Length; i++)
            {
                //UpdateVision();
            }
        }
        public void UpdateVision() 
        {
            // Vision [index]  - x -1 x + 1 y - 1 y + 1 - This will update the vision on all four sides of the character or enemy. Possibly make Vision a 2d array to store x and y
        }
        private Tile Create(Tile.TileType type)// Meant to create obstacles on the map using an array
        {

            Obstacle bush = new Obstacle(1, 1, type); // X , Y and then Tile Enum type (eg Hero , Enemy , or Obstacle)
            return bush;
        }
            



    }
}
