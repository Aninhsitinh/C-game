using System;
using System.Linq;
using System.Windows.Forms;

namespace GeographyQuizGame
{
    public partial class PlayForm : Form
    {
        private GameManager gameManager;
        private int currentIndex;

        public PlayForm(GameManager gm)
        {
            InitializeComponent();
            gameManager = gm;
            currentIndex = 0;
            gameManager.StartGame();
            ShowQuestion();
        }
        private void ShowQuestion()
        {

            if (currentIndex >= gameManager.Questions.Count)
            {
                EndGame();
                return;
            }
            var q = gameManager.Questions[currentIndex];
            lblQuestion.Text = $"{currentIndex + 1}. {q.Text}";

            // Hide all panels first
            panelChoices.Visible = false;
            panelTrueFalse.Visible = false;
            txtAnswer.Visible = false;

            if (q is MultipleChoiceQuestion mcq)
            {
                panelChoices.Visible = true;
                radioA.Text = $"A. {mcq.Options[0]}";
                radioB.Text = $"B. {mcq.Options[1]}";
                radioC.Text = $"C. {mcq.Options[2]}";
                radioD.Text = $"D. {mcq.Options[3]}";
                radioA.Checked = radioB.Checked = radioC.Checked = radioD.Checked = false;
            }
            else if (q is TrueFalseQuestion tfq)
            {
                panelTrueFalse.Visible = true;
                radioTrue.Text = "True";
                radioFalse.Text = "False";
                radioTrue.Checked = radioFalse.Checked = false;
            }
            else
            {
                txtAnswer.Visible = true;
                txtAnswer.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var q = gameManager.Questions[currentIndex];
            string userAnswer = "";

            if (q is MultipleChoiceQuestion)
            {
                if (radioA.Checked) userAnswer = "A";
                if (radioB.Checked) userAnswer = "B";
                if (radioC.Checked) userAnswer = "C";
                if (radioD.Checked) userAnswer = "D";
                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    // 1) Show warning if no option selected
                    MessageBox.Show(
                       "Please choose answer A,B,C,D.",
                       "Missing Answer",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                userAnswer = txtAnswer.Text.Trim();
                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    // 1) Show warning if no answer entered
                    MessageBox.Show(
                        "Please enter your answer before submitting.",
                        "Missing Answer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            if (q is TrueFalseQuestion tfq)
            {
                // 1) Make sure user clicked one
                if (!radioTrue.Checked && !radioFalse.Checked)
                {
                    MessageBox.Show(
                        "Please select True or False before submitting.",
                        "Missing Answer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // 2) Direct boolean compare
                bool userPickedTrue = radioTrue.Checked;    // true if “True” clicked, false if “False”
                if (userPickedTrue == tfq.IsTrue)
                {
                    gameManager.RegisterCorrect();           // correct match

                }
                // 3) Next question
                currentIndex++;
                ShowQuestion();
                return;
            }
            if (q.CheckAnswer(userAnswer))
                gameManager.RegisterCorrect();

            currentIndex++;
            ShowQuestion();
        }
        private void EndGame()
        {
            var time = gameManager.GetElapsed().TotalMinutes;
            MessageBox.Show($"Quiz finished!\nScore: {gameManager.Score}/{gameManager.Questions.Count}\nTime: {time:F2} minutes");

            if (MessageBox.Show("Show correct answers?", "Quiz Complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = string.Join("\n\n", gameManager.Questions.Select(q =>
                    $"{q.Text}\nCorrect Answer: {q.GetCorrectAnswer()}"));
                MessageBox.Show(result, "Answers");
            }

            if (MessageBox.Show("Play again?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                currentIndex = 0;
                gameManager.StartGame();
                ShowQuestion();
            }
            else
            {
                this.Close();
            }
        }
        
    }
}