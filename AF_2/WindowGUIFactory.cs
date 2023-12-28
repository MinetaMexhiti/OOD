using System;
namespace AF_2
{
	public class WindowGUIFactory : IGUIFac
	{
	

        public IButton CreateButton()
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
}

