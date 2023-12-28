using System;

namespace AF_2

{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a button in Windows style.");
        }
    }
}
