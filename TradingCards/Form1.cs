using TradingCards.PlayerInfo;
using TradingCards.CustomDrawable;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private readonly Point CardPosition = new Point(206, 12);

        private Player CurrentPlayer;
        private Card CurrentCard;

        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = PlayerData.AllData.First();
            CurrentCard = new Card(CardPosition, CurrentPlayer);
            lb_AllCards.DataSource = PlayerData.AllData;
            lb_AllCards.DisplayMember = "Name";
            lb_AllCards.ValueMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentCard.Draw(this);
        }

        private void lb_AllCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb_temp = sender as ListBox;
            CurrentPlayer.SetValues(lb_temp.SelectedItem as Player);
        }
    }
}
