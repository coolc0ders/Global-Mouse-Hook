using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Mouse_Hooks
{
    public class ClickDetector
    {
        public static void ListenForMouseEvents()
        {
            Console.WriteLine("Listening to mouse clicks.");

            //When a mouse button is pressed 
            Hook.GlobalEvents().MouseDown += async (sender, e) =>
            {
                Console.WriteLine($"Mouse {e.Button} Down");
            };
            //When a double click is made
            Hook.GlobalEvents().MouseDoubleClick += async (sender, e) =>
            {
                Console.WriteLine($"Mouse {e.Button} button double clicked.");
            };
        }
    }
}
