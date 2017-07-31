using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FactoryMethod
    {
        static void Main(string[] args)
        {
            /*
            * FACTORY METHOD PATTERN
            * 
            * The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
            * 
            * -> I am using websites as an example for this pattern. They porbably don't do justice to the power of this pattern but they are good enough to illustrate a point.
            * 
            * -> Let's say we created a portal which generates websites based on the needs of our customers. On this portal we have many different types as well as subtypes of websites. (we are using only 3 for the sake of this example)
            * -> Each website is made up of basically the same components and they need to run the same operations in order to be successfully installed. However the style/type of these components differ from website to website.
            * -> Our components for the sake of this example are (Header, Menu, Content, Footer)
            * -> These 4 components are defined as base classes, but in some cases they could be abstract as well
            * -> Now we have different types of concrete implementations of those components (e.g Classic Header, Centered Menu, Articles - as content, Classic Footer) — these concrete components could branch out endlessly 
            * 
            * -> We create a factory interface (WebsiteFactory) with implements the basic methods necessary for creating our 4 main components.
            * 
            * -> From this point on we branch out and create concrete factories which we assigned with the role of instantiating concrete components.
            * e.g PortfolioFactory instantiates those concrete components that can be used in order to create a portfolio website. (e.g. Galleries as content) 
            * on the other hand BlogFactory instantiates those concrete components that can be used in order to create a blog website. (e.g. Articles as content) 
            * 
            */

            // We create a portfolio website and we deploy it
            Website Portfolio = new PortfolioWebsite(new PortfolioWebsiteFactory());
            Portfolio.Deploy();

            Console.WriteLine("\n");

            // We create a blog and deploy it
            Website Blog = new BlogWebsite(new BlogWebsiteFactory());
            Blog.Deploy();

            Console.WriteLine("\n");

            // We are also able to use the same portfolio factory for another type of portfolio website
            Website SimplePortfolio = new PortfolioWebsiteSimple(new PortfolioWebsiteFactory());
            SimplePortfolio.Deploy();

            Console.Read();
        }
    }
}
