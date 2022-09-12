﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_part_1
{
    internal class Hero:Character 
    {
        char heroSym;
        public Hero()
        {
            this.x = getX();
            this.y = getY();
            this.hp = getHP();
            this.maxHp = getHP();
            this.damage = 2;
            heroSym = getSymbols(0);
        }

        public Hero(int x, int y, int hP, TileType type)
        {
            
        }

        override public Movement ReturnMove(Movement move = 0)
        {
            if (move == Movement.up && currentVision[x,y+1].getTileType() == Tile.TileType.Clear)
            {
                return Movement.up;
            }
            if (move == Movement.down && currentVision[x,y-1].getTileType() == Tile.TileType.Clear)
            {
                return Movement.down;
            }
            if (move == Movement.left && currentVision[ x -1 , y].getTileType() == Tile.TileType.Clear)
            {
                return Movement.left;
            }
            if(move == Movement.right && currentVision[x + 1 , y].getTileType() ==  Tile.TileType.Clear)
            {
                return Movement.right;
            }
            return Movement.noMovement;
        }
        public char getHeroSymbol() { return heroSym; }

        override public string ToString()
        {
            String heroMessage = "Player stats:\n Hp: " + hp + "/ Max: " + maxHp + "\n Damage: " + damage + "\n [X:Y] --> [" + x + ":" + y + "]";
            return ToString();
        }

    }
}
