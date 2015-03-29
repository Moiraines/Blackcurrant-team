﻿namespace MonopolyGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Model.Classes;

    class Game
    {
        public static void PlayerTurn(Player player, Tile[] tiles, int firstRoll, int secondRoll)
        {
            Tile currentTile;

            player.Move(firstRoll + secondRoll, tiles.Length);
            if (tiles[player.Position] != null)
            {
                currentTile = tiles[player.Position];
                currentTile.Action(player);
            }
            Console.WriteLine(player);
        }

        static void Main(string[] args)
        {
            Board board = Board.Instance;
            Player pesho = new Player("Pesho");
            Player gosho = new Player("Gosho");
            board.AddPlayer(pesho);
            board.AddPlayer(gosho);

            while (board.PlayerCount > 1)
            {
                foreach (Player player in board.Players)
                {
                    int firstRoll = Dice.Roll();
                    int secondRoll = Dice.Roll();
                    Console.WriteLine("{0} rolls dice...", player.Name);
                    Console.WriteLine(String.Format("first dice rolled: {0} second dice rolled: {1}", firstRoll, secondRoll));

                    PlayerTurn(player, board.Tiles, firstRoll, secondRoll);

                    if (player.IsBankrupt)
                    {
                        board.RemovePlayer(player);
                        if (board.PlayerCount <= 1)
                        {
                            Console.WriteLine(String.Format("{0} Wins !", board.Players[0].Name));
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Game over");
        }
    }
}
