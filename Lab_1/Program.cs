namespace Lab_1
{
    class Prog
    {
        const uint A = 123;
        static char[] arr = { 'a', '3', 's'};
        char C = 'l';

        enum D : short
        {
            Valu1 = 1,
            Value2 = 123
        }

        uint sm = (uint)D.Valu1 + A;
        int s = (int)arr[1] * (int)A;
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}