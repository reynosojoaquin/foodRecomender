using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Threading;


namespace MicroDataScraper
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ClMicroDataTool microdata = new ClMicroDataTool();
            // microdata.microDataTest();
            Console.WriteLine("Buscando recetas.....");
            microdata.consultarPagina("http://www.eatingwell.com/recipes/");
            Console.ReadLine();  
           
        }
       
    }
}
