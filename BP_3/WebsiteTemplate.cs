using System;
namespace BP_3
{
    public class WebsiteTemplate
    {
        public WebPageComposite CreatePortfolioWebsite()
        {
            var website = new WebPageComposite();
            website.AddComponent(new HomePage());
            website.AddComponent(new Gallery());
            website.AddComponent(new AboutUs());
            website.AddComponent(new ContactForm());
            return website;
        }

        public WebPageComposite CreateBusinessWebsite()
        {
            var website = new WebPageComposite();
            website.AddComponent(new HomePage());
            website.AddComponent(new AboutUs());
            website.AddComponent(new ContactForm());
            return website;
        }

        public WebPageComposite CreatePersonalBlog()
        {
            var website = new WebPageComposite();
            website.AddComponent(new Blog());
            website.AddComponent(new Gallery());
            return website;
        }
    }

}

