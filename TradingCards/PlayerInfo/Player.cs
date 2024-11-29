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
        public Image Image { get; set; }

        public Player(List<string> data)
        {
            // setting player properties using reflection
            PropertyInfo[] props = this.GetType().GetProperties();

            // for each property, set respective value from data
            for (int i = 0; i < props.Length - 1; i++)
                props[i].SetValue(this, DataValue(props[i], data[i]));

            Image = GetImage(Name);
        }

        private dynamic? DataValue(PropertyInfo prop, string data)
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

        public void SetValues(Player player)
        {
            // setting player properties using reflection
            PropertyInfo[] props = this.GetType().GetProperties();

            // for each property, set respective value from data
            for (int i = 0; i < props.Length; i++)
                props[i].SetValue(this, props[i].GetValue(player));

            OnPropertyChanged();
        }

        public System.Drawing.Image GetImage(string name)
        {
            return name switch 
            {
                "Anthony Davis" => Properties.Resources.AnthonyDavis,
                "Max Christie" => Properties.Resources.MaxChristie,
                "Jaxson Hayes" => Properties.Resources.JaxsonHayes,
                "Cam Reddish" => Properties.Resources.CamReddish,
                "Chet Holmgren" => Properties.Resources.ChetHolmgren,
                "Shai Gilgeous-Alexander" => Properties.Resources.ShaiGilgeousAlexander,
                "Cason Wallace" => Properties.Resources.CasonWallace,
                "Trae Young" => Properties.Resources.TraeYoung,
                "Jalen Johnson" => Properties.Resources.JalenJohnson,
                "Onyeka Okongwu" => Properties.Resources.OnyekaOkongwu
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
