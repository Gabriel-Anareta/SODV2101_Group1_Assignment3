using System.ComponentModel;
using System.Runtime.CompilerServices;
using TradingCards.PlayerInfo;

namespace TradingCards
{
    public partial class CardControl : UserControl, INotifyPropertyChanged
    {
        private Player _boundedPlayer;
        public Player BoundedPlayer
        {
            get { return _boundedPlayer; }
            set 
            {
                _boundedPlayer = value; 
                OnPropertyChanged();
            }
        }


        public CardControl()
        {
            InitializeComponent();
        }

        public void SetBindings()
        {
            lbl_Name.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.Name), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_Team.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.Team), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_POS.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.POS), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_GP.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.GP), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_MIN.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.MIN), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_PTS.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.PTS), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_FGM.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.FGM), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_FGA.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.FGA), true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_FGPerc.DataBindings.Add(new Binding("Text", BoundedPlayer, nameof(BoundedPlayer.FG_Perc), true, DataSourceUpdateMode.OnPropertyChanged));
            pb_PlayerImage.DataBindings.Add(new Binding("Image", BoundedPlayer, nameof(BoundedPlayer.Image), true, DataSourceUpdateMode.OnPropertyChanged));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
