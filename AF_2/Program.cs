using System;
using System.Runtime.InteropServices;

using AF_2;

class Program
{
    static void Main()
    {
        string osType = DetectOperatingSystem();
        IGUIFac factory = CreateFactory(osType);

        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        IWindow window = factory.CreateWindow();

        button.Render();
        checkbox.Render();
        window.Render();
    }

    private static string DetectOperatingSystem()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "Windows";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "MacOS";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return "Linux";
        }
        else
        {
            throw new NotSupportedException("Operating System not supported.");
        }
    }

    private static IGUIFac CreateFactory(string osType)
    {
        switch (osType)
        {
            case "Windows":
                return new WindowGUIFactory();
            case "MacOS":
                return new MacOSGUIFactory();
            case "Linux":
                return new LinuxGUIFactory();
            default:
                throw new NotSupportedException($"The OS type '{osType}' is not supported.");
        }
    }
}
