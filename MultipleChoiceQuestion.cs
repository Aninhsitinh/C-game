using System;

namespace GeographyQuizGame
{
    public class MultipleChoiceQuestion : Question
    {
        public string[] Options { get; set; } = new string[4];  // Indexed 0 → A, 1 → B, 2 → C, 3 → D
        public int CorrectIndex { get; set; }                   // 0 to 3

        /// <summary>
        /// Checks if the user's letter-based answer (A–D) matches the correct choice.
        /// </summary>
        public override bool CheckAnswer(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string answer = userAnswer.Trim().ToUpper();

            switch (answer)
            {
                case "A": return CorrectIndex == 0;
                case "B": return CorrectIndex == 1;
                case "C": return CorrectIndex == 2;
                case "D": return CorrectIndex == 3;
                default: return false;
            }
        }
        /// <summary>
        /// Returns the correct answer in the format: "B. Europe"
        /// </summary>
        public override string GetCorrectAnswer()
        {
            string[] labels = { "A", "B", "C", "D" };
            return $"{labels[CorrectIndex]}. {Options[CorrectIndex]}";
        }

        /// <summary>
        /// Displays the question type when listed.
        /// </summary>
        public override string ToString()
        {
            return $"{Text} (Multiple Choice)";
        }
    }
}