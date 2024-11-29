using TradingCards.PlayerInfo;

namespace TradingCards
{
    public partial class CardView : Form
    {
        private List<Player> _allPlayers;
        private AddPlayerView _addPlayerView;
        private DeletePlayerView _deletePlayerView;

        public Player CurrentPlayer { get; set; }

        public CardView()
        {
            InitializeComponent();

            _allPlayers = PlayerData.AllData;
            CurrentPlayer = _allPlayers.First();

            lb_AllCards.DataSource = _allPlayers;

            PlayerCard.BoundedPlayer = CurrentPlayer;
            PlayerCard.DataBindings.Add(new Binding("BoundedPlayer", this, nameof(this.CurrentPlayer), true, DataSourceUpdateMode.OnPropertyChanged));
            PlayerCard.SetBindings();

            _addPlayerView = new AddPlayerView();
            _addPlayerView.AddNewPlayer += AddPlayer;

            _deletePlayerView = new DeletePlayerView();
            _deletePlayerView.DeletePlayer += DeletePlayer;
        }

        private void lb_AllCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb_temp = sender as ListBox;
            if (lb_temp.DataSource == null)
                return;

            CurrentPlayer.SetValues(lb_temp.SelectedItem as Player);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _addPlayerView.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            _deletePlayerView.Show();
        }

        private void AddPlayer(Player player)
        {
            _allPlayers.Add(player);
            RefreshListView();
            _addPlayerView.Close();
        }

        private void DeletePlayer(string name)
        {
            Player deleting = _allPlayers.Find(player => player.Name == name);
            if (deleting == null)
                return;

            _allPlayers.Remove(deleting);
            RefreshListView();
            _deletePlayerView.Close();
        }

        private void RefreshListView()
        {
            lb_AllCards.DataSource = null;
            lb_AllCards.DataSource = _allPlayers;
            lb_AllCards.DisplayMember = "Name";
        }
    }
}
