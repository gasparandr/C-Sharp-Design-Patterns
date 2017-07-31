using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PortfolioWebsiteSimple : Website
    {
        WebsiteFactory WebsiteFactory;

        public PortfolioWebsiteSimple(WebsiteFactory _WebsiteFactory)
        {
            WebsiteFactory = _WebsiteFactory;
            Name = "Simple Portfolio Website";
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying " + Name);

            Menu = WebsiteFactory.CreateMenu();
            Console.WriteLine("Menu: " + Menu.Name);

            Content = WebsiteFactory.CreateContent();
            Console.WriteLine("Content: " + Content.Name);
        }
        // Other portfolio website specific methods here
    }
}
