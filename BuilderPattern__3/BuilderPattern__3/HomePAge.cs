using System;

namespace BuilderPattern_3
{
    public class HomePage : IWebsite
    {
        public void Display()
        {
            Console.WriteLine("-- Hello --");
        }

        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Business information placeholder");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Personal information placeholder");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Portfolio information placeholder");
        }
    }

    public class AboutPage : IWebsite
    {
        public void Display()
        {
            Console.WriteLine("• About Us");
        }

        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Business information placeholder");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Personal information placeholder");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Portfolio information placeholder");
        }
    }

    public class Gallery : IWebsite
    {
        public void Display()
        {
            Console.WriteLine("         ");
        }

        // Implement the necessary interfaces with placeholder content
        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Business information placeholder");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Personal information placeholder");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Portfolio information placeholder");
        }
    }

    public class Blog : IWebsite
    {
        public void Display()
        {
            Console.WriteLine("           ");
        }

        // Implement the necessary interfaces with placeholder content
        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Business information placeholder");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Personal information placeholder");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Portfolio information placeholder");
        }
    }

    public class Contact : IWebsite
    {
        public void Display()
        {
            Console.WriteLine("              ");
        }

        // Implement the necessary interfaces with placeholder content
        public void DisplayBusinessInfo()
        {
            Console.WriteLine("Business information placeholder");
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Personal information placeholder");
        }

        public void DisplayPortfolioInfo()
        {
            Console.WriteLine("Portfolio information placeholder");
        }
    }
}