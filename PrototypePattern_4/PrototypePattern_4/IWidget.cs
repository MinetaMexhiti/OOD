using System;
namespace PrototypePattern_4
{
	public interface IWidget : ICloneable
	{
		void create();
		void Configure();
	}
}

