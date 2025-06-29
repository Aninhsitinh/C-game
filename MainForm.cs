using System;
using System.Windows.Forms;

namespace GeographyQuizGame
{
    public partial class MainForm : Form
    {
        private GameManager gameManager;

        public MainForm(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var cf = new CreateForm(gameManager);
            cf.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (gameManager.Questions.Count == 0)
            {
                MessageBox.Show("No questions available. Add some first.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var pf = new PlayForm(gameManager);
            pf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}