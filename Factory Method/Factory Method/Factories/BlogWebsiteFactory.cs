using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BlogWebsiteFactory : WebsiteFactory
    {
        public Header CreateHeader()
        {
            return new ClassicHeader();
        }

        public Menu CreateMenu()
        {
            return new RightAlignMenu();
        }

        public Content CreateContent()
        {
            return new Articles();
        }

        public Footer CreateFooter()
        {
            return new ClassicFooter();
        }
    }
}
