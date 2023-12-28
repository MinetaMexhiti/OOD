using BP_3;

class Program
{
    static void Main(string[] args)
    {
        var websiteTemplate = new WebsiteTemplate();

        var portfolioWebsite = websiteTemplate.CreatePortfolioWebsite();
        Console.WriteLine("Portfolio Website:");
        portfolioWebsite.Display();

        var businessWebsite = websiteTemplate.CreateBusinessWebsite();
        Console.WriteLine("\nBusiness Website:");
        businessWebsite.Display();

        var personalBlog = websiteTemplate.CreatePersonalBlog();
        Console.WriteLine("\nPersonal Blog:");
        personalBlog.Display();
    }
}
