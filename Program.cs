using System;
using System.Windows.Forms;

namespace GeographyQuizGame
{
    static class Program
    {
        // Single shared GameManager for the entire session
        public static GameManager GameMgr = new GameManager();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(GameMgr));
        }
    }
}