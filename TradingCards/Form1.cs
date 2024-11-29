using TradingCards.PlayerInfo;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> AllPlayers;
        public Player CurrentPlayer { get; set; }

        public Form1()
        {
            InitializeComponent();
            AllPlayers = PlayerData.AllData;
            CurrentPlayer = AllPlayers.First();
            lb_AllCards.DataSource = AllPlayers;
            PlayerCard.BoundedPlayer = CurrentPlayer;
            PlayerCard.DataBindings.Add(new Binding("BoundedPlayer", this, nameof(this.CurrentPlayer), true, DataSourceUpdateMode.OnPropertyChanged));
            PlayerCard.SetBindings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lb_AllCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb_temp = sender as ListBox;
            CurrentPlayer.SetValues(lb_temp.SelectedItem as Player);
        }
    }
}
