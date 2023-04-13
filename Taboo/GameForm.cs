using Newtonsoft.Json;

namespace Taboo
{
    public partial class GameForm : Form
    {
        private TimeSpan _roundTimer;
        private readonly ProibidaoGame _game = new();

        private readonly Queue<ProibidaoCard> _queueCards = new();
        private readonly Queue<ProibidaoCard> _disCards = new();

        private ProibidaoCard _selectedCard;

        public GameForm()
        {
            InitializeComponent();


            var tabooCards = JsonConvert.DeserializeObject<List<ProibidaoCard>>(File.ReadAllText("cards1.json"));

            if (tabooCards == null) return;
            tabooCards.Shuffle();
            foreach (var card in tabooCards)
            {
                _queueCards.Enqueue(card);
            }
        }

        private void tmrRoundTimer_Tick(object sender, EventArgs e)
        {
            _roundTimer = _roundTimer.Subtract(TimeSpan.FromSeconds(1));
            lblTime.Text = $@"Tempo: {_roundTimer.Minutes}:{_roundTimer.Seconds}";

            if (_roundTimer.Seconds != 0) return;

            tmrRoundTimer.Stop();
            btnRound.Enabled = true;

            SetButtons(tmrRoundTimer.Enabled);
            new RoundEndForm().ShowDialog(this);

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            new FormCountDown().ShowDialog(this);
            _game.Rounds++;

            lblTeam.Text = _game.Rounds % 2 != 0 ? "Time A" : "Time B";

            lblRound.Text = $@"Rodada {_game.Rounds}";
            _roundTimer = TimeSpan.FromMinutes(1);
            tmrRoundTimer.Start();
            btnRound.Enabled = false;
            _selectedCard = _queueCards.Dequeue();
            btnPauseContinue.Enabled = true;
            SetRich(_selectedCard);

            SetButtons(tmrRoundTimer.Enabled);
        }

        private void SetButtons(bool enabled)
        {
            btnPass.Enabled = enabled;
            
            btnScore.Enabled = enabled;
            btnTaboo.Enabled = enabled;
        }

        private void btnPauseContinue_Click(object sender, EventArgs e)
        {
            tmrRoundTimer.Enabled = !tmrRoundTimer.Enabled;
            btnPauseContinue.Text = tmrRoundTimer.Enabled ? "Pause" : "Continuar";
            SetButtons(tmrRoundTimer.Enabled);


        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!tmrRoundTimer.Enabled) return;
            tmrRoundTimer.Stop();
            if (MessageBox.Show(@"Tem uma rodada em andamento, deseja realmente terminar?", caption: @"Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No) return;

            e.Cancel = true;
            tmrRoundTimer.Start();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }



        private void SetRich(ProibidaoCard card)
        {
            richCard.Clear();

            richCard.AppendText(card.ProibidaoWord + Environment.NewLine);

            foreach (var word in card.ProibidaoWords)
            {
                richCard.AppendText(word + Environment.NewLine);
            }

            richCard.SelectAll();
            richCard.SelectionAlignment = HorizontalAlignment.Center;
            richCard.SelectionFont = new Font("Arial", 15, FontStyle.Bold);

            richCard.Select(0, richCard.GetFirstCharIndexFromLine(0) + richCard.Lines[0].Length);
            richCard.SelectionColor = Color.Red;

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma acerto?", "Confirma Acerto?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;

            SetScore();

            _selectedCard = _queueCards.Dequeue();
            SetRich(_selectedCard);
            lblDescart.Text = $"Descarte:  {_disCards.Count}";
            lblDeck.Text = $"Deck:  {_queueCards.Count}";

        }


        private void SetScore()
        {
            if (_game.Rounds % 2 == 0)
            {
                _game.TeamB.Add(_selectedCard);
                lblTimeB.Text = $@"Time B: {_game.TeamB.Count}";
            }
            else
            {
                _game.TeamA.Add(_selectedCard);
                lblTimeA.Text = $@"Time A: {_game.TeamA.Count}";
            }
            lblDescart.Text = $"Descarte:  {_disCards.Count}";
            lblDeck.Text = $"Deck:  {_queueCards.Count}";
        }


        private void btnPass_Click(object sender, EventArgs e)
        {
            _disCards.Enqueue(_selectedCard);
            _selectedCard = _queueCards.Dequeue();
            SetRich(_selectedCard);
            lblDescart.Text = $@"Descarte:  {_disCards.Count}";
            lblDeck.Text = $@"Deck:  {_queueCards.Count}";

        }

        private void btnTaboo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Confirma Erro?", @"Confirma Erro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            _disCards.Enqueue(_selectedCard);
            _selectedCard = _queueCards.Dequeue();
            SetRich(_selectedCard);
            lblDescart.Text = $@"Descarte:  {_disCards.Count}";
            lblDeck.Text = $@"Deck:  {_queueCards.Count}";
        }
    }
}
