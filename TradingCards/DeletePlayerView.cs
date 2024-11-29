namespace TradingCards
{
    public partial class DeletePlayerView : Form
    {
        public event Action<string> DeletePlayer;
        
        public DeletePlayerView()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text.Trim() == "")
                return;

            DeletePlayer?.Invoke(tb_Name.Text);
        }
    }
}
