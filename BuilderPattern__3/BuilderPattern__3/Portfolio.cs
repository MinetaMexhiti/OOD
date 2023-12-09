using System;

namespace BuilderPattern_3
{
    public class BusinessWebsite : CompositeWebsite
    {
        public BusinessWebsite()
        {
            AddComponent(new HomePage());
            AddComponent(new AboutPage());
            AddComponent(new Contact());
            AddComponent(new Gallery());
        }

        public new void DisplayBusinessInfo()
        {
            Console.WriteLine("---Business information---");
            Console.WriteLine("                            ");
            Console.WriteLine("With application of high standards of quality control and the latest technology ");
            Console.WriteLine("In the production and roasting process, through mixture of seven different types of green coffee");
            Console.WriteLine("we have achieved a distinctive recipe");
            Console.WriteLine("Specializing in Coffee Types:");
            Console.WriteLine("   - Aroma");
            Console.WriteLine("   - Classic");
            Console.WriteLine("   - Cream");


            Console.WriteLine("                                     ");
        }
    }

    public class PersonalBlog : CompositeWebsite
    {
        public PersonalBlog()
        {
            AddComponent(new HomePage());
            AddComponent(new AboutPage());
            AddComponent(new Contact());
            AddComponent(new Blog());
        }

        public new void DisplayPersonalInfo()
        {
            Console.WriteLine("                                     ");
            Console.WriteLine("----Personal Blog information------");
            Console.WriteLine("                                     ");
            Console.WriteLine("Explore the Wonderful World of our Website.");
            Console.WriteLine("Discover Exciting Content and Engaging Information.");
            Console.WriteLine("We're Delighted to Have You Here!");
            Console.WriteLine("                                     ");
            Console.WriteLine("Personal Blog Topics:");
            Console.WriteLine("   - Travel Experiences");
            Console.WriteLine("   - Daily Reflections");
            Console.WriteLine("   - Hobby Insights");

            Console.WriteLine("Social Media Integration:");
            Console.WriteLine("   - Follow us on Twitter: @PersonalBlog");
            Console.WriteLine("   - Connect on Instagram: @PersonalBlogOfficial");
        }
    }

    public class PortfolioWebsite : CompositeWebsite
    {
        public PortfolioWebsite()
        {
            AddComponent(new HomePage());
            AddComponent(new AboutPage());

        }

        public static new void DisplayPortfolioInfo()
        {
            Console.WriteLine("-----Portfolio information-----");
            Console.WriteLine("                                     ");
            Console.WriteLine("Welcome to Our Website!");
            Console.WriteLine("Explore the Exciting Content and Features.");
            Console.WriteLine("Discover a World of Information and Entertainment.");
            Console.WriteLine("Portfolio Highlights:");
            Console.WriteLine("                                     ");
            Console.WriteLine("   - Professional Data Analyst");
            Console.WriteLine("   - Web Design and Development Showcase");

            Console.WriteLine("Recent Projects:");
            Console.WriteLine("   1. Personal Branding Campaign");
            Console.WriteLine("   2. E-commerce Website Redesign");
            Console.WriteLine("   3. Creative Art Portfolio");

            Console.WriteLine("Contact us for your next project!");
        }
    }
}
