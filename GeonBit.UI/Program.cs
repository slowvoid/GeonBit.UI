using System;

namespace GeonBit.UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using ( var game = new GeonBitUI_Examples() )
                game.Run();
        }
    }
}
