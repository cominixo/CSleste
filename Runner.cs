using Monocle;

namespace Celeste.Pico8
{
    public class Runner
    {
        public static void Main()
        {
            Tracker.Initialize();
            var emulator = new Emulator();
            Engine.Scene = emulator;
            emulator.Begin();
           
            emulator.engine.RunWithLogging();
            
            
        }
        
    }
}