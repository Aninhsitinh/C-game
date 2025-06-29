using System;
using System.Collections.Generic;
using System.Linq;

namespace GeographyQuizGame
{
    public class OpenEndedQuestion : Question
    {
        public List<string> AcceptableAnswers { get; set; }

        public override bool CheckAnswer(string userAnswer)
        {
            return AcceptableAnswers
                .Any(ans => ans.Trim().Equals(userAnswer.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public override string GetCorrectAnswer() => string.Join(" / ", AcceptableAnswers);
    }
}