using System;
namespace AF_2
{
    public class LinuxGUIFactory : IGUIFac
	{
		

        public IButton CreateButton()
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

