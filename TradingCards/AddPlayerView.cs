using System.Runtime.Intrinsics.X86;
using TradingCards.PlayerInfo;

namespace TradingCards
{
    public partial class AddPlayerView : Form
    {
        public event Action<Player> AddNewPlayer;
        
        private List<Control> _inputs;

        public AddPlayerView()
        {
            InitializeComponent();
            _inputs = new List<Control>
            {
                tb_Name,
                tb_Team,
                tb_POS,
                tb_MIN,
                tb_GP,
                tb_PTS,
                tb_FGM,
                tb_FGA,
                tb_FGPerc,
                pb_PlayerImage
            };
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (_inputs.Any(control => !InputValidity(control)))
                return;

            Player player = new Player(new List<string>
            {
                tb_Name.Text,
                tb_Team.Text,
                tb_POS.Text,
                tb_GP.Text,
                tb_MIN.Text,
                tb_PTS.Text,
                tb_FGM.Text,
                tb_FGA.Text,
                tb_FGPerc.Text
            }, pb_PlayerImage.Image);
            AddNewPlayer?.Invoke(player);
        }

        private void btn_OpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                pb_PlayerImage.Image = image;
            }
        }

        private bool InputValidity(Control control)
        {
            return control switch
            {
                TextBox textBox => textBox.Text.Trim() != "",
                PictureBox pictureBox => pictureBox.Image != null
            };
        }
    }
}
