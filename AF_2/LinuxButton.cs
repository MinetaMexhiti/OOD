using System;
namespace AF_2
{
	public class LinuxButton : IButton
	{
		public void Render()
		{
			Console.WriteLine("Rendering a Button in Linux style");
		}
	}
}

