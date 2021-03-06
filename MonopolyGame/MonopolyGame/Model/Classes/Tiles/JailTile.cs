﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.Model.Classes
{
    using Model.Delegates;

    public class JailTile : Tile
    {
        private const string JAIL_TILE_NAME = "Jail";
        private int cycle;

        public JailTile()
            : base(JAIL_TILE_NAME)
        {
            this.cycle = 3;
        }

        public override void Action(Player player)
        {
            PrintingMethodInstance.Instance("Make your choice:\n1: Pay tax from 50$!\n2: Try to roll doubles!");
            string input = ReadingMethodIntance.Instance();

            switch (input)
            {
                case "1": PayJailTax(player); break;
                case "2": EscapeFree(player); break;
                default: throw new ArgumentOutOfRangeException("Incorrect choice!");
            }
        }

        public void PayJailTax(Player player)
        {
            player.WidthdrawMoney(50);
        }

        public void EscapeFree(Player player)
        {
            if (!Dice.TryToRollDoubles(Dice.Roll(), Dice.Roll()))
            {
                player.CanMove = false;
                --cycle;

                if (cycle == 0)
                {
                    PayJailTax(player);
                }
            }
            else
            {
                player.CanMove = true;
            }
        }
    }
}
