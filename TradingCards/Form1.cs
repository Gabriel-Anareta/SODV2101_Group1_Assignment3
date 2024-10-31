using TradingCards.PlayerInfo;
using TradingCards.CustomDrawable;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private readonly Point CardPosition = new Point(206, 12);
        private readonly List<Player> AllPlayers = PlayerData.AllData;

        private Player CurrentPlayer;
        private Card CurrentCard;

        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = AllPlayers.First();
            CurrentCard = new Card(CardPosition, CurrentPlayer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentCard.Draw(this);
        }
    }
}
