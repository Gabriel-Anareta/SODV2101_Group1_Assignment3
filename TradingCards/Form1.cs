using TradingCards.PlayerStructure;
using TradingCards.CustomDrawable;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private Player CurrentPlayer;
        private Card CurrentCard;

        public Form1()
        {
            InitializeComponent();
            CurrentPlayer = new Player("Test Name", "Test Team", "");

            CurrentCard = new Card(new Point(206, 12), CurrentPlayer, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentCard.Draw(this);
        }
    }
}
