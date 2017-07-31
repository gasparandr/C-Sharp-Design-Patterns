using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PortfolioWebsite : Website
    {
        WebsiteFactory WebsiteFactory;

        public PortfolioWebsite(WebsiteFactory _WebsiteFactory)
        {
            WebsiteFactory = _WebsiteFactory;
            Name = "Portfolio Website";
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying " + Name);

            Header = WebsiteFactory.CreateHeader();
            Console.WriteLine("Header: " + Header.Name);

            Menu = WebsiteFactory.CreateMenu();
            Console.WriteLine("Menu: " + Menu.Name);

            Content = WebsiteFactory.CreateContent();
            Console.WriteLine("Content: " + Content.Name);

            Footer = WebsiteFactory.CreateFooter();
            Console.WriteLine("Footer: " + Footer.Name);

        }
        // Other portfolio website specific methods here
    }
}
