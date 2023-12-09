using BuilderPattern_3;

class Program
{
    static void Main()
    {

        // Create a business website
        var businessWebsite = new BusinessWebsite();
        businessWebsite.Display();
        businessWebsite.DisplayBusinessInfo();



        // Create a portfolio website
        var portfolioWebsite = new PortfolioWebsite();

        PortfolioWebsite.DisplayPortfolioInfo();



        // Create a personal blog
        var personalBlog = new PersonalBlog();

        personalBlog.DisplayPersonalInfo();

        Console.ReadLine();
    }
}
