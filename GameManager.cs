using System;
using System.Collections.Generic;
namespace GeographyQuizGame
{
    public class GameManager
    {
        public List<Question> Questions { get; } = new List<Question>();
        public int Score { get; private set; }
        private DateTime startTime;
        public void StartGame()
        {
            Score = 0;
            startTime = DateTime.Now;
        }
        public void RegisterCorrect() => Score++;
        public TimeSpan GetElapsed() => DateTime.Now - startTime;
    }
}