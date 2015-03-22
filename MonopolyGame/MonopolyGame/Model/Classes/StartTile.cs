﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.Model
{
    using Interfaces; 

    public class StartTile : Tile,ITile
    {
        public StartTile()
            : base(0) 
        { }
        
        public void Action(Player player)
        {
            player.Money += 200;
        }
    }
}