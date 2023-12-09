using System;
namespace AbstractFactory_2
{

    //implementation for window
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows-style button");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows-style checkbox");
        }
    }

    public class WindowsWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows-style window");
        }
    }


    //implementation for MacOS

    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS-style button");
        }
    }

    public class MacOSCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS-style checkbox");
        }
    }

    public class MacOSWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS-style window");
        }
    }


    //implementation for Linux

    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux-style button");
        }
    }

    public class LinuxCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux-style checkbox");
        }
    }

    public class LinuxWindow : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux-style window");
        }
    }



    //Concrete Fac Implementation


    public class WindowGUIFactory : IGUIFac
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new WindowsWindow();
        }
    }


    public class MacOSGUIFactory : IGUIFac
    {
        public IButton createButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new MacOSWindow();
        }
    }

    public class LinuxGUIFactory : IGUIFac
    {
        public IButton createButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public IWindow CreateWindow()
        {
            return new LinuxWindow();
        }
    }
}

