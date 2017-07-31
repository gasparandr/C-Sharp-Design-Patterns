using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PortfolioWebsiteFactory : WebsiteFactory
    {
        public Header CreateHeader()
        {
            return new ModernHeader();
        }

        public Menu CreateMenu()
        {
            return new CenteredMenu();
        }

        public Content CreateContent()
        {
            return new Galleries();
        }

        public Footer CreateFooter()
        {
            return new NoFooter();
        }
    }
}
