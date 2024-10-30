using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace TradingCards.PlayerStructure
{
    public class Player : INotifyPropertyChanged
    {
        public string _Name;
        public string _Team;
        public string _Image;

        public string Name 
        { 
            get { return _Name; } 
            set 
            {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged("Name");
            } 
        }
        public string Team 
        { 
            get { return _Team;} 
            set 
            {
                if (_Team == value)
                    return;
                _Team = value;
                OnPropertyChanged("Team");
            } 
        }
        public string Image 
        { 
            get { return _Image;} 
            set 
            {
                if (_Image == value)
                    return;
                _Image = value;
                OnPropertyChanged("Image");
            } 
        }
        // Still need to fields for player stats
        
        public Player(string name, string team, string image)
        {
            Name = name;
            Team = team;
            Image = image;
        }

        public void SetValues(Player player)
        {
            Name = player.Name;
            Team = player.Team;
            Image = player.Image;
        }

        public System.Drawing.Image GetImage()
        {
            string imagePath = Path.Combine(Environment.CurrentDirectory, Image);
            return System.Drawing.Image.FromFile(imagePath);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
