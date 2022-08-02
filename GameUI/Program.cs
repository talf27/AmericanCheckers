namespace Ex05_01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            GameManagement game = new GameManagement();
            game.Run();
        }
    }
}