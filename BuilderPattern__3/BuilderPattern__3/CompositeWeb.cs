using System;
using System.Collections.Generic;

namespace BuilderPattern_3
{
    public class CompositeWebsite : IWebsite
    {
        private readonly List<IWebsite> components = new List<IWebsite>();

        public void AddComponent(IWebsite component)
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

        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Displaying additional business information");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Displaying additional personal information");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Displaying additional portfolio information");
        }
    }
}

