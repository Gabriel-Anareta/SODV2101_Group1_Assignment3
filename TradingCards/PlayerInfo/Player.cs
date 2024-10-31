using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;

namespace TradingCards.PlayerInfo
{
    public class Player : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string POS { get; set; }
        public string GP { get; set; }
        public double MIN { get; set; }
        public double PTS { get; set; }
        public double FGM { get; set; }
        public double FGA { get; set; }
        public double FG_Perc { get; set; }
        public string Image { get; set; }


        public Player(List<string> data) // Note: code taken from assignment 2 - refactored to fit context
        {
            // setting player properties using reflection
            PropertyInfo[] props = this.GetType().GetProperties();

            // for each property, set respective value from data
            for (int i = 0; i < props.Length; i++)
                props[i].SetValue(this, DataValue(props[i], data[i]));

            this.Image = "";
        }

        private dynamic? DataValue(PropertyInfo prop, string data) // Note: code taken from assignment 2 - refactored to fit context
        {
            Type propType = prop.PropertyType;

            if (propType == typeof(int))
                return int.Parse(data);

            if (propType == typeof(double) || propType == typeof(double?))
            {
                if (data == "--")
                    return null as double?;
                else
                    return double.Parse(data);
            }

            if (propType == typeof(string))
                return data;

            return Convert.ChangeType(null, propType);
        }

        public void SetValues(Player player) // Note: code taken from assignment 2 - refactored to fit context
        {
            // setting player properties using reflection
            PropertyInfo[] props = this.GetType().GetProperties();

            // for each property, set respective value from data
            for (int i = 0; i < props.Length; i++)
                props[i].SetValue(this, props[i].GetValue(player));

            OnPropertyChanged();
        }

        public System.Drawing.Image GetImage()
        {
            string imagePath = Path.Combine(Environment.CurrentDirectory, Image);
            return System.Drawing.Image.FromFile(imagePath);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
