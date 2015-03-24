﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.Model.Classes
{
    using Enumerations;

    public class Board
    {
        private const int BOARD_SIZE = 40;

        private Board()
        {
            this.BoardArr = new Tile[BOARD_SIZE];
            this.Players = new List<Player>();
            this.ChanceCards = new List<ChanceCard>();
            this.CommunityCards = new List<CommunityCard>();
            LoadTiles();
            LoadCards();
        }

        public Tile[] BoardArr { get; private set; }
        public List<ChanceCard> ChanceCards { get; private set; }
        public List<CommunityCard> CommunityCards { get; private set; }

        public int PlayerCount
        {
            get
            {
                return this.Players.Count;
            }
        }

        public List<Player> Players { get; private set; }

        public void RemovePlayer(Player player)
        {
            this.Players.Remove(player);
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public static Board CreateBoardInstance() 
        {
            return new Board();
        }

        private void LoadChanceCards()
        {
            this.ChanceCards.Add(new ChanceCard("First prize in NASA Challenge. You get a 100$ scholarship.", 100));
        }

        private void LoadCommunityCards()
        {
            this.CommunityCards.Add(new CommunityCard("Your Windows license has expired! Microsoft charged you 20$", 20));
        }

        private void LoadCards()
        {
            LoadChanceCards();
            LoadCommunityCards();
        }

        private void LoadTiles()
        {
            this.BoardArr[0] = new StartTile();
            this.BoardArr[1] = new StreetTile(1, "Old Kent Road", 60, 2,StreetTileColor.Brown);
            this.BoardArr[2] = new CommunityTile(2);
            this.BoardArr[3] = new StreetTile(3, "Whitechapel Road", 60, 4, StreetTileColor.Brown);
            this.BoardArr[4] = new TaxTile(4, "Income Tax" , 200);
            this.BoardArr[5] = new StationTile(5, "Kings Cross Station");
            this.BoardArr[6] = new StreetTile(6, "The Angel Islington", 100, 6,StreetTileColor.LiteBlue);
            this.BoardArr[7] = new ChanceTile(7);
            this.BoardArr[8] = new StreetTile(8, "Euston Road", 100, 6, StreetTileColor.LiteBlue);
            this.BoardArr[9] = new StreetTile(9, "Pentoville Road", 8,120, StreetTileColor.LiteBlue);
            this.BoardArr[10] = new JailTile(10);
            this.BoardArr[11] = new StreetTile(11, "Pall Mall", 140, 10, StreetTileColor.Pink);
            this.BoardArr[12] = new TaxTile(12, "Electric Company",150);
            this.BoardArr[13] = new StreetTile(13, "Whitehall", 140, 10,StreetTileColor.Pink);
            this.BoardArr[14] = new StreetTile(14, "Northmurl`d Avenue", 160, 12, StreetTileColor.Pink);
            this.BoardArr[15] = new StationTile(15, "Marylebone Station");
            this.BoardArr[16] = new StreetTile(16, "Bow Street", 180, 14,StreetTileColor.Orange);
            this.BoardArr[17] = new CommunityTile(17);
            this.BoardArr[18] = new StreetTile(18, "Marlborough Street", 180, 14, StreetTileColor.Orange);
            this.BoardArr[19] = new StreetTile(19, "Vine Street", 200, 16, StreetTileColor.Orange);
            this.BoardArr[20] = null;
            this.BoardArr[21] = new StreetTile(21, "Strand", 220, 18, StreetTileColor.Red);
            this.BoardArr[22] = new ChanceTile(22);
            this.BoardArr[23] = new StreetTile(23, "Fleet Street", 220, 18, StreetTileColor.Red);
            this.BoardArr[24] = new StreetTile(24, "Trafalgar Square", 240, 20, StreetTileColor.Red);
            this.BoardArr[25] = new StationTile(25, "Fenchurch st. Station");
            this.BoardArr[26] = new StreetTile(26, "Leicester Square", 260, 22, StreetTileColor.Yellow);
            this.BoardArr[27] = new StreetTile(27, "Coventry Street", 260, 22, StreetTileColor.Yellow);
            this.BoardArr[28] = new TaxTile(28, "Water Works", 150);
            this.BoardArr[29] = new StreetTile(29, "Piccadilly", 280, 22, StreetTileColor.Yellow);
            this.BoardArr[30] = new GoToJailTile(30);
            this.BoardArr[31] = new StreetTile(31, "Regent Street", 300, 26, StreetTileColor.Green);
            this.BoardArr[32] = new StreetTile(32, "Oxford Street", 300, 26, StreetTileColor.Green);
            this.BoardArr[33] = new CommunityTile(33);
            this.BoardArr[34] = new StreetTile(34, "Bond Street", 320, 28, StreetTileColor.Green);
            this.BoardArr[35] = new StationTile(35, "Liverpool st. Station");
            this.BoardArr[36] = new ChanceTile(36);
            this.BoardArr[37] = new StreetTile(37, "Park Lane", 350, 35, StreetTileColor.DarkBlue);
            this.BoardArr[38] = new TaxTile(38, "Super Tax", 100);
            this.BoardArr[39] = new StreetTile(39, "Mayfair", 400, 50, StreetTileColor.DarkBlue);
        }
    }
}
