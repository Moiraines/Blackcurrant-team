﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.Model
{
    class JailTile : Tile,ITile
    {
        public JailTile(int position) 
            :base(position)
        { }

        public void Action(Player player)
        {
            throw new NotImplementedException();
        }
    }
}