using System;
namespace AF_2
{
	public class MacOSGUIFactory : IGUIFac
	{
		
        public IButton CreateButton()
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
}

