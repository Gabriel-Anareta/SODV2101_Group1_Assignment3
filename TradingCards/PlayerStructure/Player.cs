﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using sd = System.Drawing;

namespace TradingCards.PlayerStructure
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Image { get; set; }
        // Still need to fields for player stats
        
        public Player(string name, string team, string image)
        {
            Name = name;
            Team = team;
            Image = image;
        }

        public sd.Image AsDrawImage()
        {
            string imagePath = Path.Combine(Environment.CurrentDirectory, Image);
            return sd.Image.FromFile(imagePath);
        }
    }
}
