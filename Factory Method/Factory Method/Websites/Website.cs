using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Website
    {
        protected string Name { get; set; }
        protected Header Header;
        protected Menu Menu;
        protected Content Content;
        protected Footer Footer;

        public abstract void Deploy();

        void LoadDependencies()
        {
            Console.WriteLine("Loading dependencies...");
        }

        void DownloadContent()
        {
            Console.WriteLine("Donwloading content...");
        }

        void DisplayContent()
        {
            Console.WriteLine("Displaying content...");
        }

        void LoadJavaScript()
        {
            Console.WriteLine("Javascript loaded.");
        }

    }
}
