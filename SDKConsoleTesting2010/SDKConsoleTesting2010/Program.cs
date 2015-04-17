using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Us.Onboardis.Demo2.OnboardInformatics.Api;

namespace SDKConsoleTesting2010
{
    class OnboardInformaticsTest
    {
        public static PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
        public static void testSummariesProperties()
        {

            /*
          String point = "-75.576834";  // Point
          String radius = "10";  // Radius
          String unit = "mi";  // Unit
          String page = "1";  // Page
          String size = "30";  // Size
          String filter = "";  // Filter
            */

            String point = "";  // Point
            String radius = "";  // Radius
            String unit = "";  // Unit
            String page = "";  // Page
            String size = "";  // Size
            String filter = "";  // Filter



            try
            {
                // first arguemnt 'basePath' is optional

                String result = propertiesApi.Summaries(point, radius, unit, page, size, filter);
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Main(string[] args)
        {
            /* Resource: Properties */

            System.Console.WriteLine("Calling endpoint: summaries");
            testSummariesProperties();
            Console.ReadKey();
        }
    }
}
