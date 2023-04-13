namespace Taboo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            new GameForm().ShowDialog(this);
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            new HowToPlayForm().ShowDialog(this);
        }
    }
}