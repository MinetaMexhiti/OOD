using System;
namespace BP_3
{
    public class WebPageComposite : IWebComponent
    {
        private readonly List<IWebComponent> components = new List<IWebComponent>();

        public void AddComponent(IWebComponent component)
        {
            components.Add(component);
        }

        public void Display()
        {
            foreach (var component in components)
            {
                component.Display();
            }
        }
    }

}

