namespace GeographyQuizGame
{
    public abstract class Question
    {
        public string Text { get; set; }
        public abstract bool CheckAnswer(string userAnswer);
        public abstract string GetCorrectAnswer();
        public override string ToString() => Text;
    }
}