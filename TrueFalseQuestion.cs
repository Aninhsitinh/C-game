using System;

namespace GeographyQuizGame
{
    public class TrueFalseQuestion : Question
    {
        // true if “True” is the correct answer, false if “False”
        public bool IsTrue { get; set; }

        // We won’t use this in PlayForm for TFQ, but leave it correct anyway
        public override bool CheckAnswer(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            var trimmed = userAnswer.Trim().ToLowerInvariant();
            bool selected = (trimmed == "true" || trimmed == "t");
            return selected == IsTrue;
        }

        public override string GetCorrectAnswer() => IsTrue ? "True" : "False";
        public override string ToString() => $"{Text} (True/False)";
    }
}