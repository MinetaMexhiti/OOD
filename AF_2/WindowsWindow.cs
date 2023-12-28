using System;

namespace AF_2
{
    public class WindowsWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering a window in Windows style.");
        }
    }
}
