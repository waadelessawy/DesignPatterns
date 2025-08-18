using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{
    //The problem

    public class XmlData {}
    public class JsonData {}
    public interface IMultiRestoApp
    {
        void displayMenus(XmlData xmlData);
        void displayRecommendations(XmlData xmlData);


    }

    public class MultiRestoApp : IMultiRestoApp
    {
        public void displayMenus(XmlData xmlData)
        {
            Console.WriteLine("XML Menus");
        }

        public void displayRecommendations(XmlData xmlData)
        {
            Console.WriteLine("XML Menus");
        }
    }

    // The new third party library use Json data not xml
    public class FancyUIService 
    {
        public void displayMenus(JsonData jsonData)
        {
            Console.WriteLine("JSON Menus");
        }

        public void displayRecommendations(JsonData jsonData)
        {
            Console.WriteLine("JSON Menus");
        }
    }

    public class FancyUIServiceAdapter : IMultiRestoApp
    {
        public readonly FancyUIService fancyUIService;  //Composition principle

        public FancyUIServiceAdapter()
        {
            fancyUIService = new FancyUIService();

        }

        public void displayMenus(XmlData xmlData)
        {
            JsonData jsonData = convertXmlToJson(xmlData);
            fancyUIService.displayMenus(jsonData);
            
        }
        public void displayRecommendations(XmlData xmlData)
        {
            JsonData jsonData = convertXmlToJson(xmlData);
            fancyUIService.displayRecommendations(jsonData);
            
        }

        private JsonData convertXmlToJson(XmlData xmlData)
        {
            //Convert XmlData to JsonData 
            return new JsonData();
        }

    } 
}
