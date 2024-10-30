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
            // NEED TO SET CURRENTPLAYER
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Card CurrentCard = new Card(new Point(206, 12));
            CurrentCard.Draw(this);
        }

        
    }
}
